namespace CheckBox_kontrola
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            label1.Text = string.Empty;
            label1.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                int bodovi = 0;
                if (!checkBox2.Checked)
                {                   
                    if (checkBox3.Checked) bodovi++;
                    if (checkBox4.Checked) bodovi++;
                    if (checkBox5.Checked) bodovi++;
                }
                MessageBox.Show("Dobio si " + bodovi + " od moguca 3 boda!");
            }
            else
            {
                label1.Visible = false;
                MessageBox.Show("Moras se sloziti sa uslovima \r\nkoriscenja aplikacije");
            }
        }
    }
}
