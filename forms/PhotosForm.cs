using DP_Task1.custom_components;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace DP_Task1.forms
{
    public partial class PhotosForm : Form
    {
        readonly User m_LoggedInUser;
        readonly Dictionary<string, Photo> m_MyPhotosData = new Dictionary<string, Photo>();
        readonly Album m_CurrentAlbum;
        readonly MessageAnnouncer m_AnnouncerObject;
        public AppMainForm MainFormRef { get; set; }
        public PhotosForm(User i_LoggedInUser, Album i_CurrentAlbum, AppMainForm i_MainForm)
        {
            m_LoggedInUser = i_LoggedInUser;
            m_CurrentAlbum = i_CurrentAlbum;
            MainFormRef = i_MainForm;
            m_AnnouncerObject = MessageAnnouncer.Instance;
            InitializeComponent();
            this.Text = m_CurrentAlbum.Name;
            if (MainFormRef.TextToSpeachStatus)
            {
                new Thread(messageAnnouncement).Start();
            }

            new Thread(loadAlbumPhotos).Start();
        }
        private void messageAnnouncement()
        {
            const string k_MessageToAnnounce = "In Order To View Photos Just Click On The Desired Picture";
            m_AnnouncerObject.MessageAnnouncement(string.Format("{0} , {1}", m_CurrentAlbum.Name, k_MessageToAnnounce));
        }
        private void loadAlbumPhotos()
        {
            const int k_Left = 40;
            const byte k_BottomReference = 10;
            int top = 5;
            int tabIndex = 100;

            foreach (Photo currentPhoto in m_CurrentAlbum.Photos)
            {
                LazyPictureBox currentLazyPictureBox = createLazyPictureBox(currentPhoto, ref tabIndex, top, k_Left);
                m_MyPhotosData.Add(currentLazyPictureBox.Name, currentPhoto);
                photosPanel.Invoke(new Action(() => photosPanel.Controls.Add(currentLazyPictureBox)));
                top = currentLazyPictureBox.Bottom + k_BottomReference;
                currentLazyPictureBox.MouseHover += this.LazyPictureBox_MouseHover;
                currentLazyPictureBox.MouseLeave += this.LazyPictureBox_MouseLeave;
            }
        }
        private void LazyPictureBox_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
        private void LazyPictureBox_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private LazyPictureBox createLazyPictureBox(Photo i_CurrentPhoto, ref int io_TabIndex, int i_Top, int i_Left)
        {
            LazyPictureBox currentPictureBox = new LazyPictureBox();
            const string k_PictureBoxName = "photoPictureBox";
            const int k_PictureBoxSize = 175;

            currentPictureBox.Size = new Size(k_PictureBoxSize, k_PictureBoxSize);
            currentPictureBox.Left = i_Left;
            currentPictureBox.Top = i_Top;
            currentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            currentPictureBox.Load(i_CurrentPhoto.PictureNormalURL);
            currentPictureBox.Name = string.Format("{0}{1}", k_PictureBoxName, io_TabIndex++);
            currentPictureBox.Click += new System.EventHandler(lazyPictureBox_Click);

            return currentPictureBox;
        }
        private void lazyPictureBox_Click(object sender, EventArgs e)
        {
            LazyPictureBox clickedLazyPictureBox = sender as LazyPictureBox;

            photoBinding(clickedLazyPictureBox.Name);
        }
        private void photoBinding(string i_LazyPictureBoxName)
        {
            try
            {
                photoBindingSource.DataSource = m_MyPhotosData[i_LazyPictureBoxName];
            }
            catch (KeyNotFoundException knfe)
            {
                const string k_ErrorMessage = "Album Couldn't Load Because It's Not Exist! Please Try Other One!";
                m_AnnouncerObject.MessageAnnouncement(k_ErrorMessage);
                MessageBox.Show(k_ErrorMessage);
            }
        }
    }
}
