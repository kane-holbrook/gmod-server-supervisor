namespace ServerSupervisor
{
    partial class ServerWidget
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerWidget));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Edit = new System.Windows.Forms.PictureBox();
            this.PlayPause = new System.Windows.Forms.PictureBox();
            this.Hostname = new System.Windows.Forms.Label();
            this.IpAddr = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.PlayPause);
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 43);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Edit
            // 
            this.Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Location = new System.Drawing.Point(195, 7);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(26, 26);
            this.Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Edit.TabIndex = 1;
            this.Edit.TabStop = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // PlayPause
            // 
            this.PlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayPause.Image = ((System.Drawing.Image)(resources.GetObject("PlayPause.Image")));
            this.PlayPause.Location = new System.Drawing.Point(263, 7);
            this.PlayPause.Name = "PlayPause";
            this.PlayPause.Size = new System.Drawing.Size(26, 26);
            this.PlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayPause.TabIndex = 0;
            this.PlayPause.TabStop = false;
            this.PlayPause.Click += new System.EventHandler(this.PlayPause_Click);
            // 
            // Hostname
            // 
            this.Hostname.AutoEllipsis = true;
            this.Hostname.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Hostname.ForeColor = System.Drawing.Color.White;
            this.Hostname.Location = new System.Drawing.Point(7, 6);
            this.Hostname.Name = "Hostname";
            this.Hostname.Size = new System.Drawing.Size(154, 25);
            this.Hostname.TabIndex = 1;
            this.Hostname.Text = "label1";
            // 
            // IpAddr
            // 
            this.IpAddr.AutoEllipsis = true;
            this.IpAddr.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IpAddr.ForeColor = System.Drawing.Color.White;
            this.IpAddr.Location = new System.Drawing.Point(7, 29);
            this.IpAddr.Name = "IpAddr";
            this.IpAddr.Size = new System.Drawing.Size(154, 25);
            this.IpAddr.TabIndex = 2;
            this.IpAddr.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(271, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 14);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // ServerWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.IpAddr);
            this.Controls.Add(this.Hostname);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Name = "ServerWidget";
            this.Size = new System.Drawing.Size(300, 98);
            this.Load += new System.EventHandler(this.ServerWidget_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox Edit;
        private PictureBox PlayPause;
        private Label Hostname;
        private Label IpAddr;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
