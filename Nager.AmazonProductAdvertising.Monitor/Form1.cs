using Nager.AmazonProductAdvertising.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nager.AmazonProductAdvertising.Monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            this.InitializeComponent();
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var search = this.textBoxSearch.Text;
            var authentication = this.GetAuthentication();

            var wrapper = new AmazonWrapper(authentication);
            var result = wrapper.Search(search, AmazonEndpoint.DE, "nagerat-21", AmazonSearchIndex.Electronics, AmazonResponseGroup.Large);

            this.dataGridViewResult.DataSource = result.Items.Item;
        }

        private void dataGridViewResult_SelectionChanged(object sender, EventArgs e)
        {
            var item = this.dataGridViewResult.CurrentRow.DataBoundItem as ItemSearchResponseItemsItem;
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