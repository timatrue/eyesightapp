namespace WindowsFormsApplication2
{
    partial class FormWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWindow));
            this.timerWindowApp = new System.Windows.Forms.Timer(this.components);
            this.timerDisplayCountDown = new System.Windows.Forms.Timer(this.components);
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.radioBtnModeIntense = new System.Windows.Forms.RadioButton();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownWork = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPause = new System.Windows.Forms.NumericUpDown();
            this.radioBtnModelRelax = new System.Windows.Forms.RadioButton();
            this.radioBtnModeICustom = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanelControl = new System.Windows.Forms.FlowLayoutPanel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnTimerWorkCycle = new System.Windows.Forms.Button();
            this.countDownWorkLabel = new System.Windows.Forms.Label();
            this.stateDebugLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelExercise = new System.Windows.Forms.FlowLayoutPanel();
            this.leaveFullScreenImage = new System.Windows.Forms.PictureBox();
            this.controlFullViewPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxMode.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPause)).BeginInit();
            this.flowLayoutPanelControl.SuspendLayout();
            this.flowLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveFullScreenImage)).BeginInit();
            this.controlFullViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerWindowApp
            // 
            this.timerWindowApp.Interval = 5000;
            this.timerWindowApp.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // timerDisplayCountDown
            // 
            this.timerDisplayCountDown.Interval = 1000;
            this.timerDisplayCountDown.Tick += new System.EventHandler(this.timerMinuteLeft_Tick);
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentDateLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.currentDateLabel.Location = new System.Drawing.Point(3, 10);
            this.currentDateLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(240, 19);
            this.currentDateLabel.TabIndex = 5;
            this.currentDateLabel.Text = "dateLabel";
            this.currentDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioBtnModeIntense
            // 
            this.radioBtnModeIntense.AutoSize = true;
            this.radioBtnModeIntense.Checked = true;
            this.radioBtnModeIntense.Location = new System.Drawing.Point(20, 20);
            this.radioBtnModeIntense.Name = "radioBtnModeIntense";
            this.radioBtnModeIntense.Size = new System.Drawing.Size(112, 22);
            this.radioBtnModeIntense.TabIndex = 6;
            this.radioBtnModeIntense.TabStop = true;
            this.radioBtnModeIntense.Text = "Intense work";
            this.radioBtnModeIntense.UseVisualStyleBackColor = true;
            this.radioBtnModeIntense.CheckedChanged += new System.EventHandler(this.radioBtnModeIntense_CheckedChanged);
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxMode.Controls.Add(this.panel1);
            this.groupBoxMode.Controls.Add(this.radioBtnModelRelax);
            this.groupBoxMode.Controls.Add(this.radioBtnModeIntense);
            this.groupBoxMode.Controls.Add(this.radioBtnModeICustom);
            this.groupBoxMode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMode.Location = new System.Drawing.Point(28, 46);
            this.groupBoxMode.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(189, 168);
            this.groupBoxMode.TabIndex = 7;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Choose mode:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDownWork);
            this.panel1.Controls.Add(this.numericUpDownPause);
            this.panel1.Location = new System.Drawing.Point(39, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 69);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Pause min.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Work min.";
            // 
            // numericUpDownWork
            // 
            this.numericUpDownWork.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownWork.Location = new System.Drawing.Point(87, 8);
            this.numericUpDownWork.Name = "numericUpDownWork";
            this.numericUpDownWork.Size = new System.Drawing.Size(44, 22);
            this.numericUpDownWork.TabIndex = 15;
            this.numericUpDownWork.ValueChanged += new System.EventHandler(this.numericUpDownWork_ValueChanged);
            // 
            // numericUpDownPause
            // 
            this.numericUpDownPause.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPause.Location = new System.Drawing.Point(87, 40);
            this.numericUpDownPause.Name = "numericUpDownPause";
            this.numericUpDownPause.Size = new System.Drawing.Size(44, 22);
            this.numericUpDownPause.TabIndex = 14;
            this.numericUpDownPause.ValueChanged += new System.EventHandler(this.numericUpDownPause_ValueChanged);
            // 
            // radioBtnModelRelax
            // 
            this.radioBtnModelRelax.AutoSize = true;
            this.radioBtnModelRelax.Location = new System.Drawing.Point(20, 48);
            this.radioBtnModelRelax.Name = "radioBtnModelRelax";
            this.radioBtnModelRelax.Size = new System.Drawing.Size(99, 22);
            this.radioBtnModelRelax.TabIndex = 7;
            this.radioBtnModelRelax.Text = "Relaxation";
            this.radioBtnModelRelax.UseVisualStyleBackColor = true;
            this.radioBtnModelRelax.CheckedChanged += new System.EventHandler(this.radioBtnModeLight_CheckedChanged);
            // 
            // radioBtnModeICustom
            // 
            this.radioBtnModeICustom.AutoSize = true;
            this.radioBtnModeICustom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioBtnModeICustom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnModeICustom.Location = new System.Drawing.Point(20, 76);
            this.radioBtnModeICustom.Name = "radioBtnModeICustom";
            this.radioBtnModeICustom.Size = new System.Drawing.Size(130, 22);
            this.radioBtnModeICustom.TabIndex = 16;
            this.radioBtnModeICustom.TabStop = true;
            this.radioBtnModeICustom.Text = "Custom choice";
            this.radioBtnModeICustom.UseVisualStyleBackColor = false;
            this.radioBtnModeICustom.CheckedChanged += new System.EventHandler(this.radioBtnModeCustom_CheckedChanged);
            // 
            // flowLayoutPanelControl
            // 
            this.flowLayoutPanelControl.AutoScroll = true;
            this.flowLayoutPanelControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelControl.Controls.Add(this.currentDateLabel);
            this.flowLayoutPanelControl.Controls.Add(this.splitter1);
            this.flowLayoutPanelControl.Controls.Add(this.groupBoxMode);
            this.flowLayoutPanelControl.Controls.Add(this.btnTimerWorkCycle);
            this.flowLayoutPanelControl.Controls.Add(this.countDownWorkLabel);
            this.flowLayoutPanelControl.Controls.Add(this.stateDebugLabel);
            this.flowLayoutPanelControl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelControl.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanelControl.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanelControl.Name = "flowLayoutPanelControl";
            this.flowLayoutPanelControl.Size = new System.Drawing.Size(248, 308);
            this.flowLayoutPanelControl.TabIndex = 8;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.splitter1.Location = new System.Drawing.Point(3, 32);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(215, 1);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // btnTimerWorkCycle
            // 
            this.btnTimerWorkCycle.BackColor = System.Drawing.Color.Red;
            this.btnTimerWorkCycle.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnTimerWorkCycle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnTimerWorkCycle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnTimerWorkCycle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimerWorkCycle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimerWorkCycle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimerWorkCycle.Location = new System.Drawing.Point(0, 227);
            this.btnTimerWorkCycle.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnTimerWorkCycle.Name = "btnTimerWorkCycle";
            this.btnTimerWorkCycle.Size = new System.Drawing.Size(246, 30);
            this.btnTimerWorkCycle.TabIndex = 1;
            this.btnTimerWorkCycle.UseVisualStyleBackColor = false;
            this.btnTimerWorkCycle.Click += new System.EventHandler(this.btnStartCycle_Click);
            // 
            // countDownWorkLabel
            // 
            this.countDownWorkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countDownWorkLabel.AutoSize = true;
            this.countDownWorkLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDownWorkLabel.Location = new System.Drawing.Point(55, 267);
            this.countDownWorkLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.countDownWorkLabel.Name = "countDownWorkLabel";
            this.countDownWorkLabel.Size = new System.Drawing.Size(135, 19);
            this.countDownWorkLabel.TabIndex = 9;
            this.countDownWorkLabel.Text = "timer is  stopped";
            // 
            // stateDebugLabel
            // 
            this.stateDebugLabel.AutoSize = true;
            this.stateDebugLabel.Location = new System.Drawing.Point(3, 286);
            this.stateDebugLabel.Name = "stateDebugLabel";
            this.stateDebugLabel.Size = new System.Drawing.Size(0, 13);
            this.stateDebugLabel.TabIndex = 11;
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelMain.Controls.Add(this.flowLayoutPanelControl);
            this.flowLayoutPanelMain.Controls.Add(this.flowLayoutPanelExercise);
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(0, 39);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(500, 310);
            this.flowLayoutPanelMain.TabIndex = 9;
            // 
            // flowLayoutPanelExercise
            // 
            this.flowLayoutPanelExercise.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanelExercise.BackgroundImage = global::eyesightapp.Properties.Resources.appBg;
            this.flowLayoutPanelExercise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanelExercise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelExercise.Location = new System.Drawing.Point(251, 1);
            this.flowLayoutPanelExercise.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanelExercise.Name = "flowLayoutPanelExercise";
            this.flowLayoutPanelExercise.Size = new System.Drawing.Size(248, 308);
            this.flowLayoutPanelExercise.TabIndex = 9;
            // 
            // leaveFullScreenImage
            // 
            this.leaveFullScreenImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.leaveFullScreenImage.BackColor = System.Drawing.Color.Transparent;
            this.leaveFullScreenImage.BackgroundImage = global::eyesightapp.Properties.Resources.icon_close;
            this.leaveFullScreenImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leaveFullScreenImage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.leaveFullScreenImage.Location = new System.Drawing.Point(666, 0);
            this.leaveFullScreenImage.Margin = new System.Windows.Forms.Padding(0);
            this.leaveFullScreenImage.Name = "leaveFullScreenImage";
            this.leaveFullScreenImage.Size = new System.Drawing.Size(20, 20);
            this.leaveFullScreenImage.TabIndex = 10;
            this.leaveFullScreenImage.TabStop = false;
            // 
            // controlFullViewPanel
            // 
            this.controlFullViewPanel.AutoScroll = true;
            this.controlFullViewPanel.AutoSize = true;
            this.controlFullViewPanel.BackColor = System.Drawing.Color.Transparent;
            this.controlFullViewPanel.Controls.Add(this.leaveFullScreenImage);
            this.controlFullViewPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlFullViewPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.controlFullViewPanel.Location = new System.Drawing.Point(0, 0);
            this.controlFullViewPanel.Name = "controlFullViewPanel";
            this.controlFullViewPanel.Size = new System.Drawing.Size(686, 20);
            this.controlFullViewPanel.TabIndex = 13;
            // 
            // FormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::eyesightapp.Properties.Resources.city_night_sea;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 331);
            this.Controls.Add(this.controlFullViewPanel);
            this.Controls.Add(this.flowLayoutPanelMain);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EyeSight";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPause)).EndInit();
            this.flowLayoutPanelControl.ResumeLayout(false);
            this.flowLayoutPanelControl.PerformLayout();
            this.flowLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leaveFullScreenImage)).EndInit();
            this.controlFullViewPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerWindowApp;
        private System.Windows.Forms.Timer timerDisplayCountDown;
        private System.Windows.Forms.Label currentDateLabel;
        private System.Windows.Forms.RadioButton radioBtnModeIntense;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.RadioButton radioBtnModelRelax;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelControl;
        private System.Windows.Forms.Button btnTimerWorkCycle;
        private System.Windows.Forms.Label countDownWorkLabel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelExercise;
        private System.Windows.Forms.PictureBox leaveFullScreenImage;
        private System.Windows.Forms.FlowLayoutPanel controlFullViewPanel;
        private System.Windows.Forms.Label stateDebugLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownPause;
        private System.Windows.Forms.NumericUpDown numericUpDownWork;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBtnModeICustom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

