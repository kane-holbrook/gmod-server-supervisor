using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerSupervisor
{
    public partial class Sidebar : Form
    {
        public List<ServerWidget> Items = new List<ServerWidget>();

        public Sidebar()
        {
            InitializeComponent();
        }

        private void Sidebar_Load(object sender, EventArgs e)
        {
            var bounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Width = 330;
            this.Height = bounds.Height;
            this.Location = new Point(bounds.Width - this.Width, 0);
            Refresh();
        }

        public void Refresh()
        {
            Servers.SuspendLayout();

            foreach (ServerWidget sw in Items)
                sw.Dispose();

            foreach (Server gs in Server.All)
            {
                ServerWidget sw = new ServerWidget(gs);
                Servers.Controls.Add(sw);
                Items.Add(sw);
            }

            Servers.ResumeLayout();

        }

        private void addNewServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewServer edit = new ViewServer();
            edit.Show();
            edit.FormClosed += (sender, e) => this.Refresh();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exiting the supervisor will shut down any srcds servers attached to it. Do you want to continue?", "Exit srcds supervisor", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Servers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ContextMenuStrip.Show();
        }
    }
}
