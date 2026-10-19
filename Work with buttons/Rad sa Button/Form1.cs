namespace Rad_sa_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
            button3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kliknuo si na dugme!");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
