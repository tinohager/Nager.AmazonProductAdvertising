namespace Nager.AmazonProductAdvertising.Monitor
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxAsin = new System.Windows.Forms.TextBox();
            this.buttonLookup = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxResponseGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxSearchIndex = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEndpoint = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCommon = new System.Windows.Forms.TabPage();
            this.splitContainerItems = new System.Windows.Forms.SplitContainer();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.ColumnAsin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalesRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userControlItem = new Nager.AmazonProductAdvertising.Monitor.UserControlItem();
            this.tabPageXml = new System.Windows.Forms.TabPage();
            this.textBoxXml = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxEndpoint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(868, 536);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxAsin);
            this.groupBox2.Controls.Add(this.buttonLookup);
            this.groupBox2.Location = new System.Drawing.Point(643, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 132);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lookup";
            // 
            // textBoxAsin
            // 
            this.textBoxAsin.Location = new System.Drawing.Point(6, 19);
            this.textBoxAsin.Name = "textBoxAsin";
            this.textBoxAsin.Size = new System.Drawing.Size(143, 20);
            this.textBoxAsin.TabIndex = 7;
            this.textBoxAsin.Text = "B00BYPW00I";
            // 
            // buttonLookup
            // 
            this.buttonLookup.Location = new System.Drawing.Point(5, 44);
            this.buttonLookup.Name = "buttonLookup";
            this.buttonLookup.Size = new System.Drawing.Size(75, 23);
            this.buttonLookup.TabIndex = 8;
            this.buttonLookup.Text = "Lookup";
            this.buttonLookup.UseVisualStyleBackColor = true;
            this.buttonLookup.Click += new System.EventHandler(this.buttonLookup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxResponseGroup);
            this.groupBox1.Controls.Add(this.comboBoxSearchIndex);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Location = new System.Drawing.Point(308, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 135);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "ResponseGroup:";
            // 
            // comboBoxResponseGroup
            // 
            this.comboBoxResponseGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResponseGroup.FormattingEnabled = true;
            this.comboBoxResponseGroup.Location = new System.Drawing.Point(104, 49);
            this.comboBoxResponseGroup.Name = "comboBoxResponseGroup";
            this.comboBoxResponseGroup.Size = new System.Drawing.Size(205, 21);
            this.comboBoxResponseGroup.TabIndex = 13;
            // 
            // comboBoxSearchIndex
            // 
            this.comboBoxSearchIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchIndex.FormattingEnabled = true;
            this.comboBoxSearchIndex.Location = new System.Drawing.Point(104, 22);
            this.comboBoxSearchIndex.Name = "comboBoxSearchIndex";
            this.comboBoxSearchIndex.Size = new System.Drawing.Size(205, 21);
            this.comboBoxSearchIndex.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "SearchIndex:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(104, 76);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(205, 20);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.Text = "canon eos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(103, 102);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Endpoint:";
            // 
            // comboBoxEndpoint
            // 
            this.comboBoxEndpoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEndpoint.FormattingEnabled = true;
            this.comboBoxEndpoint.Location = new System.Drawing.Point(77, 12);
            this.comboBoxEndpoint.Name = "comboBoxEndpoint";
            this.comboBoxEndpoint.Size = new System.Drawing.Size(225, 21);
            this.comboBoxEndpoint.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCommon);
            this.tabControl1.Controls.Add(this.tabPageXml);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(868, 382);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPageCommon
            // 
            this.tabPageCommon.Controls.Add(this.splitContainerItems);
            this.tabPageCommon.Location = new System.Drawing.Point(4, 22);
            this.tabPageCommon.Name = "tabPageCommon";
            this.tabPageCommon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCommon.Size = new System.Drawing.Size(860, 356);
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
            this.splitContainerItems.Panel2.Controls.Add(this.userControlItem);
            this.splitContainerItems.Size = new System.Drawing.Size(854, 350);
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
            this.dataGridViewResult.Size = new System.Drawing.Size(220, 350);
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
            // userControlItem
            // 
            this.userControlItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlItem.Location = new System.Drawing.Point(0, 0);
            this.userControlItem.Name = "userControlItem";
            this.userControlItem.Size = new System.Drawing.Size(630, 350);
            this.userControlItem.TabIndex = 0;
            // 
            // tabPageXml
            // 
            this.tabPageXml.Controls.Add(this.textBoxXml);
            this.tabPageXml.Location = new System.Drawing.Point(4, 22);
            this.tabPageXml.Name = "tabPageXml";
            this.tabPageXml.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageXml.Size = new System.Drawing.Size(860, 356);
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
            this.textBoxXml.Size = new System.Drawing.Size(854, 350);
            this.textBoxXml.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 536);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "change by code";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private UserControlItem userControlItem;
        private System.Windows.Forms.ComboBox comboBoxEndpoint;
        private System.Windows.Forms.ComboBox comboBoxSearchIndex;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxResponseGroup;
    }
}

