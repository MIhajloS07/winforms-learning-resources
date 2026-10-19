namespace Crtanje_pravougaonika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(320, 240);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            /* Overloads
             *  DrawRectangle(Pen, int, int, int, int)
             *  DrawRectangle(Pen, float, float, float, float)
             *  DrawRectangle(Pen, Rectangle)
             *  DrawRectangle(Pen, RectangleF)
            */
            //Rectangle rect = new Rectangle(30, 30, this.Width / 2, this.Height / 3);
            RectangleF rectF = new RectangleF(30.7f, 30.9f, (float)this.Width / 2, (float)this.Height / 3);
            using (Pen p = new Pen(Color.Black, 4))
            {
                //int cx = 200;
                //int cy = 200;
                //for (int i = 10; i < 200; i += 10)
                //{
                //    g.DrawRectangle(p, cx - i / 2, cy - i / 2, i, i);
                //}
            }
            using (Brush b = new SolidBrush(Color.SkyBlue))
                g.FillRectangle(b, rectF);

        }
    }
}
