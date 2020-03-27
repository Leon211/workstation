using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharar_Case2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string[] classStudents = new string[] { "zhang", "li", "wang", "zhao", "tian", "zhou" };
            //int l = classStudents.Length;
            //for (int i = 0; i < l; i++)
            //{
            //    if (classStudents[i] == "zhao")
            //    {
            //        MessageBox.Show("Found" + classStudents[i] + "send him home.");
            //        break;
            //    }
            //}
            string[] classStudents = new string[] { "zhang", "li", "wang", "zhao", "tian", "zhou" };
            int i = 0;
            string student = "";
            bool isfound = true;
            while (student != "zhao")
            {
                if (i >= classStudents.Length)
                {
                    MessageBox.Show("not found");
                    isfound = false;
                    break;
                }
                student = classStudents[i++];
            }
            if(isfound) MessageBox.Show("Found " + classStudents[i] + " send him home.");
        }
    }
}
