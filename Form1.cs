using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLights
{
    public partial class TrafficLights : Form
    {
        private Timer timerSwitch;

        public TrafficLights()
        {
            InitializeComponent();
            InitializeTrafficLights();
            InitializeTimerSwitch();
        }

        private void InitializeTimerSwitch()
        {
            timerSwitch = new Timer();
            timerSwitch.Interval = 1000;
            timerSwitch.Tick += new EventHandler(timerSwitch_Tick);
            timerSwitch.Start();
        }

        private void timerSwitch_Tick(object sender, EventArgs e)
        {
            if(Red.BackColor == Color.DarkRed)
            {
                Red.BackColor = Color.Red;
            }
            else
            {
                Red.BackColor = Color.DarkRed;
            }
        }

        private void InitializeTrafficLights()
        {
            Red.BackColor = Color.DarkRed;
            Yellow.BackColor = Color.DarkGoldenrod;
            Green.BackColor = Color.DarkGreen;
        }
    }
}