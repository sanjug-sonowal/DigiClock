using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            hourprocess.Value = DateTime.Now.Hour;
            minuteprocess.Value = DateTime.Now.Minute;
            secondprocess.Value = DateTime.Now.Second;

          


            lbltime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblday.Text = DateTime.Now.ToString("dddd");
            lblDate.Text = DateTime.Now.ToString("D");


        }

       
    }
}
