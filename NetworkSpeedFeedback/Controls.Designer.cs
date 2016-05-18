namespace NetworkSpeedFeedback
{
    partial class Controls
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
            this.NetworkInterfaces = new System.Windows.Forms.ComboBox();
            this.GetNetworkAdapters = new System.Windows.Forms.Button();
            this.ToggleOnOff = new System.Windows.Forms.Button();
            this.TextColorLabel = new System.Windows.Forms.Label();
            this.PingTargetLabel = new System.Windows.Forms.Label();
            this.TextColorSelect = new System.Windows.Forms.ComboBox();
            this.PingEnabled = new System.Windows.Forms.CheckBox();
            this.PingTarget = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NetworkInterfaces
            // 
            this.NetworkInterfaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NetworkInterfaces.FormattingEnabled = true;
            this.NetworkInterfaces.Location = new System.Drawing.Point(12, 26);
            this.NetworkInterfaces.Name = "NetworkInterfaces";
            this.NetworkInterfaces.Size = new System.Drawing.Size(294, 21);
            this.NetworkInterfaces.TabIndex = 0;
            this.NetworkInterfaces.SelectedIndexChanged += new System.EventHandler(this.NetworkInterfaces_SelectedIndexChanged);
            // 
            // GetNetworkAdapters
            // 
            this.GetNetworkAdapters.Location = new System.Drawing.Point(12, 155);
            this.GetNetworkAdapters.Name = "GetNetworkAdapters";
            this.GetNetworkAdapters.Size = new System.Drawing.Size(160, 23);
            this.GetNetworkAdapters.TabIndex = 2;
            this.GetNetworkAdapters.Text = "Refresh Network Adapter List";
            this.GetNetworkAdapters.UseVisualStyleBackColor = true;
            this.GetNetworkAdapters.Click += new System.EventHandler(this.GetNetworkAdapters_Click);
            // 
            // ToggleOnOff
            // 
            this.ToggleOnOff.Location = new System.Drawing.Point(207, 155);
            this.ToggleOnOff.Name = "ToggleOnOff";
            this.ToggleOnOff.Size = new System.Drawing.Size(94, 23);
            this.ToggleOnOff.TabIndex = 3;
            this.ToggleOnOff.Text = "Start";
            this.ToggleOnOff.UseVisualStyleBackColor = true;
            this.ToggleOnOff.Click += new System.EventHandler(this.ToggleOnOff_Click);
            // 
            // TextColorLabel
            // 
            this.TextColorLabel.AutoSize = true;
            this.TextColorLabel.Location = new System.Drawing.Point(9, 50);
            this.TextColorLabel.Name = "TextColorLabel";
            this.TextColorLabel.Size = new System.Drawing.Size(55, 13);
            this.TextColorLabel.TabIndex = 4;
            this.TextColorLabel.Text = "Text Color";
            // 
            // PingTargetLabel
            // 
            this.PingTargetLabel.AutoSize = true;
            this.PingTargetLabel.Location = new System.Drawing.Point(9, 113);
            this.PingTargetLabel.Name = "PingTargetLabel";
            this.PingTargetLabel.Size = new System.Drawing.Size(62, 13);
            this.PingTargetLabel.TabIndex = 5;
            this.PingTargetLabel.Text = "Ping Target";
            // 
            // TextColorSelect
            // 
            this.TextColorSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextColorSelect.FormattingEnabled = true;
            this.TextColorSelect.Location = new System.Drawing.Point(12, 66);
            this.TextColorSelect.Name = "TextColorSelect";
            this.TextColorSelect.Size = new System.Drawing.Size(121, 21);
            this.TextColorSelect.TabIndex = 6;
            this.TextColorSelect.SelectedIndexChanged += new System.EventHandler(this.TextColorSelect_SelectedIndexChanged);
            // 
            // PingEnabled
            // 
            this.PingEnabled.AutoSize = true;
            this.PingEnabled.Checked = true;
            this.PingEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PingEnabled.Location = new System.Drawing.Point(12, 93);
            this.PingEnabled.Name = "PingEnabled";
            this.PingEnabled.Size = new System.Drawing.Size(97, 17);
            this.PingEnabled.TabIndex = 7;
            this.PingEnabled.Text = "Enable Pinging";
            this.PingEnabled.UseVisualStyleBackColor = true;
            this.PingEnabled.CheckedChanged += new System.EventHandler(this.PingEnabled_CheckedChanged);
            // 
            // PingTarget
            // 
            this.PingTarget.Location = new System.Drawing.Point(12, 129);
            this.PingTarget.Name = "PingTarget";
            this.PingTarget.Size = new System.Drawing.Size(261, 20);
            this.PingTarget.TabIndex = 8;
            this.PingTarget.Text = "www.google.com";
            this.PingTarget.TextChanged += new System.EventHandler(this.PingTarget_TextChanged);
            // 
            // Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 223);
            this.Controls.Add(this.PingTarget);
            this.Controls.Add(this.PingEnabled);
            this.Controls.Add(this.TextColorSelect);
            this.Controls.Add(this.PingTargetLabel);
            this.Controls.Add(this.TextColorLabel);
            this.Controls.Add(this.NetworkInterfaces);
            this.Controls.Add(this.GetNetworkAdapters);
            this.Controls.Add(this.ToggleOnOff);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Controls";
            this.ShowIcon = false;
            this.Text = "Controls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.ComboBox NetworkInterfaces;
        internal System.Windows.Forms.Button ToggleOnOff;
        internal System.Windows.Forms.Button GetNetworkAdapters;
        private System.Windows.Forms.Label TextColorLabel;
        private System.Windows.Forms.Label PingTargetLabel;
        private System.Windows.Forms.ComboBox TextColorSelect;
        private System.Windows.Forms.CheckBox PingEnabled;
        private System.Windows.Forms.TextBox PingTarget;
    }
}