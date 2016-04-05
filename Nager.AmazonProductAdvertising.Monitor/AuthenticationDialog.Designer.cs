namespace Nager.AmazonProductAdvertising.Monitor
{
    partial class AuthenticationDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSecretKey = new System.Windows.Forms.TextBox();
            this.textBoxAccessKey = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "AccessKey:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SecretKey:";
            // 
            // textBoxSecretKey
            // 
            this.textBoxSecretKey.Location = new System.Drawing.Point(86, 38);
            this.textBoxSecretKey.Name = "textBoxSecretKey";
            this.textBoxSecretKey.Size = new System.Drawing.Size(410, 20);
            this.textBoxSecretKey.TabIndex = 6;
            this.textBoxSecretKey.UseSystemPasswordChar = true;
            // 
            // textBoxAccessKey
            // 
            this.textBoxAccessKey.Location = new System.Drawing.Point(86, 12);
            this.textBoxAccessKey.Name = "textBoxAccessKey";
            this.textBoxAccessKey.Size = new System.Drawing.Size(410, 20);
            this.textBoxAccessKey.TabIndex = 5;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(421, 69);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // AuthenticationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 105);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSecretKey);
            this.Controls.Add(this.textBoxAccessKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthenticationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazon Authentication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSecretKey;
        private System.Windows.Forms.TextBox textBoxAccessKey;
        private System.Windows.Forms.Button buttonOk;
    }
}