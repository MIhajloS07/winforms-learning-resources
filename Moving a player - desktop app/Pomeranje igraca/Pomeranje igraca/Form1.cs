using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Pomeranje_igraca
{
    public partial class Forma : Form
    {
        SoundPlayer splayer = new SoundPlayer(@"FNAF.wav");
        SoundPlayer winnerSound = new SoundPlayer(@"WIN-FNAF.wav");
        private Random random = new Random();
        private Label coin;
        private Label igrac;
        private int brzina = 8;
        private int score = 0;
        private bool isDarkTheme = false;
        private bool isRedTheme = false;
        private bool isGreenTheme = false;
        private bool isSoundOn = true;
        public Forma()
        {
            InitializeComponent();         
            this.KeyPreview = true;
            //Kreiranje instance igraca
            igrac = new Label();
            igrac.Text = "🧍"; 
            igrac.Font = new Font("Segoe UI Emoji", 24, FontStyle.Bold);
            igrac.ForeColor = Color.Purple;
            igrac.AutoSize = true;
            igrac.Location = new Point(150, 150); 
            this.Controls.Add(igrac);

            drvoLabel1.AutoSize = true;
            drvoLabel2.AutoSize = true;
            drvoLabel3.AutoSize = true;
            drvoLabel4.AutoSize = true;
            drvoLabel5.AutoSize = true;
            drvoLabel6.AutoSize = true;
            drvoLabel7.AutoSize = true;

            //ForeColor za labelu 
            drvoLabel1.ForeColor = Color.DarkGreen;
            drvoLabel2.ForeColor = Color.DarkGreen;
            drvoLabel3.ForeColor = Color.DarkGreen;
            drvoLabel4.ForeColor = Color.DarkGreen;
            drvoLabel5.ForeColor = Color.DarkGreen;
            drvoLabel6.ForeColor = Color.DarkGreen;
            drvoLabel7.ForeColor = Color.DarkGreen;

            //BackColor za labelu 
            drvoLabel1.BackColor = Color.Transparent;
            drvoLabel2.BackColor = Color.Transparent;
            drvoLabel3.BackColor = Color.Transparent;
            drvoLabel4.BackColor = Color.Transparent;
            drvoLabel5.BackColor = Color.Transparent;
            drvoLabel6.BackColor = Color.Transparent;
            drvoLabel7.BackColor = Color.Transparent;

            // Kreiranje instance novcica
            coin = new Label();
            coin.Text = "🧁";
            coin.Font = new Font("Segoe UI Emoji", 20, FontStyle.Bold);
            coin.ForeColor = Color.DeepPink;
            coin.AutoSize = true;
            coin.BackColor = Color.Transparent;
            postaviNovcicNaRandomMesto();
            this.Controls.Add(coin);

            // Postavi KeyDown događaj za kretanje
            this.KeyDown += Forma_KeyDown;

            MessageBox.Show("Dobrodosao u igricu, potrebno je da nahranis Villiama " +
                "sto vise kolacicima, udarom u drvo Viliam ostaje gladan i broj poena se vraca na 0, PAZI!");

            //button za sound on/off
            SoundChangeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SoundChangeBtn.FlatStyle = FlatStyle.Flat;
            SoundChangeBtn.FlatAppearance.BorderSize = 0;
            SoundChangeBtn.BackColor = Color.Transparent;
            SoundChangeBtn.Text = "🔊";
            SoundChangeBtn.Font = new Font("Segoe UI Emoji", 18, FontStyle.Bold);
            SoundChangeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            SoundChangeBtn.UseVisualStyleBackColor = false;

            splayer.PlayLooping();
        }

        private void postaviNovcicNaRandomMesto()
        {
            int x = random.Next(0, this.ClientSize.Width - coin.Width); // x osa
            int y = random.Next(0, this.ClientSize.Height - coin.Height); // y osa
            coin.Location = new Point(x, y); // lokacija dodeljena konstrukoru Point na osnovu x i y ose (0 - max)
        }
        private void Winner() 
        {           
            MessageBox.Show("It's me","Winner");      
            Reset();       
        }
        private void Reset()
        {
            if (isSoundOn) 
                splayer.PlayLooping();
            else 
                splayer.Stop();
            score = 0;
            ScoreLabel.Text = "Score: " + score;
            igrac.Location = new Point(150, 150);       
            postaviNovcicNaRandomMesto();
        }
        private void ResetTheme()
        {
            //BackColor
            this.BackColor = Color.White;
            drvoLabel1.BackColor = Color.White;
            drvoLabel2.BackColor = Color.White;
            drvoLabel3.BackColor = Color.White;
            drvoLabel4.BackColor = Color.White;
            drvoLabel5.BackColor = Color.White;
            drvoLabel6.BackColor = Color.White;
            drvoLabel7.BackColor = Color.White;          
            igrac.BackColor = Color.White;
            SoundChangeBtn.BackColor = Color.White;
            //ForeColor
            drvoLabel1.ForeColor = Color.DarkGreen;
            drvoLabel2.ForeColor = Color.DarkGreen;
            drvoLabel3.ForeColor = Color.DarkGreen;
            drvoLabel4.ForeColor = Color.DarkGreen;
            drvoLabel5.ForeColor = Color.DarkGreen;
            drvoLabel6.ForeColor = Color.DarkGreen;
            drvoLabel7.ForeColor = Color.DarkGreen;
            igrac.ForeColor = Color.Purple;
            ScoreLabel.ForeColor = Color.Black;
            SoundChangeBtn.ForeColor = Color.Black;
        }
        private void ApplyDarkTheme()
        {
            if (isDarkTheme)
            {
                //BackColor
                this.BackColor = Color.Black;
                drvoLabel1.BackColor = Color.Black;
                drvoLabel2.BackColor = Color.Black;
                drvoLabel3.BackColor = Color.Black;
                drvoLabel4.BackColor = Color.Black;
                drvoLabel5.BackColor = Color.Black;
                drvoLabel6.BackColor = Color.Black;
                drvoLabel7.BackColor = Color.Black;
                igrac.BackColor = Color.Black;
                SoundChangeBtn.BackColor = Color.Black;

                //ForeColor
                drvoLabel1.ForeColor = Color.DarkGreen;
                drvoLabel2.ForeColor = Color.DarkGreen;
                drvoLabel3.ForeColor = Color.DarkGreen;
                drvoLabel4.ForeColor = Color.DarkGreen;
                drvoLabel5.ForeColor = Color.DarkGreen;
                drvoLabel6.ForeColor = Color.DarkGreen;
                drvoLabel7.ForeColor = Color.DarkGreen;
                igrac.ForeColor = Color.Purple;
                ScoreLabel.ForeColor = Color.White;
                SoundChangeBtn.ForeColor = Color.White;
            }
            else
            {
                ResetTheme();
            }
        }
        private void ApplyRedTheme()
        {
            if (isRedTheme)
            {
                //BackColor
                this.BackColor = Color.DarkRed;
                drvoLabel1.BackColor = Color.DarkRed;
                drvoLabel2.BackColor = Color.DarkRed;
                drvoLabel3.BackColor = Color.DarkRed;
                drvoLabel4.BackColor = Color.DarkRed;
                drvoLabel5.BackColor = Color.DarkRed;
                drvoLabel6.BackColor = Color.DarkRed;
                drvoLabel7.BackColor = Color.DarkRed;
                igrac.BackColor = Color.DarkRed;
                SoundChangeBtn.BackColor = Color.DarkRed;
                //ForeColor
                drvoLabel1.ForeColor = Color.Green;
                drvoLabel2.ForeColor = Color.Green;
                drvoLabel3.ForeColor = Color.Green;
                drvoLabel4.ForeColor = Color.Green;
                drvoLabel5.ForeColor = Color.Green;
                drvoLabel6.ForeColor = Color.Green;
                drvoLabel7.ForeColor = Color.Green;
                igrac.ForeColor = Color.Purple;
                ScoreLabel.ForeColor = Color.White;
                SoundChangeBtn.ForeColor = Color.White;
            }
            else
            {
                ResetTheme();
            }
        }
        private void ApplyGreenTheme()
        {
            if (isGreenTheme)
            {
                //BackColor
                this.BackColor = Color.DarkGreen;
                drvoLabel1.BackColor = Color.DarkGreen;
                drvoLabel2.BackColor = Color.DarkGreen;
                drvoLabel3.BackColor = Color.DarkGreen;
                drvoLabel4.BackColor = Color.DarkGreen;
                drvoLabel5.BackColor = Color.DarkGreen;
                drvoLabel6.BackColor = Color.DarkGreen;
                drvoLabel7.BackColor = Color.DarkGreen;
                igrac.BackColor = Color.DarkGreen;
                SoundChangeBtn.BackColor = Color.DarkGreen;
                //ForeColor
                drvoLabel1.ForeColor = Color.SandyBrown;
                drvoLabel2.ForeColor = Color.SandyBrown;
                drvoLabel3.ForeColor = Color.SandyBrown;
                drvoLabel4.ForeColor = Color.SandyBrown;
                drvoLabel5.ForeColor = Color.SandyBrown;
                drvoLabel6.ForeColor = Color.SandyBrown;
                drvoLabel7.ForeColor = Color.SandyBrown;
                igrac.ForeColor = Color.Purple;
                ScoreLabel.ForeColor = Color.White;
                SoundChangeBtn.ForeColor = Color.White;
            }
            else
            {
                ResetTheme();   
            }
        }
        private void Forma_KeyDown(object sender, KeyEventArgs e)
        {
            Point pozicija = igrac.Location; // pozicija trenutno igraca

            switch (e.KeyCode)
            {
                case Keys.W: 
                    pozicija.Y -= brzina; // Pomeri gore
                    break;      
                case Keys.S:
                    pozicija.Y += brzina; // Pomeri dole
                    break;
                case Keys.A:
                    pozicija.X -= brzina; // Pomeri levo
                    break;
                case Keys.D:
                    pozicija.X += brzina; // Pomeri desno
                    break;
                default:
                    this.Text = "Pogresan klik!";
                    break;
            }

            // Odredjivanje max kretanja igraca (ne moze ici u granici koja ne postoji)
            if (pozicija.X < 0) { pozicija.X = 0; }
            if (pozicija.Y < 0) { pozicija.Y = 0; }
            if (pozicija.X > this.ClientSize.Width - igrac.Width)
                pozicija.X = this.ClientSize.Width - igrac.Width;
            if (pozicija.Y > this.ClientSize.Height - igrac.Height)
                pozicija.Y = this.ClientSize.Height - igrac.Height;

            // Da li igrac dodiruje objekte (labele)
            if (igrac.Bounds.IntersectsWith(drvoLabel1.Bounds) || 
                 igrac.Bounds.IntersectsWith(drvoLabel2.Bounds) ||
                   igrac.Bounds.IntersectsWith(drvoLabel3.Bounds) ||
                     igrac.Bounds.IntersectsWith(drvoLabel4.Bounds) ||
                      igrac.Bounds.IntersectsWith(drvoLabel5.Bounds) ||
                       igrac.Bounds.IntersectsWith(drvoLabel6.Bounds) ||
                        igrac.Bounds.IntersectsWith(drvoLabel7.Bounds))
            {
                splayer.Stop();
                MessageBox.Show("Izgubio si, broj poena koji si osvojio je: " + score + " , pokusaj ponovo :)");          
                Reset();
                return;
            }
            else
            {
                this.Text = "Igrač se kreće...";
            }
            igrac.Location = pozicija;

            // Ako igrac dodirne jedan od Objekata ili kontrola
            if(coin.Bounds.IntersectsWith(drvoLabel1.Bounds) ||
                coin.Bounds.IntersectsWith(drvoLabel2.Bounds) ||
                 coin.Bounds.IntersectsWith(drvoLabel3.Bounds) ||
                  coin.Bounds.IntersectsWith(drvoLabel4.Bounds) ||
                   coin.Bounds.IntersectsWith(drvoLabel5.Bounds) ||
                    coin.Bounds.IntersectsWith(drvoLabel6.Bounds) ||
                     coin.Bounds.IntersectsWith(drvoLabel7.Bounds) ||
                      coin.Bounds.IntersectsWith(RedThemeButton.Bounds) ||
                       coin.Bounds.IntersectsWith(GreenThemeButton.Bounds) ||
                        coin.Bounds.IntersectsWith(CloseGameButton.Bounds) ||
                         coin.Bounds.IntersectsWith(DarkThemeButton.Bounds)||
                          coin.Bounds.IntersectsWith(ScoreLabel.Bounds))
            {
                postaviNovcicNaRandomMesto();
            }

            // Da li igrac dodiruje coin
            if (igrac.Bounds.IntersectsWith(coin.Bounds))
            {
                score++;
                ScoreLabel.Text = "Score: " + score;
                postaviNovcicNaRandomMesto();
            }

            if(score == 87)
            {
                winnerSound.Play();          
                Winner();          
                splayer.Stop();
                if (isSoundOn) 
                    splayer.PlayLooping();
            }
        
        }

        private void ThemeButton_Click(object sender, EventArgs e)
        {
            isDarkTheme = !isDarkTheme;
            ApplyDarkTheme();
        }

        private void Forma_ClientSizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Ne mozes menjati velicinu prozora! :)","Upozorenje!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isRedTheme = !isRedTheme;
            ApplyRedTheme();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isGreenTheme = !isGreenTheme;   
            ApplyGreenTheme();
        }

        private void Forma_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li si siguran da zelis da izadjes iz igre?",
                "Potvrda izlaska",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true;    
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {    
            if (isSoundOn) {
                //SoundChangeBtn.BackgroundImage = Image.FromFile(@"sound-offf.png");
                SoundChangeBtn.Text = "🔇";
                splayer.Stop();
                isSoundOn = false;
            }
            else
            {
                //SoundChangeBtn.BackgroundImage = Image.FromFile(@"sound-onn.png");
                SoundChangeBtn.Text = "🔊";
                splayer.PlayLooping();
                isSoundOn = true;
            }
        }

        private void drvoLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
