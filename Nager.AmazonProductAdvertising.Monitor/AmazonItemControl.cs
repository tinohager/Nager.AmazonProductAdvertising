using Nager.AmazonProductAdvertising.Model;
using System.Linq;
using System.Windows.Forms;

namespace Nager.AmazonProductAdvertising.Monitor
{
    public partial class AmazonItemControl : UserControl
    {
        public AmazonItemControl()
        {
            this.InitializeComponent();
        }

        public void ShowItem(Item item)
        {
            if (item == null)
            {
                return;
            }

            var simpleItem = new AmazonSimpleItem(item);
            this.labelName.Text = simpleItem.Name;
            this.labelPrice.Text = simpleItem.Price.ToString("0.00 €");
            this.textBoxLink.Text = simpleItem.GetDetailPageUrl(AmazonEndpoint.DE);

            if (simpleItem.Description == null)
            {
                this.dataGridView1.DataSource = null;
            }
            else
            {
                this.dataGridView1.DataSource = simpleItem.Description.Select(o => new { Description = o }).ToList();
            }

            this.propertyGridLevel1.SelectedObject = item;

            this.ShowImage(this.pictureBox1, item.LargeImage);
            this.ShowImage(this.pictureBox2, item.SmallImage);
        }

        private void ShowImage(PictureBox pictureBox, Image image)
        {
            if (image == null)
            {
                pictureBox.Image = null;
                return;
            }

            pictureBox.ImageLocation = image.URL;
        }

        private void propertyGridLevel1_SelectedGridItemChanged(object sender, SelectedGridItemChangedEventArgs e)
        {
            this.propertyGridLevel3.SelectedObject = null;
            this.propertyGridLevel2.SelectedObject = this.propertyGridLevel1.SelectedGridItem.Value;
        }

        private void propertyGridLevel2_SelectedGridItemChanged(object sender, SelectedGridItemChangedEventArgs e)
        {
            this.propertyGridLevel3.SelectedObject = this.propertyGridLevel2.SelectedGridItem.Value;
        }
    }
}