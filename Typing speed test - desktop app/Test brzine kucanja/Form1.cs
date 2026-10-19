using System.Diagnostics;

namespace Test_brzine_kucanja
{
    public partial class Form1 : Form
    {

        private List<string> recenice;
        private string recenica;
        private Random random;
        private Stopwatch stoperica;
        public Form1()
        {
            InitializeComponent();
            InicijalizujIgru(); // Inicijalizacije igre pri pogretanju forme
        }
        private void ProveraTacnosti()
        {
            int tacniKarakteri = 0;
            int minLen = Math.Min(TypeTextBox.TextLength, recenica.Length);

            for (int i = 0; i < minLen; i++)
            {
                if (TypeTextBox.Text[i] == recenica[i]) tacniKarakteri++;
            }
            double accuracy = (double)tacniKarakteri / recenica.Length * 100;
            label3.Text = $"Tacnost: {accuracy:F1}%";
        }
        private void InicijalizujIgru()
        {
            try
            {
                random = new Random();
                recenice = File.ReadAllLines("Recenice.txt").ToList(); // Citamo sve recenice iz txt fajla i postavljamo u listu
                label1.Text = string.Empty;
                label2.Text = string.Empty;
                label3.Text = string.Empty;
                TypeTextBox.Enabled = false; // TextBox je disabled dok se ne klikne dugme
                StartButton.Text = "Pocni";
                stoperica = new Stopwatch();
            }
            catch (FileNotFoundException notFound)
            {
                MessageBox.Show($"Greska!: fajl nije pronadjen.\r\nDetalji greske {notFound.Message}");
                this.Close();
            }
            catch (FileLoadException errorLoad)
            {
                MessageBox.Show($"Greska!: fajl nije moguce ucitati.\r\nDetalji greske {errorLoad.Message}");
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Desila se greska!\r\n Detalji greske {error.Message}");
                this.Close();
            }
        }
        private void Rezultat()
        {
            double istekloSekundi = stoperica.Elapsed.TotalSeconds;
            if (istekloSekundi <= 0) return; //da se izbegne deljenje nulom
            int brojKaraktera = TypeTextBox.TextLength;
            double WPM = (brojKaraktera * 60.0) / (5.0 * istekloSekundi);
            label1.Text = $"Rezultat: {WPM:F2} reci u minuti (WPM)";
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            recenica = recenice[random.Next(recenice.Count)]; // Bira se random recenica iz recenice.txt fajla
            label2.Text = recenica; // Random recenica se ispisuje u label2
            label1.Text = "Rezultat: 0 reci u minuti"; // Pocetka brzina
            TypeTextBox.Enabled = true; // Omogucavamo korisniku da pristupi typetextbox-u
            TypeTextBox.Clear(); // Ako ima neki tekst u njemu, koristimo metodu Clear() da ocisti
            TypeTextBox.Focus(); // Postavljamo focus na kontrolu TypeTextBox uz pomoc Focus() metode
            StartButton.Enabled = false; // Button postaje onemogucen
            stoperica.Reset(); // Resetujemo stopericu ako se koristila
            stoperica.Start(); // Startujemo stopericu
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Test brzine kucanja!");
        }
        private void TypeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TypeTextBox.Text == recenica)
            {
                stoperica.Stop();
                StartButton.Enabled = true;
                StartButton.Focus();
            }
            if (stoperica.Elapsed.TotalSeconds > 0)
            {
                Rezultat(); // Real time prikaz WPM
                ProveraTacnosti(); // Real time provere tacnosti
            }
        }
        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            this.ClientSize = new Size(816, 320);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li si siguran da zelis da izadjes iz aplikacije?",
                "Potvrda",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes) { e.Cancel = false; }    
            if(result == DialogResult.No) { e.Cancel = true; }
        }
    }
}