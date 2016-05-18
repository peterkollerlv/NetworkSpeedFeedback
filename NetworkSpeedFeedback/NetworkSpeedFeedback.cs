using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace NetworkSpeedFeedback
{
    public partial class NetworkSpeedFeedback : Form
    {
        private NetworkInterface[] adapters;
        private bool toggleOnOff;
        private NetworkInterface selectedAdapter;
        private IPInterfaceProperties adapterProperties;
        private IPv4InterfaceStatistics adapterStatistics;
        private Ping ping;
        private long bytesReceived;

        public NetworkSpeedFeedback()
        {
            InitializeComponent();
            toggleOnOff = false;
            Feedback.Text = 0.ToString();
            FeedbackBandwith.Text = 0.ToString();
            FeedbackLatency.Text = 0.ToString();

            adapters = NetworkInterface.GetAllNetworkInterfaces();
            if (adapters != null)
            {
                NetworkInterfaces.Items.Clear();
                foreach (NetworkInterface adapter in adapters)
                {
                    //if (adapter.Speed > 0)
                    //{
                    NetworkInterfaces.Items.Add(adapter.Description);
                    //}
                }
                NetworkInterfaces.SelectedIndex = 0;
            }
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
                pingGoogle();
                bytesReceived = adapterStatistics.BytesReceived;
            }
        }

        private void pingGoogle()
        {
            ping = new Ping();
            try
            { 
            var currentPing = ping.Send("www.google.com");
            FeedbackLatency.Text = currentPing.RoundtripTime.ToString() + " ms";
            }
            catch (Exception ex)
            {
                FeedbackLatency.Text = ex.Message;
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

        private void GetNetworkAdapters_Click(object sender, EventArgs e)
        {
            adapters = NetworkInterface.GetAllNetworkInterfaces();
            if (adapters != null)
            {
                NetworkInterfaces.Items.Clear();
                foreach (NetworkInterface adapter in adapters)
                {
                    NetworkInterfaces.Items.Add(adapter.Description);
                }
            }
        }

        private void ToggleOnOff_Click(object sender, EventArgs e)
        {
            if (!toggleOnOff)
            {
                toggleOnOff = true;
                bytesReceived = selectedAdapter.GetIPv4Statistics().BytesReceived;
                RefreshTimer.Start();
                ToggleOnOff.Text = "Stop";
            }
            else
            {
                toggleOnOff = false;
                bytesReceived = 0;
                RefreshTimer.Stop();
                ToggleOnOff.Text = "Start";
            }
        }

        private void NetworkInterfaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (adapters != null)
            {
                selectedAdapter = adapters[NetworkInterfaces.SelectedIndex];

            }
        }
    }
}
