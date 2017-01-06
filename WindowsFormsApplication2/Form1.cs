using System;
using System.Windows.Forms;
using System.Linq;

namespace WindowsFormsApplication2
{
    public partial class FormWindow : Form
    {
        public FormWindow()
        {
            InitializeComponent();
            this.debugMode(false);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timerDisplayCountDown.Interval = Globals.minuteTime;
            currentDateLabel.Text = Globals.dateText + DateTime.Now.ToLongDateString();
            this.Text = Globals.titleBarText;
            leaveFullScreenImage.Visible = Globals.debugMode;
            flowLayoutPanelMain.Left = (this.ClientSize.Width - flowLayoutPanelMain.Size.Width) / 2;
            //Handlers
            this.Resize += new EventHandler(flowLayoutPanelMain_Resize);
            
            leaveFullScreenImage.Click += leaveFullScreen_Click;
           

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
                countDownWorkLabel.Text = Globals.setTimeMinutes.ToString();
                messageBoxPause();
            }
            else
            {
                countDownWorkLabel.Text = Globals.pauseFinishedText.ToString();
            }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Globals.initCountDown -= 1;
            countDownWorkLabel.Text = Globals.initCountDown.ToString() + Globals.timeLeftText;
        }
        private void startTimerCycle(bool pause)
        {
            Globals.pauseCycleRunning = pause;
            setTimeInterval(pause);
            timerWindowApp.Interval = Globals.setTimeMinutes * Globals.minuteTime;
            btnTimerWorkCycle.Text = Globals.pauseText;
            countDownWorkLabel.Text = Globals.initCountDown.ToString() + Globals.timeLeftText;
            this.TopMost = false;
            timerDisplayCountDown.Start();
            timerWindowApp.Start();
        }
        private void setTimeInterval(bool pause)
        {
            if (pause == false)
            {
                Globals.setTimeMinutes = UserMode.cycleWork;    
            }
            else
            {
                Globals.setTimeMinutes = UserMode.cyclePause;
            }
            int time = Globals.setTimeMinutes;
            Globals.initCountDown = time;
        }
        private void fullScreenMode()
        {
            leaveFullScreenImage.Visible = true;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            System.Media.SystemSounds.Asterisk.Play();
        }
        private void leavefullScreenMode()
        {
            leaveFullScreenImage.Visible = false;
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
        private void flowLayoutPanelMain_Resize(object sender, EventArgs e)
        {
            flowLayoutPanelMain.Left = (this.ClientSize.Width - flowLayoutPanelMain.Size.Width) / 2;
            leaveFullScreenImage.Left = this.ClientSize.Width - leaveFullScreenImage.Size.Width;

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
        private void leaveFullScreen_Click(object sender, EventArgs e)
        {
            leavefullScreenMode();          
        }

        public class UserMode {
            public static int cyclePause = ModeList.hardMode.getCycles()[0];
            public static int cycleWork = ModeList.hardMode.getCycles()[1];

        }
        public static class ModeList
        {
            public static readonly WorkMode hardMode = new WorkMode(7, 27);
            public static readonly WorkMode lightMode = new WorkMode(5, 15);
            public static readonly WorkMode debugMode = new WorkMode(1, 2);
            public static WorkMode userMode;
        }
        public class WorkMode
        {
            private int cyclePause;
            private int cycleWork;

            public WorkMode(int pause, int work){
                this.cyclePause = pause;
                this.cycleWork = work;
        }
            public int[] getCycles()
            {
               return new[] { this.cyclePause, this.cycleWork};
            }
        }

        private RadioButton searchCheckedRadio() {

            var radioButtonSelected = groupBoxMode.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            return radioButtonSelected;
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UserMode.cyclePause = ModeList.hardMode.getCycles()[0];
            UserMode.cycleWork = ModeList.hardMode.getCycles()[1];
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UserMode.cyclePause = ModeList.lightMode.getCycles()[0];
            UserMode.cycleWork = ModeList.lightMode.getCycles()[1];
        }
        private void labelCountDownWork_Click(object sender, EventArgs e)
        {

        }
        private void currentDateLabel_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private class Globals
        {
            public static bool debugMode = false;
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
        public void debugMode(bool debugMode)
        {
            if (debugMode)
            {
                Globals.debugMode = true;
                UserMode.cyclePause = ModeList.debugMode.getCycles()[0];
                UserMode.cycleWork = ModeList.debugMode.getCycles()[0];
            }
        }
    }
}