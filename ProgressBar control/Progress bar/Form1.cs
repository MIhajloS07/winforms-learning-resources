namespace Progress_bar
{
    public partial class Form1 : Form
    {
        bool buttonClicked = false;

        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
            StartBtn.Text = "Forwards";
        }

        int progressValue = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressValue += 2;
            progressBar1.Value = progressValue;
            if (progressBar1.Value == 100)
                progressValue = 0;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            buttonClicked = !buttonClicked; // set true -> false and false -> true
            StartBtn.Enabled = false;
            if (buttonClicked)
            {           
                StartBtn.Text = "Backwards";
                for (int i = 0; i <= 100; i++)
                {
                    progressBar1.Value = i;
                    Thread.Sleep(20);
                }
            }
            else 
            {
                StartBtn.Enabled = true;
                StartBtn.Text = "Forwards";
                for (int i = 100; i >= 0; i--)
                {
                    progressBar1.Value = i;
                    Thread.Sleep(20);
                }
            }
            StartBtn.Enabled = true;
        }
    }
}
