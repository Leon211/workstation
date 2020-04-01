using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpDic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1,"98");
            dictionary.Add(2,"92");
            dictionary.Add(3,"91");//add方法添加
            dictionary[1] = "88";//索引器赋值
            Dictionary<string, string> dictionary1 = new Dictionary<string, string>
            {
                { "A","a"}
            };
            string b = dictionary[1]; 
        }
    }
}
