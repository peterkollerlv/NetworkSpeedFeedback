namespace NetworkSpeedFeedback
{
    partial class NetworkSpeedFeedback
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
            this.Feedback = new System.Windows.Forms.Label();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.TotalThrougput = new System.Windows.Forms.Label();
            this.AdapterSpeed = new System.Windows.Forms.Label();
            this.FeedbackBandwith = new System.Windows.Forms.Label();
            this.PingToGoogle = new System.Windows.Forms.Label();
            this.FeedbackLatency = new System.Windows.Forms.Label();
            this.LatencyTarget = new System.Windows.Forms.Label();
            this.ToggleControls = new System.Windows.Forms.Button();
            this.ExitApplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Feedback
            // 
            this.Feedback.AutoSize = true;
            this.Feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Feedback.ForeColor = System.Drawing.Color.DarkCyan;
            this.Feedback.Location = new System.Drawing.Point(168, 37);
            this.Feedback.Name = "Feedback";
            this.Feedback.Size = new System.Drawing.Size(59, 20);
            this.Feedback.TabIndex = 1;
            this.Feedback.Text = "(label)";
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Interval = 500;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // TotalThrougput
            // 
            this.TotalThrougput.AutoSize = true;
            this.TotalThrougput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TotalThrougput.ForeColor = System.Drawing.Color.DarkCyan;
            this.TotalThrougput.Location = new System.Drawing.Point(12, 37);
            this.TotalThrougput.Name = "TotalThrougput";
            this.TotalThrougput.Size = new System.Drawing.Size(150, 20);
            this.TotalThrougput.TabIndex = 4;
            this.TotalThrougput.Text = "Data Throughput:";
            // 
            // AdapterSpeed
            // 
            this.AdapterSpeed.AutoSize = true;
            this.AdapterSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdapterSpeed.ForeColor = System.Drawing.Color.DarkCyan;
            this.AdapterSpeed.Location = new System.Drawing.Point(12, 57);
            this.AdapterSpeed.Name = "AdapterSpeed";
            this.AdapterSpeed.Size = new System.Drawing.Size(88, 20);
            this.AdapterSpeed.TabIndex = 5;
            this.AdapterSpeed.Text = "Bandwith:";
            // 
            // FeedbackBandwith
            // 
            this.FeedbackBandwith.AutoSize = true;
            this.FeedbackBandwith.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FeedbackBandwith.ForeColor = System.Drawing.Color.DarkCyan;
            this.FeedbackBandwith.Location = new System.Drawing.Point(168, 57);
            this.FeedbackBandwith.Name = "FeedbackBandwith";
            this.FeedbackBandwith.Size = new System.Drawing.Size(59, 20);
            this.FeedbackBandwith.TabIndex = 6;
            this.FeedbackBandwith.Text = "(label)";
            // 
            // PingToGoogle
            // 
            this.PingToGoogle.AutoSize = true;
            this.PingToGoogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PingToGoogle.ForeColor = System.Drawing.Color.DarkCyan;
            this.PingToGoogle.Location = new System.Drawing.Point(12, 77);
            this.PingToGoogle.Name = "PingToGoogle";
            this.PingToGoogle.Size = new System.Drawing.Size(77, 20);
            this.PingToGoogle.TabIndex = 7;
            this.PingToGoogle.Text = "Latency:";
            // 
            // FeedbackLatency
            // 
            this.FeedbackLatency.AutoSize = true;
            this.FeedbackLatency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FeedbackLatency.ForeColor = System.Drawing.Color.DarkCyan;
            this.FeedbackLatency.Location = new System.Drawing.Point(168, 77);
            this.FeedbackLatency.Name = "FeedbackLatency";
            this.FeedbackLatency.Size = new System.Drawing.Size(59, 20);
            this.FeedbackLatency.TabIndex = 8;
            this.FeedbackLatency.Text = "(label)";
            // 
            // LatencyTarget
            // 
            this.LatencyTarget.AutoSize = true;
            this.LatencyTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LatencyTarget.ForeColor = System.Drawing.Color.DarkCyan;
            this.LatencyTarget.Location = new System.Drawing.Point(12, 97);
            this.LatencyTarget.Name = "LatencyTarget";
            this.LatencyTarget.Size = new System.Drawing.Size(59, 20);
            this.LatencyTarget.TabIndex = 9;
            this.LatencyTarget.Text = "(label)";
            // 
            // ToggleControls
            // 
            this.ToggleControls.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ToggleControls.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToggleControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ToggleControls.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ToggleControls.Location = new System.Drawing.Point(214, 4);
            this.ToggleControls.Name = "ToggleControls";
            this.ToggleControls.Size = new System.Drawing.Size(25, 25);
            this.ToggleControls.TabIndex = 10;
            this.ToggleControls.Text = "^";
            this.ToggleControls.UseVisualStyleBackColor = false;
            this.ToggleControls.Click += new System.EventHandler(this.ToggleControls_Click);
            // 
            // ExitApplication
            // 
            this.ExitApplication.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ExitApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitApplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExitApplication.ForeColor = System.Drawing.Color.Red;
            this.ExitApplication.Location = new System.Drawing.Point(245, 4);
            this.ExitApplication.Name = "ExitApplication";
            this.ExitApplication.Size = new System.Drawing.Size(25, 25);
            this.ExitApplication.TabIndex = 11;
            this.ExitApplication.Text = "x";
            this.ExitApplication.UseVisualStyleBackColor = false;
            this.ExitApplication.Click += new System.EventHandler(this.ExitApplication_Click);
            // 
            // NetworkSpeedFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 133);
            this.Controls.Add(this.ExitApplication);
            this.Controls.Add(this.ToggleControls);
            this.Controls.Add(this.LatencyTarget);
            this.Controls.Add(this.FeedbackLatency);
            this.Controls.Add(this.PingToGoogle);
            this.Controls.Add(this.FeedbackBandwith);
            this.Controls.Add(this.AdapterSpeed);
            this.Controls.Add(this.TotalThrougput);
            this.Controls.Add(this.Feedback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NetworkSpeedFeedback";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ToggleControls;
        internal System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.Button ExitApplication;
        internal System.Windows.Forms.Label PingToGoogle;
        internal System.Windows.Forms.Label FeedbackLatency;
        internal System.Windows.Forms.Label LatencyTarget;
        internal System.Windows.Forms.Label Feedback;
        internal System.Windows.Forms.Label TotalThrougput;
        internal System.Windows.Forms.Label AdapterSpeed;
        internal System.Windows.Forms.Label FeedbackBandwith;
    }
}

