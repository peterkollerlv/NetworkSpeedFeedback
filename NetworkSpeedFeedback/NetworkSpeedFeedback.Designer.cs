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
            this.NetworkInterfaces = new System.Windows.Forms.ComboBox();
            this.Feedback = new System.Windows.Forms.Label();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.GetNetworkAdapters = new System.Windows.Forms.Button();
            this.ToggleOnOff = new System.Windows.Forms.Button();
            this.TotalThrougput = new System.Windows.Forms.Label();
            this.AdapterSpeed = new System.Windows.Forms.Label();
            this.FeedbackBandwith = new System.Windows.Forms.Label();
            this.PingToGoogle = new System.Windows.Forms.Label();
            this.FeedbackLatency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NetworkInterfaces
            // 
            this.NetworkInterfaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NetworkInterfaces.FormattingEnabled = true;
            this.NetworkInterfaces.Location = new System.Drawing.Point(12, 12);
            this.NetworkInterfaces.Name = "NetworkInterfaces";
            this.NetworkInterfaces.Size = new System.Drawing.Size(294, 21);
            this.NetworkInterfaces.TabIndex = 0;
            this.NetworkInterfaces.SelectedIndexChanged += new System.EventHandler(this.NetworkInterfaces_SelectedIndexChanged);
            // 
            // Feedback
            // 
            this.Feedback.AutoSize = true;
            this.Feedback.Location = new System.Drawing.Point(187, 45);
            this.Feedback.Name = "Feedback";
            this.Feedback.Size = new System.Drawing.Size(35, 13);
            this.Feedback.TabIndex = 1;
            this.Feedback.Text = "(label)";
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Interval = 500;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // GetNetworkAdapters
            // 
            this.GetNetworkAdapters.Location = new System.Drawing.Point(12, 139);
            this.GetNetworkAdapters.Name = "GetNetworkAdapters";
            this.GetNetworkAdapters.Size = new System.Drawing.Size(160, 23);
            this.GetNetworkAdapters.TabIndex = 2;
            this.GetNetworkAdapters.Text = "Refresh Network Adapter List";
            this.GetNetworkAdapters.UseVisualStyleBackColor = true;
            this.GetNetworkAdapters.Click += new System.EventHandler(this.GetNetworkAdapters_Click);
            // 
            // ToggleOnOff
            // 
            this.ToggleOnOff.Location = new System.Drawing.Point(178, 139);
            this.ToggleOnOff.Name = "ToggleOnOff";
            this.ToggleOnOff.Size = new System.Drawing.Size(94, 23);
            this.ToggleOnOff.TabIndex = 3;
            this.ToggleOnOff.Text = "Start";
            this.ToggleOnOff.UseVisualStyleBackColor = true;
            this.ToggleOnOff.Click += new System.EventHandler(this.ToggleOnOff_Click);
            // 
            // TotalThrougput
            // 
            this.TotalThrougput.AutoSize = true;
            this.TotalThrougput.Location = new System.Drawing.Point(9, 45);
            this.TotalThrougput.Name = "TotalThrougput";
            this.TotalThrougput.Size = new System.Drawing.Size(91, 13);
            this.TotalThrougput.TabIndex = 4;
            this.TotalThrougput.Text = "Data Throughput:";
            // 
            // AdapterSpeed
            // 
            this.AdapterSpeed.AutoSize = true;
            this.AdapterSpeed.Location = new System.Drawing.Point(9, 58);
            this.AdapterSpeed.Name = "AdapterSpeed";
            this.AdapterSpeed.Size = new System.Drawing.Size(54, 13);
            this.AdapterSpeed.TabIndex = 5;
            this.AdapterSpeed.Text = "Bandwith:";
            // 
            // FeedbackBandwith
            // 
            this.FeedbackBandwith.AutoSize = true;
            this.FeedbackBandwith.Location = new System.Drawing.Point(187, 58);
            this.FeedbackBandwith.Name = "FeedbackBandwith";
            this.FeedbackBandwith.Size = new System.Drawing.Size(35, 13);
            this.FeedbackBandwith.TabIndex = 6;
            this.FeedbackBandwith.Text = "(label)";
            // 
            // PingToGoogle
            // 
            this.PingToGoogle.AutoSize = true;
            this.PingToGoogle.Location = new System.Drawing.Point(12, 89);
            this.PingToGoogle.Name = "PingToGoogle";
            this.PingToGoogle.Size = new System.Drawing.Size(133, 13);
            this.PingToGoogle.TabIndex = 7;
            this.PingToGoogle.Text = "Lateny (www.google.com):";
            // 
            // FeedbackLatency
            // 
            this.FeedbackLatency.AutoSize = true;
            this.FeedbackLatency.Location = new System.Drawing.Point(187, 89);
            this.FeedbackLatency.Name = "FeedbackLatency";
            this.FeedbackLatency.Size = new System.Drawing.Size(35, 13);
            this.FeedbackLatency.TabIndex = 8;
            this.FeedbackLatency.Text = "(label)";
            // 
            // NetworkSpeedFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 182);
            this.Controls.Add(this.FeedbackLatency);
            this.Controls.Add(this.PingToGoogle);
            this.Controls.Add(this.FeedbackBandwith);
            this.Controls.Add(this.AdapterSpeed);
            this.Controls.Add(this.TotalThrougput);
            this.Controls.Add(this.ToggleOnOff);
            this.Controls.Add(this.GetNetworkAdapters);
            this.Controls.Add(this.Feedback);
            this.Controls.Add(this.NetworkInterfaces);
            this.Name = "NetworkSpeedFeedback";
            this.Text = "Network Adapter Speed Feedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NetworkInterfaces;
        private System.Windows.Forms.Label Feedback;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.Button GetNetworkAdapters;
        private System.Windows.Forms.Button ToggleOnOff;
        private System.Windows.Forms.Label TotalThrougput;
        private System.Windows.Forms.Label AdapterSpeed;
        private System.Windows.Forms.Label FeedbackBandwith;
        private System.Windows.Forms.Label PingToGoogle;
        private System.Windows.Forms.Label FeedbackLatency;
    }
}

