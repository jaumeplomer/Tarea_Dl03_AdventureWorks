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
            customizedUserControl1.SizeClicked += recieveData;
        }
        
        public void recieveData(object sender, SizeClickedEventArgs e)
        {
            textBox1.Text = e.Data;
        }

        private void customizedUserControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void customizedUserControl1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
