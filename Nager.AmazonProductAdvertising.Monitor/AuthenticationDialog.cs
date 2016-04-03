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
    public partial class AuthenticationDialog : Form
    {
        public AmazonAuthentication Authentication;

        public AuthenticationDialog()
        {
            this.InitializeComponent();
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

        private void buttonOk_Click(object sender, EventArgs e)
        {
            var authentication = new AmazonAuthentication();
            authentication.AccessKey = this.textBoxAccessKey.Text;
            authentication.SecretKey = this.textBoxSecretKey.Text;

            if (!this.IsValidAuthentication(authentication))
            {
                return;
            }

            this.Authentication = authentication;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
