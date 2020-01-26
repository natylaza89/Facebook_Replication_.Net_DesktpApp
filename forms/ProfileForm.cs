using DP_Task1.custom_components;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DP_Task1.forms
{
    public partial class ProfileForm : Form
    {
        readonly User m_LoggedInUser;
        readonly MessageAnnouncer m_AnnouncerObject;
        private const string k_AnnounceMessage = "In order to read the profile make a double click on your mouse";
        public AppMainForm MainFormRef { get; set; }
        public ProfileForm(User i_m_LoggedInUser, AppMainForm i_MainForm)
        {
            m_LoggedInUser = i_m_LoggedInUser;
            MainFormRef = i_MainForm;
            m_AnnouncerObject = MessageAnnouncer.Instance;
            InitializeComponent();
            new Thread(fetchDataIntoProfileForm).Start();
        }
        private void messageAnnouncement()
        {
            string userProfile = string.Format("{0}'s Profile", m_LoggedInUser.Name);
            string textToSpeach = string.Format("{0}, {1}", userProfile, k_AnnounceMessage);

            m_AnnouncerObject.MessageAnnouncement(textToSpeach);
        }
        private void fetchDataIntoProfileForm()
        {
            userBindingSource.DataSource = m_LoggedInUser;
        }
        private void ProfileForm_DoubleClick(object sender, EventArgs e)
        {
            StringBuilder controlsTextHolders = new StringBuilder();
            SortedDictionary<int, string> profileControls = new SortedDictionary<int, string>();

            if (MainFormRef.TextToSpeachStatus)
            {

                foreach (Control currentControl in this.Controls)
                {
                    if (!string.IsNullOrEmpty(currentControl.Text))
                    {
                        profileControls.Add(currentControl.TabIndex, currentControl.Text);
                    }

                }

                foreach (string currentString in profileControls.Values)
                {
                    controlsTextHolders.Append(string.Format("{0}, ", currentString));
                }

                m_AnnouncerObject.MessageAnnouncement(controlsTextHolders.ToString());
            }
        }
        private void MainTitleLabel_Paint(object sender, PaintEventArgs e)
        {
            if (MainFormRef.TextToSpeachStatus)
            {
                messageAnnouncement();
            }
        }
    }
}

