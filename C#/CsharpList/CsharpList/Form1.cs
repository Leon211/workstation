using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<int> intList = new List<int>();
            //intList.Add(1);
            List<Person> people = new List<Person>();
            Person a = new Person()
            {
                Age = 10,
                Height = 178,
                Name = "A'"
            };
            people.Add(a);
            Person b = people[0];
            people.Remove(a);
        }
    }
}
