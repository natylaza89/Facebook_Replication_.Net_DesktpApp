namespace DP_Task1.forms
{
    partial class PostsForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label messageLabel;
            this.postsListBox = new System.Windows.Forms.ListBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.postRoundedPictureBox = new DP_Task1.custom_components.RoundedPictureBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.messageLabel1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postRoundedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.Color.White;
            nameLabel.Location = new System.Drawing.Point(50, 34);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(76, 23);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            messageLabel.ForeColor = System.Drawing.Color.White;
            messageLabel.Location = new System.Drawing.Point(50, 116);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(104, 23);
            messageLabel.TabIndex = 2;
            messageLabel.Text = "Message:";
            // 
            // postsListBox
            // 
            this.postsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.postsListBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.postsListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postsListBox.DataSource = this.postBindingSource;
            this.postsListBox.DisplayMember = "CreatedTime";
            this.postsListBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postsListBox.ForeColor = System.Drawing.Color.Black;
            this.postsListBox.FormattingEnabled = true;
            this.postsListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.postsListBox.ItemHeight = 19;
            this.postsListBox.Location = new System.Drawing.Point(0, 0);
            this.postsListBox.Name = "postsListBox";
            this.postsListBox.Size = new System.Drawing.Size(264, 479);
            this.postsListBox.TabIndex = 0;
            this.postsListBox.SelectedValueChanged += new System.EventHandler(this.PostsListBox_SelectedValueChanged);
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 28);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 563);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(60, 509);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(879, 82);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.postsListBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(60, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 481);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.postRoundedPictureBox);
            this.panel5.Controls.Add(nameLabel);
            this.panel5.Controls.Add(messageLabel);
            this.panel5.Controls.Add(this.nameLabel1);
            this.panel5.Controls.Add(this.messageLabel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(330, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(609, 481);
            this.panel5.TabIndex = 6;
            // 
            // postRoundedPictureBox
            // 
            this.postRoundedPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.postBindingSource, "PictureURL", true));
            this.postRoundedPictureBox.Location = new System.Drawing.Point(168, 239);
            this.postRoundedPictureBox.Name = "postRoundedPictureBox";
            this.postRoundedPictureBox.Size = new System.Drawing.Size(254, 212);
            this.postRoundedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.postRoundedPictureBox.TabIndex = 6;
            this.postRoundedPictureBox.TabStop = false;
            this.postRoundedPictureBox.URL = null;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "*Not Mentioned*"));
            this.nameLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.ForeColor = System.Drawing.Color.White;
            this.nameLabel1.Location = new System.Drawing.Point(168, 34);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(314, 55);
            this.nameLabel1.TabIndex = 5;
            this.nameLabel1.Text = "label1";
            // 
            // messageLabel1
            // 
            this.messageLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "*Not Mentioned*"));
            this.messageLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel1.ForeColor = System.Drawing.Color.White;
            this.messageLabel1.Location = new System.Drawing.Point(168, 116);
            this.messageLabel1.Name = "messageLabel1";
            this.messageLabel1.Size = new System.Drawing.Size(414, 95);
            this.messageLabel1.TabIndex = 3;
            this.messageLabel1.Text = "label1";
            // 
            // PostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 591);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PostsForm";
            this.Text = "PostsForm";
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postRoundedPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox postsListBox;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private custom_components.RoundedPictureBox postRoundedPictureBox;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label messageLabel1;
    }
}