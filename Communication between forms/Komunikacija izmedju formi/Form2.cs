using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komunikacija_izmedju_formi
{
    public partial class Form2 : Form
    {
        public string name;
        private Form1 baseForm;
        public string Message
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public string Name
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public Form2(Form1 firstForm)
        {
            InitializeComponent();
            baseForm = firstForm;
        }

        public void ForwardMessage(string text) => label1.Text = text;

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            baseForm.GetData(textBox1.Text);
            this.Close();
        }
    }
}
