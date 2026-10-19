using System;

namespace Zadatak_test_programiranje
{
    public partial class Forma : Form
    {
        private Krug krug;
        private Random random = new Random();
        public Forma()
        {
            InitializeComponent();
            PovrsinaCheck.TabStop = false;
            ObimCheck.TabStop = false;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            label3.Visible = false;
            label5.Text = string.Empty;
            timer1.Start();
            timer2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double vrednostCombobox = double.Parse(comboBox1.Text);
                krug = new Krug(vrednostCombobox);
                if (ObimCheck.Checked)
                {
                    label3.Visible = true;
                    label3.Text = $"Obim: {Math.Round(krug.Obim(), 2)}cm";
                }
                else if (PovrsinaCheck.Checked)
                {
                    label3.Visible = true;
                    label3.Text = $"Povrsina: {Math.Round(krug.Povrsina(), 2)}cm";
                }
                else
                    throw new ArgumentException("Mora se selektovati jedan od radio dugmeta!");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}",
                    "Greska",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Desila se greska: detalji greske {ex.Message}",
                    "Greska",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void pozadinaPanelaBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
                panel1.BackColor = colorDialog1.Color;
            if (colorDialog1.Color == Color.White)
                label3.ForeColor = Color.Black;
            else
                label3.ForeColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.BackColor = RandomColor();
            pictureBox2.BackColor = RandomColor();
            pictureBox3.BackColor = RandomColor();
        }
        
        private Color RandomColor()
        {
            return Color.FromArgb(
                random.Next(256),
                random.Next(256), 
                random.Next(256)
            );
        }
    }
}
