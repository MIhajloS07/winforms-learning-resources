using System.Diagnostics;

namespace GroupBox_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = $"mailto:{textBox2.Text}?subject=Poruka%20sa%20forme",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string korisnik = null;
            if (textBox1.Text != string.Empty)
            {
                korisnik = textBox1.Text;
            }
            else
            {
                korisnik = "Korisnik aplikacije";
            }
            MessageBox.Show($"Postovani {korisnik} \r\npozovite +381 23 456 7890");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
