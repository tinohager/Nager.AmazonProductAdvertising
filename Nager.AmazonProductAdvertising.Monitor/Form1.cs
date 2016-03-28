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

            var wrapper = new AmazonWrapper(authentication);
            var result = wrapper.Search(search, AmazonEndpoint.DE, "nagerat-21", AmazonSearchIndex.All, AmazonResponseGroup.Large);

            if (result == null)
            {
                MessageBox.Show("Request error");
                return;
            }

            this.dataGridViewResult.DataSource = result.Items.Item;
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