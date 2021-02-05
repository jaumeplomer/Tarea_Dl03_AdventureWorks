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

        public event EventHandler ClearButtonClicked;
        public virtual void OnClearButtonClicked(EventArgs e)
        {
            ClearButtonClicked?.Invoke(this, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnClearButtonClicked(e);
        }
    }
}
