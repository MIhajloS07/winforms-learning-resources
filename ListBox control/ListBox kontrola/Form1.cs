namespace ListBox_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void OsveziBroj()
        {
            label2.Text = $"Ukupno zadatka: {listBox1.Items.Count}";
        }

        private void DodajBtn_Click(object sender, EventArgs e)
        {
            string zadatak = textBox1.Text;
            if (string.IsNullOrEmpty(zadatak))
            {
                MessageBox.Show("Moras uneti zadatak!");
            }
            else
            {
                listBox1.Items.Add(zadatak);
                textBox1.Text = string.Empty;
            }
            OsveziBroj();
        }

        private void UkloniBtn_Click(object sender, EventArgs e)
        {
            // Moguce je postavljanje i listBox1.SelectedIndex > -1 
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Zadatak nije pronadjen!");
            }
            OsveziBroj();
        }

        private void PretraziBtn_Click(object sender, EventArgs e)
        {
            string zadatak = textBox1.Text;
            if (string.IsNullOrEmpty(zadatak))
            {
                MessageBox.Show("Moras uneti ime zadatka!");
            }
            else
            {
                listBox1.ClearSelected();
                int indeks = listBox1.FindString(zadatak);
                if (indeks < 0)
                {
                    MessageBox.Show("Zadatak nije pronadjen!");
                }
                else
                {
                    listBox1.SelectedIndex = indeks;
                }
                textBox1.Text = string.Empty;
            }
        }

        private void UkloniSveBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            OsveziBroj();
        }
    }
}
