using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Drawing;

namespace NetworkSpeedFeedback
{
    public partial class NetworkSpeedFeedback : Form
    {
        internal NetworkInterface[] adapters;
        internal NetworkInterface selectedAdapter;
        internal IPInterfaceProperties adapterProperties;
        internal IPv4InterfaceStatistics adapterStatistics;
        internal string pingTarget;
        internal bool pingingActive;
        internal Ping ping;
        internal long bytesReceived;
        internal Controls controls;
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        public NetworkSpeedFeedback()
        {
            InitializeComponent();
            
            Feedback.Text = 0.ToString();
            FeedbackBandwith.Text = 0.ToString();
            FeedbackLatency.Text = 0.ToString();
            pingingActive = true;
            this.BackColor = Color.CornflowerBlue;
            this.TransparencyKey = Color.CornflowerBlue;
            pingTarget = "www.google.com";
            adapters = NetworkInterface.GetAllNetworkInterfaces();
            controls = new Controls(this);
            



        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {

            if (selectedAdapter != null)
            {
                adapterProperties = selectedAdapter.GetIPProperties();
                adapterStatistics = selectedAdapter.GetIPv4Statistics();
                var bytes = ((adapterStatistics.BytesReceived - bytesReceived) / 1024) * 2;
                if ((bytesReceived - adapterStatistics.BytesReceived) > 1024)
                {
                    Feedback.Text = bytes.ToString() + " MB/s";
                }
                else if ((bytesReceived - adapterStatistics.BytesReceived) < 1024)
                {
                    Feedback.Text = bytes.ToString() + " KB/s";
                }
                updateBandwith(bytes);
                MeasureLatency();
                bytesReceived = adapterStatistics.BytesReceived;
            }
        }

        internal void MeasureLatency()
        {
            if (pingingActive)
            {
                ping = new Ping();
                try
                {
                    if (pingTarget != "")
                    {
                        var currentPing = ping.Send(pingTarget);
                        FeedbackLatency.Text = currentPing.RoundtripTime.ToString() + " ms";
                    }
                    else
                    {
                        FeedbackLatency.Text = "Target cannot be empty";
                    }
                }
                catch (Exception ex)
                {
                    FeedbackLatency.Text = "Error";
                }
            }
            else
            {
                FeedbackLatency.Text = "...";
            }


        }

        private void updateBandwith(long bytes)
        {
            var bandwith = (bytes / 0.125);
            if (bandwith > 1024)
            {
                bandwith = (bandwith / 1024);
                FeedbackBandwith.Text = bandwith.ToString("N") + " Mbps";
            }
            else
            {
                FeedbackBandwith.Text = bandwith.ToString("N") + " Kbps";
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch(m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    if((int)m.Result == HTCLIENT)
                    {
                        m.Result = (IntPtr)HTCAPTION;
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        private void ToggleControls_Click(object sender, EventArgs e)
        {
            if(controls != null && controls.IsDisposed != true)
            {
                if (!controls.Visible)
                {
                    controls.Show();
                }
                else
                {
                    controls.Hide();
                }
            }
            else
            {
                controls = new Controls(this);
                controls.Show();
            }

        
        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
