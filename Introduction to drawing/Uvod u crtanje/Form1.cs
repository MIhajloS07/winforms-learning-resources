namespace Uvod_u_crtanje
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();        
        }
        /*protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            //Graphics g = e.Graphics;
            //g.DrawRectangle(Pens.Red, 0, 0, 150, 150);
            //g.DrawLine(Pens.Black, 0, 0, 100, 100);
            //Graphics g = this.CreateGraphics();
            //g.DrawLine(Pens.Black, 0, 0, 100, 100);
            //g.Dispose();
            //Bitmap bmp = new Bitmap(320, 240);
            //using (Graphics g = Graphics.FromImage(bmp))
            //{
            //    g.DrawLine(Pens.Gray, 0, 0, 100, 100);
            //}
            //bmp.Save("Line.png");
        }
        */

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            // Sky
            g.FillRectangle(Brushes.SkyBlue, 0, 0, this.Width, this.Height);
            //g.DrawRectangle(Pens.Black, 0, 0, this.Width, this.Height);
            // Sun
            g.FillEllipse(Brushes.Yellow, 30, 30, 70, 70);
            g.DrawEllipse(Pens.Black, 30, 30, 70, 70);
            // House body
            g.FillRectangle(Brushes.DarkKhaki, 100, 150, 200, 150);
            g.DrawRectangle(Pens.Black, 100, 150, 200, 150);
            // Roof
            Point[] krov = { new Point(100, 150), new Point(200, 50), new Point(300, 150) };
            g.FillPolygon(Brushes.DarkRed, krov);
            g.DrawPolygon(Pens.Black, krov);
            // Doors
            g.FillRectangle(Brushes.Blue, 170, 230, 50, 70);
            g.DrawRectangle(Pens.Black, 170, 230, 50, 70);
            // Windows
            g.FillRectangle(Brushes.Green, 130, 175, 40, 40);
            g.DrawRectangle(Pens.Black, 130, 175, 40, 40);
            g.FillRectangle(Brushes.Green, 230, 175, 40, 40);
            g.DrawRectangle(Pens.Black, 230, 175, 40, 40);
            // Floor
            g.FillRectangle(Brushes.ForestGreen, 0, 300, this.Width, this.Height);
            g.DrawRectangle(Pens.Black, 0, 300, this.Width, this.Height);
            // Tree
            g.FillRectangle(Brushes.SaddleBrown, 450, 210, 40, 90);
            g.DrawRectangle(Pens.Black, 450, 210, 40, 90);
            g.FillEllipse(Brushes.DarkGreen, 410, 100, 120, 120);
        }
    }
}
