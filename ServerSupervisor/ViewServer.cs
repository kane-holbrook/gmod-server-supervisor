using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerSupervisor
{
    public partial class ViewServer : Form
    {
        Server Server;
        private bool isEdit = false;

        public ViewServer()
        {
            InitializeComponent();

            srcdsLocation.FileOk += SrcdsLocation_FileOk;
            cfgLocation.FileOk += CfgLocation_FileOk;

            Server = new Server();
            Save.Text = "Create";

            launchString.DataBindings.Add("Text", Server, "LaunchString");
        }

        public void SetServer(Server s)
        {
            Server = s;
            Save.Text = "Save";

            srcdsPath.Text = Server.Path;
            Hostname.Text = Server.Hostname;
            Password.Text = Server.Password;
            ipAddr.Text = Server.IpAddress;
            Port.Text = Server.Port.ToString();
            Map.Text = Server.Map;
            MaxPlayers.Text = Server.MaxPlayers.ToString();
            Tickrate.Text = Server.Tickrate.ToString();
            Gamemode.Text = Server.Gamemode;
            cfgPath.Text = Server.ServerCfgFile;
            workshopId.Text = Server.WorkshopId;
            loadingURL.Text = Server.LoadingURL;
            additionalParams.Text = Server.AdditionalParameters;
            GSLT.Text = Server.GSLT;
            this.Text = $"Edit {Server.Hostname} ({Server.IpPort})";
            deleteServer.Visible = true;

            launchString.DataBindings.Clear();
            launchString.DataBindings.Add("Text", Server, "LaunchString");

            isEdit = true;
        }

        public void CloneOf(Server s)
        {
            srcdsPath.Text = s.Path;
            Hostname.Text = s.Hostname;
            Password.Text = s.Password;
            ipAddr.Text = s.IpAddress;
            Port.Text = s.Port.ToString();
            Map.Text = s.Map;
            MaxPlayers.Text = s.MaxPlayers.ToString();
            Tickrate.Text = s.Tickrate.ToString();
            Gamemode.Text = s.Gamemode;
            cfgPath.Text = s.ServerCfgFile;
            workshopId.Text = s.WorkshopId;
            loadingURL.Text = s.LoadingURL;
            additionalParams.Text = s.AdditionalParameters;
        }

        private void Bind()
        {
            /*srcdsPath.DataBindings.Add("Text", Server, "Path");
            Hostname.DataBindings.Add("Text", Server, "Hostname");
            Password.DataBindings.Add("Text", Server, "Password");
            ipAddr.DataBindings.Add("Text", Server, "IpAddress");
            Port.DataBindings.Add("Text", Server, "Port");
            Map.DataBindings.Add("Text", Server, "Map");
            MaxPlayers.DataBindings.Add("Text", Server, "MaxPlayers");
            Tickrate.DataBindings.Add("Text", Server, "Tickrate");
            Gamemode.DataBindings.Add("Text", Server, "Gamemode");
            cfgPath.DataBindings.Add("Text", Server, "ServerCfgFile");
            workshopId.DataBindings.Add("Text", Server, "WorkshopId");
            loadingURL.DataBindings.Add("Text", Server, "LoadingURL");
            additionalParams.DataBindings.Add("Text", Server, "AdditionalParameters");*/
        }

        private void CfgLocation_FileOk(object? sender, CancelEventArgs e)
        {
            cfgPath.Text = ((OpenFileDialog)sender).FileName;
        }

        private void SrcdsLocation_FileOk(object? sender, CancelEventArgs e)
        {
            srcdsPath.Text = ((OpenFileDialog)sender).FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            srcdsLocation.ShowDialog();
        }

        private void ViewServer_Load(object sender, EventArgs e)
        {
            foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (netInterface.NetworkInterfaceType != NetworkInterfaceType.Ethernet && netInterface.NetworkInterfaceType != NetworkInterfaceType.Wireless80211)
                    continue;

                IPInterfaceProperties ipProps = netInterface.GetIPProperties();

                foreach (UnicastIPAddressInformation addr in ipProps.UnicastAddresses)
                {
                    if (addr.Address.AddressFamily != System.Net.Sockets.AddressFamily.InterNetwork)
                        continue;

                    string ip = addr.Address.ToString();
                    if (ip.StartsWith("127.") || ip.StartsWith("192."))
                        continue;

                    ipAddr.Items.Add(addr.Address.ToString());
                }
            }

            Location = new Point(Program.Sidebar.Location.X - Width - 10, 20);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cfgLocation.InitialDirectory = srcdsPath.Text + "/garrysmod/cfg";
            cfgLocation.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "https://steamcommunity.com/dev/managegameservers";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string url = loadingURL.Text;
            url = url.Replace("&", "^&");
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string url = "https://steamcommunity.com/workshop/filedetails/?id=" + workshopId.Text;
            url = url.Replace("&", "^&");
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });

        }

        private void Save_Click(object sender, EventArgs e)
        {
            Server.Path = srcdsPath.Text;
            Server.Hostname = Hostname.Text;
            Server.Password = Password.Text;
            Server.IpAddress = ipAddr.Text;
            Server.Port = int.Parse(Port.Text);
            Server.Map = Map.Text;
            Server.MaxPlayers = int.Parse(MaxPlayers.Text);
            Server.Tickrate = int.Parse(Tickrate.Text);
            Server.Gamemode = Gamemode.Text;
            Server.ServerCfgFile = cfgPath.Text;
            Server.WorkshopId = workshopId.Text;
            Server.LoadingURL = loadingURL.Text;
            Server.AdditionalParameters = additionalParams.Text;
            Server.GSLT = GSLT.Text;

            if (!isEdit)
            {
                Server.All.Add(Server);
            }

            Program.Save();
            this.Close();
        }

        private void deleteServer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You can't undo this action once it has been completed. Are you sure you want to proceed?", "Delete server", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Server.All.Remove(Server);

                Program.Save();
                this.Close();
            }

        }
    }
}
