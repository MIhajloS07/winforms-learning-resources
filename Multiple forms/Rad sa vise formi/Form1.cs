namespace Rad_sa_vise_formi
{
    public partial class Form1 : Form
    {
        //Form2 formaDruga = new Form2();
        //private Form2 formaDruga;

        public Form1()
        {
            InitializeComponent();
        }

        private void UcitajFormuBtn_Click(object sender, EventArgs e)
        {
            // Nepravilan pristup
            //Form2 formaDruga = new Form2();
            //formaDruga.Show();
            //formaDruga.Show();
            //if (formaDruga == null || formaDruga.IsDisposed)
            //{
            //    formaDruga = new Form2();
            //    formaDruga.FormClosed += (s, e) =>
            //    {
            //        formaDruga.Show();
            //        formaDruga.Activate();
            //    };
            //}
            //this.Hide();
            //formaDruga.Show();
            //formaDruga.Activate();
            Form2 formaDruga = new Form2();
            formaDruga.ShowDialog();
        }
    }
}
