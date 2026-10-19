namespace ContextMenuStripKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContextMenuStrip Contextmeni = new ContextMenuStrip();
            ToolStripMenuItem iseci = new ToolStripMenuItem("&Iseci");
            ToolStripMenuItem kopiraj = new ToolStripMenuItem("&Kopiraj");
            ToolStripMenuItem nalepi = new ToolStripMenuItem("&Nalepi");
            Contextmeni.Items.Add(iseci);
            Contextmeni.Items.Add(kopiraj);
            Contextmeni.Items.Add(nalepi);
            textBox1.ContextMenuStrip = Contextmeni;
            iseci.Click += Iseci_Click;
            kopiraj.Click += Kopiraj_Click;
            nalepi.Click += Nalepi_Click;
        }

        private void Iseci_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void Kopiraj_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void Nalepi_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }
    }
}
