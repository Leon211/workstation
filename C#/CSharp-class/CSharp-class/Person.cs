using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_class
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public static string ID { get; set; }
        public void Eat()
        {
            MessageBox.Show("在吃");
        }
    }
}
