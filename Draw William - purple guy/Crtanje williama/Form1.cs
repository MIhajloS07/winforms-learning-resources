namespace Crtanje_williama
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
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
            Point[] glava =
            {
                new Point(100, 100),
                new Point(160, 60),
                new Point(160, 70),
                new Point(180, 70),
                new Point(180, 125),
                new Point(160, 125),
                new Point(160, 140),
                new Point(60, 140),
                new Point(60, 120),
                new Point(40, 120),
                new Point(40, 75),
                new Point(60, 75),
                new Point(60, 60)
            };
            g.FillPolygon(Brushes.Purple, glava);
        }
    }
}
