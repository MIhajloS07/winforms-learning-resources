using System.Media;

namespace BudilnikZad1
{
    public partial class DigitalAlarmClock : Form
    {
        SoundPlayer alarmSound = new SoundPlayer(@"a2eea96c102934b34098793a490f91b2Classic_Alarm_Clock_-_Sound_Effect_ProSounds.wav");
        bool ukljucen = true;
        private int sati, minuti, sekunde;
        public DigitalAlarmClock()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            // Aktiviramo timer da pocne da broji preko kontrole timer1
            timer1.Start();
            // Poravnjanje textBoxova za broj sati minuta i sekundi
            HourTextBox.TextAlign = HorizontalAlignment.Center;
            MinuteTextBox.TextAlign = HorizontalAlignment.Center;
            SecondTextBox.TextAlign = HorizontalAlignment.Center;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Budilnik App");
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox
                .Show("Da li ste sigurni da zelite\r\nda izadjete iz app?",
                "Potvrda izlaska",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes) { this.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ukljucen)
            {
                ukljucen = false;
                buttonClock.Text = "Ukljuci alarm";
            }
            else
            {
                if (int.TryParse(HourTextBox.Text, out sati)
                    && int.TryParse(MinuteTextBox.Text, out minuti)
                    && int.TryParse(SecondTextBox.Text, out sekunde))
                {
                    ukljucen = true;
                    buttonClock.Text = "Iskljuci alarm!";
                }
                else
                {
                    MessageBox.Show("Unesi ispravno broj sati i minuta");
                }
            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dataTimeNow = DateTime.Now;
            label4.Font = new Font("segue UI",10);
            label4.Text = $"Danasnji datum -> {dataTimeNow.ToString("dd:MM:yyyy")}";
            clocklabel.Text = dataTimeNow.ToString("HH:mm:ss");

            if (ukljucen
                && dataTimeNow.Hour == sati
                && dataTimeNow.Minute == minuti
                && dataTimeNow.Second == sekunde)
            {
                ukljucen = false;
                buttonClock.Text = "Ukljuci alarm";
                alarmSound.PlayLooping();
                MessageBox.Show("Probudi se");
                alarmSound.Stop();
                HourTextBox.Text = string.Empty;
                MinuteTextBox.Text = string.Empty;  
                SecondTextBox.Text = string.Empty;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Width = 612;
            this.Height = 354;
            MessageBox.Show("Ne mozes menjati velicinu prozora!");
        }

        private void ExitBtn_MouseEnter(object sender, EventArgs e)
        {
            ExitBtn.BackColor = Color.Orange;
            ExitBtn.ForeColor = Color.White;
            ExitBtn.Font = new Font("Segue UI", 9, FontStyle.Bold);
            ExitBtn.Cursor = Cursors.Hand;
        }

        private void ExitBtn_MouseLeave(object sender, EventArgs e)
        {
            ExitBtn.BackColor = Color.White;
            ExitBtn.ForeColor = Color.Black;
            ExitBtn.Font = new Font("Segue UI", 9, FontStyle.Regular);
            ExitBtn.Cursor = Cursors.Default;
        }

        private void HourTextBox_MouseEnter(object sender, EventArgs e)
        {
            HourTextBox.BackColor = Color.DeepSkyBlue;
        }

        private void HourTextBox_MouseLeave(object sender, EventArgs e)
        {
            HourTextBox.BackColor = Color.White;
        }

        private void MinuteTextBox_MouseEnter(object sender, EventArgs e)
        {
            MinuteTextBox.BackColor = Color.DeepSkyBlue;
        }

        private void MinuteTextBox_MouseLeave(object sender, EventArgs e)
        {
            MinuteTextBox.BackColor = Color.White;
        }

        private void SecondTextBox_MouseEnter(object sender, EventArgs e)
        {
            SecondTextBox.BackColor = Color.DeepSkyBlue;
        }

        private void SecondTextBox_MouseLeave(object sender, EventArgs e)
        {
            SecondTextBox.BackColor = Color.White;
        }

   
        private void buttonClock_MouseEnter(object sender, EventArgs e)
        {
            buttonClock.BackColor = Color.Orange;
            buttonClock.ForeColor = Color.White;
            buttonClock.Font = new Font("Segue UI", 9, FontStyle.Bold);
            buttonClock.Cursor = Cursors.Hand;
        }

        private void buttonClock_MouseLeave(object sender, EventArgs e)
        {
            buttonClock.BackColor = Color.White;
            buttonClock.ForeColor = Color.Black;
            buttonClock.Font = new Font("Segue UI", 9, FontStyle.Regular);
            buttonClock.Cursor = Cursors.Default;
        }
        
        private void clocklabel_MouseEnter(object sender, EventArgs e)
        {
            clocklabel.ForeColor = Color.DarkSlateGray;
        }

        private void clocklabel_MouseLeave(object sender, EventArgs e)
        {
            clocklabel.ForeColor = Color.Black;
        }
    }
}