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
            this.SuspendLayout();
            // 
            // labelCountDownWork
            // 
            this.labelCountDownWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCountDownWork.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountDownWork.Location = new System.Drawing.Point(0, 0);
            this.labelCountDownWork.Margin = new System.Windows.Forms.Padding(3, 100, 3, 0);
            this.labelCountDownWork.Name = "labelCountDownWork";
            this.labelCountDownWork.Size = new System.Drawing.Size(484, 461);
            this.labelCountDownWork.TabIndex = 0;
            this.labelCountDownWork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCountDownWork.Click += new System.EventHandler(this.labelCountDownWork_Click);
            // 
            // btnTimerWorkCycle
            // 
            this.btnTimerWorkCycle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimerWorkCycle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimerWorkCycle.Location = new System.Drawing.Point(194, 124);
            this.btnTimerWorkCycle.Name = "btnTimerWorkCycle";
            this.btnTimerWorkCycle.Size = new System.Drawing.Size(100, 25);
            this.btnTimerWorkCycle.TabIndex = 1;
            this.btnTimerWorkCycle.Text = "start timer";
            this.btnTimerWorkCycle.UseVisualStyleBackColor = true;
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
            // FormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnTimerWorkCycle);
            this.Controls.Add(this.labelCountDownWork);
            this.Name = "FormWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCountDownWork;
        private System.Windows.Forms.Button btnTimerWorkCycle;
        private System.Windows.Forms.Timer timerWindowApp;
        private System.Windows.Forms.Timer timerDisplayCountDown;
    }
}

