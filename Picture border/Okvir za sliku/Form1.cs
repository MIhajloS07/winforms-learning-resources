namespace Okvir_za_sliku
{
    public partial class Form1 : Form
    {
        Bitmap pristupnaTacka = new Bitmap("waccesspoint.jpg");
        Bitmap bezicniMost = new Bitmap("wbridge.jpg");
        Bitmap bezicniRuter = new Bitmap("wrouter.jpg");
        public Form1()
        {
            InitializeComponent();
            MrezaLabel.Text = "Na mreznim dijagramima, za bezicne uredjaje \n koriste se sledeci simboli:";
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            pristupnaTacka.Dispose();   
            bezicniMost.Dispose();
            bezicniRuter.Dispose();
        }

        private void PrisTacBtn_Click(object sender, EventArgs e)
        {
            //if(pictureBox1.Image != null)
            //{
            //    pictureBox1.Image.Dispose();
            //    pictureBox1.Image = null;
            //}   
            pictureBox1.Image = pristupnaTacka;
        }

        private void BezMostBtn_Click(object sender, EventArgs e)
        {
            //if (pictureBox1.Image != null)
            //{
            //    pictureBox1.Image.Dispose();
            //    pictureBox1.Image = null;
            //}            
            pictureBox1.Image = bezicniMost;
        }

        private void BezRuterBtn_Click(object sender, EventArgs e)
        {
            //if (pictureBox1.Image != null)
            //{
            //    pictureBox1.Image.Dispose();
            //    pictureBox1.Image = null;
            //}  
            pictureBox1.Image = bezicniRuter;
        }
    }
}
