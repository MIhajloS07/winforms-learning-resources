namespace Radio_dugme_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.TabIndex = 0; // Postavljamo indeks fokusa kako neko radio dugme nebi bilo selektovano
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Drugi nacin je da TabStop bude false
            radioButton1.TabStop = false;
            radioButton2.TabStop = false;
            radioButton3.TabStop = false;
            radioButton4.TabStop = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                MessageBox.Show($"{radioButton2.Text} je tacan odgovor");
            }
            else if(radioButton1.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("Odgovor nije tacan");
            }
            else
            {
                MessageBox.Show("Moras odabrati jedan odgovor!");
            }
        }
    }
}
