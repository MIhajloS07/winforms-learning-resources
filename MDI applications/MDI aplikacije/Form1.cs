namespace MDI_aplikacije
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void noviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.StartPosition = FormStartPosition.CenterScreen;
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }  
    }
}
