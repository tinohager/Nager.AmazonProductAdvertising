using Nager.AmazonProductAdvertising.Model;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Nager.AmazonProductAdvertising.Monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();

            var version = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = String.Format("Nager - AmazonProductAdvertising {0}", version);

            this.dataGridViewResult.AutoGenerateColumns = false;
        }

        private AmazonAuthentication GetAuthentication()
        {
            var authentication = new AmazonAuthentication();
            authentication.AccessKey = this.textBoxAccessKey.Text;
            authentication.SecretKey = this.textBoxSecretKey.Text;
            return authentication;
        }

        private bool IsValidAuthentication(AmazonAuthentication authentication)
        {
            if (String.IsNullOrEmpty(authentication.AccessKey) || String.IsNullOrEmpty(authentication.SecretKey))
            {
                this.textBoxAccessKey.BackColor = Color.OrangeRed;
                this.textBoxSecretKey.BackColor = Color.OrangeRed;
                return false;
            }

            this.textBoxAccessKey.BackColor = Color.White;
            this.textBoxSecretKey.BackColor = Color.White;
            return true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var search = this.textBoxSearch.Text;
            var authentication = this.GetAuthentication();

            if (!this.IsValidAuthentication(authentication))
            {
                MessageBox.Show("Authentication invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE, "nagerat-21");
            wrapper.XmlReceived += XmlReceived;
            var result = wrapper.Search(search, AmazonSearchIndex.All, AmazonResponseGroup.Large);
            wrapper.XmlReceived -= XmlReceived;

            if (result == null)
            {
                MessageBox.Show("Request error");
                return;
            }

            this.dataGridViewResult.DataSource = result.Items.Item;
        }

        private void buttonLookup_Click(object sender, EventArgs e)
        {
            var asin = this.textBoxAsin.Text;
            var authentication = this.GetAuthentication();

            if (!this.IsValidAuthentication(authentication))
            {
                MessageBox.Show("Authentication invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE, "nagerat-21");
            wrapper.XmlReceived += XmlReceived;
            var result = wrapper.Lookup(asin);
            wrapper.XmlReceived -= XmlReceived;

            if (result == null)
            {
                MessageBox.Show("Request error");
                return;
            }

            this.dataGridViewResult.DataSource = result.Items.Item;
        }

        private void XmlReceived(string xml)
        {
            this.textBoxXml.Text = xml.Replace("><", ">\r\n<");
        }

        private void dataGridViewResult_SelectionChanged(object sender, EventArgs e)
        {
            var item = this.dataGridViewResult.CurrentRow.DataBoundItem as Item;
            if (item == null)
            {
                return;
            }

            this.propertyGrid1.SelectedObject = item.ItemAttributes;
            if (item.MediumImage == null)
            {
                this.pictureBox1.Image = null;
            }
            else
            {
                this.pictureBox1.ImageLocation = item.MediumImage.URL;
            }
        }
    }
}