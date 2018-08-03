namespace Nager.AmazonProductAdvertising.TestUI
{
    partial class Main
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSearchIndex = new System.Windows.Forms.ComboBox();
            this.comboBoxResponseGroup = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAsin = new System.Windows.Forms.TextBox();
            this.buttonLookup = new System.Windows.Forms.Button();
            this.panelEndpoint = new System.Windows.Forms.Panel();
            this.comboBoxEndpoint = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCommon = new System.Windows.Forms.TabPage();
            this.splitContainerItems = new System.Windows.Forms.SplitContainer();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.ColumnAsin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalesRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amazonItemControl = new Nager.AmazonProductAdvertising.TestUI.AmazonItemControl();
            this.tabPageXml = new System.Windows.Forms.TabPage();
            this.textBoxXml = new System.Windows.Forms.TextBox();
            this.responseGroupControl1 = new Nager.AmazonProductAdvertising.TestUI.ResponseGroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelEndpoint.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageCommon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerItems)).BeginInit();
            this.splitContainerItems.Panel1.SuspendLayout();
            this.splitContainerItems.Panel2.SuspendLayout();
            this.splitContainerItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.tabPageXml.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl2);
            this.splitContainer1.Panel1.Controls.Add(this.panelEndpoint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1005, 640);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 37);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1005, 213);
            this.tabControl2.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboBoxSearchIndex);
            this.tabPage1.Controls.Add(this.comboBoxResponseGroup);
            this.tabPage1.Controls.Add(this.buttonSearch);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(997, 187);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "ResponseGroup:";
            // 
            // comboBoxSearchIndex
            // 
            this.comboBoxSearchIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchIndex.FormattingEnabled = true;
            this.comboBoxSearchIndex.Location = new System.Drawing.Point(101, 6);
            this.comboBoxSearchIndex.Name = "comboBoxSearchIndex";
            this.comboBoxSearchIndex.Size = new System.Drawing.Size(205, 21);
            this.comboBoxSearchIndex.TabIndex = 10;
            // 
            // comboBoxResponseGroup
            // 
            this.comboBoxResponseGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResponseGroup.FormattingEnabled = true;
            this.comboBoxResponseGroup.Location = new System.Drawing.Point(101, 33);
            this.comboBoxResponseGroup.Name = "comboBoxResponseGroup";
            this.comboBoxResponseGroup.Size = new System.Drawing.Size(205, 21);
            this.comboBoxResponseGroup.TabIndex = 13;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(100, 86);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "SearchIndex:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(101, 60);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(205, 20);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.Text = "canon eos";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.responseGroupControl1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxAsin);
            this.tabPage2.Controls.Add(this.buttonLookup);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 187);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lookup";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "ResponseGroup:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ASIN:";
            // 
            // textBoxAsin
            // 
            this.textBoxAsin.Location = new System.Drawing.Point(101, 6);
            this.textBoxAsin.Name = "textBoxAsin";
            this.textBoxAsin.Size = new System.Drawing.Size(143, 20);
            this.textBoxAsin.TabIndex = 7;
            this.textBoxAsin.Text = "B00BYPW00I";
            // 
            // buttonLookup
            // 
            this.buttonLookup.Location = new System.Drawing.Point(101, 158);
            this.buttonLookup.Name = "buttonLookup";
            this.buttonLookup.Size = new System.Drawing.Size(75, 23);
            this.buttonLookup.TabIndex = 8;
            this.buttonLookup.Text = "Lookup";
            this.buttonLookup.UseVisualStyleBackColor = true;
            this.buttonLookup.Click += new System.EventHandler(this.buttonLookup_Click);
            // 
            // panelEndpoint
            // 
            this.panelEndpoint.Controls.Add(this.comboBoxEndpoint);
            this.panelEndpoint.Controls.Add(this.label1);
            this.panelEndpoint.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEndpoint.Location = new System.Drawing.Point(0, 0);
            this.panelEndpoint.Name = "panelEndpoint";
            this.panelEndpoint.Size = new System.Drawing.Size(1005, 37);
            this.panelEndpoint.TabIndex = 16;
            // 
            // comboBoxEndpoint
            // 
            this.comboBoxEndpoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEndpoint.FormattingEnabled = true;
            this.comboBoxEndpoint.Location = new System.Drawing.Point(68, 9);
            this.comboBoxEndpoint.Name = "comboBoxEndpoint";
            this.comboBoxEndpoint.Size = new System.Drawing.Size(225, 21);
            this.comboBoxEndpoint.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Endpoint:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCommon);
            this.tabControl1.Controls.Add(this.tabPageXml);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 386);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPageCommon
            // 
            this.tabPageCommon.Controls.Add(this.splitContainerItems);
            this.tabPageCommon.Location = new System.Drawing.Point(4, 22);
            this.tabPageCommon.Name = "tabPageCommon";
            this.tabPageCommon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCommon.Size = new System.Drawing.Size(997, 360);
            this.tabPageCommon.TabIndex = 0;
            this.tabPageCommon.Text = "Common";
            this.tabPageCommon.UseVisualStyleBackColor = true;
            // 
            // splitContainerItems
            // 
            this.splitContainerItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerItems.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerItems.IsSplitterFixed = true;
            this.splitContainerItems.Location = new System.Drawing.Point(3, 3);
            this.splitContainerItems.Name = "splitContainerItems";
            // 
            // splitContainerItems.Panel1
            // 
            this.splitContainerItems.Panel1.Controls.Add(this.dataGridViewResult);
            // 
            // splitContainerItems.Panel2
            // 
            this.splitContainerItems.Panel2.Controls.Add(this.amazonItemControl);
            this.splitContainerItems.Size = new System.Drawing.Size(991, 354);
            this.splitContainerItems.SplitterDistance = 220;
            this.splitContainerItems.TabIndex = 1;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.AllowUserToResizeColumns = false;
            this.dataGridViewResult.AllowUserToResizeRows = false;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAsin,
            this.ColumnSalesRank});
            this.dataGridViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResult.Size = new System.Drawing.Size(220, 354);
            this.dataGridViewResult.TabIndex = 0;
            this.dataGridViewResult.SelectionChanged += new System.EventHandler(this.dataGridViewResult_SelectionChanged);
            // 
            // ColumnAsin
            // 
            this.ColumnAsin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAsin.DataPropertyName = "ASIN";
            this.ColumnAsin.HeaderText = "ASIN";
            this.ColumnAsin.Name = "ColumnAsin";
            this.ColumnAsin.ReadOnly = true;
            // 
            // ColumnSalesRank
            // 
            this.ColumnSalesRank.DataPropertyName = "SalesRank";
            this.ColumnSalesRank.HeaderText = "SalesRank";
            this.ColumnSalesRank.Name = "ColumnSalesRank";
            this.ColumnSalesRank.ReadOnly = true;
            // 
            // amazonItemControl
            // 
            this.amazonItemControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amazonItemControl.Location = new System.Drawing.Point(0, 0);
            this.amazonItemControl.Name = "amazonItemControl";
            this.amazonItemControl.Size = new System.Drawing.Size(767, 354);
            this.amazonItemControl.TabIndex = 0;
            // 
            // tabPageXml
            // 
            this.tabPageXml.Controls.Add(this.textBoxXml);
            this.tabPageXml.Location = new System.Drawing.Point(4, 22);
            this.tabPageXml.Name = "tabPageXml";
            this.tabPageXml.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageXml.Size = new System.Drawing.Size(997, 360);
            this.tabPageXml.TabIndex = 1;
            this.tabPageXml.Text = "XML";
            this.tabPageXml.UseVisualStyleBackColor = true;
            // 
            // textBoxXml
            // 
            this.textBoxXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxXml.Location = new System.Drawing.Point(3, 3);
            this.textBoxXml.Multiline = true;
            this.textBoxXml.Name = "textBoxXml";
            this.textBoxXml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxXml.Size = new System.Drawing.Size(991, 354);
            this.textBoxXml.TabIndex = 0;
            // 
            // responseGroupControl1
            // 
            this.responseGroupControl1.Location = new System.Drawing.Point(101, 35);
            this.responseGroupControl1.Name = "responseGroupControl1";
            this.responseGroupControl1.Size = new System.Drawing.Size(336, 117);
            this.responseGroupControl1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 640);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "change by code";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelEndpoint.ResumeLayout(false);
            this.panelEndpoint.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCommon.ResumeLayout(false);
            this.splitContainerItems.Panel1.ResumeLayout(false);
            this.splitContainerItems.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerItems)).EndInit();
            this.splitContainerItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.tabPageXml.ResumeLayout(false);
            this.tabPageXml.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonLookup;
        private System.Windows.Forms.TextBox textBoxAsin;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCommon;
        private System.Windows.Forms.TabPage tabPageXml;
        private System.Windows.Forms.TextBox textBoxXml;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAsin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalesRank;
        private System.Windows.Forms.SplitContainer splitContainerItems;
        private AmazonItemControl amazonItemControl;
        private System.Windows.Forms.ComboBox comboBoxEndpoint;
        private System.Windows.Forms.ComboBox comboBoxSearchIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxResponseGroup;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelEndpoint;
        private System.Windows.Forms.Label label6;
        private ResponseGroupControl responseGroupControl1;
    }
}

