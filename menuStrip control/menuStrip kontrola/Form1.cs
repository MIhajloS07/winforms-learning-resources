using System.Runtime.Versioning;

namespace menuStrip_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Menustrip
            MenuStrip glavniMeni = new MenuStrip();
            
            // Meni
            ToolStripMenuItem fajlMeni = new ToolStripMenuItem("&Fajl");
            // Podmeni
            ToolStripMenuItem noviStavka = new ToolStripMenuItem("&Novi");
            ToolStripMenuItem otvoriStavka = new ToolStripMenuItem("&Otvori");
            ToolStripMenuItem sacuvajStavka = new ToolStripMenuItem("&Sacuvaj");
            ToolStripMenuItem izlazStavka = new ToolStripMenuItem("&Izlaz");
            izlazStavka.Image = Properties.Resources.ikoniac;

            // Precice
            sacuvajStavka.ShortcutKeys = Keys.Control | Keys.S;
            otvoriStavka.ShortcutKeys = Keys.Control | Keys.O;
            noviStavka.ShortcutKeys = Keys.Control | Keys.N;
            izlazStavka.ShortcutKeys = Keys.Control | Keys.K;

            // Event za izlaz iz app za Click
            izlazStavka.Click += (se, ev) =>
            {
                Application.Exit();
            };

            // Dodavanje podmenija na meni fajlMeni
            fajlMeni.DropDownItems.Add(noviStavka);
            fajlMeni.DropDownItems.Add(otvoriStavka);
            fajlMeni.DropDownItems.Add(sacuvajStavka);
            fajlMeni.DropDownItems.Add(new ToolStripSeparator());
            fajlMeni.DropDownItems.Add(izlazStavka);

            // Dodavanje menustrip objekta 
            glavniMeni.Items.Add(fajlMeni);
            
            // Dodavanje menustrip objekta na formu
            this.MainMenuStrip = glavniMeni;
            this.Controls.Add(glavniMeni);
        }

        //private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}
    }
}
