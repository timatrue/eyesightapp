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
            this.timerWindowApp = new System.Windows.Forms.Timer(this.components);
            this.timerDisplayCountDown = new System.Windows.Forms.Timer(this.components);
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanelControl = new System.Windows.Forms.FlowLayoutPanel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnTimerWorkCycle = new System.Windows.Forms.Button();
            this.countDownWorkLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelExercise = new System.Windows.Forms.FlowLayoutPanel();
            this.leaveFullScreenImage = new System.Windows.Forms.PictureBox();
            this.groupBoxMode.SuspendLayout();
            this.flowLayoutPanelControl.SuspendLayout();
            this.flowLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveFullScreenImage)).BeginInit();
            this.SuspendLayout();
            // 
            // timerWindowApp
            // 
            this.timerWindowApp.Interval = 5000;
            this.timerWindowApp.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerDisplayCountDown
            // 
            this.timerDisplayCountDown.Interval = 1000;
            this.timerDisplayCountDown.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateLabel.Location = new System.Drawing.Point(71, 10);
            this.currentDateLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(78, 18);
            this.currentDateLabel.TabIndex = 5;
            this.currentDateLabel.Text = "dateLabel";
            this.currentDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.currentDateLabel.Click += new System.EventHandler(this.currentDateLabel_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(112, 22);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Intense work";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxMode.Controls.Add(this.radioButton2);
            this.groupBoxMode.Controls.Add(this.radioButton1);
            this.groupBoxMode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMode.Location = new System.Drawing.Point(27, 45);
            this.groupBoxMode.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(167, 78);
            this.groupBoxMode.TabIndex = 7;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Choose mode:";
            this.groupBoxMode.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 22);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "Relaxation";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // flowLayoutPanelControl
            // 
            this.flowLayoutPanelControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanelControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanelControl.Controls.Add(this.currentDateLabel);
            this.flowLayoutPanelControl.Controls.Add(this.splitter1);
            this.flowLayoutPanelControl.Controls.Add(this.groupBoxMode);
            this.flowLayoutPanelControl.Controls.Add(this.btnTimerWorkCycle);
            this.flowLayoutPanelControl.Controls.Add(this.countDownWorkLabel);
            this.flowLayoutPanelControl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelControl.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelControl.Name = "flowLayoutPanelControl";
            this.flowLayoutPanelControl.Size = new System.Drawing.Size(215, 240);
            this.flowLayoutPanelControl.TabIndex = 8;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.splitter1.Location = new System.Drawing.Point(3, 31);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(215, 1);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // btnTimerWorkCycle
            // 
            this.btnTimerWorkCycle.BackColor = System.Drawing.Color.Crimson;
            this.btnTimerWorkCycle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimerWorkCycle.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnTimerWorkCycle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnTimerWorkCycle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnTimerWorkCycle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimerWorkCycle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimerWorkCycle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimerWorkCycle.Location = new System.Drawing.Point(0, 136);
            this.btnTimerWorkCycle.Margin = new System.Windows.Forms.Padding(0, 10, 5, 0);
            this.btnTimerWorkCycle.Name = "btnTimerWorkCycle";
            this.btnTimerWorkCycle.Size = new System.Drawing.Size(216, 30);
            this.btnTimerWorkCycle.TabIndex = 1;
            this.btnTimerWorkCycle.Text = "start timer";
            this.btnTimerWorkCycle.UseVisualStyleBackColor = false;
            this.btnTimerWorkCycle.Click += new System.EventHandler(this.button1_Click);
            // 
            // countDownWorkLabel
            // 
            this.countDownWorkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countDownWorkLabel.AutoSize = true;
            this.countDownWorkLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDownWorkLabel.Location = new System.Drawing.Point(43, 176);
            this.countDownWorkLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.countDownWorkLabel.Name = "countDownWorkLabel";
            this.countDownWorkLabel.Size = new System.Drawing.Size(135, 19);
            this.countDownWorkLabel.TabIndex = 9;
            this.countDownWorkLabel.Text = "timer is  stopped";
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.Controls.Add(this.flowLayoutPanelControl);
            this.flowLayoutPanelMain.Controls.Add(this.flowLayoutPanelExercise);
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(12, 36);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(430, 244);
            this.flowLayoutPanelMain.TabIndex = 9;
            // 
            // flowLayoutPanelExercise
            // 
            this.flowLayoutPanelExercise.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanelExercise.BackgroundImage = global::eyesightapp.Properties.Resources.appBg;
            this.flowLayoutPanelExercise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanelExercise.Location = new System.Drawing.Point(224, 3);
            this.flowLayoutPanelExercise.Name = "flowLayoutPanelExercise";
            this.flowLayoutPanelExercise.Size = new System.Drawing.Size(197, 240);
            this.flowLayoutPanelExercise.TabIndex = 9;
            // 
            // leaveFullScreenImage
            // 
            this.leaveFullScreenImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.leaveFullScreenImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.leaveFullScreenImage.BackgroundImage = global::eyesightapp.Properties.Resources.leave_full_screen_mode;
            this.leaveFullScreenImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leaveFullScreenImage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.leaveFullScreenImage.Location = new System.Drawing.Point(455, 10);
            this.leaveFullScreenImage.Margin = new System.Windows.Forms.Padding(0);
            this.leaveFullScreenImage.Name = "leaveFullScreenImage";
            this.leaveFullScreenImage.Size = new System.Drawing.Size(20, 20);
            this.leaveFullScreenImage.TabIndex = 10;
            this.leaveFullScreenImage.TabStop = false;
            // 
            // FormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.leaveFullScreenImage);
            this.Controls.Add(this.flowLayoutPanelMain);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "FormWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            this.flowLayoutPanelControl.ResumeLayout(false);
            this.flowLayoutPanelControl.PerformLayout();
            this.flowLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leaveFullScreenImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerWindowApp;
        private System.Windows.Forms.Timer timerDisplayCountDown;
        private System.Windows.Forms.Label currentDateLabel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelControl;
        private System.Windows.Forms.Button btnTimerWorkCycle;
        private System.Windows.Forms.Label countDownWorkLabel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelExercise;
        private System.Windows.Forms.PictureBox leaveFullScreenImage;
    }
}

