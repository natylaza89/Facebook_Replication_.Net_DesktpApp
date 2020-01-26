namespace DP_Task1.forms
{
    partial class AppMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppMainForm));
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.buttonSettingsForm = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLogo = new System.Windows.Forms.Label();
            this.buttonVideosForm = new System.Windows.Forms.Button();
            this.buttonEventsForm = new System.Windows.Forms.Button();
            this.buttonProfileForm = new System.Windows.Forms.Button();
            this.buttonAlbumsForm = new System.Windows.Forms.Button();
            this.buttonPostsForm = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.roundedUserPictureBox = new DP_Task1.custom_components.RoundedPictureBox();
            this.labelFormDescription = new System.Windows.Forms.Label();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelContext = new System.Windows.Forms.Panel();
            this.contextPannel = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.mainTitleLabel = new System.Windows.Forms.Label();
            this.iconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelSideBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedUserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panelContext.SuspendLayout();
            this.contextPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panelSideBar.Controls.Add(this.buttonSettingsForm);
            this.panelSideBar.Controls.Add(this.panelLogo);
            this.panelSideBar.Controls.Add(this.buttonVideosForm);
            this.panelSideBar.Controls.Add(this.buttonEventsForm);
            this.panelSideBar.Controls.Add(this.buttonProfileForm);
            this.panelSideBar.Controls.Add(this.buttonAlbumsForm);
            this.panelSideBar.Controls.Add(this.buttonPostsForm);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(216, 602);
            this.panelSideBar.TabIndex = 0;
            // 
            // buttonSettingsForm
            // 
            this.buttonSettingsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonSettingsForm.FlatAppearance.BorderSize = 0;
            this.buttonSettingsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettingsForm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettingsForm.ForeColor = System.Drawing.Color.White;
            this.buttonSettingsForm.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettingsForm.Image")));
            this.buttonSettingsForm.Location = new System.Drawing.Point(3, 439);
            this.buttonSettingsForm.Name = "buttonSettingsForm";
            this.buttonSettingsForm.Size = new System.Drawing.Size(216, 42);
            this.buttonSettingsForm.TabIndex = 17;
            this.buttonSettingsForm.Text = "    Settings";
            this.buttonSettingsForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSettingsForm.UseVisualStyleBackColor = false;
            this.buttonSettingsForm.Click += new System.EventHandler(this.SidePannelButton_Click);
            this.buttonSettingsForm.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.buttonSettingsForm.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.SteelBlue;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.labelLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(216, 64);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(68, 25);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(62, 23);
            this.labelLogo.TabIndex = 2;
            this.labelLogo.Text = ".Naty";
            // 
            // buttonVideosForm
            // 
            this.buttonVideosForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonVideosForm.FlatAppearance.BorderSize = 0;
            this.buttonVideosForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVideosForm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVideosForm.ForeColor = System.Drawing.Color.White;
            this.buttonVideosForm.Image = ((System.Drawing.Image)(resources.GetObject("buttonVideosForm.Image")));
            this.buttonVideosForm.Location = new System.Drawing.Point(0, 285);
            this.buttonVideosForm.Name = "buttonVideosForm";
            this.buttonVideosForm.Size = new System.Drawing.Size(216, 42);
            this.buttonVideosForm.TabIndex = 11;
            this.buttonVideosForm.Text = "    Videos";
            this.buttonVideosForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonVideosForm.UseVisualStyleBackColor = false;
            this.buttonVideosForm.Click += new System.EventHandler(this.SidePannelButton_Click);
            this.buttonVideosForm.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.buttonVideosForm.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // buttonEventsForm
            // 
            this.buttonEventsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonEventsForm.FlatAppearance.BorderSize = 0;
            this.buttonEventsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEventsForm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEventsForm.ForeColor = System.Drawing.Color.White;
            this.buttonEventsForm.Image = ((System.Drawing.Image)(resources.GetObject("buttonEventsForm.Image")));
            this.buttonEventsForm.Location = new System.Drawing.Point(0, 189);
            this.buttonEventsForm.Name = "buttonEventsForm";
            this.buttonEventsForm.Size = new System.Drawing.Size(216, 42);
            this.buttonEventsForm.TabIndex = 16;
            this.buttonEventsForm.Text = "    Events";
            this.buttonEventsForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEventsForm.UseVisualStyleBackColor = false;
            this.buttonEventsForm.Click += new System.EventHandler(this.SidePannelButton_Click);
            this.buttonEventsForm.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.buttonEventsForm.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // buttonProfileForm
            // 
            this.buttonProfileForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonProfileForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonProfileForm.FlatAppearance.BorderSize = 0;
            this.buttonProfileForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfileForm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfileForm.ForeColor = System.Drawing.Color.White;
            this.buttonProfileForm.Image = ((System.Drawing.Image)(resources.GetObject("buttonProfileForm.Image")));
            this.buttonProfileForm.Location = new System.Drawing.Point(0, 93);
            this.buttonProfileForm.Name = "buttonProfileForm";
            this.buttonProfileForm.Size = new System.Drawing.Size(216, 42);
            this.buttonProfileForm.TabIndex = 10;
            this.buttonProfileForm.Text = "    Profile";
            this.buttonProfileForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProfileForm.UseVisualStyleBackColor = false;
            this.buttonProfileForm.Click += new System.EventHandler(this.SidePannelButton_Click);
            this.buttonProfileForm.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.buttonProfileForm.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // buttonAlbumsForm
            // 
            this.buttonAlbumsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonAlbumsForm.FlatAppearance.BorderSize = 0;
            this.buttonAlbumsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlbumsForm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlbumsForm.ForeColor = System.Drawing.Color.White;
            this.buttonAlbumsForm.Image = ((System.Drawing.Image)(resources.GetObject("buttonAlbumsForm.Image")));
            this.buttonAlbumsForm.Location = new System.Drawing.Point(0, 237);
            this.buttonAlbumsForm.Name = "buttonAlbumsForm";
            this.buttonAlbumsForm.Size = new System.Drawing.Size(216, 42);
            this.buttonAlbumsForm.TabIndex = 15;
            this.buttonAlbumsForm.Text = "    Albums";
            this.buttonAlbumsForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAlbumsForm.UseVisualStyleBackColor = false;
            this.buttonAlbumsForm.Click += new System.EventHandler(this.SidePannelButton_Click);
            this.buttonAlbumsForm.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.buttonAlbumsForm.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // buttonPostsForm
            // 
            this.buttonPostsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonPostsForm.FlatAppearance.BorderSize = 0;
            this.buttonPostsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPostsForm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostsForm.ForeColor = System.Drawing.Color.White;
            this.buttonPostsForm.Image = ((System.Drawing.Image)(resources.GetObject("buttonPostsForm.Image")));
            this.buttonPostsForm.Location = new System.Drawing.Point(0, 141);
            this.buttonPostsForm.Name = "buttonPostsForm";
            this.buttonPostsForm.Size = new System.Drawing.Size(216, 42);
            this.buttonPostsForm.TabIndex = 14;
            this.buttonPostsForm.Text = "    Posts";
            this.buttonPostsForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPostsForm.UseVisualStyleBackColor = false;
            this.buttonPostsForm.Click += new System.EventHandler(this.SidePannelButton_Click);
            this.buttonPostsForm.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.buttonPostsForm.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.roundedUserPictureBox);
            this.panelTop.Controls.Add(this.labelFormDescription);
            this.panelTop.Controls.Add(this.pictureBoxMinimize);
            this.panelTop.Controls.Add(this.pictureBoxClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(216, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(903, 64);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseUp);
            // 
            // roundedUserPictureBox
            // 
            this.roundedUserPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.roundedUserPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("roundedUserPictureBox.Image")));
            this.roundedUserPictureBox.Location = new System.Drawing.Point(16, 8);
            this.roundedUserPictureBox.Name = "roundedUserPictureBox";
            this.roundedUserPictureBox.Size = new System.Drawing.Size(45, 45);
            this.roundedUserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundedUserPictureBox.TabIndex = 18;
            this.roundedUserPictureBox.TabStop = false;
            this.roundedUserPictureBox.URL = null;
            // 
            // labelFormDescription
            // 
            this.labelFormDescription.AutoSize = true;
            this.labelFormDescription.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormDescription.Location = new System.Drawing.Point(72, 16);
            this.labelFormDescription.Name = "labelFormDescription";
            this.labelFormDescription.Size = new System.Drawing.Size(83, 34);
            this.labelFormDescription.TabIndex = 6;
            this.labelFormDescription.Text = "Main";
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimize.Image")));
            this.pictureBoxMinimize.Location = new System.Drawing.Point(825, 16);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMinimize.TabIndex = 5;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.PictureBoxMinimize_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(861, 16);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 4;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.PictureBoxClose_Click);
            // 
            // panelContext
            // 
            this.panelContext.BackColor = System.Drawing.Color.Gainsboro;
            this.panelContext.Controls.Add(this.contextPannel);
            this.panelContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContext.Location = new System.Drawing.Point(216, 64);
            this.panelContext.Name = "panelContext";
            this.panelContext.Size = new System.Drawing.Size(903, 538);
            this.panelContext.TabIndex = 2;
            // 
            // contextPannel
            // 
            this.contextPannel.BackgroundImage = global::DP_Task1.Properties.Resources.facebook_508153714;
            this.contextPannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contextPannel.Controls.Add(this.buttonLogin);
            this.contextPannel.Controls.Add(this.mainTitleLabel);
            this.contextPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contextPannel.Location = new System.Drawing.Point(0, 0);
            this.contextPannel.Name = "contextPannel";
            this.contextPannel.Size = new System.Drawing.Size(903, 538);
            this.contextPannel.TabIndex = 9;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogin.Image")));
            this.buttonLogin.Location = new System.Drawing.Point(295, 416);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(270, 52);
            this.buttonLogin.TabIndex = 17;
            this.buttonLogin.Text = "     Click Here To Login";
            this.buttonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            this.buttonLogin.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.buttonLogin.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // mainTitleLabel
            // 
            this.mainTitleLabel.AutoSize = true;
            this.mainTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainTitleLabel.Font = new System.Drawing.Font("Century Gothic", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitleLabel.ForeColor = System.Drawing.Color.White;
            this.mainTitleLabel.Location = new System.Drawing.Point(245, 48);
            this.mainTitleLabel.Name = "mainTitleLabel";
            this.mainTitleLabel.Size = new System.Drawing.Size(381, 83);
            this.mainTitleLabel.TabIndex = 0;
            this.mainTitleLabel.Text = "Welcome!";
            // 
            // iconTray
            // 
            this.iconTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.iconTray.BalloonTipText = "Application Minimized";
            this.iconTray.BalloonTipTitle = "Facebook .Naty";
            this.iconTray.Icon = ((System.Drawing.Icon)(resources.GetObject("iconTray.Icon")));
            this.iconTray.Text = "Facebook .Naty";
            this.iconTray.DoubleClick += new System.EventHandler(this.IconTray_DoubleClick);
            // 
            // AppMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 602);
            this.ControlBox = false;
            this.Controls.Add(this.panelContext);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook .Naty";
            this.Load += new System.EventHandler(this.AppMainForm_Load);
            this.panelSideBar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedUserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panelContext.ResumeLayout(false);
            this.contextPannel.ResumeLayout(false);
            this.contextPannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Button buttonSettingsForm;
        private System.Windows.Forms.Button buttonVideosForm;
        private System.Windows.Forms.Button buttonEventsForm;
        private System.Windows.Forms.Button buttonProfileForm;
        private System.Windows.Forms.Button buttonAlbumsForm;
        private System.Windows.Forms.Button buttonPostsForm;
        private System.Windows.Forms.Label labelFormDescription;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Panel panelContext;
        private System.Windows.Forms.NotifyIcon iconTray;
        private System.Windows.Forms.Panel contextPannel;
        private System.Windows.Forms.Label mainTitleLabel;
        private System.Windows.Forms.Button buttonLogin;
        private custom_components.RoundedPictureBox roundedUserPictureBox;
        private System.Windows.Forms.Panel panelLogo;
    }
}