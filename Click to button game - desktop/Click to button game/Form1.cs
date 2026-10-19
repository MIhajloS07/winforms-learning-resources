namespace Click_to_button_game
{
    public partial class FormGame : Form
    {
        private Random random = new Random();
        private int points = 0;
        private Button button = null;
        public FormGame()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            timer2.Interval = 1000;
            label1.Text = "Score: 0";
        }
        private void Result()
        {
            label1.Text = $"Score: {points}";
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Click A Button game! \r\nI hope u enjoy :)");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button != null)
            {
                Controls.Remove(button);
                button.Dispose();
                button = null;
            }

            // set button to random location
            button = new Button();
            // set size for button
            button.Size = new Size(50, 50);
            // set button random location on the form
            button.Location = new Point(random.Next(0, this.ClientSize.Width - button.Width),
                                       random.Next(0, this.ClientSize.Height - button.Height));

            if (random.Next(2) == 0)
            {
                button.BackColor = Color.Green;
                button.Click += green_Click;
            }
            else
            {
                button.BackColor = Color.Red;
                button.Click += red_Click;
            }
            Controls.Add(button);
            timer2.Start();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            if (button != null)
            {
                Controls.Remove(button);
                button.Dispose();
                button = null;
            }
        }
        private void green_Click(object sender, EventArgs e)
        {
            points++;
            Result();
            DeleteButton(sender);
        }
        private void red_Click(object sender, EventArgs e)
        {
            points--;
            Result();
            DeleteButton(sender);
        }
        private void DeleteButton(object sender)
        {
            Controls.Remove((Button)sender);
            ((Button)sender).Dispose();
            button = null;
        }
        private void FormGame_Click(object sender, EventArgs e)
        {
            points--;
            Result();
        }

        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult result = MessageBox.Show($"End of the game! Well done \r\nPoints earned: {points}." +
                $"\r\n Do u want to continue?",
                "Result",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes) 
            {
                timer1.Start();
                points = 0;
                Result();
            }  
            if (result == DialogResult.No)
            {
                this.Close();
            }
        }
    }
}