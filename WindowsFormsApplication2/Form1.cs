using System;
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
            public const string pauseText= "Running...";
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
            startTimerCycle(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerDisplayCountDown.Stop();
            timerWindowApp.Stop();
            fullScreenMode();
            btnTimerWorkCycle.Text = Globals.startText;
            if (Globals.pauseCycleRunning == false)
            {
                labelCountDownWork.Text = Globals.setTimeMinutes.ToString();
                messageBoxPause();
            }
            else {
                labelCountDownWork.Text = Globals.pauseFinishedText.ToString();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Globals.initCountDown -=  1;
            labelCountDownWork.Text = Globals.initCountDown.ToString() + Globals.timeLeftText;
        }
        private void startTimerCycle(bool pause)
        {
            Globals.pauseCycleRunning = pause;
            setTimeInterval(pause);
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
                Globals.setTimeMinutes = 25;
            }
            else
            {
                Globals.setTimeMinutes = 7;
            }
            int time = Globals.setTimeMinutes;
            Globals.initCountDown = time;
        }
        private void fullScreenMode()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            System.Media.SystemSounds.Asterisk.Play();
        }
        private void minimizedMode()
        {
            this.CenterToScreen();
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
        }
        private void messageBoxPause()
        {
            DialogResult msgPause = MessageBox.Show(
                    Globals.messagePauseTitle, Globals.messagePauseText, MessageBoxButtons.YesNo);
            if (msgPause == DialogResult.Yes)
            {
                startTimerCycle(true);
            }
            else if (msgPause == DialogResult.No)
            {
                startTimerCycle(false);
            }
        }
        private void labelCountDownWork_Click(object sender, EventArgs e)
        {

        }
    }

}
