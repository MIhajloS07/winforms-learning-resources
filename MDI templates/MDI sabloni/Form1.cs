using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_sabloni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Creating public methods for changing value in richTextBox because this 
        /// control is private and cannot access in MDI parrent class
        /// </summary>

        public void LoadFile(string path) => richTextBox1.LoadFile(path, RichTextBoxStreamType.PlainText);
        public void SaveFile(string path) => richTextBox1.SaveFile(path, RichTextBoxStreamType.PlainText);
        public void Copy() => richTextBox1.Copy();
        public void Cut() => richTextBox1.Cut();
        public void Paste() => richTextBox1.Paste();    
    }
}
