using System.Windows.Forms;

namespace Dinamicko_kreiranje_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Dobrodosli u winform aplikaciju");
            ResetButton.Enabled = false;
        }
        private void ButtonText_Click(object sender, EventArgs e)
        {        
            ButtonImage.Enabled = false;
            ResetButton.Enabled = true;
            Label labelOdgovor = new Label();
            labelOdgovor.Name = "labelOdgovor";
            labelOdgovor.Location = new Point(95, 200);
            labelOdgovor.Text = "Kreirao je programski jezik c#";
            labelOdgovor.ForeColor = Color.Black;
            labelOdgovor.Font = new Font("Microsoft Sans Serif", 24);
            labelOdgovor.AutoSize = true;
            this.Controls.Add(labelOdgovor);
        }
        private void ButtonImage_Click(object sender, EventArgs e)
        {
            ButtonText.Enabled = false;
            ResetButton.Enabled = true;
            PictureBox pcbOdgovor = new PictureBox();
            Bitmap slika = new Bitmap("c-sharp-logo-B904AC0EA0-seeklogo.com.png");
            pcbOdgovor.Name = "pcbOdgovor";
            pcbOdgovor.Location = new Point(200, 160);
            pcbOdgovor.Image = slika;
            pcbOdgovor.Size = new Size(230, 210);
            pcbOdgovor.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pcbOdgovor);
              // Dodeljivanje dogadjaja click objektu pcbOdgovor klase PictureBox
            pcbOdgovor.Click += new EventHandler(pcbOdgovor_Click);
        }
        private void pcbOdgovor_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Slika je preuzeta sa wikipedia.com sajta");
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            Control kontrolaZaBrisanje = this.Controls.Find("pcbOdgovor",true).FirstOrDefault();
            if(kontrolaZaBrisanje == null)
            {
                kontrolaZaBrisanje = this.Controls.Find("labelOdgovor", true).FirstOrDefault();
            } 
            if(kontrolaZaBrisanje != null)
            {
                this.Controls.Remove(kontrolaZaBrisanje);
                kontrolaZaBrisanje.Dispose();
            }
            ButtonText.Enabled = true;
            ButtonImage.Enabled = true;    
            ResetButton.Enabled = false;
        }
    }
}
