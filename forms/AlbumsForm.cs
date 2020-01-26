using DP_Task1.custom_components;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DP_Task1.forms
{
    public partial class AlbumsForm : Form
    {
        readonly User m_LoggedInUser;
        readonly Dictionary<string, Album> m_MyAlbumsData = new Dictionary<string, Album>();
        readonly MessageAnnouncer m_AnnouncerObject;
        private const string k_MessageToAnnounce = "Albums To Display";
        public Album CurrentAlbum { get; set; }
        public AppMainForm MainFormRef { get; set; }
        public AlbumsForm(User i_LoggedInUser, AppMainForm i_MainForm)
        {
            m_LoggedInUser = i_LoggedInUser;
            MainFormRef = i_MainForm;
            m_AnnouncerObject = MessageAnnouncer.Instance;
            InitializeComponent();
            
            if (MainFormRef.TextToSpeachStatus)
            {
                MessageAnnouncement();
            }
            fetchDataIntoAlbumsForm();
        }
        private void fetchDataIntoAlbumsForm()
        {
            albumBindingSource.DataSource = m_LoggedInUser.Albums;
        }
        public void MessageAnnouncement()
        {
            m_AnnouncerObject.MessageToAnnounce = string.Format("{0} {1}", m_LoggedInUser.Albums.Count, k_MessageToAnnounce); ;
            m_AnnouncerObject.MessageAnnouncement();
        }
        private void PhotosFormButtonLoader_Click(object sender, EventArgs e)
        {
            string buttonClickedName = (sender as Button).Name;

            CurrentAlbum = albumBindingSource.Current as Album;
            Form subForm = SubFormFactory.CreateSubForm(buttonClickedName, m_LoggedInUser, CurrentAlbum, MainFormRef);

            subForm.ShowDialog();
        }
        private void Buttons_MouseEnter(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            mouseHoverDesignBehaviour(ref selectedButton, Cursors.Hand, FontStyle.Bold, Color.Red);
        }
        private void Buttons_MouseLeave(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            mouseHoverDesignBehaviour(ref selectedButton, Cursors.Arrow, FontStyle.Regular, Color.LightGray);
        }

        private void mouseHoverDesignBehaviour(ref Button io_SelectedButton, Cursor i_CursorDesign, FontStyle i_FontStyle,  Color i_HoverColor)
        {
            io_SelectedButton.Cursor = i_CursorDesign;
            io_SelectedButton.Font = new Font(io_SelectedButton.Font, i_FontStyle);
            io_SelectedButton.ForeColor = i_HoverColor;
        }
    }
}
