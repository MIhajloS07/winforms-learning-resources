namespace Crtanje_krivih_linija
{
    public partial class Form1 : Form
    {
        private List<Point> tacke = new List<Point>();
        private bool crtanje = false;
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(320, 240);
            this.Text = "Crtanje slobodnom rukom";
            this.DoubleBuffered = true;
            this.MouseDown += new MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new MouseEventHandler(this.Form_MouseUp);
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                crtanje = true;
                this.Cursor = Cursors.Hand;
                tacke.Clear();
                tacke.Add(e.Location);
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (crtanje)
            {
                tacke.Add((Point)e.Location);
                this.Invalidate();
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                crtanje = false;
                this.Cursor = Cursors.Default;
            }
                
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Pen pencil = new Pen(Color.Black, 3))
            {
                //PointF[] points =
                //{
                //    new PointF(140, 180),
                //    new PointF(30, 30),
                //    new PointF(160, 100),
                //    new PointF(260, 70),
                //    new PointF(170, 190)
                //};
                //float tension = 1.0f;
                //g.DrawCurve(pencil, points, 1, 3, tension);

                // Bezier curve
                //Point p1 = new Point(20, 100); 
                //Point p2 = new Point(50, 30); 
                //Point p3 = new Point(120, 99); 
                //Point p4 = new Point(10, 130);
                //g.DrawBezier(pencil, p1, p2, p3, p4);
                if (tacke.Count > 1)
                    g.DrawLines(pencil, tacke.ToArray());
            }
        }
    }
}
