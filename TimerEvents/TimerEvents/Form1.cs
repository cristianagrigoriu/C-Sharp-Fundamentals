using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerEvents
{
    public partial class Form1 : Form
    {
        private Timer MyTimer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyTimer = new Timer();
            MyTimer.Interval = 1000;

            MyTimer.Tick += new EventHandler(IncrementValue);

            MyTimer.Start();
        }

        private void IncrementValue(Object myObject,
                                            EventArgs myEventArgs)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value++;
            }
            else
            {
                MyTimer.Stop();
            }
        }
    }
}
