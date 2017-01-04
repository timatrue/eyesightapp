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
            this.labelCountDownWork = new System.Windows.Forms.Label();
            this.btnTimerWorkCycle = new System.Windows.Forms.Button();
            this.timerWindowApp = new System.Windows.Forms.Timer(this.components);
            this.timerDisplayCountDown = new System.Windows.Forms.Timer(this.components);
            this.btnScreenMode = new System.Windows.Forms.Button();
            this.panelScreenMode = new System.Windows.Forms.Panel();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.panelScreenMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCountDownWork
            // 
            this.labelCountDownWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCountDownWork.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountDownWork.Location = new System.Drawing.Point(0, 0);
            this.labelCountDownWork.Margin = new System.Windows.Forms.Padding(3, 100, 3, 0);
            this.labelCountDownWork.Name = "labelCountDownWork";
            this.labelCountDownWork.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.labelCountDownWork.Size = new System.Drawing.Size(484, 461);
            this.labelCountDownWork.TabIndex = 0;
            this.labelCountDownWork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCountDownWork.Click += new System.EventHandler(this.labelCountDownWork_Click);
            // 
            // btnTimerWorkCycle
            // 
            this.btnTimerWorkCycle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimerWorkCycle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTimerWorkCycle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimerWorkCycle.Location = new System.Drawing.Point(194, 124);
            this.btnTimerWorkCycle.Margin = new System.Windows.Forms.Padding(5);
            this.btnTimerWorkCycle.Name = "btnTimerWorkCycle";
            this.btnTimerWorkCycle.Size = new System.Drawing.Size(100, 30);
            this.btnTimerWorkCycle.TabIndex = 1;
            this.btnTimerWorkCycle.Text = "start timer";
            this.btnTimerWorkCycle.UseVisualStyleBackColor = false;
            this.btnTimerWorkCycle.Click += new System.EventHandler(this.button1_Click);
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
            // btnScreenMode
            // 
            this.btnScreenMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScreenMode.Location = new System.Drawing.Point(0, 0);
            this.btnScreenMode.Name = "btnScreenMode";
            this.btnScreenMode.Size = new System.Drawing.Size(105, 25);
            this.btnScreenMode.TabIndex = 4;
            this.btnScreenMode.Text = "Leave Full Screen";
            this.btnScreenMode.UseVisualStyleBackColor = true;
            this.btnScreenMode.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // panelScreenMode
            // 
            this.panelScreenMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelScreenMode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelScreenMode.Controls.Add(this.btnScreenMode);
            this.panelScreenMode.Location = new System.Drawing.Point(377, 5);
            this.panelScreenMode.Name = "panelScreenMode";
            this.panelScreenMode.Size = new System.Drawing.Size(105, 25);
            this.panelScreenMode.TabIndex = 4;
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateLabel.Location = new System.Drawing.Point(1, 0);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.currentDateLabel.Size = new System.Drawing.Size(50, 38);
            this.currentDateLabel.TabIndex = 5;
            this.currentDateLabel.Text = "label1";
            this.currentDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.currentDateLabel);
            this.Controls.Add(this.panelScreenMode);
            this.Controls.Add(this.btnTimerWorkCycle);
            this.Controls.Add(this.labelCountDownWork);
            this.Name = "FormWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelScreenMode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCountDownWork;
        private System.Windows.Forms.Button btnTimerWorkCycle;
        private System.Windows.Forms.Timer timerWindowApp;
        private System.Windows.Forms.Timer timerDisplayCountDown;
        private System.Windows.Forms.Button btnScreenMode;
        private System.Windows.Forms.Panel panelScreenMode;
        private System.Windows.Forms.Label currentDateLabel;
    }
}

