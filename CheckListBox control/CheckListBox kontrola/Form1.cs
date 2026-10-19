namespace CheckListBox_kontrola
{
    public partial class ToDoForm : Form
    {
        public ToDoForm()
        {
            InitializeComponent();
        }

        private void OsveziBrojac()
        {
            label2.Text = $"Broj zadatka: {checkedListBox1.Items.Count} | " +
                          $"zavrseni: {checkedListBox1.CheckedItems.Count}";
        }

        private void DodajBtn_Click(object sender, EventArgs e)
        {
            string zadatak = textBoxZad.Text;
            if (string.IsNullOrEmpty(zadatak))
            {
                MessageBox.Show("Moras uneti zadatak!");
            }
            else
            {
                checkedListBox1.Items.Add(zadatak, false);
                textBoxZad.Text = string.Empty;
            }
            OsveziBrojac();
        }

        private void PretraziBtn_Click(object sender, EventArgs e)
        {
            string zadatak = textBoxZad.Text;
            if (string.IsNullOrEmpty(zadatak))
            {
                MessageBox.Show("Moras uneti zadatak!");
            }
            else
            {
                checkedListBox1.ClearSelected();
                int indeks = checkedListBox1.Items.IndexOf(zadatak);
                if (indeks < 0)
                {
                    MessageBox.Show("Zadatak nije pronadjen");
                }
                else
                {
                    checkedListBox1.SelectedIndex = indeks;
                    textBoxZad.Text = string.Empty;
                }
            }
        }

        private void UkloniBtn_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex >= 0)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Zadatak nije oznacen");
            }
            OsveziBrojac();
        }

        private void UkloniSveBtn_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            OsveziBrojac();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)(() =>
            {
                OsveziBrojac();
            }));
        }
    }
}
