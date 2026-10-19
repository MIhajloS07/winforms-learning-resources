namespace Jedinice_mere_za_crtanje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Graphics g = this.CreateGraphics();
            float dpiX = g.DpiX;
            float dpiY = g.DpiY;
            double sirinaInci = 2.5;
            double visinaInci = 0.5;
            int sirinaPikseli = (int)(sirinaInci * dpiX);
            int visinaPikseli = (int)(visinaInci * dpiY);
            Button button = new Button();
            button.Width = sirinaPikseli;
            button.Height = visinaPikseli;
            this.Controls.Add(button);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.Text = "Jedinice mere";
            Graphics g = e.Graphics;
            g.PageUnit = GraphicsUnit.Millimeter;
            g.DrawRectangle(Pens.Black, 20, 20, 60, 30);
        }
    }
}
