using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CustomizedUserControl
{
    public partial class CustomizedUserControl: UserControl
    {
        Product productInfo = new Product();

        private Color _sizesBgColor;
        public Color SizesBgColor
        {
            get { return _sizesBgColor; }
            set { _sizesBgColor = value; }
        }

        public CustomizedUserControl()
        {
            InitializeComponent();
            largePhotoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
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
            ProductModel productModel = new ProductModel();
            sizesFlowLayoutPanel.Controls.Clear();

            int randomizer()
            {
                List<Product> productIds = DataAccess.getRandomId();
                List<int> intProductIds = new List<int>();

                foreach (Product prod in productIds)
                {
                    int id = prod.ProductId;
                    intProductIds.Add(id);
                }

                Random rnd = new Random();
                int a = intProductIds[rnd.Next(0, intProductIds.Count)];
                return a;
            }

            int randomProductModelID = randomizer();
            bool notNull = false;

            while (notNull == false)
            {
                try
                {
                    productModel = DataAccess.GetProductModel(randomProductModelID);
                    if (productModel != null)
                    {
                        notNull = true;
                    }
                    else
                    {
                        randomProductModelID = randomizer();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }                   

            MemoryStream ms = new MemoryStream(productModel.LargePhoto);
            Image largePhoto = Image.FromStream(ms);
            largePhotoPictureBox.Image = largePhoto;
            productModelIdTextBox.Text = productModel.ProductModelID.ToString();
            productModelNameTextBox.Text = productModel.Name;
            productPriceTextBox.Text = productModel.ListPrice.ToString();

            productModel.ProductSizes = DataAccess.GetProducts(randomProductModelID);

            if (productModel.ProductSizes[0].Size != null)
            {
                foreach (Product product in productModel.ProductSizes)
                {
                    Button sizeButton = new Button();
                    sizeButton.Text = product.Size;
                    sizeButton.Name = product.ProductId.ToString();
                    sizeButton.BackColor = Color.Gray;
                    sizesFlowLayoutPanel.Controls.Add(sizeButton);
                    sizeButton.Click += rtButtons_Click;
                }
            }
            else
            {
                Product product = productModel.ProductSizes[0];
                Button sizeButton = new Button();
                sizeButton.Text = "Talla unica";
                sizeButton.Name = product.ProductId.ToString();
                sizeButton.BackColor = Color.Gray;
                sizesFlowLayoutPanel.Controls.Add(sizeButton);
                sizeButton.Click += rtButtons_Click;
            }
        }

        private void rtButtons_Click(object sender, EventArgs e)
        {
            productInfo.ProductId = Int32.Parse(((Button)sender).Name);
            SizeClickedEventArgs args = new SizeClickedEventArgs(productInfo);
            OnSizeClicked(args);
        }

        private void mainBgColorButton_Click(object sender, EventArgs e)
        {
            this.BackColor = SizesBgColor;
        }

        private void panelsBgColorButton_Click(object sender, EventArgs e)
        {
            largePhotoPictureBox.BackColor = SizesBgColor;
            sizesFlowLayoutPanel.BackColor = SizesBgColor;
        }
    }
}
