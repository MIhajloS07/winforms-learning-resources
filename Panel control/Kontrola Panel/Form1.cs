using System.Diagnostics;

namespace Kontrola_Panel
{
    public partial class Forma : Form
    {
        public Forma()
        {
            InitializeComponent();
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://rademetalac.edu.rs/",
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}
