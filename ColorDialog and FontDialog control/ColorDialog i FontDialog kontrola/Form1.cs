namespace ColorDialog_i_FontDialog_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void izaberiBojuBtn_Click(object sender, EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                // Select current label forecolor
                dialog.Color = label1.ForeColor;
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                    label1.ForeColor = dialog.Color;
                else if (result == DialogResult.Cancel)
                    MessageBox.Show(
                        "Task canceled for Color",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
            }
        }

        private void izaberiFontBtn_Click(object sender, EventArgs e)
        {
            using (FontDialog dialog = new FontDialog())
            {
                // Select current label font
                dialog.Font = label1.Font;
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                    label1.Font = dialog.Font;
                else if (result == DialogResult.Cancel)
                    MessageBox.Show(
                        "Task canceled for Font",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
            }
        }
    }
}
