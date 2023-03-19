using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSupervisor
{
    public class Server 
    {
        public static List<Server> All = new List<Server>();

        public string Path { get; set; }
        public string Hostname { get; set; }
        public string? Password { get; set; }
        public string IpAddress { get; set; }

        public int Port { get; set; }

        public string Map { get; set; }

        public int MaxPlayers { get; set; }

        public int Tickrate { get; set; }

        public string Gamemode { get; set; }

        public string ServerCfgFile { get; set; }

        public string WorkshopId { get; set; }

        public string GSLT { get; set; }

        public string LoadingURL { get; set; }

        public string AdditionalParameters { get; set; }

        public string IpPort { get => IpAddress + ":" + Port; }

        [NonSerialized]
        public Process? Process;

        private Boolean _active = false;
        public Boolean Active
        {
            get => _active; 
            set
            {
                try
                {
                    _active = value;

                    if (_active)
                    {
                        Start();
                        Console.WriteLine("TEST");
                    }
                    else
                    {
                        if (Process != null)
                        {
                            Process.Exited -= Process_Exited;
                            Process?.Kill(true);
                            Process?.Dispose();
                            Process = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    _active = false;
                }
            }
        }

        public string LaunchString
        {
            get 
            {
                string p = $"-console -game \"garrysmod\" -ip \"{IpAddress}\" -port {Port} -maxplayers {MaxPlayers} -tickrate {Tickrate} +sv_setsteamaccount \"{GSLT}\" +host_workshop_collection \"{WorkshopId}\" +hostname \"{Hostname}\" +map \"{Map}\" +gamemode \"{Gamemode}\" +sv_loadingurl \"{LoadingURL}\" +servercfgfile \"{ServerCfgFile}\" +cl_showdemooverlay 1 {AdditionalParameters}";
                if (!string.IsNullOrWhiteSpace(Password))
                {
                    p = p + " +sv_password \"" + Password + "\"";
                }
                return p;
            }
        }
        
        public void Start()
        {
            Process = Process.Start(new ProcessStartInfo(Path, LaunchString));
            Process.EnableRaisingEvents = true;
            Process.Exited += Process_Exited;
        }

        private void Process_Exited(object? sender, EventArgs e)
        {
            Start();
        }

        public Color Indicator { get => Active ? Color.Green : Color.Black; }
    }
}
