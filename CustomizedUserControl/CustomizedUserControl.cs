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
        public CustomizedUserControl()
        {
            InitializeComponent();
        }

        private void largePhotoPictureBox_Click(object sender, EventArgs e)
        {
            var productModel = DataAccess.GetProductModel(100);
            MemoryStream ms = new MemoryStream(productModel.LargePhoto);
            Image largePhoto = Image.FromStream(ms);
            largePhotoPictureBox.Image = largePhoto;
            productModelIdTextBox.Text = productModel.ProductModelID.ToString();
            productModelNameTextBox.Text = productModel.Name;
            productPriceTextBox.Text = productModel.ListPrice.ToString();

            productModel.ProductSizes = DataAccess.GetProducts(100);

            if (productModel.ProductSizes[0].Size != null)
            {
                foreach (Product product in productModel.ProductSizes)
                {
                    Button sizeButton = new Button();
                    sizeButton.Text = product.Size;
                    sizeButton.Name = product.ProductId.ToString();
                    sizesFlowLayoutPanel.Controls.Add(sizeButton);
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

    }
}
