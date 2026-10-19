namespace Font_klasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = (decimal)lblText.Font.Size;
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 72;
        }

        private void boldBtn_Click(object sender, EventArgs e)
        {
            Font current = lblText.Font;
            FontStyle newStyle = current.Style ^ FontStyle.Bold; //XOR
            lblText.Font = new Font(current, newStyle);
        }

        private void italicBtn_Click(object sender, EventArgs e)
        {
            Font current = lblText.Font;
            FontStyle newStyle = current.Style ^ FontStyle.Italic; //XOR
            lblText.Font = new Font(current, newStyle);
        }

        private void underlineBtn_Click(object sender, EventArgs e)
        {
            Font current = lblText.Font;
            FontStyle newStyle = current.Style ^ FontStyle.Underline; //XOR
            lblText.Font = new Font(current, newStyle);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Font current = lblText.Font;
            float size = (float)numericUpDown1.Value;
            lblText.Font = new Font(current.FontFamily, size, current.Style);
        }
    }
}
