namespace Komunikacija_izmedju_formi
{
    public partial class Form1 : Form
    {
        // Form2 instance
        Form2 f2;

        public Form1() => InitializeComponent();   

        public void GetData(string data)
        {
            label1.Text = data;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            f2 = new Form2(this);
            //f2.ForwardMessage("Pozdrav iz Form1 preko metode");
            //f2.ShowDialog();
            //if (f2.DialogResult == DialogResult.OK)
            //    MessageBox.Show($"U drugoj formi je uneseno ime: {f2.Name}");
            //else
            //    MessageBox.Show("Korisnik je pritisnuo Calcel dugme");
            f2.ShowDialog();
        }
    }
}
