using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dogadjaji_tastature_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                MessageBox.Show("Igrac ide pravo");
            }
            else if (e.KeyCode == Keys.A)
            {
                MessageBox.Show("Igrac ide levo");
            }
            else if (e.KeyCode == Keys.S)
            {
                MessageBox.Show("Igrac ide nazad");
            }
            else if (e.KeyCode == Keys.D)
            {
                MessageBox.Show("Igrac ide desno");
            }
            else if (e.KeyCode == Keys.E)
            {
                MessageBox.Show("Igrac baca spell -> vatra");
            }
            else if (e.KeyCode == Keys.Q)
            {
                MessageBox.Show("Igrac baca spell -> mana recovery");
            }
            else if (e.KeyCode == Keys.Space)
            {
                MessageBox.Show("Igrac skace");
            }
            else
            {
                MessageBox.Show("Pogresno uneto dugme sa tastature");
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Prazno
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W || e.KeyCode == Keys.A || e.KeyCode == Keys.S || e.KeyCode == Keys.D)
            {
                this.Text = "Играч је стао!";
            }
        }
    }
}
