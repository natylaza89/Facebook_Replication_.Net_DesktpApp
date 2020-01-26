using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DP_Task1.forms
{
    public partial class VideosForm : Form
    {
        User m_LoggedInUser;
        Dictionary<string, Video> m_MyVideosData = new Dictionary<string, Video>();
        Video m_CurrentVideo;
        public VideosForm(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            fetchVideosDataIntoVideosForm();
        }

        private void fetchVideosDataIntoVideosForm()
        {
            foreach (Video currentVideo in m_LoggedInUser.Videos)
            {
                videosListBox.Items.Add(currentVideo.Id);
                bool isDuplicateAlbum = m_MyVideosData.ContainsKey(currentVideo.Id);
                if (!isDuplicateAlbum)
                {
                    m_MyVideosData.Add(currentVideo.Id, currentVideo);
                }
            }
        }

        private void VideosListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            Video tempVideo = null;

            m_MyVideosData.TryGetValue(listBox.SelectedItem.ToString(), out tempVideo);
            if (tempVideo != null)
            {
                axShockwaveFlash.Movie = tempVideo.URL;
                //this.videosPlayer.URL = tempVideo.URL;
                //this.videosPlayer.settings.autoStart = true;
                //this.videosPlayer.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("Couldn't Play The Video");
            }

        }
    }
}
