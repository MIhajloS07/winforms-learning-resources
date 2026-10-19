namespace kastovanje_kontrolra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            // EKSPLICTNI CASTING
            //try
            //{
            //    Button kliknutoDugme = (Button)sender;
            //}
            //catch (InvalidCastException)
            //{
            //    MessageBox.Show("Objekat nije tacnog tipa!");
            //}

            // CASTING preko AS operatora
            Button kliknutoDugme = sender as Button;
            if (kliknutoDugme != null)
            {
                kliknutoDugme.Text = "Kliknuto";
                kliknutoDugme.Enabled = false;
                //MessageBox.Show($"{kliknutoDugme.Name} je kliknuto");
            }
            else
            {
                MessageBox.Show("Objekat nije tacnog tipa!");
            }
            
        }
    }
}
