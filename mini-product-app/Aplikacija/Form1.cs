namespace Aplikacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Postavljanje labele za prikaz ukupne vrednosti kao nevidljivu
            label5.Visible = false; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Obrada izuzetaka 
            try
            {
                string naziv = textBox3.Text;
                int kolicina = int.Parse(textBox2.Text);
                int cena = int.Parse(textBox1.Text);
                // Kreiranje instance klase
                Proizvod proizvod = new Proizvod(naziv, cena, kolicina);
                MessageBox.Show($"Proizvod uspesno kreiran", "Informacija",MessageBoxButtons.OK, MessageBoxIcon.Information);
                label5.Visible = true;
                label5.Text = $"Ukupna vrednost proizvoda {proizvod.UkupnaVrednost().ToString()} dinara";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Desila se greska, detalji greske: {ex.Message}", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Desila se greska, detalji greske: {ex.Message}", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
