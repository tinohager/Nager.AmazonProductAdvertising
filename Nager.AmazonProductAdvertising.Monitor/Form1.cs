using Nager.AmazonProductAdvertising.Model;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Nager.AmazonProductAdvertising.Monitor
{
    public partial class Form1 : Form
    {
        private AmazonAuthentication _authentication;

        public Form1()
        {
            this.InitializeComponent();
            var dialog = new AuthenticationDialog();
            var dialogResult = dialog.ShowDialog(this);
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this._authentication = dialog.Authentication;
            }

            var version = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = String.Format("Nager - AmazonProductAdvertising {0}", version);

            this.dataGridViewResult.AutoGenerateColumns = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var search = this.textBoxSearch.Text;

            var wrapper = new AmazonWrapper(this._authentication, AmazonEndpoint.DE, "nagerat-21");
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

            var wrapper = new AmazonWrapper(this._authentication, AmazonEndpoint.DE, "nagerat-21");
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

            this.propertyGridItem.SelectedObject = item;
            this.propertyGridDetail.SelectedObject = item.ItemAttributes;

            this.ShowImage(item.LargeImage);
        }

        private void ShowImage(Nager.AmazonProductAdvertising.Model.Image image)
        {
            if (image == null)
            {
                this.pictureBox1.Image = null;
            }
            else
            {
                this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                this.pictureBox1.ImageLocation = image.URL;
            }
        }

        private void propertyGridItem_SelectedGridItemChanged(object sender, SelectedGridItemChangedEventArgs e)
        {
            this.propertyGridCommon.SelectedObject = this.propertyGridItem.SelectedGridItem.Value;
        }
    }
}