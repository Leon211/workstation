using System;
using System.Windows.Forms;

namespace CSharpCase1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //double price = 1.9;
            //int count = 6;
            //double disCount = 0.75;
            //double totalPrice;
            //totalPrice = price * count;
            //if (totalPrice > 10)
            //{
            //    totalPrice = totalPrice * disCount;
            //}
            //MessageBox.Show(totalPrice.ToString());
            double price = 1.9;
            int count = 16;
            double disCount = 0.75;
            double totalPrice; 
            double totalTen = 0;
            totalPrice = price * count;
            int d = (int)(totalPrice / 10);
            for (int i = 0; i < d; i++)
            {
              
                totalTen = totalTen + 10 * disCount;
            }
            double add = totalPrice % 10;
            totalPrice = totalTen + add;

        }
    }
}
