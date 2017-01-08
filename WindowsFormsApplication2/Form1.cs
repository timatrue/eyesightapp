using System;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;


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
            this.WindowState = FormWindowState.Normal;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            this.Text = Globals.titleBarText;
            btnTimerWorkCycle.Text = Globals.startText;

            timerDisplayCountDown.Interval = Globals.minuteTime;
            currentDateLabel.Text = Globals.dateText + DateTime.Now.ToLongDateString();            
            leaveFullScreenImage.Visible = Globals.debugMode;
            flowLayoutPanelMain.Left = (this.ClientSize.Width - flowLayoutPanelMain.Size.Width) / 2;
            //Handlers
            this.Resize += new EventHandler(flowLayoutPanelMain_Resize);         
            leaveFullScreenImage.Click += leaveFullScreen_Click;           
        }

        private void btnStartCycle_Click(object sender, EventArgs e)
        {           
            if(Process.getState() == State.InActive) startTimerCycle(false);
            else if(Process.getState() == State.Work) startTimerCycle(true);
            else if (Process.getState() == State.Pause) startTimerCycle(false);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerDisplayCountDown.Stop();
            timerWindowApp.Stop();
            
            fullScreenMode();
            btnTimerWorkCycle.Text = Globals.startText;
            if (Globals.pauseCycleRunning == false)
            {
                countDownWorkLabel.Text = Globals.workFinishedText;
                messageBoxPause();
            }
            else
            {
                countDownWorkLabel.Text = Globals.pauseFinishedText.ToString();
            }
            Process.setState(State.InActive);
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
            if (pause == false) btnTimerWorkCycle.Text = Globals.pauseText;
            else btnTimerWorkCycle.Text = Globals.startText;
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
                Process.setState(State.Work);
                btnTimerWorkCycle.BackColor = Color.DodgerBlue;             
            }
            else
            {
                Globals.setTimeMinutes = UserMode.cyclePause;
                Process.setState(State.Pause);
                
                btnTimerWorkCycle.BackColor = Color.Red;
            }
            int time = Globals.setTimeMinutes;
            Globals.initCountDown = time;
        }
        private void fullScreenMode()
        {
            leaveFullScreenImage.Visible = true;
            this.TopMost = true;
            this.WindowState = FormWindowState.Normal;
            //if (this.WindowState != FormWindowState.Maximized) this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            System.Media.SystemSounds.Asterisk.Play();
        }
        private void leavefullScreenMode()
        {
            leaveFullScreenImage.Visible = false;
            this.TopMost = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
        }
        private void flowLayoutPanelMain_Resize(object sender, EventArgs e)
        {
            flowLayoutPanelMain.Left = (this.ClientSize.Width - flowLayoutPanelMain.Size.Width) / 2;
        }
        public Rectangle GetScreen()
        {
            return Screen.FromControl(this).Bounds;
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
            public static readonly WorkMode debugMode = new WorkMode(1, 3);
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
        public enum State {Pause, Work, InActive };

        public static class Process {
            private static State state;
            public static void setState(State state) {
                Process.state = state;
            }
            public static State getState() {
                return Process.state;
            }
        }
        private class Globals
        {
            public static bool debugMode = false;
            public static bool pauseCycleRunning = false;
            public static int setTimeMinutes;
            public const int minuteTime = 1000 * 60;
            public static int initCountDown;
            public const string titleBarText = "EyeSight";
            public const string pauseText = "Go to break";
            public const string startText = "Start work";
            public const string timeLeftText = " minutes left";
            public const string pauseFinishedText = "Break is finished";
            public const string workFinishedText = "Work is finished";
            public const string messagePauseText = "Break!";
            public const string messagePauseTitle = "It's time to have a break.";
            public const string screenMode = "";
            public const string dateText = "Today is ";
            Color redColor = ColorTranslator.FromHtml("#E74C3C");
            Color blueColor = ColorTranslator.FromHtml("#3498DB");

        }
        public void debugMode(bool debugMode)
        {
            if (debugMode)
            {
                Globals.debugMode = true;
                UserMode.cyclePause = ModeList.debugMode.getCycles()[0];
                UserMode.cycleWork = ModeList.debugMode.getCycles()[1];
            }
        }
        public void debugScreen() {
            String x1 = Screen.PrimaryScreen.Bounds.Width.ToString();
            String x2 = Screen.PrimaryScreen.Bounds.Width.ToString();
            String y1 = Screen.PrimaryScreen.Bounds.Height.ToString();
            String y2 = Screen.PrimaryScreen.Bounds.Height.ToString();
            MessageBox.Show("Height" + this.Height + " " + y1 + " " + y2
                +" "+ "Width" + this.Width + " " + x1 + " " + x2);
        }


    }
}