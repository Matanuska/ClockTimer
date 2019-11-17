using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockTimer
{
    public partial class Form1 : Form
    {
        ClockTimer ct;
        public Form1()
        {
            ct = new ClockTimer();
            InitializeComponent();
            ct.TimeChanged += ClockTimer1_TimeChanged;
            comboBox1.SelectedIndex = 0;
        }

        private void ClockTimer1_TimeChanged(object sender, ThresholdReachedEventArgs e)
        {
            label1.Text = e.Time.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ct.TimeZone = TimeZoneInfo.FindSystemTimeZoneById("Alaskan Standard Time");
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ct.TimeFormat = comboBox1.SelectedItem.ToString();
        }
    }
}

