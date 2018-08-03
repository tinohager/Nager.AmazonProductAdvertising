namespace Nager.AmazonProductAdvertising.TestUI
{
    partial class ResponseGroupControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewResponseGroup = new System.Windows.Forms.DataGridView();
            this.ColumnText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResponseGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResponseGroup
            // 
            this.dataGridViewResponseGroup.AllowUserToAddRows = false;
            this.dataGridViewResponseGroup.AllowUserToDeleteRows = false;
            this.dataGridViewResponseGroup.AllowUserToResizeRows = false;
            this.dataGridViewResponseGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResponseGroup.ColumnHeadersVisible = false;
            this.dataGridViewResponseGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnText});
            this.dataGridViewResponseGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResponseGroup.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewResponseGroup.Name = "dataGridViewResponseGroup";
            this.dataGridViewResponseGroup.ReadOnly = true;
            this.dataGridViewResponseGroup.RowHeadersVisible = false;
            this.dataGridViewResponseGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResponseGroup.Size = new System.Drawing.Size(342, 162);
            this.dataGridViewResponseGroup.TabIndex = 0;
            // 
            // ColumnText
            // 
            this.ColumnText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnText.DataPropertyName = "Text";
            this.ColumnText.HeaderText = "Text";
            this.ColumnText.Name = "ColumnText";
            this.ColumnText.ReadOnly = true;
            // 
            // ResponseGroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewResponseGroup);
            this.Name = "ResponseGroupControl";
            this.Size = new System.Drawing.Size(342, 162);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResponseGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResponseGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnText;
    }
}
