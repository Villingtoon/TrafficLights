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
        private int timeCounter = 0;

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
            if(timeCounter == 0)
            {
                Red.BackColor = Color.Red;
                Yellow.BackColor = Color.DarkGoldenrod;
            }
            else if(timeCounter == 5)
            {
                Yellow.BackColor = Color.Yellow;
                Red.BackColor = Color.DarkRed;
            }
            else if (timeCounter == 6)
            {
                Green.BackColor = Color.Lime;
                Yellow.BackColor = Color.DarkGoldenrod;
            }
            else if (timeCounter == 11)
            {
                Yellow.BackColor = Color.Yellow;
                Green.BackColor = Color.DarkGreen;
            }
            else if (timeCounter == 12)
            {
                timeCounter = -1;
            }
            timeCounter++;
        }

        private void InitializeTrafficLights()
        {
            Red.BackColor = Color.DarkRed;
            Yellow.BackColor = Color.DarkGoldenrod;
            Green.BackColor = Color.DarkGreen;
        }
    }
}