using ServerSupervisor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerSupervisor
{
    public partial class ServerWidget : UserControl
    {
        Server Server { get; set; }
        public ServerWidget(Server s)
        {
            InitializeComponent();
            Server = s;

            Hostname.DataBindings.Add("Text", Server, "Hostname");
            IpAddr.DataBindings.Add("Text", Server, "IpPort");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            ViewServer edit = new ViewServer();
            edit.SetServer(Server);
            edit.FormClosed += (sender, e) => ((Sidebar)this.ParentForm).Refresh();
            edit.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {

            ViewServer edit = new ViewServer();
            edit.CloneOf(Server);
            edit.FormClosed += (sender, e) => ((Sidebar)this.ParentForm).Refresh();
            edit.Show();
        }

        private void PlayPause_Click(object sender, EventArgs e)
        {
            Server.Active = !Server.Active;


            var rm = new System.ComponentModel.ComponentResourceManager(this.GetType());
            PlayPause.Image = Server.Active ? (System.Drawing.Image)rm.GetObject("pictureBox2.Image") : (System.Drawing.Image)rm.GetObject("PlayPause.Image");

            Program.Save();
        }

        private void ServerWidget_Load(object sender, EventArgs e)
        {
            var rm = new System.ComponentModel.ComponentResourceManager(this.GetType());
            PlayPause.Image = Server.Active ? (System.Drawing.Image)rm.GetObject("pictureBox2.Image") : (System.Drawing.Image)rm.GetObject("PlayPause.Image");
        }
    }
}
