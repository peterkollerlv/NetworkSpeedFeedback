﻿using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;


namespace NetworkSpeedFeedback
{
    internal partial class Controls : Form
    {
        protected NetworkSpeedFeedback networkSpeedFeedback;
        private bool toggleOnOff;
        private KnownColor[] knownColors;





        public Controls(NetworkSpeedFeedback networkSpeedFeedback)
        {
            this.networkSpeedFeedback = networkSpeedFeedback;
            InitializeComponent();
            PingTarget.Text = networkSpeedFeedback.pingTarget;
            networkSpeedFeedback.LatencyTarget.Text = networkSpeedFeedback.pingTarget;
            toggleOnOff = true;

            System.Array colorsArray = Enum.GetValues(typeof(KnownColor));
            knownColors = new KnownColor[colorsArray.Length];
            Array.Copy(colorsArray, knownColors, colorsArray.Length);
            for (int i = 0; i < knownColors.Length; i++)
            {
                TextColorSelect.Items.Add(knownColors[i].ToString());
            }
            TextColorSelect.SelectedIndex = 49;


            if (networkSpeedFeedback.adapters != null)
            {
                NetworkInterfaces.Items.Clear();
                foreach (NetworkInterface adapter in networkSpeedFeedback.adapters)
                {
                    //if (adapter.Speed > 0)
                    //{
                    NetworkInterfaces.Items.Add(adapter.Description);
                    //}
                }
                NetworkInterfaces.SelectedIndex = 0;
            }
            ToggleTimer();
        }


        private void ToggleOnOff_Click(object sender, EventArgs e)
        {
            ToggleTimer();
        }

        private void ToggleTimer()
        {
            if (toggleOnOff)
            {
                toggleOnOff = false;
                networkSpeedFeedback.bytesReceived = networkSpeedFeedback.selectedAdapter.GetIPv4Statistics().BytesReceived;
                networkSpeedFeedback.RefreshTimer.Start();
                ToggleOnOff.Text = "Stop";
            }
            else
            {
                toggleOnOff = true;
                networkSpeedFeedback.bytesReceived = 0;
                networkSpeedFeedback.RefreshTimer.Stop();
                ToggleOnOff.Text = "Start";
            }
        }

        private void NetworkInterfaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (networkSpeedFeedback.adapters != null)
            {
                networkSpeedFeedback.selectedAdapter = networkSpeedFeedback.adapters[NetworkInterfaces.SelectedIndex];
            }
        }

        private void GetNetworkAdapters_Click(object sender, EventArgs e)
        {
            networkSpeedFeedback.adapters = NetworkInterface.GetAllNetworkInterfaces();
            if (networkSpeedFeedback.adapters != null)
            {
                NetworkInterfaces.Items.Clear();
                foreach (NetworkInterface adapter in networkSpeedFeedback.adapters)
                {
                    NetworkInterfaces.Items.Add(adapter.Description);
                }
            }
        }

        private void TextColorSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control control in networkSpeedFeedback.Controls)
            {
                if (control.GetType() == typeof(Label))
                {
                    control.ForeColor = Color.FromKnownColor(knownColors[TextColorSelect.SelectedIndex]);
                }
            }
        }

        private void PingEnabled_CheckedChanged(object sender, EventArgs e)
        {
            PingTargetLabel.Enabled = PingEnabled.Checked;
            PingTarget.Enabled = PingEnabled.Checked;
            networkSpeedFeedback.PingToGoogle.Visible = PingEnabled.Checked;
            networkSpeedFeedback.FeedbackLatency.Visible = PingEnabled.Checked;
            networkSpeedFeedback.LatencyTarget.Visible = PingEnabled.Checked;
        }

        private void PingTarget_TextChanged(object sender, EventArgs e)
        {
            networkSpeedFeedback.pingingActive = false;
            networkSpeedFeedback.pingTarget = PingTarget.Text;
            networkSpeedFeedback.LatencyTarget.Text = PingTarget.Text;


        }

        private void UpdatePingTarget_Click(object sender, EventArgs e)
        {
            networkSpeedFeedback.pingingActive = true;
        }

        private void EnableSpeed_CheckedChanged(object sender, EventArgs e)
        {
            networkSpeedFeedback.TotalThrougput.Visible = EnableSpeed.Checked;
            networkSpeedFeedback.Feedback.Visible = EnableSpeed.Checked;
            networkSpeedFeedback.AdapterSpeed.Visible = EnableSpeed.Checked;
            networkSpeedFeedback.FeedbackBandwith.Visible = EnableSpeed.Checked;
        }
    }
}
