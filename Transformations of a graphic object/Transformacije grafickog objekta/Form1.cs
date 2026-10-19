using System.Drawing.Design;
using System.Drawing.Drawing2D;

namespace Transformacije_grafickog_objekta
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Pen okvir = new Pen(Color.Black, 3))
            using (Brush pozadina = new SolidBrush(Color.Red))
            {
                Rectangle rect = new Rectangle(0, 0, 100, 60);
                //g.DrawRectangle(, rect);
                // TranslateTransform(x, y, MatrixOrder);
                // TranslateTransform(x, y);
                // RotateTransform(angle)
                // RotateTransform(angle, MatrixOrder)
                //g.RotateTransform(30);
                //g.TranslateTransform(20, 20, System.Drawing.Drawing2D.MatrixOrder.Append);
                //g.DrawRectangle(pen, rect);
                //g.TranslateTransform(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);            
                //for (int i = 2; i < 100; i++)
                //{
                //    g.RotateTransform(21);
                //    g.DrawRectangle(penTwo, -rect.Width / i, -rect.Height / i, rect.Width, rect.Height);
                //}
                //g.RotateTransform(30);
                //g.ScaleTransform(1.5f, 1f, System.Drawing.Drawing2D.MatrixOrder.Append);
                //g.DrawRectangle(penOne, rect);
                //g.TranslateTransform(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
                //g.ScaleTransform(1.5f, 1.5f);
                //g.TranslateTransform(-rect.Width / 2, -rect.Height / 2);
                //g.DrawRectangle(penOne, 0, 0, rect.Width, rect.Height);
                //GraphicsState state = g.Save();
                //g.ScaleTransform(2.0f, 2.0f);
                //g.DrawRectangle(penOne, rect);
                //g.RotateTransform(30);
                //g.DrawRectangle(penOne, rect);
                //g.Restore(state);
                //g.TranslateTransform(100, 100);
                //g.DrawRectangle(penOne, rect);
                //g.DrawRectangle(penOne, rect);
                Rectangle kartica = new Rectangle(0, 0, 120, 80);
                g.FillRectangle(pozadina, kartica);
                g.DrawRectangle(okvir, kartica);
                g.DrawString("1", Font, Brushes.Black, 50, 30);
                GraphicsState stanje = g.Save();
                g.TranslateTransform(150, 0);
                g.ScaleTransform(0.8F, 0.8F);
                g.FillRectangle(pozadina, kartica);
                g.DrawRectangle(okvir, kartica);
                g.DrawString("2", Font, Brushes.Black, 50, 30);
                g.Restore(stanje);
                stanje = g.Save();
                g.TranslateTransform(60, 150);
                g.RotateTransform(30);
                g.TranslateTransform(-60, -40);
                g.FillRectangle(pozadina, kartica);
                g.DrawRectangle(okvir, kartica);
                g.DrawString("3", Font, Brushes.Black, 50, 30);
                g.Restore(stanje);
                stanje = g.Save();
                g.TranslateTransform(250, 100);
                g.RotateTransform(-15);
                g.ScaleTransform(1.2F, 1.2F);
                g.TranslateTransform(-60, -40);
                g.FillRectangle(pozadina, kartica);
                g.DrawRectangle(okvir, kartica);
                g.DrawString("4", Font, Brushes.Black, 50, 30);
                g.Restore(stanje);
            }
        }
    }
}
