using DP_Task1.custom_components;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace DP_Task1.forms
{
    public partial class AppMainForm : Form
    {
        public LoginResult UserLoginResult { get; set; }
        public User LoggedInUser { get; set; }
        public MessageAnnouncer AnnouncerObject { get; set; }
        public bool TextToSpeachStatus { get; set; }
        public bool IsLoggedIn { get; set; }
        private bool m_Dragging = false;
        private Point m_DragCursorPoint;
        private Point m_DragFormPoint;
        public AppMainForm()
        {
            InitializeComponent();
            TextToSpeachStatus = true;
            AnnouncerObject = MessageAnnouncer.Instance;
        }
        private void PictureBoxMinimize_Click(object sender, EventArgs e)
        {
            Hide();
            this.WindowState = FormWindowState.Minimized;
            this.iconTray.Visible = true;
            this.iconTray.ShowBalloonTip(1000);
        }
        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            OnClosing(e as CancelEventArgs);
            Application.Exit();
        }
        private void IconTray_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            this.iconTray.Visible = false;
        }
        private void AppMainForm_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.iconTray.Visible = false;
            this.ShowIcon = true;
        }
        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            m_Dragging = true;
            m_DragCursorPoint = Cursor.Position;
            m_DragFormPoint = this.Location;
        }
        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_Dragging)
            {
                Point offset = Point.Subtract(Cursor.Position, new Size(m_DragCursorPoint));
                this.Location = Point.Add(m_DragFormPoint, new Size(offset));
            }
        }
        private void PanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            m_Dragging = false;
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
        private void mouseHoverDesignBehaviour(ref Button io_SelectedButton, Cursor i_CursorDesign, FontStyle i_FontStyle, Color i_HoverColor)
        {
            io_SelectedButton.Cursor = i_CursorDesign;
            io_SelectedButton.Font = new Font(io_SelectedButton.Font, i_FontStyle);
            io_SelectedButton.ForeColor = i_HoverColor;
        }
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserLoginResult = FacebookService.Login("983872545338944",

                "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "publish_to_groups",
                "groups_access_member_info",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_hometown"

                );
            }
            catch (Facebook.FacebookOAuthException)
            {
                IsLoggedIn = false;
            }
            finally
            {
                IsLoggedIn = true;
            }

            new Thread(loginProcess).Start();
        }
        private void contextPannelHandler(Form i_MyCustomeForm)
        {
            i_MyCustomeForm.TopLevel = false;
            i_MyCustomeForm.AutoScroll = true;
            i_MyCustomeForm.FormBorderStyle = FormBorderStyle.None;

            if (this.contextPannel.Controls.Count != 0)
            {
                this.contextPannel.Controls.Clear();
            }
            this.contextPannel.Controls.Add(i_MyCustomeForm);

            i_MyCustomeForm.Show();
        }
        private void initializeMainUIAfterLogin()
        {
            LoggedInUser = UserLoginResult.LoggedInUser;
            //TODO for future: logout also...
            buttonLogin.Invoke(new Action(() => this.buttonLogin.Hide()));
            mainTitleLabel.Invoke(new Action(() => this.mainTitleLabel.Text = string.Format("{0} {1}{2}", "Welcome",
                                                                  LoggedInUser.FirstName,
                                                                  Environment.NewLine)));
            mainTitleLabel.Invoke(new Action(() => this.mainTitleLabel.Left -= LoggedInUser.FirstName.Length * 20));
            this.roundedUserPictureBox.LoadAsync(LoggedInUser.PictureNormalURL);

            if (TextToSpeachStatus && !string.IsNullOrEmpty(LoggedInUser.Name))
            {
                AnnouncerObject.MessageAnnouncement(string.Format("Welcome {0}!", LoggedInUser.Name));
            }
        }
        private void InitializeAutoLogin()
        {
            try
            {
                UserLoginResult = FacebookService.Connect(AppSettings.Instance.AccessToken);
                IsLoggedIn = true;
                new Thread(loginProcess).Start();
            }
            catch (Facebook.FacebookOAuthException)
            {
                MessageBox.Show("Malformed or Wrong Access Token Loaded");
            }
            catch (System.ArgumentNullException)
            {
                MessageBox.Show("Malformed or Wrong Access Token Loaded");
            }
            catch (Facebook.WebExceptionWrapper)
            {
                MessageBox.Show("No Internet Connection");
            }
        }
        private void loginProcess()
        {
            try
            {
                new Thread(initializeMainUIAfterLogin).Start();
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("No Internet Connection");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Couldn't Initialize Connection to Facebook Application");
            }
            catch (Facebook.FacebookOAuthException)
            {
                MessageBox.Show(UserLoginResult.ErrorMessage);
            }
        }
        private void SidePannelButton_Click(object sender, EventArgs e)
        {
            const string k_ErrorMessage = "You're Not Logged In!";

            Form subForm = null;

            if (IsLoggedIn)
            {
                string buttonClickedName = (sender as Button).Name;
                string classTypeStringBefore = buttonClickedName.Split(new[] { "button" }, StringSplitOptions.None)[1];
                //string classTypeStringAfter = string.Format("{0}{1}",
                //                                            classTypeStringBefore.Substring(0, 1).ToUpper(),
                //                                            classTypeStringBefore.Substring(1));
                Type formType = typeof(AppMainForm);

                try
                {
                    formType = Type.GetType(string.Format("{0}.{1}", formType.Namespace, classTypeStringBefore));
                    subForm = FormsRepository.Instance.GetReference(formType);
                }
                catch (KeyNotFoundException)
                {
                    subForm = SubFormFactory.CreateSubForm(buttonClickedName, LoggedInUser, null, this);
                    FormsRepository.Instance.AddPrototype(subForm, formType);
                }
                finally
                {
                    this.labelFormDescription.Text = string.Format("{0}'s {1}", LoggedInUser.Name, (sender as Button).Text.Trim());
                    contextPannelHandler(subForm);
                }
            }
            else
            {

                if (TextToSpeachStatus)
                {
                    AnnouncerObject.MessageAnnouncement(k_ErrorMessage);
                }

                MessageBox.Show(k_ErrorMessage);
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            try
            {
                AppSettings.Instance.AccessToken = UserLoginResult.AccessToken;
            }
            catch (NullReferenceException)
            {
                AppSettings.Instance.AccessToken = string.Empty;
            }

            AppSettings.Instance.TextToSpeachStatus = this.TextToSpeachStatus;

            try
            {
                SettingsForm settingsForm = FormsRepository.Instance.GetReference(typeof(SettingsForm)) as SettingsForm;
                AppSettings.Instance.AutoLogin = settingsForm.AutoLogin;
            }
            catch (KeyNotFoundException)
            {
                AppSettings.Instance.AutoLogin = false;
            }

            AppSettings.Instance.Save();
            base.OnClosing(e);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.TextToSpeachStatus = AppSettings.Instance.TextToSpeachStatus;
            SettingsForm settingsForm = null;

            try
            {
                settingsForm = FormsRepository.Instance.GetReference(typeof(SettingsForm)) as SettingsForm;
                settingsForm.AutoLogin = AppSettings.Instance.AutoLogin;
            }
            catch (KeyNotFoundException)
            {
                //MessageBox.Show("Saved Settings Couldn't be Loaded!");
            }
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (AppSettings.Instance.AutoLogin)
            {
                InitializeAutoLogin();
            }
        }
    }
}
