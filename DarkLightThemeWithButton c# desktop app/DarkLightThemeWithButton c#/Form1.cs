using System;
using System.Drawing;
using System.Windows.Forms;

namespace DarkLightThemeWithButton_c_
{
    public partial class Form1 : Form
    {
        private bool isDarkTheme = false; // Čuvamo trenutno stanje teme

        public Form1()
        {
            InitializeComponent();
            ApplyTheme(); // Postavljamo početnu temu
        }

        private void buttonTheme_Click(object sender, EventArgs e)
        {
            isDarkTheme = !isDarkTheme; // Prebacujemo stanje
            ApplyTheme(); // Primeni novu temu
        }

        private void ApplyTheme()
        {
            if (isDarkTheme)
            {
                this.BackColor = Color.Black;
                buttonTheme.BackColor = Color.WhiteSmoke;
                buttonTheme.ForeColor = Color.Black;
                buttonTheme.Text = "Light Theme";
            }
            else
            {
                this.BackColor = Color.White;
                buttonTheme.BackColor = Color.Black;
                buttonTheme.ForeColor = Color.WhiteSmoke;
                buttonTheme.Text = "Dark Theme";
            }
        }
    }
}
