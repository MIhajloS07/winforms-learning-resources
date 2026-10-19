using Dzuboks.Properties;
using System.Drawing.Common;

namespace Dzuboks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackgroundImage = Resources.Default;
            comboBox1.Items.Add("Toma Zdravkovic");
            comboBox1.Items.Add("Eminem");
            textBox2.ReadOnly = true;   
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        pictureBox1.BackgroundImage = Properties.Resources.Toma;
                        textBox2.Text = "NARODNA";
                        break;
                    }
                case 1:
                    {
                        pictureBox1.BackgroundImage = Properties.Resources.Eminem;
                        textBox2.Text = "POP";
                        break;
                    }
            }
        }
    }
}
