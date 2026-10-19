namespace Nasledjivanje_Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            label1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Zaposleni zaposleni;
                if (comboBox1.SelectedIndex == 0)
                    zaposleni = new Radnik(textBox1.Text, int.Parse(textBox2.Text));
                else
                    zaposleni = new Menadzer(textBox1.Text, int.Parse(textBox2.Text));
                listBox1.Items.Add(zaposleni);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Greska! detalji greske: {ex.Message}",
                    "Greska",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska! detalji greske: {ex.Message}",
                    "Greska",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Zaposleni zaposleni)
            {
                label1.Visible = true;
                label1.Text = zaposleni.prikaziPodatke();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
