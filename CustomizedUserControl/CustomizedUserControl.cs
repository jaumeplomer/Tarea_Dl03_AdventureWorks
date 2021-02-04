using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CustomizedUserControl
{
    public partial class CustomizedUserControl: UserControl
    {
        Product prod = new Product();
        public CustomizedUserControl()
        {
            InitializeComponent();
            ToolTip tt = new ToolTip();
            tt.SetToolTip(largePhotoPictureBox, "Click me to display another product");


        }
        public event EventHandler<SizeClickedEventArgs> SizeClicked;

        public virtual void OnSizeClicked(SizeClickedEventArgs e)
        {
            SizeClicked?.Invoke(this, e);
        }

        private void largePhotoPictureBox_Click(object sender, EventArgs e)
        {
            var productModel = DataAccess.GetProductModel(20);
            MemoryStream ms = new MemoryStream(productModel.LargePhoto);
            Image largePhoto = Image.FromStream(ms);
            largePhotoPictureBox.Image = largePhoto;
            productModelIdTextBox.Text = productModel.ProductModelID.ToString();
            productModelNameTextBox.Text = productModel.Name;
            productPriceTextBox.Text = productModel.ListPrice.ToString();

            productModel.ProductSizes = DataAccess.GetProducts(20);

            if (productModel.ProductSizes[0].Size != null)
            {
                foreach (Product product in productModel.ProductSizes)
                {
                    Button sizeButton = new Button();
                    sizeButton.Text = product.Size;
                    sizeButton.Name = product.ProductId.ToString();
                    sizesFlowLayoutPanel.Controls.Add(sizeButton);
                    sizeButton.Click += rtButtons_Click;
                }
            }
            else
            {
                Button sizeButton = new Button();
                sizeButton.Text = "Talla unica";
                sizeButton.Name = "Talla unica";
                sizesFlowLayoutPanel.Controls.Add(sizeButton);
            }
        }

        private void rtButtons_Click(object sender, EventArgs e)
        {
            prod.ProductId = Int32.Parse(((Button)sender).Name);
            SizeClickedEventArgs args = new SizeClickedEventArgs(prod);
            OnSizeClicked(args);
        }
    }
}
