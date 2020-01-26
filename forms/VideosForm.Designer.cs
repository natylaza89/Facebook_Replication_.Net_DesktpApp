namespace DP_Task1.forms
{
    partial class VideosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideosForm));
            this.videosListBox = new System.Windows.Forms.ListBox();
            this.axShockwaveFlash = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.mySplitter1 = new DP_Task1.custom_components.MySplitter();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash)).BeginInit();
            this.SuspendLayout();
            // 
            // videosListBox
            // 
            this.videosListBox.FormattingEnabled = true;
            this.videosListBox.ItemHeight = 16;
            this.videosListBox.Location = new System.Drawing.Point(141, 95);
            this.videosListBox.Name = "videosListBox";
            this.videosListBox.Size = new System.Drawing.Size(258, 292);
            this.videosListBox.TabIndex = 1;
            this.videosListBox.SelectedValueChanged += new System.EventHandler(this.VideosListBox_SelectedValueChanged);
            // 
            // axShockwaveFlash
            // 
            this.axShockwaveFlash.Enabled = true;
            this.axShockwaveFlash.Location = new System.Drawing.Point(343, 76);
            this.axShockwaveFlash.Name = "axShockwaveFlash";
            this.axShockwaveFlash.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash.OcxState")));
            this.axShockwaveFlash.Size = new System.Drawing.Size(240, 240);
            this.axShockwaveFlash.TabIndex = 3;
            // 
            // mySplitter1
            // 
            this.mySplitter1.Location = new System.Drawing.Point(0, 0);
            this.mySplitter1.Name = "mySplitter1";
            this.mySplitter1.Size = new System.Drawing.Size(3, 916);
            this.mySplitter1.TabIndex = 2;
            this.mySplitter1.TabStop = false;
            // 
            // VideosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1625, 916);
            this.Controls.Add(this.axShockwaveFlash);
            this.Controls.Add(this.mySplitter1);
            this.Controls.Add(this.videosListBox);
            this.Name = "VideosForm";
            this.Text = "VideosForm";
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox videosListBox;
        private DP_Task1.custom_components.MySplitter mySplitter1;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash;
    }
}