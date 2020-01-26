namespace DP_Task1.forms

{
    partial class PhotosForm
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
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotosForm));
            this.photosPanel = new System.Windows.Forms.Panel();
            this.photoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createdTimeLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.imageNormalRoundedPictureBox = new DP_Task1.custom_components.RoundedPictureBox();
            createdTimeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalRoundedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.BackColor = System.Drawing.Color.Transparent;
            createdTimeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            createdTimeLabel.ForeColor = System.Drawing.Color.White;
            createdTimeLabel.Location = new System.Drawing.Point(410, 13);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(147, 23);
            createdTimeLabel.TabIndex = 2;
            createdTimeLabel.Text = "Created Time:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.Color.Transparent;
            nameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.Color.White;
            nameLabel.Location = new System.Drawing.Point(410, 57);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(76, 23);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name:";
            // 
            // photosPanel
            // 
            this.photosPanel.AutoScroll = true;
            this.photosPanel.BackColor = System.Drawing.Color.Transparent;
            this.photosPanel.Location = new System.Drawing.Point(12, 12);
            this.photosPanel.Name = "photosPanel";
            this.photosPanel.Size = new System.Drawing.Size(367, 473);
            this.photosPanel.TabIndex = 0;
            // 
            // photoBindingSource
            // 
            this.photoBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Photo);
            // 
            // createdTimeLabel1
            // 
            this.createdTimeLabel1.BackColor = System.Drawing.Color.Transparent;
            this.createdTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoBindingSource, "CreatedTime", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "*Not Mentioned*"));
            this.createdTimeLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdTimeLabel1.ForeColor = System.Drawing.Color.White;
            this.createdTimeLabel1.Location = new System.Drawing.Point(588, 13);
            this.createdTimeLabel1.Name = "createdTimeLabel1";
            this.createdTimeLabel1.Size = new System.Drawing.Size(325, 23);
            this.createdTimeLabel1.TabIndex = 3;
            this.createdTimeLabel1.Text = "*Not Mentioned*";
            // 
            // nameLabel1
            // 
            this.nameLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "*Not Mentioned*"));
            this.nameLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.ForeColor = System.Drawing.Color.White;
            this.nameLabel1.Location = new System.Drawing.Point(588, 59);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(325, 23);
            this.nameLabel1.TabIndex = 7;
            this.nameLabel1.Text = "*Not Mentioned*";
            // 
            // imageNormalRoundedPictureBox
            // 
            this.imageNormalRoundedPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photoBindingSource, "ImageNormal", true));
            this.imageNormalRoundedPictureBox.Location = new System.Drawing.Point(593, 107);
            this.imageNormalRoundedPictureBox.Name = "imageNormalRoundedPictureBox";
            this.imageNormalRoundedPictureBox.Size = new System.Drawing.Size(350, 350);
            this.imageNormalRoundedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalRoundedPictureBox.TabIndex = 8;
            this.imageNormalRoundedPictureBox.TabStop = false;
            this.imageNormalRoundedPictureBox.URL = null;
            // 
            // PhotosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1119, 522);
            this.Controls.Add(this.imageNormalRoundedPictureBox);
            this.Controls.Add(createdTimeLabel);
            this.Controls.Add(this.createdTimeLabel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.photosPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PhotosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhotosForm";
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalRoundedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel photosPanel;
        private System.Windows.Forms.BindingSource photoBindingSource;
        private System.Windows.Forms.Label createdTimeLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private DP_Task1.custom_components.RoundedPictureBox imageNormalRoundedPictureBox;
    }
}