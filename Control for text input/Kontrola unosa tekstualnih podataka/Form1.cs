using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrola_unosa_tekstualnih_podataka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.MaxLength = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.BackColor = Color.Red;
            //textBox1.ForeColor = Color.White;
            //if (textBox1.Text.Length == 0)
            //{
            //    MessageBox.Show(
            //       "Niste uneli tekst",
            //       "Informacija",
            //       MessageBoxButtons.OK,
            //       MessageBoxIcon.Information
            //    );        
            //}
            //else if (!textBox1.Text.All(char.IsDigit))
            //{
            //    textBox1.BackColor = Color.Orange;
            //    textBox1.ForeColor = Color.White;
            //    MessageBox.Show(
            //       "Tekst mora sadrzati samo cifre",
            //       "Upozorenje",
            //       MessageBoxButtons.OK,
            //       MessageBoxIcon.Warning
            //    );          
            //}
            //else
            //{
            //    textBox1.BackColor = Color.White;
            //    textBox1.ForeColor = Color.Black;
            //    MessageBox.Show(
            //       $"{textBox1.Text}",
            //       "Informacija",
            //       MessageBoxButtons.OK,
            //       MessageBoxIcon.Information
            //    );          
            //}
            ValidirajUnos();
            MessageBox.Show($"{ValidirajUnos()}", "Unos", MessageBoxButtons.OK);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (textBox1.Text.Length > 10)
            //{
            //    MessageBox.Show(
            //       "Prekoracen je maksimalni broj poruke",
            //       "Upozorenje",
            //       MessageBoxButtons.OK,
            //       MessageBoxIcon.Warning
            //    );
            //    textBox1.Enabled = false;
            //}
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) 
            //    e.Handled = true;
        }
    
        private bool ValidirajUnos()
        {
            if (!int.TryParse(textBox1.Text, out int result)) return false;
            if (textBox1.Text.Length > 9) return false;
            return result >= 0 && result <= 9; 
        }
    }
}
