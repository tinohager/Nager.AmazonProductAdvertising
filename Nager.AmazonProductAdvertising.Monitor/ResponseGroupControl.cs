using Nager.AmazonProductAdvertising.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Nager.AmazonProductAdvertising.Monitor
{
    public partial class ResponseGroupControl : UserControl
    {
        public ResponseGroupControl()
        {
            this.InitializeComponent();

            var items = new List<AmazonResponseGroup>((AmazonResponseGroup[])Enum.GetValues(typeof(AmazonResponseGroup))).Select(o => new GridItem { Text = o.ToString() }).OrderBy(o => o.Text).ToList();
            this.dataGridViewResponseGroup.DataSource = items;
        }

        public AmazonResponseGroup GetResponseGroup()
        {
            AmazonResponseGroup responseGroup = AmazonResponseGroup.Tracks;

            for (var i = 0; i < this.dataGridViewResponseGroup.SelectedRows.Count; i++)
            {
                var selectedRow = this.dataGridViewResponseGroup.SelectedRows[i];
                var gridItem = selectedRow.DataBoundItem as GridItem;
                var tempResponseGroup = (AmazonResponseGroup)Enum.Parse(typeof(AmazonResponseGroup), gridItem.Text);

                if (i == 0)
                {
                    responseGroup = tempResponseGroup;
                    continue;
                }

                responseGroup |= tempResponseGroup;
            }

            return responseGroup;
        }

        public class GridItem
        {
            public string Text { get; set; }
        }
    }
}
