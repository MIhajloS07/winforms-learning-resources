namespace Klase_za_rad_sa_slikama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // OnPaint metoda
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //Graphics g = e.Graphics;
            //string fileName = "image.jpg";
            //try
            //{
            //    using (Image img = Image.FromFile(fileName))
            //    {
            //        g.DrawImage(img, 10, 10, img.Width, img.Height);
            //    }
            //}
            //catch (FileNotFoundException ex)
            //{
            //    MessageBox.Show(
            //        $"Fajl {fileName} nije pronadjen",
            //        "Greska!",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error
            //    );
            //}
            using (Bitmap bmp = new Bitmap(300, 300)) 
            {
                // Sirina
                for (int x = 0; x < 300; x++)
                {
                    // Visina
                    for (int y = 0; y < 300; y++)
                    {
                        int red = (x * 255) / 300; // Sirina * 255 / 300 (od 0 do 299 mnozi sa 255 pa deli sa 300)
                        int green = (y * 255) / 300; // Visina * 255 / 300 (od 0 do 299 mnozi sa 255 pa deli sa 300)
                        bmp.SetPixel(x, y, Color.FromArgb(red, green, 128));
                    }
                }
                e.Graphics.DrawImage(bmp, 50, 50);
            }
        }
    }
}
