namespace DP_Task1.forms
{
    partial class SettingsForm
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
            System.Windows.Forms.Label textToSpeachStatusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            System.Windows.Forms.Label autoLoginLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.autoLoginCheckBox = new System.Windows.Forms.CheckBox();
            this.textToSpeachCheckBox = new System.Windows.Forms.CheckBox();
            this.appMainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            textToSpeachStatusLabel = new System.Windows.Forms.Label();
            autoLoginLabel = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appMainFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textToSpeachStatusLabel
            // 
            textToSpeachStatusLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textToSpeachStatusLabel.ForeColor = System.Drawing.Color.White;
            textToSpeachStatusLabel.Image = ((System.Drawing.Image)(resources.GetObject("textToSpeachStatusLabel.Image")));
            textToSpeachStatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            textToSpeachStatusLabel.Location = new System.Drawing.Point(280, 160);
            textToSpeachStatusLabel.Name = "textToSpeachStatusLabel";
            textToSpeachStatusLabel.Size = new System.Drawing.Size(314, 36);
            textToSpeachStatusLabel.TabIndex = 12;
            textToSpeachStatusLabel.Text = "    Text To Speach Status:";
            textToSpeachStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autoLoginLabel
            // 
            autoLoginLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            autoLoginLabel.ForeColor = System.Drawing.Color.White;
            autoLoginLabel.Image = ((System.Drawing.Image)(resources.GetObject("autoLoginLabel.Image")));
            autoLoginLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            autoLoginLabel.Location = new System.Drawing.Point(280, 218);
            autoLoginLabel.Name = "autoLoginLabel";
            autoLoginLabel.Size = new System.Drawing.Size(221, 29);
            autoLoginLabel.TabIndex = 13;
            autoLoginLabel.Text = "    Auto Login:";
            autoLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(26, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(844, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "    Settings Are Auto Saved/Loaded when Closing/Reopening the Application.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 36);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(31, 486);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(31, 492);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(969, 30);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(990, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 456);
            this.panel4.TabIndex = 13;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(autoLoginLabel);
            this.panelMain.Controls.Add(this.autoLoginCheckBox);
            this.panelMain.Controls.Add(textToSpeachStatusLabel);
            this.panelMain.Controls.Add(this.textToSpeachCheckBox);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(31, 36);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(938, 456);
            this.panelMain.TabIndex = 14;
            // 
            // autoLoginCheckBox
            // 
            this.autoLoginCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.autoLoginCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("autoLoginCheckBox.BackgroundImage")));
            this.autoLoginCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.autoLoginCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autoLoginCheckBox.FlatAppearance.BorderSize = 0;
            this.autoLoginCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.autoLoginCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.autoLoginCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.autoLoginCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoLoginCheckBox.Location = new System.Drawing.Point(580, 218);
            this.autoLoginCheckBox.Name = "autoLoginCheckBox";
            this.autoLoginCheckBox.Size = new System.Drawing.Size(64, 27);
            this.autoLoginCheckBox.TabIndex = 14;
            this.autoLoginCheckBox.UseVisualStyleBackColor = true;
            this.autoLoginCheckBox.CheckedChanged += new System.EventHandler(this.AutoLoginCheckBox_CheckedChanged);
            this.autoLoginCheckBox.Click += new System.EventHandler(this.CheckBoxToggle_Click);
            // 
            // textToSpeachCheckBox
            // 
            this.textToSpeachCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.textToSpeachCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textToSpeachCheckBox.BackgroundImage")));
            this.textToSpeachCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.textToSpeachCheckBox.Checked = global::DP_Task1.Properties.Settings.Default.MainFormRef;
            this.textToSpeachCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textToSpeachCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.appMainFormBindingSource, "TextToSpeachStatus", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textToSpeachCheckBox.FlatAppearance.BorderSize = 0;
            this.textToSpeachCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.textToSpeachCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.textToSpeachCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.textToSpeachCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textToSpeachCheckBox.Location = new System.Drawing.Point(580, 169);
            this.textToSpeachCheckBox.Name = "textToSpeachCheckBox";
            this.textToSpeachCheckBox.Size = new System.Drawing.Size(64, 27);
            this.textToSpeachCheckBox.TabIndex = 13;
            this.textToSpeachCheckBox.UseVisualStyleBackColor = true;
            this.textToSpeachCheckBox.CheckedChanged += new System.EventHandler(this.TextToSpeachCheckBox_CheckedChanged);
            this.textToSpeachCheckBox.Click += new System.EventHandler(this.CheckBoxToggle_Click);
            // 
            // appMainFormBindingSource
            // 
            this.appMainFormBindingSource.DataSource = typeof(DP_Task1.forms.AppMainForm);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 522);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appMainFormBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.CheckBox textToSpeachCheckBox;
        private System.Windows.Forms.BindingSource appMainFormBindingSource;
        private System.Windows.Forms.CheckBox autoLoginCheckBox;
    }
}