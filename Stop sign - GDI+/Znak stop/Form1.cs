namespace Znak_stop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            // Sestougao
            Point[] points =
            {
                new Point(100, 100),
                new Point(150 ,100),
                new Point(170, 120),
                new Point(170, 160),
                new Point(150, 180),
                new Point(100, 180),
                new Point(80, 160),
                new Point(80, 120),
            };
            using (Pen p = new Pen(Color.WhiteSmoke, 10))
                g.DrawPolygon(p, points);
            g.FillPolygon(Brushes.Red, points);
            using (Font font = new Font("Arial", 18, FontStyle.Regular))
                g.DrawString("STOP", font, Brushes.White, new PointF(87, 125));
            using (Pen p = new Pen(Color.Gray, 8))
                g.DrawLine(p, 125, 184, 124, 300);
        }
    }
}
