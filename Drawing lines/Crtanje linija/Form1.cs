using System.Drawing.Drawing2D;

namespace Crtanje_linija
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
            g.SmoothingMode = SmoothingMode.AntiAlias;
            /* Overloadings
             * DrawLine(Pen, int, int, int, int)
             * DrawLine(Pen, float, float, float, float)
             * DrawLine(Pen, Point, Point)
             * DrawLine(Pen, PointF, PointF)
            */

            // Using point with integer values 
            //Point p1 = new Point(50, 100); // x1, y1
            //Point p2 = new Point(250, 100); // x2, y2
            
            // Using point with floating values
            //PointF p1F = new PointF(50.5f, 100.5f); //x1, y1
            //PointF p2F = new PointF(250.5f, 100.5f); //x2, y2
            //using (Pen p = new Pen(Color.Black, 2))
            //    g.DrawLine(p, p1F, p2F);

            using (Pen p = new Pen(Color.Black, 10))
            {
                //Point[] points =
                //{
                //    new Point(50, 50),
                //    new Point(75, 100),
                //    new Point(100, 50),
                //    new Point(125, 100),
                //    new Point(150, 50),
                //    new Point(175, 100),
                //    new Point(200, 50),
                //    new Point(225, 100),
                //    new Point(250, 50)

                //};
                //PointF[] pointsF =
                //{
                //    new PointF(50.5f, 50.5f),
                //    new PointF(75.5f, 100.5f),
                //    new PointF(100.5f, 50.5f),
                //    new PointF(125.5f, 100.5f),
                //    new PointF(150.5f, 50.5f),
                //    new PointF(175.5f, 100.5f),
                //    new PointF(200.5f, 50.5f),
                //    new PointF(225.5f, 100.5f),
                //    new PointF(250.5f, 50.5f)
                //};
                //g.DrawLines(p, pointsF);

                // Line terminators
                p.StartCap = LineCap.Flat;
                p.EndCap = LineCap.Square;
                g.DrawLine(p, 50, 40, 250, 40);
                p.StartCap = LineCap.Round;
                p.EndCap = LineCap.Triangle;
                g.DrawLine(p, 50, 80, 250, 80);
                p.StartCap = LineCap.SquareAnchor;
                p.EndCap = LineCap.RoundAnchor;
                g.DrawLine(p, 50, 120, 250, 120);
                p.StartCap = LineCap.DiamondAnchor;
                p.EndCap = LineCap.ArrowAnchor;
                g.DrawLine(p, 50, 160, 250, 160);
            }
        }
    }
}
