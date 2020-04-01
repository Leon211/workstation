using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CSharp_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person p = new Person()
            {
                Age=18,
                Height=170,
                Name = "p"
            };
            Person.ID = "123456";
            p.Name = "p";
            p.Eat();

        }
    }
}
