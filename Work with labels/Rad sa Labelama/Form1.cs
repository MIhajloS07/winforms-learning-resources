namespace Rad_sa_Labelama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SkrivenaLabela.Visible = false;
            SkrivenaLabela.Text = "POZDRAV IZ SAJTA";
            SkrivenaLabela.ForeColor = Color.DarkGreen;
            
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Purple;
            label1.Cursor = Cursors.Hand;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SkrivenaLabela.Visible = !SkrivenaLabela.Visible;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label1.Cursor = Cursors.Default;
        }
    }
}
