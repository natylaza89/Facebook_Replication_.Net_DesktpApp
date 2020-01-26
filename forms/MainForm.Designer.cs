namespace DP_Task1.forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.postsFormButton = new System.Windows.Forms.Button();
            this.contextPannel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.mainTitleLabel = new System.Windows.Forms.Label();
            this.videosFormButton = new System.Windows.Forms.Button();
            this.albumsFormButton = new System.Windows.Forms.Button();
            this.settingsFormButton = new System.Windows.Forms.Button();
            this.eventsFormButton = new System.Windows.Forms.Button();
            this.profileFormButton = new System.Windows.Forms.Button();
            this.roundedPictureBox1 = new DP_Task1.custom_components.RoundedPictureBox();
            this.mySplitter = new DP_Task1.custom_components.MySplitter();
            this.contextPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // postsFormButton
            // 
            this.postsFormButton.BackgroundImage = global::DP_Task1.Properties.Resources.posts;
            this.postsFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.postsFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postsFormButton.Location = new System.Drawing.Point(14, 223);
            this.postsFormButton.Name = "postsFormButton";
            this.postsFormButton.Size = new System.Drawing.Size(174, 38);
            this.postsFormButton.TabIndex = 3;
            this.postsFormButton.UseVisualStyleBackColor = true;
            this.postsFormButton.Click += new System.EventHandler(this.SidePannelButton_Click);
            // 
            // contextPannel
            // 
            this.contextPannel.BackgroundImage = global::DP_Task1.Properties.Resources.facebook_508153714;
            this.contextPannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contextPannel.Controls.Add(this.loginButton);
            this.contextPannel.Controls.Add(this.mainTitleLabel);
            this.contextPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contextPannel.Location = new System.Drawing.Point(202, 0);
            this.contextPannel.Name = "contextPannel";
            this.contextPannel.Size = new System.Drawing.Size(917, 522);
            this.contextPannel.TabIndex = 8;
            this.contextPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContextPannel_Paint);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.White;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(257, 388);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(397, 57);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Click Here To Login!";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // mainTitleLabel
            // 
            this.mainTitleLabel.AutoSize = true;
            this.mainTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitleLabel.ForeColor = System.Drawing.Color.White;
            this.mainTitleLabel.Location = new System.Drawing.Point(284, 48);
            this.mainTitleLabel.Name = "mainTitleLabel";
            this.mainTitleLabel.Size = new System.Drawing.Size(353, 79);
            this.mainTitleLabel.TabIndex = 0;
            this.mainTitleLabel.Text = "Welcome!";
            this.mainTitleLabel.Click += new System.EventHandler(this.MainTitleLabel_Click);
            // 
            // videosFormButton
            // 
            this.videosFormButton.BackgroundImage = global::DP_Task1.Properties.Resources.videos;
            this.videosFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.videosFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videosFormButton.Location = new System.Drawing.Point(12, 403);
            this.videosFormButton.Name = "videosFormButton";
            this.videosFormButton.Size = new System.Drawing.Size(174, 38);
            this.videosFormButton.TabIndex = 7;
            this.videosFormButton.UseVisualStyleBackColor = true;
            this.videosFormButton.Click += new System.EventHandler(this.SidePannelButton_Click);
            // 
            // albumsFormButton
            // 
            this.albumsFormButton.BackgroundImage = global::DP_Task1.Properties.Resources.albums;
            this.albumsFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.albumsFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.albumsFormButton.Location = new System.Drawing.Point(12, 343);
            this.albumsFormButton.Name = "albumsFormButton";
            this.albumsFormButton.Size = new System.Drawing.Size(174, 38);
            this.albumsFormButton.TabIndex = 6;
            this.albumsFormButton.UseVisualStyleBackColor = true;
            this.albumsFormButton.Click += new System.EventHandler(this.SidePannelButton_Click);
            // 
            // settingsFormButton
            // 
            this.settingsFormButton.BackgroundImage = global::DP_Task1.Properties.Resources.settings;
            this.settingsFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsFormButton.Location = new System.Drawing.Point(12, 463);
            this.settingsFormButton.Name = "settingsFormButton";
            this.settingsFormButton.Size = new System.Drawing.Size(174, 38);
            this.settingsFormButton.TabIndex = 5;
            this.settingsFormButton.UseVisualStyleBackColor = true;
            this.settingsFormButton.Click += new System.EventHandler(this.SidePannelButton_Click);
            // 
            // eventsFormButton
            // 
            this.eventsFormButton.BackgroundImage = global::DP_Task1.Properties.Resources.events;
            this.eventsFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eventsFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventsFormButton.Location = new System.Drawing.Point(15, 283);
            this.eventsFormButton.Name = "eventsFormButton";
            this.eventsFormButton.Size = new System.Drawing.Size(174, 38);
            this.eventsFormButton.TabIndex = 4;
            this.eventsFormButton.UseVisualStyleBackColor = true;
            this.eventsFormButton.Click += new System.EventHandler(this.SidePannelButton_Click);
            // 
            // profileFormButton
            // 
            this.profileFormButton.BackgroundImage = global::DP_Task1.Properties.Resources.profile;
            this.profileFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profileFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileFormButton.Location = new System.Drawing.Point(12, 163);
            this.profileFormButton.Name = "profileFormButton";
            this.profileFormButton.Size = new System.Drawing.Size(174, 38);
            this.profileFormButton.TabIndex = 2;
            this.profileFormButton.UseVisualStyleBackColor = true;
            this.profileFormButton.Click += new System.EventHandler(this.SidePannelButton_Click);
            // 
            // roundedPictureBox1
            // 
            this.roundedPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("roundedPictureBox1.Image")));
            this.roundedPictureBox1.Location = new System.Drawing.Point(48, 39);
            this.roundedPictureBox1.Name = "roundedPictureBox1";
            this.roundedPictureBox1.Size = new System.Drawing.Size(100, 88);
            this.roundedPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundedPictureBox1.TabIndex = 1;
            this.roundedPictureBox1.TabStop = false;
            this.roundedPictureBox1.URL = null;
            // 
            // mySplitter
            // 
            this.mySplitter.BackColor = System.Drawing.Color.White;
            this.mySplitter.Location = new System.Drawing.Point(0, 0);
            this.mySplitter.Name = "mySplitter";
            this.mySplitter.Size = new System.Drawing.Size(202, 522);
            this.mySplitter.TabIndex = 0;
            this.mySplitter.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1119, 522);
            this.Controls.Add(this.postsFormButton);
            this.Controls.Add(this.contextPannel);
            this.Controls.Add(this.videosFormButton);
            this.Controls.Add(this.albumsFormButton);
            this.Controls.Add(this.settingsFormButton);
            this.Controls.Add(this.eventsFormButton);
            this.Controls.Add(this.profileFormButton);
            this.Controls.Add(this.roundedPictureBox1);
            this.Controls.Add(this.mySplitter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyFacebookApp";
            this.contextPannel.ResumeLayout(false);
            this.contextPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DP_Task1.custom_components.MySplitter mySplitter;
        private DP_Task1.custom_components.RoundedPictureBox roundedPictureBox1;
        private System.Windows.Forms.Button profileFormButton;
        private System.Windows.Forms.Button postsFormButton;
        private System.Windows.Forms.Button eventsFormButton;
        private System.Windows.Forms.Button settingsFormButton;
        private System.Windows.Forms.Button albumsFormButton;
        private System.Windows.Forms.Button videosFormButton;
        private System.Windows.Forms.Panel contextPannel;
        private System.Windows.Forms.Label mainTitleLabel;
        private System.Windows.Forms.Button loginButton;
    }
}

