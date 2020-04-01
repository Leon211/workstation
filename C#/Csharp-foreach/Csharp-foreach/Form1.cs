using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int[] ints = { 1, 2, 3 };
            //foreach (int item in ints)
            //{
            //    MessageBox.Show(item.ToString());
            //}
            //List<int> intList = new List<int>() { 1, 2, 3 };
            //foreach (int item in intList)
            //{
            //    MessageBox.Show(item.ToString());
            //}
            //Dictionary<string, string> Dictionary = new Dictionary<string, string>()
            //{
            //    {"A","a" },{ "B","b" },
            //};
            //foreach (KeyValuePair<string, string> item in Dictionary)
            //{
            //    string key = item.Key;
            //    string value = item.Value;
            //}
            List<Person> personList = new Person().GetUserList();
            foreach (Person item in personList)
            {
                MessageBox.Show(item.Name+"Age is"+item.Age.ToString());
            }
        }
    }
}
