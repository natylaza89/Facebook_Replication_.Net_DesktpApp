using DP_Task1.custom_components;
using FacebookWrapper.ObjectModel;
using System;
using System.Threading;
using System.Windows.Forms;

namespace DP_Task1.forms
{
    public partial class PostsForm : Form
    {
        readonly User m_LoggedInUser;
        readonly MessageAnnouncer m_AnnouncerObject;
        public string MessageToAnnounce { get; set; }
        private const string k_MessageToAnnounce = "Posts On You Wall To Display";
        public AppMainForm MainFormRef { get; set; }
        public PostsForm(User i_m_LoggedInUser, AppMainForm i_MainForm)
        {
            m_LoggedInUser = i_m_LoggedInUser;
            MainFormRef = i_MainForm;
            m_AnnouncerObject = MessageAnnouncer.Instance;
            InitializeComponent();
        }
        private void fetchPostsDataIntoPostsForm()
        {
            if (MainFormRef.TextToSpeachStatus)
            {
                messageAnnouncement();
            }
            this.Invoke(new Action(() => postBindingSource.DataSource = m_LoggedInUser.Posts));
        }
        private void messageAnnouncement()
        {
            m_AnnouncerObject.MessageToAnnounce = string.Format("{0} {1}", m_LoggedInUser.Posts.Count, k_MessageToAnnounce); ;
            m_AnnouncerObject.MessageAnnouncement();
        }
        private void PostsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Post currentPost = (sender as ListBox).SelectedItem as Post;

            if (currentPost != null)
            {
                postRoundedPictureBox.ImageLocation = currentPost.PictureURL;
            }
        }
        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
            new Thread(fetchPostsDataIntoPostsForm).Start();
        }
    }
}