namespace OOPWinforms_zadatak
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
            label5.Visible = false;
        }

        private void PrikaziBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Osoba osoba = new Osoba(textBoxIme.Text, textBoxPrezime.Text, int.Parse(textBoxGodine.Text));
                label5.Visible = true;    
                label5.Text = osoba.PrikaziInfo();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Greska ! detalji greske: {ex.Message}", 
                    "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska ! detalji greske: {ex.Message}",
                   "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
