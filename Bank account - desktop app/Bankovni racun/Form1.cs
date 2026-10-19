namespace Bankovni_racun
{
    public partial class Form1 : Form
    {
        private Korisnik korisnik;
        private TextBox uplataText;
        private TextBox isplataText;
        private Label ispisStanjaLabel, uplataLabel, isplataLabel, info;
        private Button uplataBtn, isplataBtn;
        private GroupBox informacije;
        public Form1()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.MaxLength = 24;
            checkPass.Checked = false;
        }

        private void logInbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(PasswordTextBox.Text)
                    || string.IsNullOrEmpty(userNameTextBox.Text)
                    || string.IsNullOrEmpty(FirstNameText.Text)
                    || string.IsNullOrEmpty(LastNameText.Text))
                    throw new ArgumentException("Sva polja moraju biti popunjena!");
                else
                {
                    MessageBox.Show($"Dobrodosao na svoj bankovni racun {FirstNameText.Text} {LastNameText.Text}",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    korisnik = new Korisnik(FirstNameText.Text, LastNameText.Text, userNameTextBox.Text, PasswordTextBox.Text);
                    SetInvisibleComponents();
                    createComponents();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    $"Greska, detalji greske: {ex.Message}",
                    "GRESKA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        protected void SetInvisibleComponents()
        {
            PasswordTextBox.Visible = false;
            FirstNameText.Visible = false;
            LastNameText.Visible = false;
            userNameTextBox.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            checkPass.Visible = false;
            logInbtn.Visible = false;   
        }
        protected void createComponents()
        {
            uplataText = new TextBox
            {
                Text = string.Empty,
                Location = new Point(150, 100),
                Width = 120
            };
            isplataText = new TextBox
            {
                Text = string.Empty,
                Location= new Point(350, 100),
                Width = 120
            };
            ispisStanjaLabel = new Label
            {
                Text = "STANJE: ",
                Location = new Point(200, 400),
                Width = 100
            };
            uplataLabel = new Label
            {
                Text = "Uplata",
                Location = new Point(180, 70),
            };
            isplataLabel = new Label
            {
                Text = "Isplata",
                Location = new Point(380, 70),
            };
            uplataBtn = new Button
            {
                Text = "Uplata",
                Location = new Point(155, 150),
                Width = 100
            };
            isplataBtn = new Button
            {
                Text = "Isplata",
                Location = new Point(360, 150),
                Width = 100
            };
            informacije = new GroupBox
            {
                Text = "Informacije",
                Location = new Point(12, 205),
                Size = new Size(600, 150)
            };
            info = new Label
            {
                Text = $"NALOG -> {userNameTextBox.Text}",
                Location = new Point(200, 27),
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                AutoSize = true
            };
            this.Controls.Add(uplataText);
            this.Controls.Add(isplataText);
            this.Controls.Add(ispisStanjaLabel);
            this.Controls.Add(uplataLabel);
            this.Controls.Add(isplataLabel);
            this.Controls.Add(uplataBtn);
            this.Controls.Add(isplataBtn);
            this.Controls.Add(informacije);
            this.Controls.Add(info);
            

            // Methods using lambda
            isplataBtn.Click += (s, e) =>
            {
                isplataBtn.Enabled = false;
            };
            uplataBtn.Click += (s, e) =>
            {
                uplataBtn.Enabled = false;
            };
        }
        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = checkPass.Checked ? '\0' : '*';
        }       
    }
}
