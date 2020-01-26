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
    public partial class MainForm : Form
    {
        public LoginResult UserLoginResult { get; set; }
        public User LoggedInUser { get; set; }
        public MessageAnnouncer AnnouncerObject { get; set; }
        public bool TextToSpeachStatus { get; set; }
        public bool IsLoggedIn { get; set; }

        public MainForm()
        {
            InitializeComponent();
            TextToSpeachStatus = true;
            AnnouncerObject = MessageAnnouncer.Instance;
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
            //AccessToken = UserLoginResult.AccessToken;
            LoggedInUser = UserLoginResult.LoggedInUser;
            //TODO for future: logout also...
            loginButton.Invoke(new Action(() => this.loginButton.Hide()));
            mainTitleLabel.Invoke(new Action(() => this.mainTitleLabel.Text = string.Format("{0} {1}{2}", "Welcome",
                                                                  LoggedInUser.FirstName,
                                                                  Environment.NewLine)));
            mainTitleLabel.Invoke(new Action(() => this.mainTitleLabel.Left -= LoggedInUser.FirstName.Length * 20));
            this.roundedPictureBox1.LoadAsync(LoggedInUser.PictureNormalURL);


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
        private void LoginButton_Click(object sender, EventArgs e)
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
        private void SidePannelButton_Click(object sender, EventArgs e)
        {
            const string k_ErrorMessage = "You're Not Logged In!";

            Form subForm = null;

            if (IsLoggedIn)
            {
                string buttonClickedName = (sender as Button).Name;
                string classTypeStringBefore = buttonClickedName.Split(new[] { "Button" }, StringSplitOptions.None)[0];
                string classTypeStringAfter = string.Format("{0}{1}",
                                                            classTypeStringBefore.Substring(0, 1).ToUpper(),
                                                            classTypeStringBefore.Substring(1));
                Type formType = typeof(MainForm);

                try
                {
                    formType = Type.GetType(string.Format("{0}.{1}", formType.Namespace, classTypeStringAfter));
                    subForm = FormsRepository.Instance.GetReference(formType);
                }
                catch (KeyNotFoundException)
                {
                    subForm = SubFormFactory.CreateSubForm(buttonClickedName, LoggedInUser, null, new AppMainForm());
                    FormsRepository.Instance.AddPrototype(subForm, formType);
                }
                finally
                {
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

            AppSettings.Instance.SideBarColor = this.mySplitter.BackColor.ToArgb();
            AppSettings.Instance.TextToSpeachStatus = this.TextToSpeachStatus;

            try
            {
                SettingsForm settingsForm = FormsRepository.Instance.GetReference(typeof(SettingsForm)) as SettingsForm;
                AppSettings.Instance.AutoLogin = settingsForm.AutoLogin;
            }
            catch (KeyNotFoundException)
            {
                //AppSettings.Instance.AutoLogin = false;
            }

            AppSettings.Instance.Save();

            base.OnClosing(e);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.TextToSpeachStatus = AppSettings.Instance.TextToSpeachStatus;
            this.mySplitter.BackColor = Color.FromArgb(AppSettings.Instance.SideBarColor);

            SettingsForm settingsForm = null;

            try
            {
                //settingsForm = SubFormRepository[typeof(SettingsForm)] as SettingsForm;
                settingsForm.AutoLogin = AppSettings.Instance.AutoLogin;
            }
            catch (KeyNotFoundException)
            {
                //doSomething..
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

        private void ContextPannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainTitleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
