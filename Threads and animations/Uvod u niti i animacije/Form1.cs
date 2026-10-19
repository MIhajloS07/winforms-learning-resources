namespace Uvod_u_niti_i_animacije
{
    public partial class Form1 : Form
    {
        private int x = 0;
        private Thread nit;
        //private volatile bool aktivna = true;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Width = 320;
            this.Height = 240;
            this.Text = "Animacija pomocu niti!";
            //this.FormClosing += new FormClosingEventHandler((s, e) =>
            //{
            //    aktivna = false;
            //});
            //nit = new Thread(new ThreadStart(PokreniAnimaciju));
            //nit.IsBackground = true;
            //nit.Start();
            timer1.Interval = 10;
            timer1.Start();         
        }
        //private void PokreniAnimaciju()
        //{
        //    try
        //    {
        //        while (aktivna)
        //        {
        //            x += 8;
        //            if (x > this.Width)
        //                x = -50;
        //            if (this.IsHandleCreated && !this.IsDisposed)
        //                this.Invoke(new MethodInvoker(this.Invalidate));
        //            Thread.Sleep(2);
        //        }
        //    }
        //    catch (ObjectDisposedException) { }
        //    catch (InvalidOperationException) { }
        //}
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.FillEllipse(Brushes.Red, x, 60, 40, 40);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 5;
            if (x > this.Width)
                x = -50;
            this.Invalidate();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();
        }
    }
}
