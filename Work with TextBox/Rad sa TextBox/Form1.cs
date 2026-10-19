namespace Rad_sa_TextBox
{
    public partial class Forma : Form
    {
        public Forma()
        {
            InitializeComponent();
            textBox3.ReadOnly = true;
            textBox3.Multiline = true;
            textBox3.ShortcutsEnabled = false;
            textBox3.CharacterCasing = CharacterCasing.Upper;
            textBox3.ScrollBars = ScrollBars.Vertical;
            textBox2.UseSystemPasswordChar = true;
        }

        private void Forma_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Login aplikacija");
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                textBox3.Text = $"Entered username: {textBox1.Text}, entered password is: {textBox2.Text}";
            }
            else
            {
                MessageBox.Show("U must enter username and password");
            }               
        }
    }
}
