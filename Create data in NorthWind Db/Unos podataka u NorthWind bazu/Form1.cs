using System.Windows.Forms;
using System;
using System.Data.SqlClient;
namespace Unos_podataka_u_NorthWind_bazu
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCompanyName.Text) || string.IsNullOrEmpty(txtBrojTelefona.Text) || !checkPotvrda.Checked)
            {
                MessageBox.Show(
                    "Unesite adekvatne podatke i slozite se sa uslovima koriscenja aplikacije kako bi upisali podatke",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            try
            {
                string naziv = txtCompanyName.Text;
                string brojTelefona = txtBrojTelefona.Text;
                int noviId = Prevoznik.Dodaj(naziv, brojTelefona);
                if (noviId > 0)
                {
                    MessageBox.Show(
                        $"Podaci su uspešno upisani. Novi ID prevoznika je: {noviId}",
                        "Uspeh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    txtCompanyName.Clear();
                    txtBrojTelefona.Clear();
                    checkPotvrda.Checked = false;
                    txtCompanyName.Focus();
                }
                else
                {
                    MessageBox.Show(
                        "Došlo je do greške prilikom upisa podataka.",
                        "Greška",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Greška u konekciji baze",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
