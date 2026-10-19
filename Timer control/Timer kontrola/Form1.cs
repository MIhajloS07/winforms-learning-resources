namespace Timer_kontrola
{
    public partial class Form1 : Form
    {
        private int sekunde = 0;
        private int stotinke = 0;
        private int desetinke = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void StartStopBtn_Click(object sender, EventArgs e)
        {
            //1.Nacin
            //timer1.Start();
            //2.Nacin
            timer1.Enabled = true;
        }
        private void StopBtn_Click(object sender, EventArgs e)
        {
            //1.Nacin
            //timer1.Stop();
            //2.Nacin
            timer1.Enabled = false;
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            stotinke = desetinke = sekunde = 0;
            label1.Text = "00:00:00";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            stotinke++;
            if (stotinke >= 10) { stotinke = 0; desetinke++; }
            if (desetinke >= 10) { desetinke = 0; sekunde++; }
            label1.Text = $"{sekunde:D2}:{desetinke:D2}:{stotinke:D2}";
            label1.TextAlign = ContentAlignment.MiddleCenter;
        }  
    }
}
