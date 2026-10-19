namespace Crtanje_luka_i_kruznog_isecka
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            // Kruzni luk i isecak
            using (Brush b = new SolidBrush(Color.Orange))
            using (Pen p = new Pen(Color.Black, 4)) 
            {
                g.DrawArc(p, 20, 20, 300, 220, 180, 90);
                // pen, rect (x,y,w,h), start angle, sweep angle
                g.FillPie(b, 20, 20, 300, 220, 180, 90);

                // Polukrug
                //g.DrawArc(p, 20, 20, 300, 300, 180, 180);
                //g.FillPie(b, 20, 20, 300, 300, 180, 180);
            }
            
        }
    }
}
