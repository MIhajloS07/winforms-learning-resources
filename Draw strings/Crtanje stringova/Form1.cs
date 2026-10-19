namespace Crtanje_stringova
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);            
            Graphics g = e.Graphics;
            string text = "Hello, World!";
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Brush b = new SolidBrush(Color.Black))
            using (Font f = new Font("Nirmala UI", 36, FontStyle.Bold, GraphicsUnit.Pixel))
            {
                //g.DrawString(text, f, b, new PointF(20, 20)); 
                // Using rect for draw string
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                Rectangle rect = new Rectangle(10, 10, 250, 60);
                g.FillRectangle(Brushes.Green, rect);
                g.DrawString(text, f, b, rect, sf);

            }
        }
    }
}
