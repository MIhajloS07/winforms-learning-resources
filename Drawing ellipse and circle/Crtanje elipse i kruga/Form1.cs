namespace Crtanje_elipse_i_kruga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            RectangleF rectFEllipse = new RectangleF(50.5f, 50.5f, (float)this.Width / 5, (float)this.Height / 3);
            RectangleF rectFCircle = new RectangleF(135.6f, 150.5f, 70.5f, 70.5f);
            using (Brush b = new SolidBrush(Color.DarkOliveGreen))
            using (Pen p = new Pen(Color.Black, 3)) 
            {
                #region Frog
                // DrawEllipse
                g.DrawEllipse(p, rectFEllipse);
                // DrawCircle
                g.DrawEllipse(p, rectFCircle);
                // FillEllipse
                g.FillEllipse(b, rectFEllipse);
                // FillCircle
                g.FillEllipse(b, rectFCircle);
                // Eye
                g.FillEllipse(Brushes.Black, 125, 170, 20, 20);
                g.FillEllipse(Brushes.Black, 165, 145, 20, 20);
                g.FillEllipse(Brushes.White, 170, 150, 7, 7);
                g.FillEllipse(Brushes.White, 130, 175, 7, 7);
                #endregion
            }
        }
    }
}
