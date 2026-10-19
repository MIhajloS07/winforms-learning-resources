using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrola_datetime_picker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //dateTimePicker1.Format = DateTimePickerFormat.Short;
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.Format = DateTimePickerFormat.Long;
            //dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }
    }
}
