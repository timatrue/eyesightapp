using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{

    public partial class FormWindow : Form
    {
        public FormWindow()
        {
            InitializeComponent();
   
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timerDisplayCountDown.Interval = Globals.minuteTime;
            currentDateLabel.Text = Globals.dateText + DateTime.Now.ToLongDateString();
            this.Text = Globals.titleBarText;
            btnScreenMode.Visible = false;
            panelScreenMode.Visible = false;
            currentDateLabel.Left = (this.ClientSize.Width - currentDateLabel.Size.Width) / 2;
            //Handlers
            panelScreenMode.MouseMove += new MouseEventHandler(panelTest_MouseMove);
            btnScreenMode.MouseLeave += new EventHandler(panelTest_MouseLeave);
            this.Resize += new EventHandler(labels_Resize);
        }
        private void panelTest_MouseMove(object sender, MouseEventArgs e)
        {
            if (btnScreenMode.Bounds.Contains(e.Location) && !btnScreenMode.Visible)
            {
                btnScreenMode.Visible = true;
            }
          
        }
        private void panelTest_MouseLeave(object sender, EventArgs e)
        {
            btnScreenMode.Hide();
        }
        private void panelTest_MouseEnter(object sender, EventArgs e)
        {
            btnScreenMode.Show();
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
                Globals.setTimeMinutes = 27;
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
            panelScreenMode.Visible = true;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            System.Media.SystemSounds.Asterisk.Play();
        }
        private void leavefullScreenMode()
        {
            panelScreenMode.Visible = false;
            this.TopMost = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
        }
        private void minimizedMode()
        {
            this.CenterToScreen();
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
        }
        private void labels_Resize(object sender, EventArgs e)
        {
            currentDateLabel.Left = (this.ClientSize.Width - currentDateLabel.Size.Width) / 2;
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
        private void panelTest_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            leavefullScreenMode();
        }

    class Globals
    {
        public static int setTimeMinutes;
        public const int minuteTime = 1000 * 60;
        public static int initCountDown;
        public const string titleBarText = "EyeSight";
        public const string pauseText = "Running...";
        public const string startText = "Start";
        public const string timeLeftText = " minutes left";
        public const string pauseFinishedText = "Pause is finished";
        public const string messagePauseText = "Pause?";
        public const string messagePauseTitle = "Pause?";
        public const string screenMode = "";
        public const string dateText = "Today is ";
        public static bool pauseCycleRunning = false; 
    }

}
}
