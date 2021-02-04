using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomizedUserControl
{
    public class SizeClickedEventArgs : EventArgs
    {
        private string m_Data;      
        public SizeClickedEventArgs(Product prod)
        {
            m_Data = prod.ProductId.ToString();
        }
        public string Data { get { return m_Data; } }
    }
}
