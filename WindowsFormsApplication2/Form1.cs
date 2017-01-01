using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{

    public partial class FormWindow : Form
    {
        public FormWindow()
        {
            InitializeComponent();    
        }
        class Globals
        {
            public static int setTimeMinutes;
            public const int minuteTime = 1000 * 60;
            public static int initCountDown;

            public const string titleBarText = "EyeSight";
            public const string pauseText= "Pause";
            public const string startText = "Start";
            public const string timeLeftText = " minutes left";
            public const string pauseFinishedText = "Pause is finished";
            public const string messagePauseText = "Pause?";
            public const string messagePauseTitle = "Pause?";
            public static bool pauseCycleRunning = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timerDisplayCountDown.Interval = Globals.minuteTime;
            //labelCurrentDate.Text = DateTime.Now.ToString(("hh:mm:ss tt"));

            this.Text = Globals.titleBarText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startTimerWorkCycle();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerDisplayCountDown.Stop();
            timerWindowApp.Stop();
            this.CenterToScreen();
            if (this.WindowState == FormWindowState.Minimized) { 
                this.WindowState = FormWindowState.Normal;
            }
            this.TopMost = true;
            if (Globals.pauseCycleRunning == false)
            {
                labelCountDownWork.Text = Globals.setTimeMinutes.ToString();
                btnTimerWorkCycle.Text = Globals.startText;
            }
            else
            {
                labelCountDownWork.Text = Globals.pauseFinishedText.ToString();
            }
            if (Globals.pauseCycleRunning == false) { 
                DialogResult msgPause = MessageBox.Show(
                    Globals.messagePauseTitle, Globals.messagePauseText, MessageBoxButtons.YesNo);
                if (msgPause == DialogResult.Yes)
                {
                    startTimerPauseCycle();
                }
                else if ( msgPause == DialogResult.No ) {
                    startTimerWorkCycle();
                }
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Globals.initCountDown -=  1;
            labelCountDownWork.Text = Globals.initCountDown.ToString() + Globals.timeLeftText;
        }
        private void startTimerWorkCycle() {
            Globals.pauseCycleRunning = false;
            setTimeInterval(false);
            timerWindowApp.Interval = Globals.setTimeMinutes * Globals.minuteTime;
            btnTimerWorkCycle.Text = Globals.pauseText;
            labelCountDownWork.Text = Globals.initCountDown.ToString() + Globals.timeLeftText;
            this.TopMost = false;
            timerDisplayCountDown.Start();
            timerWindowApp.Start();

        }
        private void startTimerPauseCycle()
        {
            Globals.pauseCycleRunning = true;
            setTimeInterval(true);
            timerWindowApp.Interval = Globals.setTimeMinutes * Globals.minuteTime;
            btnTimerWorkCycle.Text = Globals.pauseText;
            labelCountDownWork.Text = Globals.initCountDown.ToString() + Globals.timeLeftText;
            this.TopMost = false;
            timerDisplayCountDown.Start();
            timerWindowApp.Start();

        }
        private void setTimeInterval(bool pause) {
            if (pause == false)
            {
                Globals.setTimeMinutes = 3;
            }
            else
            {
                Globals.setTimeMinutes = 2;
            }
            int time = Globals.setTimeMinutes;
            Globals.initCountDown = time;
        }
    }

}
