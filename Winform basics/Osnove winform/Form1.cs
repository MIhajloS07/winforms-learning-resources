using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Osnove_winform
{
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void frmGlavna_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            this.Text = "Kliknuo si na formu";
            textBox1.Text = "Dvoklik za izlaz iz aplikacije...";
            ExitBtn.Visible = false;    
        }

        private void frmGlavna_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmGlavna_ClientSizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Ne mozes da menjas velicinu prozora");
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
