namespace DP_Task1.forms
{
    partial class AlbumsForm
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
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label imageAlbumLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label messageLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumsForm));
            this.albumsListBox = new System.Windows.Forms.ListBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.createdTimeLabel1 = new System.Windows.Forms.Label();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.imageAlbumRoundedPictureBox = new DP_Task1.custom_components.RoundedPictureBox();
            this.locationLabel1 = new System.Windows.Forms.Label();
            this.messageLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.photosFormButtonLoader = new System.Windows.Forms.Button();
            createdTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            imageAlbumLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumRoundedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            createdTimeLabel.ForeColor = System.Drawing.Color.White;
            createdTimeLabel.Location = new System.Drawing.Point(16, 122);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(147, 23);
            createdTimeLabel.TabIndex = 13;
            createdTimeLabel.Text = "Created Time:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.ForeColor = System.Drawing.Color.White;
            descriptionLabel.Location = new System.Drawing.Point(16, 77);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(125, 23);
            descriptionLabel.TabIndex = 16;
            descriptionLabel.Text = "Description:";
            // 
            // imageAlbumLabel
            // 
            imageAlbumLabel.AutoSize = true;
            imageAlbumLabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imageAlbumLabel.ForeColor = System.Drawing.Color.White;
            imageAlbumLabel.Location = new System.Drawing.Point(16, 265);
            imageAlbumLabel.Name = "imageAlbumLabel";
            imageAlbumLabel.Size = new System.Drawing.Size(150, 23);
            imageAlbumLabel.TabIndex = 18;
            imageAlbumLabel.Text = "Image Album:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationLabel.ForeColor = System.Drawing.Color.White;
            locationLabel.Location = new System.Drawing.Point(16, 168);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(100, 23);
            locationLabel.TabIndex = 21;
            locationLabel.Text = "Location:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            messageLabel.ForeColor = System.Drawing.Color.White;
            messageLabel.Location = new System.Drawing.Point(16, 217);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(104, 23);
            messageLabel.TabIndex = 23;
            messageLabel.Text = "Message:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(16, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 23);
            label1.TabIndex = 25;
            label1.Text = "Name:";
            // 
            // albumsListBox
            // 
            this.albumsListBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.albumsListBox.DataSource = this.albumBindingSource;
            this.albumsListBox.DisplayMember = "Name";
            this.albumsListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.albumsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumsListBox.FormattingEnabled = true;
            this.albumsListBox.ItemHeight = 20;
            this.albumsListBox.Location = new System.Drawing.Point(0, 0);
            this.albumsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.albumsListBox.Name = "albumsListBox";
            this.albumsListBox.ScrollAlwaysVisible = true;
            this.albumsListBox.Size = new System.Drawing.Size(246, 412);
            this.albumsListBox.TabIndex = 0;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // photoBindingSource
            // 
            this.photoBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Photo);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 15);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(21, 576);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(21, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(918, 164);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.albumsListBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(21, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(257, 412);
            this.panel4.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.photosFormButtonLoader);
            this.panel6.Controls.Add(createdTimeLabel);
            this.panel6.Controls.Add(this.createdTimeLabel1);
            this.panel6.Controls.Add(descriptionLabel);
            this.panel6.Controls.Add(this.descriptionLabel1);
            this.panel6.Controls.Add(imageAlbumLabel);
            this.panel6.Controls.Add(this.imageAlbumRoundedPictureBox);
            this.panel6.Controls.Add(locationLabel);
            this.panel6.Controls.Add(this.locationLabel1);
            this.panel6.Controls.Add(messageLabel);
            this.panel6.Controls.Add(this.messageLabel1);
            this.panel6.Controls.Add(label1);
            this.panel6.Controls.Add(this.nameLabel1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(278, 15);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(661, 412);
            this.panel6.TabIndex = 13;
            // 
            // createdTimeLabel1
            // 
            this.createdTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "CreatedTime", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Not Available"));
            this.createdTimeLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdTimeLabel1.ForeColor = System.Drawing.Color.White;
            this.createdTimeLabel1.Location = new System.Drawing.Point(172, 122);
            this.createdTimeLabel1.Name = "createdTimeLabel1";
            this.createdTimeLabel1.Size = new System.Drawing.Size(228, 23);
            this.createdTimeLabel1.TabIndex = 14;
            this.createdTimeLabel1.Text = "label1";
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Not Available"));
            this.descriptionLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel1.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel1.Location = new System.Drawing.Point(172, 77);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(228, 23);
            this.descriptionLabel1.TabIndex = 17;
            this.descriptionLabel1.Text = "label1";
            // 
            // imageAlbumRoundedPictureBox
            // 
            this.imageAlbumRoundedPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageAlbum", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Not Available"));
            this.imageAlbumRoundedPictureBox.Location = new System.Drawing.Point(232, 256);
            this.imageAlbumRoundedPictureBox.Name = "imageAlbumRoundedPictureBox";
            this.imageAlbumRoundedPictureBox.Size = new System.Drawing.Size(150, 150);
            this.imageAlbumRoundedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAlbumRoundedPictureBox.TabIndex = 19;
            this.imageAlbumRoundedPictureBox.TabStop = false;
            this.imageAlbumRoundedPictureBox.URL = null;
            // 
            // locationLabel1
            // 
            this.locationLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Location", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Not Available"));
            this.locationLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel1.ForeColor = System.Drawing.Color.White;
            this.locationLabel1.Location = new System.Drawing.Point(172, 168);
            this.locationLabel1.Name = "locationLabel1";
            this.locationLabel1.Size = new System.Drawing.Size(236, 23);
            this.locationLabel1.TabIndex = 22;
            this.locationLabel1.Text = "label1";
            // 
            // messageLabel1
            // 
            this.messageLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Message", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Not Available"));
            this.messageLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel1.ForeColor = System.Drawing.Color.White;
            this.messageLabel1.Location = new System.Drawing.Point(172, 217);
            this.messageLabel1.Name = "messageLabel1";
            this.messageLabel1.Size = new System.Drawing.Size(228, 23);
            this.messageLabel1.TabIndex = 24;
            this.messageLabel1.Text = "label1";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "Not Available"));
            this.nameLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.ForeColor = System.Drawing.Color.White;
            this.nameLabel1.Location = new System.Drawing.Point(172, 37);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(228, 23);
            this.nameLabel1.TabIndex = 27;
            this.nameLabel1.Text = "label1";
            // 
            // photosFormButtonLoader
            // 
            this.photosFormButtonLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.photosFormButtonLoader.FlatAppearance.BorderSize = 0;
            this.photosFormButtonLoader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.photosFormButtonLoader.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photosFormButtonLoader.ForeColor = System.Drawing.Color.White;
            this.photosFormButtonLoader.Image = ((System.Drawing.Image)(resources.GetObject("photosFormButtonLoader.Image")));
            this.photosFormButtonLoader.Location = new System.Drawing.Point(20, 333);
            this.photosFormButtonLoader.Name = "photosFormButtonLoader";
            this.photosFormButtonLoader.Size = new System.Drawing.Size(186, 42);
            this.photosFormButtonLoader.TabIndex = 28;
            this.photosFormButtonLoader.Text = "     Load Album";
            this.photosFormButtonLoader.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.photosFormButtonLoader.UseVisualStyleBackColor = false;
            this.photosFormButtonLoader.Click += new System.EventHandler(this.PhotosFormButtonLoader_Click);
            this.photosFormButtonLoader.MouseEnter += new System.EventHandler(this.Buttons_MouseEnter);
            this.photosFormButtonLoader.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            // 
            // AlbumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 591);
            this.ControlBox = false;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AlbumsForm";
            this.Text = "AlbumsForm";
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumRoundedPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox albumsListBox;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.BindingSource photoBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label createdTimeLabel1;
        private System.Windows.Forms.Label descriptionLabel1;
        private custom_components.RoundedPictureBox imageAlbumRoundedPictureBox;
        private System.Windows.Forms.Label locationLabel1;
        private System.Windows.Forms.Label messageLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Button photosFormButtonLoader;
    }
}