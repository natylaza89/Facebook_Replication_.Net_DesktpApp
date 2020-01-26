namespace DP_Task1.forms
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.nameLabel3 = new System.Windows.Forms.Label();
            this.nameLabel5 = new System.Windows.Forms.Label();
            this.imageNormalRoundedPictureBox = new DP_Task1.custom_components.RoundedPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalRoundedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.birthdayLabel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayLabel1.ForeColor = System.Drawing.Color.White;
            this.birthdayLabel1.Image = ((System.Drawing.Image)(resources.GetObject("birthdayLabel1.Image")));
            this.birthdayLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.birthdayLabel1.Location = new System.Drawing.Point(268, 271);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(491, 46);
            this.birthdayLabel1.TabIndex = 1;
            this.birthdayLabel1.Text = "User Birthday";
            this.birthdayLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailLabel1
            // 
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailLabel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel1.ForeColor = System.Drawing.Color.White;
            this.emailLabel1.Image = ((System.Drawing.Image)(resources.GetObject("emailLabel1.Image")));
            this.emailLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emailLabel1.Location = new System.Drawing.Point(268, 353);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(491, 46);
            this.emailLabel1.TabIndex = 3;
            this.emailLabel1.Text = "User Email";
            this.emailLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel3
            // 
            this.nameLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Location.Name", true));
            this.nameLabel3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel3.ForeColor = System.Drawing.Color.White;
            this.nameLabel3.Image = ((System.Drawing.Image)(resources.GetObject("nameLabel3.Image")));
            this.nameLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameLabel3.Location = new System.Drawing.Point(268, 434);
            this.nameLabel3.Name = "nameLabel3";
            this.nameLabel3.Size = new System.Drawing.Size(491, 46);
            this.nameLabel3.TabIndex = 7;
            this.nameLabel3.Text = "User Location";
            this.nameLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel5
            // 
            this.nameLabel5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameLabel5.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel5.ForeColor = System.Drawing.Color.White;
            this.nameLabel5.Location = new System.Drawing.Point(226, 157);
            this.nameLabel5.Name = "nameLabel5";
            this.nameLabel5.Size = new System.Drawing.Size(405, 57);
            this.nameLabel5.TabIndex = 9;
            this.nameLabel5.Text = "User Full Name";
            this.nameLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageNormalRoundedPictureBox
            // 
            this.imageNormalRoundedPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalRoundedPictureBox.Location = new System.Drawing.Point(360, 25);
            this.imageNormalRoundedPictureBox.Name = "imageNormalRoundedPictureBox";
            this.imageNormalRoundedPictureBox.Size = new System.Drawing.Size(125, 125);
            this.imageNormalRoundedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalRoundedPictureBox.TabIndex = 10;
            this.imageNormalRoundedPictureBox.TabStop = false;
            this.imageNormalRoundedPictureBox.URL = null;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 591);
            this.Controls.Add(this.imageNormalRoundedPictureBox);
            this.Controls.Add(this.nameLabel5);
            this.Controls.Add(this.nameLabel3);
            this.Controls.Add(this.emailLabel1);
            this.Controls.Add(this.birthdayLabel1);
            this.DoubleBuffered = true;
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.DoubleClick += new System.EventHandler(this.ProfileForm_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalRoundedPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.Label nameLabel3;
        private System.Windows.Forms.Label nameLabel5;
        private custom_components.RoundedPictureBox imageNormalRoundedPictureBox;
    }
}