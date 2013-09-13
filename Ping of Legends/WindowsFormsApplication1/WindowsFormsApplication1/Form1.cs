using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        Ping pvpnetClient;
        about aboutwin = null;
        public Form1()
        {
            InitializeComponent();
            pvpnetClient = new Ping();
            Server.SelectedIndex = 0;
        }

        private void pingButton_MouseEnter(object sender, EventArgs e)
        {
            pingButton.BackgroundImage = Properties.Resources.pingover;
        }

        private void pingButton_MouseLeave(object sender, EventArgs e)
        {
            pingButton.BackgroundImage = null;
        }

        private void pingButton_Click(object sender, EventArgs e)
        {
            PingReply reply;
            if (Server.Text == "EUW")
                reply = pvpnetClient.Send("95.172.65.2");
            else if (Server.Text == "EUN")
                reply = pvpnetClient.Send("95.172.70.0");
            else if (Server.Text == "LAS")
                reply = pvpnetClient.Send("200.73.71.112");
            else if (Server.Text == "LAN")
                reply = pvpnetClient.Send("66.151.33.50");
            else//if(Server.Text == "NA")
                reply = pvpnetClient.Send("64.7.194.1");


            if (reply.RoundtripTime > 0)
                pingLabel.Text = reply.RoundtripTime.ToString();
            else
                pingLabel.Text = reply.Status.ToString();
        }

        private void pingButton_MouseDown(object sender, MouseEventArgs e)
        {
            pingButton.BackgroundImage = Properties.Resources.pingdown;
        }

        private void pingButton_MouseUp(object sender, MouseEventArgs e)
        {
            pingButton.BackgroundImage = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (aboutwin == null)
            {
                aboutwin = new about();
                aboutwin.Show();
                aboutwin.FormClosed += closed_about;
            }
        }
        private void closed_about(object sender, EventArgs e)
        {
            aboutwin = null;
        }

    }
}
