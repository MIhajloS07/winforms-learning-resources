using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pogadjanje_zamisljenog_broja_GUI
{
    public partial class FormaRand : Form
    {
        private int zamisljeni;
        private Random random;
        private byte pokusaji = 5;
        public FormaRand()
        {
            InitializeComponent();
            random = new Random();
            button1.Text = "Pogodi!";
            Resetuj();
        }
        private void Resetuj()
        {
            zamisljeni = random.Next(1, 101);
            button1.Enabled = true;
            label1.Text = "Pogodi zamisljeni broj izmedju 1 i 100";
            pokusaji = 5;
            PokusajiLabel.Text = "Preostalo pokusaja: " + pokusaji.ToString();
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int uneti;
            if (pokusaji < 1)
            {
                MessageBox.Show("Nemaš više pokušaja! Nova igra počinje.");
                Resetuj();
                return;
            }

            // Provera validnosti unosa
            if (!int.TryParse(textBox1.Text, out uneti))
            {
                
                label1.Text = "Unos mora biti broj!";
                return;
            }

            // Provera opsega
            if (uneti < 1 || uneti > 100)
            {
                label1.Text = "Unesi broj između 1 i 100!";
                return;
            }
            // Poređenje brojeva
            if (uneti < zamisljeni)
            {
                pokusaji--;
                label1.Text = "Uneti broj je manji od zamisljenog!";
            }
            else if (uneti > zamisljeni)
            {
                pokusaji--;
                label1.Text = "Uneti broj je veći od zamisljenog!";
            }
            else
            {
                MessageBox.Show($"Bravo! Pogodio si broj {zamisljeni}!", "Pobeda!");
                Resetuj();
                return;
            }

            // Ažuriranje labela
            PokusajiLabel.Text = $"Preostalo pokušaja: {pokusaji}";

            // Ako su pokušaji potrošeni
            if (pokusaji == 0)
            {
                button1.Enabled = false;
                MessageBox.Show($"Izgubio si! Zamišljeni broj je bio: {zamisljeni}", "Kraj igre");
                Resetuj();
            }
        }
        private void FormaRand_ClientSizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Izmena velicine prozora nije dozvoljeno!");
            
        }
    }
}
            
