using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_function
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string message = "你好";
            SendMessage(ref message);
            //string res = sellHouse(100, 10000, out string wantPrice);
            MessageBox.Show(message);
            //MessageBox.Show(res);
            //MessageBox.Show(wantPrice);
        }
        //public void SendMessage(out string message)
        //{
        //    message = "好久不见";
        //    MessageBox.Show(message);
        //}
        public void SendMessage(ref string message)
        {
            message = "好久不见";
            MessageBox.Show(message);
        }
        public string sellHouse(int area, int price, out string wantPrice)
        {
            wantPrice = "愿意出价" + (area * price - 1);
            return "张三想买";
        }
    }
}
