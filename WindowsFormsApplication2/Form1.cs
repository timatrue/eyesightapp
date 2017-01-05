using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;

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
            flowLayoutPanelMain.Left = (this.ClientSize.Width - flowLayoutPanelMain.Size.Width) / 2;
            //Handlers
            panelScreenMode.MouseMove += new MouseEventHandler(panelTest_MouseMove);
            btnScreenMode.MouseLeave += new EventHandler(panelTest_MouseLeave);
            this.Resize += new EventHandler(flowLayoutPanelMain_Resize);
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
                Globals.setTimeMinutes = UserInput.cycleWork;
                
            }
            else
            {
                Globals.setTimeMinutes = UserInput.cyclePause;
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
        private void flowLayoutPanelMain_Resize(object sender, EventArgs e)
        {
            flowLayoutPanelMain.Left = (this.ClientSize.Width - flowLayoutPanelMain.Size.Width) / 2;
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

        private class Globals
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
        private class UserInput
        {
            public static int cyclePause;
            public static int cycleWork;
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private RadioButton searchCheckedRadio() {

            var radioButtonSelected = groupBoxMode.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            return radioButtonSelected;
        }
        private void currentDateLabel_Click(object sender, EventArgs e)
        {

        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UserInput.cyclePause = 7;
            UserInput.cycleWork = 27;
               
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UserInput.cyclePause = 10;
            UserInput.cycleWork = 45;
        }
    }
}