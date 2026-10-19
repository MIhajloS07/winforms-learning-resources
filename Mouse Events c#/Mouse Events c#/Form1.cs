using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse_Events_c_
{
    public partial class Form1 : Form
    {
        private bool isDarkTheme = false;

        public Form1()
        {
            InitializeComponent();
            ApplyTheme();
        }

        public void ApplyTheme()
        {
            if (isDarkTheme)
            {
                this.BackColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.White;
            }

        }

        public void SwitchTheme()
        {
            isDarkTheme = !isDarkTheme;
            ApplyTheme();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show($"Desio se klik misa na dugme {e.Button.ToString()}, " +
            //    $"\n na poziciji {e.Location}" +
            //    $", a \n koordinate ose su ({e.X},{e.Y})","Dogadjaj misa");

            if (e.Button == MouseButtons.Left) // Ukoliko je kliknuto levo dugme
            {
                MessageBox.Show("Fire");
            }
            else if (e.Button == MouseButtons.Right) // Ukoliko je kliknuto desno dugme
            {
                MessageBox.Show("Aim");
            }
            else if (e.Button == MouseButtons.Middle) // Ukoliko je kliknuto srednje dugme onda menjaj temu (Light/Dark)
            {
                SwitchTheme();
            }
        }
    }
}
