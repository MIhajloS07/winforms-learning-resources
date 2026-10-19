namespace ComboBox_kontrola
{
    public partial class Forma : Form
    {
        private string imePrezime = string.Empty;
        private string brojGodina = string.Empty;
        private string razred = string.Empty;
        private string indeksOdeljenja = string.Empty;
        private string skolskaGodina = string.Empty;
        private string kategorija = string.Empty;        
        public Forma()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; // Unos onemogucen
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList; // Unos onemogucen
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList; // Unos onemogucen
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList; // Unos onemogucen
            comboBox3.DropDownStyle = ComboBoxStyle.DropDown; // Unos omogucen

            //Error labele
            ErrorLabel1.Visible = false;
            ErrorLabel2.Visible = false;
            ErrorLabel3.Visible = false;
            ErrorLabel4.Visible = false;
            ErrorLabel5.Visible = false;
            ErrorLabel6.Visible = false;  
        }
        private void ResetujSvaPolja()
        {
            imePrezime = string.Empty;
            brojGodina = string.Empty;
            razred = string.Empty;
            indeksOdeljenja = string.Empty;
            skolskaGodina = string.Empty;
            kategorija = string.Empty;

            ImePrezimeTextBox.Text = string.Empty;
            comboBox3.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;         
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Dobrodosli u aplikaciju za prijavu \n\r" +
                "ucenika na skolskom takmicenju iz programiranja");
        }

        private void PrijaviSeBtn_Click(object sender, EventArgs e)
        {
            bool validno = true;
            imePrezime = ImePrezimeTextBox.Text;
            brojGodina = comboBox1.Text;
            razred = comboBox2.Text;
            indeksOdeljenja = comboBox3.Text;
            skolskaGodina = comboBox4.Text;
            kategorija = comboBox5.Text;

            //if (string.IsNullOrWhiteSpace(imePrezime) ||
            //    string.IsNullOrWhiteSpace(brojGodina) ||
            //    string.IsNullOrWhiteSpace(razred) ||
            //    string.IsNullOrWhiteSpace(indeksOdeljenja) ||
            //    string.IsNullOrWhiteSpace(skolskaGodina) ||
            //    string.IsNullOrWhiteSpace(kategorija))
            //{
            //    MessageBox.Show("Molimo popunite sva polja!");
            //}
            if (string.IsNullOrWhiteSpace(imePrezime)) { ErrorLabel1.Visible = true; validno = false; }
            else ErrorLabel1.Visible = false;
            if (string.IsNullOrWhiteSpace(brojGodina)) { ErrorLabel2.Visible = true; validno = false; }
            else ErrorLabel2.Visible = false;
            if (string.IsNullOrWhiteSpace(razred)) { ErrorLabel3.Visible = true; validno = false; }
            else ErrorLabel3.Visible = false;
            if (string.IsNullOrWhiteSpace(indeksOdeljenja)) { ErrorLabel4.Visible = true; validno = false; }
            else ErrorLabel4.Visible = false;
            if (string.IsNullOrWhiteSpace(skolskaGodina)) { ErrorLabel5.Visible = true; validno = false; }
            else ErrorLabel5.Visible = false;
            if (string.IsNullOrWhiteSpace(kategorija)) { ErrorLabel6.Visible = true; validno = false; }
            else ErrorLabel6.Visible = false;
            if (validno)
            {
                PrikazPrijaveTextBox.Text =
                    $"Ime i prezime: {imePrezime}\r\n" +
                    $"broj godina: {brojGodina}\r\n" +
                    $"razred: {razred}\r\n" +
                    $"indeks odeljenja: {indeksOdeljenja}\r\n" +
                    $"skolska godina: {skolskaGodina}\r\n" +
                    $"kategorija: {kategorija}";
                ResetujSvaPolja();
            }
        }

        private void PrijaviSeBtn_MouseEnter(object sender, EventArgs e)
        {
            PrijaviSeBtn.BackColor = Color.Blue;
            PrijaviSeBtn.ForeColor = Color.White;
        }

        private void PrijaviSeBtn_MouseLeave(object sender, EventArgs e)
        {
            PrijaviSeBtn.BackColor = Color.White;
            PrijaviSeBtn.ForeColor = Color.Black;
        }
    }
}
