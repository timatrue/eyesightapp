using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Reflection;

namespace WindowsFormsApplication2
{
    public partial class FormWindow : Form
    {
        private Icon defaultIcon = eyesightapp.Properties.Resources.favicon;
        private Icon workIcon = eyesightapp.Properties.Resources.faviconOrange;
        public FormWindow()
        {
            InitializeComponent();
            this.debugMode(false);               
        }
        private void MainForm_Load(object sender, EventArgs e)
        {         
            this.WindowState = FormWindowState.Normal;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            this.Text = Globals.titleBarText;
            this.Resize += new EventHandler(flowLayoutPanelMain_Resize);         
            setInitialControls();
            setLockNumericUpDown(false);
            setUserData();
        }
        private void setUserData()
        {
            numericUpDownPause.Value = eyesightapp.Properties.Settings.Default.customPause;
            numericUpDownWork.Value = eyesightapp.Properties.Settings.Default.customWork;
        }
        private void setInitialControls() {
            Process.setState(State.InActive);
            timerDisplayCountDown.Interval = Globals.minuteTime;
            currentDateLabel.Text = Globals.dateText + DateTime.Now.ToLongDateString();
            leaveFullScreenImage.Visible = Globals.debugMode;
            btnTimerWorkCycle.Text = Globals.startText;
            flowLayoutPanelMain.Left = (this.ClientSize.Width - flowLayoutPanelMain.Size.Width) / 2;
            leaveFullScreenImage.Click += leaveFullScreen_Click;
        }
        private void startTimerCycle(State state)
        {            
            setTransitionToState(state);
            this.stateDebugLabel.Text = Process.getState().ToString();
            setDataForTimeCycle();          
            setIconsApp();
        }
        private void setTransitionToState(State state)
        {
            if (state != State.Work )
            {
                Globals.setTimeMinutes = UserMode.cycleWork;
                Process.setState(State.Work);
                btnTimerWorkCycle.BackColor = Color.DodgerBlue;
                btnTimerWorkCycle.Text = Globals.pauseText;
            } else {
                Globals.setTimeMinutes = UserMode.cyclePause;
                Process.setState(State.Pause);
                btnTimerWorkCycle.BackColor = Color.Red;
                btnTimerWorkCycle.Text = Globals.startText;
            }            
        }
        private void setDataForTimeCycle()
        {
            this.TopMost = false;
            int time = Globals.setTimeMinutes;
            Globals.initCountDown = time;
            timerWindowApp.Interval = Globals.setTimeMinutes * Globals.minuteTime;
            countDownWorkLabel.Text = Globals.initCountDown.ToString() + Globals.timeLeftText;
            timerDisplayCountDown.Start();
            timerWindowApp.Start();
        }
        private void setIconsApp()
        {
            this.Icon = (Process.getState() == State.Work) ? defaultIcon : workIcon;
        }
        private void timerMain_Tick(object sender, EventArgs e)
        {
            timerDisplayCountDown.Stop();
            timerWindowApp.Stop();
            fullScreenMode();
            btnTimerWorkCycle.Text = Globals.startText;
            if (Process.getState() != State.Pause)
            {
                countDownWorkLabel.Text = Globals.workFinishedText;
                messageBoxPause();
            } else {
                countDownWorkLabel.Text = Globals.pauseFinishedText.ToString();
                Process.setState(State.InActive);
            }
            this.stateDebugLabel.Text = Process.getState().ToString();                  
        }
        private void timerMinuteLeft_Tick(object sender, EventArgs e)
        {
            Globals.initCountDown -= 1;
            countDownWorkLabel.Text = Globals.initCountDown.ToString() + Globals.timeLeftText;
        }
        private void messageBoxPause()
        {
            btnTimerWorkCycle.BackColor = Color.Red;
            DialogResult msgPause = MessageBox.Show(
                    Globals.messagePauseTitle, Globals.messagePauseText, MessageBoxButtons.YesNo);
            if (msgPause == DialogResult.Yes)
            {
                startTimerCycle(Process.getState());
            }
            else if (msgPause == DialogResult.No)
            {
                Globals.setTimeMinutes = UserMode.cycleWork;
                btnTimerWorkCycle.BackColor = Color.DodgerBlue;
                btnTimerWorkCycle.Text = Globals.pauseText;
                setDataForTimeCycle();
            }
        }
        //////////////////////////
        ///SETTINGS FOR SCREEN///
        ////////////////////////
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
        private void leaveFullScreen_Click(object sender, EventArgs e)
        {
            leavefullScreenMode();          
        }
        private Rectangle GetScreen()
        {
            return Screen.FromControl(this).Bounds;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                //cp.Style &= ~0x02000000; // Turn off WS_CLIPCHILDREN
                return cp;
            }
        }
        ///////////////////////
        ///CONTROL LISTENERS///
        //////////////////////
        private void btnStartCycle_Click(object sender, EventArgs e)
        {
            startTimerCycle(Process.getState());
        }
        private void flowLayoutPanelMain_Resize(object sender, EventArgs e)
        {
            flowLayoutPanelMain.Left = (this.ClientSize.Width - flowLayoutPanelMain.Size.Width) / 2;
        }
        private void radioBtnModeIntense_CheckedChanged(object sender, EventArgs e)
        {
            UserMode.cyclePause = ModeList.hardMode.getCycles()[0];
            UserMode.cycleWork = ModeList.hardMode.getCycles()[1];
        }
        private void radioBtnModeLight_CheckedChanged(object sender, EventArgs e)
        {
            UserMode.cyclePause = ModeList.lightMode.getCycles()[0];
            UserMode.cycleWork = ModeList.lightMode.getCycles()[1];
        }
        private void radioBtnModeCustom_CheckedChanged(object sender, EventArgs e)
        {
            setLockNumericUpDown(radioBtnModeICustom.Checked);
        }
        private void setLockNumericUpDown(bool btnChecked) {
            numericUpDownWork.ReadOnly = !btnChecked;
            numericUpDownPause.ReadOnly = !btnChecked;
            numericUpDownWork.Increment = btnChecked ? 1 :  0;
            numericUpDownPause.Increment = btnChecked ? 1 : 0;
        }
        private void numericUpDownWork_ValueChanged(object sender, EventArgs e)
        {
            int customWork = (int)numericUpDownWork.Value;
            eyesightapp.Properties.Settings.Default.customWork = customWork;
            eyesightapp.Properties.Settings.Default.Save();
            ModeList.userMode.setCycleWork(eyesightapp.Properties.Settings.Default.customWork);
            UserMode.cycleWork = ModeList.userMode.getCycles()[1];
        }
        private void numericUpDownPause_ValueChanged(object sender, EventArgs e)
        {
            int customPause = (int)numericUpDownPause.Value;
            eyesightapp.Properties.Settings.Default.customPause = customPause;
            eyesightapp.Properties.Settings.Default.Save();
            ModeList.userMode.setCyclePause(eyesightapp.Properties.Settings.Default.customPause);
            UserMode.cyclePause = ModeList.userMode.getCycles()[0];
        }
        ///////////////////////////
        /// FUNCTIONS FOR DEBUG///
        //////////////////////////
        private void debugMode(bool debugMode)
        {
            if (debugMode)
            {
                Globals.debugMode = true;
                UserMode.cyclePause = ModeList.debugMode.getCycles()[0];
                UserMode.cycleWork = ModeList.debugMode.getCycles()[1];
            }
        }    
        private void debugScreen() {
            String x1 = Screen.PrimaryScreen.Bounds.Width.ToString();
            String x2 = Screen.PrimaryScreen.Bounds.Width.ToString();
            String y1 = Screen.PrimaryScreen.Bounds.Height.ToString();
            String y2 = Screen.PrimaryScreen.Bounds.Height.ToString();
            MessageBox.Show("Height" + this.Height + " " + y1 + " " + y2
                +" "+ "Width" + this.Width + " " + x1 + " " + x2);
        }
        private void debugResourses()
        {
            string[] debug = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            foreach (var item in debug)
            {
                Debug.WriteLine(item.ToString());
            }
        }
    }
    static class Process
    {
        private static State state;
        public static void setState(State state)
        {
            Process.state = state;
        }
        public static State getState()
        {
            return Process.state;
        }
    }
    class UserMode
    {
        public static int cyclePause = ModeList.hardMode.getCycles()[0];
        public static int cycleWork = ModeList.hardMode.getCycles()[1];
    }
    static class ModeList
    {
        public static readonly WorkMode hardMode = new WorkMode(7, 27);
        public static readonly WorkMode lightMode = new WorkMode(5, 15);
        public static readonly WorkMode debugMode = new WorkMode(1, 2);
        public static WorkMode userMode = new WorkMode(eyesightapp.Properties.Settings.Default.customPause, eyesightapp.Properties.Settings.Default.customWork);
    }
    class WorkMode
    {
        private int cyclePause;
        private int cycleWork;
        public WorkMode(int pause, int work)
        {
            this.cyclePause = pause;
            this.cycleWork = work;
        }
        public void setCycleWork(int work)
        {
            this.cycleWork = work;
        }
        public void setCyclePause(int pause)
        {
            this.cyclePause = pause;
        }    
        public int[] getCycles()
        {
            return new[] { this.cyclePause, this.cycleWork };
        }
    }
    enum State { Pause, Work, InActive };
    class Globals
    {
        public static bool debugMode = false;
        public static bool cancelBreak = false;
        public static int setTimeMinutes;
        public static int initCountDown;
        public const int minuteTime = 1000 * 60;
        public static int customWork = eyesightapp.Properties.Settings.Default.customWork;
        public static int customPause = eyesightapp.Properties.Settings.Default.customPause;
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
    }

}