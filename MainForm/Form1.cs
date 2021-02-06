using CustomizedUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Subscribe to the event
            customizedUserControl1.SizeClicked += recieveData;           
        }

        //get the data from the event args to show it in the textbox
        public void recieveData(object sender, SizeClickedEventArgs e)
        {
            textBox1.Text = e.Data;
        }

        //set a RGB value to UI property SizesBgColor
        private void colorPickerTrackBar_Scroll(object sender, EventArgs e)
        {
            int red = redPickerTrackBar.Value;
            int green = greenPickerTrackBar.Value;
            int blue = bluePickerTrackBar.Value;

            Color color = Color.FromArgb(red, green, blue);
            customizedUserControl1.SizesBgColor = color;    
        }
    }
}
