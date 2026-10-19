using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrola_masked_text_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            maskedTextBox1.Mask = "C000-00-000-0000";
            maskedTextBox1.PromptChar = '_';
            maskedTextBox1.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!maskedTextBox1.MaskCompleted)
                MessageBox.Show("Phone number not exist", "Phone number");
            else
                MessageBox.Show(maskedTextBox1.Text, "Phone number");
        }
    }
}
