using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = ""; 
            s  = textBox1.Text;
            int n1 = int.Parse(s);
            s = textBox2.Text;
            int n2 = int.Parse(s);
            int n3 = n1 * n2;
            textBox3.Text = n3.ToString();

        }

        
    }
}
