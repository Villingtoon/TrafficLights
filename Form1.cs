using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLights
{
    public partial class TrafficLights : Form
    {
        private Timer timerSwitch = null;
        private Timer timerBlink = null;
        private int timeCounter = 0;
        private Label labelTime = null;

        public TrafficLights()
        {
            InitializeComponent();
            InitializeTrafficLights();
            InitializeLabelTime();
            InitializeTimerSwitch();
            InitializeTimerBlink();
        }

        private void InitializeTimerSwitch()
        {
            timerSwitch = new Timer();
            timerSwitch.Interval = 1000;
            timerSwitch.Tick += new EventHandler(timerSwitch_Tick);
            timerSwitch.Start();
        }

        private void InitializeTimerBlink()
        {
            timerBlink = new Timer();
            timerBlink.Interval = 200;
            timerBlink.Tick += new EventHandler(timerBlink_Tick);
        }

        private void InitializeLabelTime()
        {
            labelTime = new Label();
            labelTime.Font = new Font("Tahoma", 18, FontStyle.Bold);
            labelTime.Width = 150;
            labelTime.Height = 50;
            labelTime.Top = 20;
            labelTime.Left = 50;
            labelTime.Text = "00:00:00";
            this.Controls.Add(labelTime);
        }

        private void SwitchLights()
        {
            switch (timeCounter)
            {
                case 0:
                    Red.BackColor = Color.Red;
                    break;
                case 3:
                    Yellow.BackColor = Color.Yellow;
                    //RedLight.BackColor = Color.Gray;
                    break;
                case 5:
                    Red.BackColor = Color.Gray;
                    Yellow.BackColor = Color.Gray;
                    Green.BackColor = Color.Green;
                    break;
                case 6:
                    timerBlink.Start();
                    break;
                case 8:
                    timerBlink.Stop();
                    Yellow.BackColor = Color.Yellow;
                    Green.BackColor = Color.Gray;
                    break;
                case 10:
                    Yellow.BackColor = Color.Gray;
                    Red.BackColor = Color.Red;
                    timeCounter = -1;
                    break;
            }
            timeCounter++;
        }

        private void timerSwitch_Tick(object sender, EventArgs e)
        {
            SwitchLights();
        }

        private void timerBlink_Tick(object sender, EventArgs e)
        {
            if(Green.BackColor == Color.DarkGreen)
            {
                Green.BackColor = Color.Green;
            }
            else
            {
                Green.BackColor = Color.DarkGreen;
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