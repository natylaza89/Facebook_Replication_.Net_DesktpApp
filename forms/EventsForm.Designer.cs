namespace DP_Task1.forms
{
    partial class EventsForm
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label startTimeLabel;
            this.eventListBox = new System.Windows.Forms.ListBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.endTimeLabel1 = new System.Windows.Forms.Label();
            this.imageNormalRoundedPictureBox = new DP_Task1.custom_components.RoundedPictureBox();
            this.locationLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.startTimeLabel1 = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalRoundedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            descriptionLabel.Cursor = System.Windows.Forms.Cursors.Default;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.ForeColor = System.Drawing.Color.White;
            descriptionLabel.Location = new System.Drawing.Point(280, 103);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(112, 20);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.BackColor = System.Drawing.Color.Transparent;
            endTimeLabel.Cursor = System.Windows.Forms.Cursors.Default;
            endTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            endTimeLabel.ForeColor = System.Drawing.Color.White;
            endTimeLabel.Location = new System.Drawing.Point(280, 205);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(94, 20);
            endTimeLabel.TabIndex = 4;
            endTimeLabel.Text = "End Time:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.BackColor = System.Drawing.Color.Transparent;
            locationLabel.Cursor = System.Windows.Forms.Cursors.Default;
            locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationLabel.ForeColor = System.Drawing.Color.White;
            locationLabel.Location = new System.Drawing.Point(280, 151);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(87, 20);
            locationLabel.TabIndex = 8;
            locationLabel.Text = "Location:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.Color.Transparent;
            nameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.Color.White;
            nameLabel.Location = new System.Drawing.Point(280, 76);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(63, 20);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Name:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.BackColor = System.Drawing.Color.Transparent;
            startTimeLabel.Cursor = System.Windows.Forms.Cursors.Default;
            startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            startTimeLabel.ForeColor = System.Drawing.Color.White;
            startTimeLabel.Location = new System.Drawing.Point(280, 178);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(103, 20);
            startTimeLabel.TabIndex = 12;
            startTimeLabel.Text = "Start Time:";
            // 
            // eventListBox
            // 
            this.eventListBox.DataSource = this.eventBindingSource;
            this.eventListBox.DisplayMember = "Name";
            this.eventListBox.FormattingEnabled = true;
            this.eventListBox.ItemHeight = 16;
            this.eventListBox.Location = new System.Drawing.Point(40, 78);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.Size = new System.Drawing.Size(212, 340);
            this.eventListBox.TabIndex = 0;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel1.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel1.Location = new System.Drawing.Point(385, 103);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(149, 48);
            this.descriptionLabel1.TabIndex = 3;
            this.descriptionLabel1.Text = "label1";
            // 
            // endTimeLabel1
            // 
            this.endTimeLabel1.BackColor = System.Drawing.Color.Transparent;
            this.endTimeLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.endTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "EndTime", true));
            this.endTimeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeLabel1.ForeColor = System.Drawing.Color.White;
            this.endTimeLabel1.Location = new System.Drawing.Point(385, 205);
            this.endTimeLabel1.Name = "endTimeLabel1";
            this.endTimeLabel1.Size = new System.Drawing.Size(200, 23);
            this.endTimeLabel1.TabIndex = 5;
            this.endTimeLabel1.Text = "label1";
            // 
            // imageNormalRoundedPictureBox
            // 
            this.imageNormalRoundedPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.imageNormalRoundedPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.imageNormalRoundedPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.imageNormalRoundedPictureBox.Location = new System.Drawing.Point(302, 254);
            this.imageNormalRoundedPictureBox.Name = "imageNormalRoundedPictureBox";
            this.imageNormalRoundedPictureBox.Size = new System.Drawing.Size(130, 130);
            this.imageNormalRoundedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalRoundedPictureBox.TabIndex = 7;
            this.imageNormalRoundedPictureBox.TabStop = false;
            this.imageNormalRoundedPictureBox.URL = null;
            // 
            // locationLabel1
            // 
            this.locationLabel1.BackColor = System.Drawing.Color.Transparent;
            this.locationLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.locationLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true));
            this.locationLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel1.ForeColor = System.Drawing.Color.White;
            this.locationLabel1.Location = new System.Drawing.Point(385, 151);
            this.locationLabel1.Name = "locationLabel1";
            this.locationLabel1.Size = new System.Drawing.Size(149, 23);
            this.locationLabel1.TabIndex = 9;
            this.locationLabel1.Text = "label1";
            // 
            // nameLabel1
            // 
            this.nameLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Name", true));
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.ForeColor = System.Drawing.Color.White;
            this.nameLabel1.Location = new System.Drawing.Point(385, 76);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(200, 23);
            this.nameLabel1.TabIndex = 11;
            this.nameLabel1.Text = "label1";
            // 
            // startTimeLabel1
            // 
            this.startTimeLabel1.BackColor = System.Drawing.Color.Transparent;
            this.startTimeLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.startTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "StartTime", true));
            this.startTimeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeLabel1.ForeColor = System.Drawing.Color.White;
            this.startTimeLabel1.Location = new System.Drawing.Point(385, 178);
            this.startTimeLabel1.Name = "startTimeLabel1";
            this.startTimeLabel1.Size = new System.Drawing.Size(200, 23);
            this.startTimeLabel1.TabIndex = 13;
            this.startTimeLabel1.Text = "label1";
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1625, 816);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionLabel1);
            this.Controls.Add(endTimeLabel);
            this.Controls.Add(this.endTimeLabel1);
            this.Controls.Add(this.imageNormalRoundedPictureBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationLabel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(startTimeLabel);
            this.Controls.Add(this.startTimeLabel1);
            this.Controls.Add(this.eventListBox);
            this.DoubleBuffered = true;
            this.Name = "EventsForm";
            this.Text = "EventsForm";
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalRoundedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox eventListBox;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.Label endTimeLabel1;
        private DP_Task1.custom_components.RoundedPictureBox imageNormalRoundedPictureBox;
        private System.Windows.Forms.Label locationLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label startTimeLabel1;
    }
}