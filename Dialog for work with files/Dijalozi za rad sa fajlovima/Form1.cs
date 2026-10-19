using System.Windows.Forms;

namespace Dijalozi_za_rad_sa_fajlovima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            //MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86));
            //MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.Windows));          
        }
        private void ShowError(Exception ex) 
        {
            MessageBox.Show(
                        $"detalji greske -> {ex.Message}",
                        "Greska",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
            );
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Title = "Open text-file";
                    dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    dialog.FilterIndex = 1;
                    dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    dialog.RestoreDirectory = true;
                    dialog.Multiselect = false;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        pathLabel.Text = dialog.FileName;
                        richTextBox1.Text = File.ReadAllText(dialog.FileName);
                    }
                }
            }
            catch (IOException ex)
            {
                ShowError(ex);
            }
        }

        private void SaveFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Save file to";
                    dialog.FilterIndex = 1;
                    dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    dialog.RestoreDirectory = true;
                    dialog.DefaultExt = "txt";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(dialog.FileName, richTextBox1.Text);
                        pathLabel.Text = dialog.FileName;
                    }
                }
            }
            catch (IOException ex)
            {
                ShowError(ex);
            }
        }

        private void ChooseFolderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string putanja = string.Empty;
                using (FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog())
                {
                    folderBrowserDialog1.Description = "Odaberi folder";
                    folderBrowserDialog1.ShowNewFolderButton = true;
                    folderBrowserDialog1.SelectedPath = putanja;
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    {
                        putanja = folderBrowserDialog1.SelectedPath;
                        pathLabel.Text = putanja;
                    }
                }
            }
            catch (IOException ex)
            {
                ShowError(ex);
            }
        }
    }
}
