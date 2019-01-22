using Nager.AmazonProductAdvertising.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Nager.AmazonProductAdvertising.TestUI
{
    public partial class Main : Form
    {
        private AmazonAuthentication _authentication;

        public Main()
        {
            this.InitializeComponent();
            var dialog = new AuthenticationDialog();
            var dialogResult = dialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                this._authentication = dialog.Authentication;
            }

            this.comboBoxEndpoint.DataSource = Enum.GetValues(typeof(AmazonEndpoint));
            this.comboBoxEndpoint.SelectedItem = AmazonEndpoint.DE;
            this.comboBoxSearchIndex.DataSource = Enum.GetValues(typeof(AmazonSearchIndex));

            this.comboBoxResponseGroup.DataSource = Enum.GetValues(typeof(AmazonResponseGroup));
            this.comboBoxResponseGroup.SelectedItem = AmazonResponseGroup.Large;

            var version = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = String.Format("Nager - AmazonProductAdvertising {0}", version);

            this.dataGridViewResult.AutoGenerateColumns = false;
        }

        #region Buttons

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            var search = this.textBoxSearch.Text;
            var endpoint = (AmazonEndpoint)this.comboBoxEndpoint.SelectedItem;
            var searchIndex = (AmazonSearchIndex)this.comboBoxSearchIndex.SelectedItem;
            var responseGroup = (AmazonResponseGroup)this.comboBoxResponseGroup.SelectedItem;

            var wrapper = new AmazonWrapper(this._authentication, endpoint, "nagerat-21");
            wrapper.XmlReceived += XmlReceived;
            var result = await wrapper.SearchAsync(search, searchIndex, responseGroup);
            wrapper.XmlReceived -= XmlReceived;

            if (result == null)
            {
                this.tabControl1.SelectedIndex = 1;
                MessageBox.Show("Request error");
                return;
            }

            this.dataGridViewResult.DataSource = result.Items.Item;
        }

        private void buttonLookup_Click(object sender, EventArgs e)
        {
            var asin = this.textBoxAsin.Text;
            var endpoint = (AmazonEndpoint)this.comboBoxEndpoint.SelectedItem;
            var responseGroup = this.responseGroupControl1.GetResponseGroup();

            var wrapper = new AmazonWrapper(this._authentication, endpoint, "nagerat-21");
            wrapper.XmlReceived += XmlReceived;
            var result = wrapper.Lookup(asin, responseGroup);
            wrapper.XmlReceived -= XmlReceived;

            if (result == null)
            {
                MessageBox.Show("Request error");
                return;
            }

            this.dataGridViewResult.DataSource = result.Items.Item;
        }

        #endregion

        private void XmlReceived(string xml)
        {
            this.textBoxXml.Text = System.Xml.Linq.XDocument.Parse(xml).ToString();
        }

        private void dataGridViewResult_SelectionChanged(object sender, EventArgs e)
        {
            var item = this.dataGridViewResult.CurrentRow.DataBoundItem as Item;
            if (item == null)
            {
                return;
            }

            this.amazonItemControl.ShowItem(item);
        }

        private void SearchXml(int startIndex)
        {
            var search = this.textBoxXmlSearch.Text;

            var indexOf = this.textBoxXml.Text.IndexOf(search, startIndex, StringComparison.OrdinalIgnoreCase);
            if (indexOf == -1)
            {
                return;
            }

            this.textBoxXml.SelectionStart = indexOf;
            this.textBoxXml.SelectionLength = search.Length;
            this.textBoxXml.ScrollToCaret();
        }

        private void textBoxXmlSearch_TextChanged(object sender, EventArgs e)
        {
            this.SearchXml(0);
        }

        private void textBoxXmlSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            var startIndex = this.textBoxXml.SelectionStart + this.textBoxXml.SelectionLength;
            this.SearchXml(startIndex);
        }
    }
}