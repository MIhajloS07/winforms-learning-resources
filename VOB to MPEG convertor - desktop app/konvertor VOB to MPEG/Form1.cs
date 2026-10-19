using System.Diagnostics;

namespace konvertor_VOB_to_MPEG
{
    public partial class KonvertorForma : Form
    {
        private string[] selectedFiles;
        private string outputPath;
        public KonvertorForma()
        {
            InitializeComponent();
            txtOutputPath.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(
            //    "Dobrodosli u aplikaciju", 
            //    "Zdravo Korisnik",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information
            //);
        }

        private void BtnSelectVob_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "VOB files (*.vob)|*.vob";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedFiles = ofd.FileNames;

                lstFiles.Items.Clear();
                foreach (var file in selectedFiles)
                {
                    lstFiles.Items.Add(file);
                }

                statusLabel.Text = "VOB fajlovi izabrani.";
            }
        }

        private void btnSelectOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "MPEG files (*.mpg)|*.mpg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                outputPath = sfd.FileName;
                txtOutputPath.Text = outputPath;
                statusLabel.Text = "Izlazna putanja izabrana.";
            }
        }

        private async void btnMerge_Click(object sender, EventArgs e)
        {
            if (selectedFiles == null || selectedFiles.Length == 0)
            {
                MessageBox.Show("Izaberite VOB fajlove.");
                return;
            }

            if (string.IsNullOrEmpty(outputPath))
            {
                MessageBox.Show("Izaberite izlaznu lokaciju.");
                return;
            }

            try
            {
                statusLabel.Text = "Spajanje u toku...";
                progressBar1.Value = 0;

                string listFilePath = Path.Combine(Path.GetTempPath(), "lista.txt");

                using (StreamWriter sw = new StreamWriter(listFilePath))
                {
                    foreach (var file in selectedFiles)
                    {
                        sw.WriteLine($"file '{file.Replace("\\", "/")}'");
                    }
                }

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = Path.Combine(Application.StartupPath, "ffmpeg.exe");
                psi.Arguments = $"-f concat -safe 0 -i \"{listFilePath}\" -c copy \"{outputPath}\"";
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                psi.RedirectStandardError = true;
                psi.RedirectStandardOutput = true;

                using (Process process = new Process())
                {
                    process.StartInfo = psi;
                    process.Start();

                    // Citaj paralelno da ne bi doslo do deadlocka
                    Task<string> errorTask = process.StandardError.ReadToEndAsync();
                    Task<string> outputTask = process.StandardOutput.ReadToEndAsync();

                    await Task.WhenAll(errorTask, outputTask);
                    await process.WaitForExitAsync();

                    // Prikazi grešku SAMO ako je exit code != 0
                    if (process.ExitCode != 0)
                    {
                        string error = await errorTask;
                        MessageBox.Show(
                            "ffmpeg greška:\n" + error,
                            "Greska",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        statusLabel.Text = "Greška pri spajanju.";
                        return; // Ne nastavljaj dalje
                    }
                }

                progressBar1.Value = 100;
                statusLabel.Text = "Gotovo!";
                DialogResult result = MessageBox.Show(
                    "Spajanje uspešno završeno!",
                    "Informacija",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                if (result == DialogResult.OK)
                    Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
                statusLabel.Text = "Greška.";
            }
        }

        private void Reset()
        {
            lstFiles.Items.Clear();
            progressBar1.Value = 0;
            txtOutputPath.Text = string.Empty;
            statusLabel.Text = string.Empty;
        }

        // EVENTI ZA DIZAJN
        private void BtnSelectVob_MouseEnter(object sender, EventArgs e)
        {
            BtnSelectVob.BackColor = Color.LightGray;
            BtnSelectVob.ForeColor = Color.Red;
            this.Cursor = Cursors.Hand;
        }

        private void BtnSelectVob_MouseLeave(object sender, EventArgs e)
        {
            BtnSelectVob.BackColor = Color.White;
            BtnSelectVob.ForeColor = Color.Black;
            this.Cursor = Cursors.Default;
        }

        private void btnMerge_MouseEnter(object sender, EventArgs e)
        {
            btnMerge.BackColor = Color.LightGray;
            btnMerge.ForeColor = Color.Red;
            this.Cursor = Cursors.Hand;
        }

        private void btnMerge_MouseLeave(object sender, EventArgs e)
        {
            btnMerge.BackColor = Color.White;
            btnMerge.ForeColor = Color.Black;
            this.Cursor = Cursors.Default;
        }

        private void btnSelectOutput_MouseEnter(object sender, EventArgs e)
        {
            btnSelectOutput.BackColor = Color.LightGray;
            btnSelectOutput.ForeColor = Color.Red;
            this.Cursor = Cursors.Hand;
        }

        private void btnSelectOutput_MouseLeave(object sender, EventArgs e)
        {
            btnSelectOutput.BackColor = Color.White;
            btnSelectOutput.ForeColor = Color.Black;
            this.Cursor = Cursors.Default;
        }

        private void btnPostupak_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Izaberi VOB fajlove, odredi putanju i ime,\n" +
                "klikni 'Sacuvaj kao MPEG', a zatim 'Spoji u MPEG'.\n" +
                "Kada aplikacija zavrsi, dobijas svoj MPEG fajl.",
                "Postupak koriscenja aplikacije",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void KonvertorForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show
            (
                "Da li ste sigurni da zelite da napustite aplikaciju?",
                "Pitanje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}
