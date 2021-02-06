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

        //Property for the background colors
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
            //Create a tootltip to show a message on the largePhotoPictureBox
            ToolTip tt = new ToolTip();
            tt.SetToolTip(largePhotoPictureBox, "Click me to display another product");
        }

        //Declare the eventhandler and delegate and raise it
        public event EventHandler<SizeClickedEventArgs> SizeClicked;
        
        public virtual void OnSizeClicked(SizeClickedEventArgs e)
        {
            SizeClicked?.Invoke(this, e);
        }

        private void largePhotoPictureBox_Click(object sender, EventArgs e)
        {
            ProductModel productModel = new ProductModel();
            sizesFlowLayoutPanel.Controls.Clear();
            
            //Method that returns a random int from ProductModelID values. 
            int randomizer()
            {
                //We set all the ids from database in productIds list
                List<Product> productIds = DataAccess.getRandomId();
                List<int> intProductIds = new List<int>();

                //Get the id as an int and set into another list
                foreach (Product prod in productIds)
                {
                    int id = prod.ProductId;
                    intProductIds.Add(id);
                }

                //Pick a random id from the new list and return it
                Random rnd = new Random();
                int a = intProductIds[rnd.Next(0, intProductIds.Count)];
                return a;
            }

            //Declare a boolean to control when the ProductModel is not null
            int randomProductModelID = randomizer();
            bool notNull = false;

            while (notNull == false)
            {
                try
                {
                    //we try to get a product model from the database with the id of the random int we got before.
                    //if it is not null, we set the bool to true and exit the while, if it is null, we get another random id and enter the while again.
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

            //Set the values of the ProductModel to the components of the UserControl.
            MemoryStream ms = new MemoryStream(productModel.LargePhoto);
            Image largePhoto = Image.FromStream(ms);
            largePhotoPictureBox.Image = largePhoto;
            productModelIdTextBox.Text = productModel.ProductModelID.ToString();
            productModelNameTextBox.Text = productModel.Name;
            productPriceTextBox.Text = productModel.ListPrice.ToString();

            //Get a list of Sizs (and product id) from the database.
            productModel.ProductSizes = DataAccess.GetProducts(randomProductModelID);

            //if there are sizes, we create a button for each size with the productId as its name and add it to the FlowLayoutPanel. Plus subscribe it to rtButtons_Click event.
            //if sizes are empty, we create only one button with the same properties, only we set the Text to "talla unica".
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

        //Method that sets the ProductID of the size, shown in the runtime button, as an argument of the SizeClickedEventArgs and calls OnSizeClicked.
        private void rtButtons_Click(object sender, EventArgs e)
        {
            productInfo.ProductId = Int32.Parse(((Button)sender).Name);
            SizeClickedEventArgs args = new SizeClickedEventArgs(productInfo);
            OnSizeClicked(args);
        }

        //Methods to set the background color of the main User control or panels to the color set on the Property
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
