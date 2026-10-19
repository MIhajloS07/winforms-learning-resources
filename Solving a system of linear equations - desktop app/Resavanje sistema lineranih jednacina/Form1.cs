using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace Resavanje_sistema_lineranih_jednacina
{
    public partial class Forma : Form
    {
        private struct Jednacina { public double A, B, C; }
        private Jednacina? jednacina1 = null;
        private Jednacina? jednacina2 = null;
        private PointF? tackaPreseka = null;
        private bool trebaCrtatiPrave = false;
        /// <summary>
        /// Struct ne moze biti null po defaultu za razliku od klase i zato se postavlja 
        /// ? operator (nullable) odnosno vrednost moze imati vrednost null
        /// </summary>

        public Forma()
        {
            InitializeComponent();
            PanelError.Visible = false;
            this.PanelCanvas.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(PanelCanvas, true, null);
        }
        /// <summary>
        /// Kroz konstruktor se poziva metoda InitializeComponent(), postavlja vidljivost panela 
        /// za error na false kao i postavljanje panela u kome se crtaju grafici kao DoubleBuffered
        /// </summary>

        private void PanelCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // AntiAliasing -> On
            NacrtajKoordinatniSistem(g, PanelCanvas.ClientRectangle);
            if (trebaCrtatiPrave)
            {
                using (Font font = new Font("Arial", 10))
                using (Brush brush = new SolidBrush(Color.DarkGreen))
                {
                    if (jednacina1.HasValue)
                    {
                        NacrtajPravu(g, PanelCanvas.ClientRectangle, jednacina1.Value, new Pen(Color.Blue, 2));
                        g.DrawString($"1. -> {JednacinaUString(jednacina1.Value)}", font, brush, new PointF(10, 315));
                    }
                    if (jednacina2.HasValue)
                    {
                        NacrtajPravu(g, PanelCanvas.ClientRectangle, jednacina2.Value, new Pen(Color.Red, 2));
                        g.DrawString($"2. -> {JednacinaUString(jednacina2.Value)}", font, brush, new PointF(10, 335));
                    }
                }
                if (tackaPreseka.HasValue)
                    NacrtajPresek(g, PanelCanvas.ClientRectangle, tackaPreseka.Value);
            }
        }
        /// <summary>
        /// Koristimo objekat klase Graphics uz pomoc PaintEventArgs objekta, 
        /// postavljamo AntiAliasing za glatku rezoluciju i piksele, pozivamo 
        /// metodu NacrtajKoordinatniSistem. Nakon toga vrsimo proveru kroz 
        /// uslov da li je potrebno da se crtaju prave (bool -> trebaCrtatiPrave)
        /// Ukoliko je true, ulazimo u dodatne uslove gde se proverava posebno za
        /// svaku jednacinu da li ima neku vrednost, gde ako ima vrsi se crtanje 
        /// prave odnosno poziva se metoda NacrtajPravu. Postoji takodje uslov i 
        /// za tacku preseka.
        /// </summary>

        #region Draw
        private void NacrtajKoordinatniSistem(Graphics g, Rectangle granice)
        {
            float centarX = granice.Width / 2f;
            float centarY = granice.Height / 2f;
            float skala = 20f;
            using (Pen gridPen = new Pen(Color.LightGray, 1))
            using (Pen osaPen = new Pen(Color.Black, 2))
            {
                for (float x = centarX; x < granice.Width; x += skala)
                {
                    g.DrawLine(gridPen, x, 0, x, granice.Height);
                    g.DrawLine(gridPen, centarX - (x - centarX), 0, centarX - (x - centarX), granice.Height);
                }
                for (float y = centarY; y < granice.Height; y += skala)
                {
                    g.DrawLine(gridPen, 0, y, granice.Width, y);
                    g.DrawLine(gridPen, 0, centarY - (y - centarY), granice.Width, centarY - (y - centarY));
                }
                // Horizontalna osa
                g.DrawLine(osaPen, 0, centarY, granice.Width, centarY);
                // Vertikalna osa
                g.DrawLine(osaPen, centarX, 0, centarX, granice.Height);
            }
        }
        /// <summary>
        /// Nalazimo centarX i centarY iz panela za crtanje, zatim skala za kockice, 
        /// nakon toga korisimo olovku za grid i za osu, prolazimo kroz petlju za
        /// x i y koordinate panela i crtamo kockice. Nakon toga se vrsi crtanje 
        /// horizontalne ose i vertikalne ose pomocu crtanja linija unutar panela.
        /// </summary>

        private void NacrtajPravu(Graphics g, Rectangle granice, Jednacina j, Pen olovka)
        {
            float centarX = granice.Width / 2f;
            float centarY = granice.Height / 2f;
            float skala = 20f;
            PointF p1 = new PointF();
            PointF p2 = new PointF();
            if (Math.Abs(j.B) < 1e-9)
            {
                if (Math.Abs(j.A) < 1e-9)
                    return;
                float x = (float)(j.C / j.A);
                p1.X = centarX + x * skala;
                p1.Y = 0;
                p2.X = centarX + x * skala;
                p2.Y = granice.Height;
            }
            else
            {
                float x1_math = -centarX / skala;
                float x2_math = (granice.Width - centarX) / skala;
                float y1_math = (float)((j.C - j.A * x1_math) / j.B);
                float y2_math = (float)((j.C - j.A * x2_math) / j.B);
                p1.X = centarX + x1_math * skala;
                p1.Y = centarY - y1_math * skala;
                p2.X = centarX + x2_math * skala;
                p2.Y = centarY - y2_math * skala;
            }
            g.DrawLine(olovka, p1, p2);
        }
        /// <summary>
        /// Prvo se odredjuje centar u X i Y osi na osnovu granica panela 
        /// za crtanje, zatim deklarise i inicijalizuje promenljiva skala
        /// tipa float, nakon toga kreiranje instanci PointF struktura.
        /// Nakon toga se vrsi provera da li je absolutna vrednost iz 
        /// B parametra jednacine manja od 1e-9, gde ukoliko je manja vrsi
        /// se jos jedan uslov  gde se pita isto samo za A parametar jednacine,
        /// gde ukoliko je manje, vrsi se izlazak iz metode i vracamo se na mesto
        /// poziva. Nakon toga definisemo promenljivu x kod koje se vrsi eksplicitno
        /// kastovanje u float gde se vrsi deljenje C i A parametra iz jednacine.
        /// Koristeci svojstva X i Y iz strukture p1 i p2, dodeljujemo vrednosti,
        /// za X i Y za obe strukture tipa PointF. Ukoliko je absolutna vrednost iz 
        /// B parametra jednacine veca od 1e-9, onda se vrsi kreiranje x1,x2,y1 i y2
        /// math promenljvih za racunanje ose, i takodje vrsi izmena struktura uz pomoc
        /// X i Y svojstva. Na kraju vrsimo crtanje linije zadatom olovkom, i start i end
        /// pozicijom koje cine strukture p1 i p2 tipa PointF.
        /// </summary>

        private void NacrtajPresek(Graphics g, Rectangle granice, PointF presek)
        {
            float centarX = granice.Width / 2f;
            float centarY = granice.Height / 2f;
            float skala = 20f;
            float screenX = centarX + presek.X * skala;
            float screenY = centarY - presek.Y * skala;
            g.FillEllipse(Brushes.DarkGreen, screenX - 5, screenY - 5, 10, 10);
            string text = $"Presek: ({presek.X:F2}, {presek.Y:F2})";
            using (Font font = new Font("Arial", 10))
                g.DrawString(text, font, Brushes.DarkGreen, screenX + 23, screenY);
        }
        /// <summary>
        /// U pocetku racunamo centarX i centarY ose na osnovu granica panela,
        /// zatim deklarisemo i inicijalizujemo skala promenljivu tipa float,
        /// gde nakon toga vrsimo racunanje centra ekrana na x i y osi. Posle toga
        /// vrsimo crtanje elipse odnosno popunjavanje kao krug tako da se nacrta u 
        /// preseku dveju pravih. Pored same tacke odnosno kruga koja oznacava
        /// presek pravih, koristimo font objekat za crtanje striga u kome pisu 
        /// koordinate preseka dveju pravih zelenom bojom.
        /// </summary>

        private void NacrtajBtn_Click(object sender, EventArgs e)
        {
            PanelError.Visible = false;
            try
            {
                Jednacina j1 = new Jednacina
                {
                    A = double.Parse(A1.Text),
                    B = double.Parse(B1.Text),
                    C = double.Parse(C1.Text)
                };
                Jednacina j2 = new Jednacina
                {
                    A = double.Parse(A2.Text),
                    B = double.Parse(B2.Text),
                    C = double.Parse(C2.Text)
                };
                this.jednacina1 = j1;
                this.jednacina2 = j2;
                this.tackaPreseka = IzracunajPresek(j1, j2);
                this.trebaCrtatiPrave = true;
                PanelCanvas.Invalidate();
            }
            catch (Exception ex)
            {
                PanelError.Visible = true;
                PanelError.BackColor = Color.Red;
                label3.BackColor = Color.Red;
                label3.ForeColor = Color.White;
                label3.Text = $"Unesite validne brojeve u sva polja.";
                Resetuj();
            }
        }
        /// <summary>
        /// Vrsi se obrada izuzetka na pocetku gde se u try bloku kreiraju
        /// instance strukture Jednacina gde se kreiraju dve jednacine,
        /// null objekat na pocetku za jednacinu 1 i 2 se dodeljuju tako da
        /// budu jednake novokreiralim instancama i vise nisu null. Zatim se
        /// poziva IzracunajPresek(j1, j2) metoda gde se na osnovu te dve jednacine
        /// racuna njihov presek. Postavlja se da treba crtati prave, osvezava se
        /// panel u kome se crta koordinatnisistem. Ukoliko program uhvati gresku, 
        /// kroz catch blok ce postaviti panel za prikaz errora na true, i izvrsice
        /// reset
        /// </summary>
        #endregion

        #region calculation
        private PointF? IzracunajPresek(Jednacina j1, Jednacina j2)
        {
            double D = j1.A * j2.B - j2.A * j1.B;
            if (Math.Abs(D) < 1e-9)
            {
                PanelError.Visible = true;
                PanelError.BackColor = Color.Yellow;
                label3.BackColor = Color.Yellow;
                label3.ForeColor = Color.Black;
                label3.Text = "Prave su paralelne ili se poklapaju.";
                return null;
            }
            double Dx = j1.C * j2.B - j2.C * j1.B;
            double Dy = j1.A * j2.C - j2.A * j1.C;
            float x = (float)(Dx / D);
            float y = (float)(Dy / D);
            return new PointF(x, y);
        }
        /// <summary>
        /// racunamu glavnu determinantu na osnovu strukture koja predstavlja 
        /// blueprint za jednacine (2 komada).Ukoliko je apsolutna vrednost
        /// determinante manja od 1e-9, onda postavljamo panel i ispisujemo 
        /// da su prave ili paralelne ili da se preklapaju i vracamo null 
        /// odnosno PointF? struct ce imati vracenu vrednost null. Nakon toga 
        /// racunamo i determinante Dx i Dy preko strukture Jednacina tj. njenih 
        /// instanci, nakon toga racunamo x i y i vracamo novi PointF sa x i y.
        /// </summary>    
        /// <returns><see cref="PointF"/></returns>
        #endregion

        private string JednacinaUString(Jednacina j)
        {
            string s = string.Empty;
            // Ax 
            if (j.A != 0)
                s += $"{j.A}x";
            // Bx
            if (j.B > 0 && s != "")
                s += $" + {j.B}y";
            else if (j.B < 0)
                s += $" - {Math.Abs(j.B)}y";
            else if (j.B != 0)
                s += $"{j.B}y";
            // C
            if (j.C > 0)
                s += $" + {j.C}";
            else if (j.C < 0)
                s += $" - {Math.Abs(j.C)}";
            // Ako je 0
            if (s == "") s = "0";
            return s;
        }
        /// <summary>
        /// Vrsimo ispis posebno svake jednacine u donjem levom uglu
        /// panela za crtanje tako sto definisemo jedan string i proveravamo
        /// da li su parametri jednacine odnosno polja strukture manja ili 
        /// razlicita od nule i na osnovu toga mi ispisujemo jednacine sa
        /// adekvatnim znakom.
        /// </summary>

        private void Resetuj()
        {
            jednacina1 = null;
            jednacina2 = null;
            tackaPreseka = null;
            trebaCrtatiPrave = false;
            PanelCanvas.Invalidate();
        }
        /// <summary>
        /// Resetujemo sve vrednosti tako da strukture budu null ponovo, 
        /// ne trebamo crtati prave i iscrtati ponovo panel tako da 
        /// bude prazan samo sa koordinatnim sistemom.
        /// </summary>

        private void ObrisiBtn_Click(object sender, EventArgs e)
        {
            A1.Clear(); B1.Clear(); C1.Clear();
            A2.Clear(); B2.Clear(); C2.Clear();
            PanelError.Visible = false;
            Resetuj();
        }
        /// <summary>
        /// Sve vrednosti unete u textBox se brisu, i poziva se metoda Resetuj()
        /// koja vrsi resetovanje svih vrednosti i struktura
        /// </summary>

        #region FormControlls
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Da li zelis da izadjes iz aplikacije?",
                "Izlaz",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
                Application.Exit();
        }
        /// <summary>
        /// Event koji klikom na dugme kreira result objekat tipa DialogREsult
        /// i vraca Yes ili No u zavisnosti od kliknutog dugmeta. Ako je kliknuto
        /// dugme Yes, vrsi se izlazak iz aplikacije (sistem dialoga za proveru izlaska)
        /// </summary>

        private void MinimizeBtn_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
        /// <summary>
        /// Event koji klikom na dugme postavlja svojstvo WindowState na minimized
        /// -> dugme za spustanje prozora aplikacije
        /// </summary>
        #endregion

        #region Button-Style
        private void NacrtajBtn_MouseEnter(object sender, EventArgs e) =>
            ChangeButtonThemeOnHover(Color.OrangeRed, Color.WhiteSmoke, NacrtajBtn.Cursor, NacrtajBtn);
        private void NacrtajBtn_MouseLeave(object sender, EventArgs e) =>
            ChangeButtonThemeOnHover(Color.WhiteSmoke, Color.Black, NacrtajBtn.Cursor, NacrtajBtn);
        private void ObrisiBtn_MouseEnter(object sender, EventArgs e) =>
            ChangeButtonThemeOnHover(Color.OrangeRed, Color.WhiteSmoke, ObrisiBtn.Cursor, ObrisiBtn);
        private void ObrisiBtn_MouseLeave(object sender, EventArgs e) =>
            ChangeButtonThemeOnHover(Color.WhiteSmoke, Color.Black, ObrisiBtn.Cursor, ObrisiBtn);
        private void ExitBtn_MouseEnter(object sender, EventArgs e) => ExitBtn.ForeColor = Color.WhiteSmoke;
        private void ExitBtn_MouseLeave(object sender, EventArgs e) => ExitBtn.ForeColor = Color.Black;
        private void MinimizeBtn_MouseEnter(object sender, EventArgs e) => MinimizeBtn.ForeColor = Color.WhiteSmoke;
        private void MinimizeBtn_MouseLeave(object sender, EventArgs e) => MinimizeBtn.ForeColor = Color.Black;
        /// <summary>
        /// Event-ovi koji prelaskom i odlaskom pomocu kursora preko dugmeta menja njegov stil
        /// </summary>
        private void ChangeButtonThemeOnHover(Color btnBackColor, Color btnForeColor, Cursor BtnCursor, Button btn)
        {
            btn.BackColor = btnBackColor;
            btn.ForeColor = btnForeColor;
            btn.Cursor = Cursors.Hand;
        }
        /// <summary>
        /// Metoda kojom se izbagava DRY, time sto sluzi kao placeholder za promenu teme za bilo koje dugme na formi na dalje
        /// </summary>
        #endregion 
    }
}
