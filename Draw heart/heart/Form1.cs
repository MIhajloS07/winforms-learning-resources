namespace heart
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Point[] points =
            {
                new Point(150, 150),
                new Point(200, 120),
                new Point(245, 165),
                new Point(290, 120),
                new Point(338, 150),
                new Point(245, 325)
            };
            using (Pen p = new Pen(Color.DarkRed, 7))
                g.DrawPolygon(p, points);
            g.FillPolygon(Brushes.Red, points);
        }
    }
}
