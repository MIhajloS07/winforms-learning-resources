using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InkrementDekrementApp
{
    public partial class Form1 : Form
    {
        int number = 0;
        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number++;
            label1.Text = number.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            number--;
            label1.Text = number.ToString();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            number = 0;
            label1.Text = number.ToString();
        }
    }
}
