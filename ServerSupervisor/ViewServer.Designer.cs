namespace ServerSupervisor
{
    partial class ViewServer
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
            this.srcdsLocation = new System.Windows.Forms.OpenFileDialog();
            this.srcdsPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GSLT = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ipAddr = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.Map = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.workshopId = new System.Windows.Forms.TextBox();
            this.MaxPlayers = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Gamemode = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Tickrate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cfgPath = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.additionalParams = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.loadingURL = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Hostname = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.cfgLocation = new System.Windows.Forms.OpenFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.deleteServer = new System.Windows.Forms.Button();
            this.launchString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // srcdsLocation
            // 
            this.srcdsLocation.Filter = "Executables|*.exe";
            // 
            // srcdsPath
            // 
            this.srcdsPath.Location = new System.Drawing.Point(12, 42);
            this.srcdsPath.Name = "srcdsPath";
            this.srcdsPath.PlaceholderText = "D:\\sstrp2021\\srcds_win64.exe";
            this.srcdsPath.Size = new System.Drawing.Size(507, 23);
            this.srcdsPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server directory";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "This is the path to srcds.exe or srcds_win64.exe, typically in the garrysmod/ fol" +
    "der.";
            // 
            // GSLT
            // 
            this.GSLT.Location = new System.Drawing.Point(302, 361);
            this.GSLT.Name = "GSLT";
            this.GSLT.PlaceholderText = "0057A23DCF0CF6723A2408620B80EE7B...";
            this.GSLT.Size = new System.Drawing.Size(230, 23);
            this.GSLT.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(538, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(302, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Without this, players will have trouble connecting. It should be unique.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Steam Game Server Token (+sv_setsteamaccount)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "IP Address (-ip)";
            // 
            // ipAddr
            // 
            this.ipAddr.FormattingEnabled = true;
            this.ipAddr.Location = new System.Drawing.Point(13, 174);
            this.ipAddr.Name = "ipAddr";
            this.ipAddr.Size = new System.Drawing.Size(207, 23);
            this.ipAddr.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Port (-port)";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(226, 174);
            this.Port.Name = "Port";
            this.Port.PlaceholderText = "27015";
            this.Port.Size = new System.Drawing.Size(58, 23);
            this.Port.TabIndex = 13;
            // 
            // Map
            // 
            this.Map.Location = new System.Drawing.Point(299, 174);
            this.Map.Name = "Map";
            this.Map.PlaceholderText = "27015";
            this.Map.Size = new System.Drawing.Size(151, 23);
            this.Map.TabIndex = 15;
            this.Map.Text = "gm_construct";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Map (+map)";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(13, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(283, 39);
            this.label8.TabIndex = 18;
            this.label8.Text = "This is the ID of the workshop collection you want to the server to download and " +
    "mount on startup.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(288, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Workshop Collection ID (+host_workshop_collection)";
            // 
            // workshopId
            // 
            this.workshopId.Location = new System.Drawing.Point(13, 361);
            this.workshopId.Name = "workshopId";
            this.workshopId.PlaceholderText = "2784720927";
            this.workshopId.Size = new System.Drawing.Size(207, 23);
            this.workshopId.TabIndex = 16;
            // 
            // MaxPlayers
            // 
            this.MaxPlayers.Location = new System.Drawing.Point(526, 174);
            this.MaxPlayers.Name = "MaxPlayers";
            this.MaxPlayers.PlaceholderText = "32";
            this.MaxPlayers.Size = new System.Drawing.Size(79, 23);
            this.MaxPlayers.TabIndex = 20;
            this.MaxPlayers.Text = "32";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(456, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Max players (-maxplayers)";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(147, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 31);
            this.label15.TabIndex = 29;
            this.label15.Text = "The name of the folder in garrysmod/gamemodes to load.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(147, 216);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 15);
            this.label16.TabIndex = 28;
            this.label16.Text = "Gamemode (+gamemode)";
            // 
            // Gamemode
            // 
            this.Gamemode.Location = new System.Drawing.Point(147, 265);
            this.Gamemode.Name = "Gamemode";
            this.Gamemode.PlaceholderText = "ixsstrp2023";
            this.Gamemode.Size = new System.Drawing.Size(124, 23);
            this.Gamemode.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(13, 231);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 31);
            this.label17.TabIndex = 32;
            this.label17.Text = "How frequently the server updates clients";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 216);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 15);
            this.label18.TabIndex = 31;
            this.label18.Text = "Tickrate (-tickrate)";
            // 
            // Tickrate
            // 
            this.Tickrate.Location = new System.Drawing.Point(13, 265);
            this.Tickrate.Name = "Tickrate";
            this.Tickrate.PlaceholderText = "33";
            this.Tickrate.Size = new System.Drawing.Size(62, 23);
            this.Tickrate.TabIndex = 30;
            this.Tickrate.Text = "33";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(302, 231);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(303, 31);
            this.label20.TabIndex = 36;
            this.label20.Text = "The path to the server.cfg file (usually /cfg/server.cfg) that loads on the serve" +
    "r starting or changing maps.";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(302, 216);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(141, 15);
            this.label21.TabIndex = 35;
            this.label21.Text = "server.cfg (+servercfgfile)";
            // 
            // cfgPath
            // 
            this.cfgPath.Location = new System.Drawing.Point(302, 265);
            this.cfgPath.Name = "cfgPath";
            this.cfgPath.PlaceholderText = "server.cfg";
            this.cfgPath.Size = new System.Drawing.Size(218, 23);
            this.cfgPath.TabIndex = 34;
            this.cfgPath.Text = "server.cfg";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(526, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 23);
            this.button3.TabIndex = 37;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 487);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 15);
            this.label12.TabIndex = 38;
            this.label12.Text = "Additional startup parameters";
            // 
            // additionalParams
            // 
            this.additionalParams.Location = new System.Drawing.Point(13, 505);
            this.additionalParams.Multiline = true;
            this.additionalParams.Name = "additionalParams";
            this.additionalParams.Size = new System.Drawing.Size(592, 131);
            this.additionalParams.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 421);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(387, 15);
            this.label13.TabIndex = 43;
            this.label13.Text = "This is a web page that shows when players are connecting to the server.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 406);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 15);
            this.label14.TabIndex = 42;
            this.label14.Text = "Loading screen URL (+sv_loadingurl)";
            // 
            // loadingURL
            // 
            this.loadingURL.Location = new System.Drawing.Point(13, 439);
            this.loadingURL.Name = "loadingURL";
            this.loadingURL.PlaceholderText = "https://sstrp.net/game/loading/";
            this.loadingURL.Size = new System.Drawing.Size(519, 23);
            this.loadingURL.TabIndex = 41;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(488, 775);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(117, 41);
            this.Save.TabIndex = 44;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(538, 439);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 23);
            this.button4.TabIndex = 45;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(387, 15);
            this.label11.TabIndex = 48;
            this.label11.Text = "The name that appears to players when they look at their server browser.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 82);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(144, 15);
            this.label19.TabIndex = 47;
            this.label19.Text = "Server name (+hostname)";
            // 
            // Hostname
            // 
            this.Hostname.Location = new System.Drawing.Point(13, 115);
            this.Hostname.Name = "Hostname";
            this.Hostname.PlaceholderText = "Starship Troopers: The Klendathu Chronicles | sstrp.net";
            this.Hostname.Size = new System.Drawing.Size(387, 23);
            this.Hostname.TabIndex = 46;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(406, 97);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(160, 15);
            this.label22.TabIndex = 51;
            this.label22.Text = "Leave blank for no password.";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(406, 82);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(142, 15);
            this.label23.TabIndex = 50;
            this.label23.Text = "Password (+sv_password)";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(406, 115);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(199, 23);
            this.Password.TabIndex = 49;
            // 
            // cfgLocation
            // 
            this.cfgLocation.FileName = "openFileDialog1";
            this.cfgLocation.Filter = "Config files|*.cfg";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(226, 360);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 23);
            this.button5.TabIndex = 52;
            this.button5.Text = "View";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // deleteServer
            // 
            this.deleteServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteServer.Location = new System.Drawing.Point(13, 775);
            this.deleteServer.Name = "deleteServer";
            this.deleteServer.Size = new System.Drawing.Size(137, 41);
            this.deleteServer.TabIndex = 54;
            this.deleteServer.Text = "Delete server";
            this.deleteServer.UseVisualStyleBackColor = false;
            this.deleteServer.Visible = false;
            this.deleteServer.Click += new System.EventHandler(this.deleteServer_Click);
            // 
            // launchString
            // 
            this.launchString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.launchString.Location = new System.Drawing.Point(12, 651);
            this.launchString.Multiline = true;
            this.launchString.Name = "launchString";
            this.launchString.ReadOnly = true;
            this.launchString.Size = new System.Drawing.Size(592, 99);
            this.launchString.TabIndex = 55;
            // 
            // ViewServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(616, 838);
            this.Controls.Add(this.launchString);
            this.Controls.Add(this.deleteServer);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.Hostname);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.loadingURL);
            this.Controls.Add(this.additionalParams);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cfgPath);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Tickrate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Gamemode);
            this.Controls.Add(this.MaxPlayers);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.workshopId);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ipAddr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GSLT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.srcdsPath);
            this.Name = "ViewServer";
            this.Text = "Add a new server";
            this.Load += new System.EventHandler(this.ViewServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog srcdsLocation;
        private TextBox srcdsPath;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox GSLT;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label6;
        private ComboBox ipAddr;
        private Label label5;
        private TextBox Port;
        private TextBox Map;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox workshopId;
        private TextBox MaxPlayers;
        private Label label10;
        private Label label15;
        private Label label16;
        private TextBox Gamemode;
        private Label label17;
        private Label label18;
        private TextBox Tickrate;
        private Label label20;
        private Label label21;
        private TextBox cfgPath;
        private Button button3;
        private Label label12;
        private TextBox additionalParams;
        private Label label13;
        private Label label14;
        private TextBox loadingURL;
        private Button Save;
        private Button button4;
        private Label label11;
        private Label label19;
        private TextBox Hostname;
        private Label label22;
        private Label label23;
        private TextBox Password;
        private OpenFileDialog cfgLocation;
        private Button button5;
        private Button deleteServer;
        private TextBox launchString;
    }
}