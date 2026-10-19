namespace Strukture_SystemDrawing
{
    public partial class Form1 : Form
    {
        // Struct Color
        /// <summary>
        /// Color structure define some color in color-pallete ARGB(Alpha, Red, Green, Blue). 
        /// Its using for define colors for draw, fill or similar graphics operations. This 
        /// structure have predefined colors (example -> Color.Red, Color.Blue...), and enable
        /// create some color. Color for every pixel is 32bits, where every component from ARGB
        /// method use 8bits (8x4=32bits).Alpha component define color-transparent (0 - full transparent,
        /// 255 - semi transparent). For colors which isn't predefined we use FromArgb() method for 
        /// create custom color. If we use FromArgb() method with 3 components (RGB), Alpha have default
        /// value 255 (full non-transparent)
        /// </summary>
        Color poluprovidnaPlava = Color.FromArgb(128, 0, 0, 255);
        Color plava = Color.FromArgb(0, 0, 255);

        // Struct Point
        /// <summary>
        /// Point structure define point in 2D dimension with coordinates (X,Y). Its using 
        /// for positioning objects on form. Struct PointF is like struct Point, but PointF
        /// use float datatype for coordinates.
        /// </summary>
        Point p1 = new Point(123, 123);
        PointF p2 = new PointF(123.45f, 123.45f);

        // Struct Size
        /// <summary>
        /// Size structure define dimensions (width, heigth) with integer values and its 
        /// using for define some size for objects or windows. Similar, SizeF structure 
        /// use values with float datatype and its using for define more accurate sizes 
        /// with moveable notch.
        /// </summary>
        Size s1 = new Size(123, 123);
        SizeF s2 = new SizeF(123.32f, 123.45f);

        // Struct Rectangle
        /// <summary>
        /// Rectangle structure define rectangle region with integer coordinates (X, Y) and
        /// size (Width, Heigth). Its using for define some region on screen or work with
        /// image parts. Structure RectangleF is similar to Rectangle, but its using float
        /// datatype for coordinates and size for accurate defining rect regions.
        /// </summary>
        Rectangle r1 = new Rectangle(10, 10, 50, 50);
        RectangleF r2 = new RectangleF(50.1f, 50.1f, 89.9f, 89.9f);


        public Form1()
        {
            InitializeComponent();
            //pictureBox1.BackColor = plava;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            // Colors
            Color colorRect = Color.Blue;
            Color colorEllipse = Color.Red;
            Color colorLine = Color.Green;
            Color colorString = Color.Black;
            using (Pen penRect = new Pen(colorRect, 3))
            using (Pen penEllipse = new Pen(colorEllipse, 2))
            using (Pen penLine = new Pen(colorLine, 2))
            using (Brush brushString = new SolidBrush(colorString))
            using (Font fontString = new Font("Nirmala UI", 12))
            {
                Point pRect = new Point(50, 50);
                Size sRect = new Size(200, 100);
                Rectangle rect = new Rectangle(pRect, sRect); // 50, 50, 200, 100
                graphics.DrawRectangle(penRect, rect);
                graphics.DrawEllipse(penEllipse, rect);
                graphics.DrawLine(penLine, rect.Left, rect.Top, rect.Right, rect.Bottom);
                string str = "Upotreba struktura";
                graphics.DrawString(str, fontString, brushString, new PointF(rect.Left + 26.7f, rect.Top + 40.12f));
            }
        }
    }
}
