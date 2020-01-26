using DP_Task1.custom_components;
using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DP_Task1.forms
{
    public partial class SettingsForm : Form
    {
        User m_LoggedInUser;
        public AppMainForm MainFormRef { get; set; }
        public ColorDialog ColorDailongHelper { get; set; }
        public bool AutoLogin { get; set; }
        private const string k_toggleButtonAutoLoginText = "Auto Login";
        private const string k_toggleButonTextToSpeach = "Text To Speach";
        public SettingsForm(User i_LoggedInUser, AppMainForm i_MainForm)
        {
            m_LoggedInUser = i_LoggedInUser;
            MainFormRef = i_MainForm;
            ColorDailongHelper = new ColorDialog();
            InitializeComponent();
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            AutoLogin = AppSettings.Instance.AutoLogin;
            MainFormRef.TextToSpeachStatus = AppSettings.Instance.TextToSpeachStatus;
            autoLoginCheckBox.Checked = AutoLogin;
            checkBoxToggleUpdate(autoLoginCheckBox);
            textToSpeachCheckBox.Checked = MainFormRef.TextToSpeachStatus;
            checkBoxToggleUpdate(textToSpeachCheckBox);
        }
        private void checkBoxToggleUpdate(CheckBox i_Checkbox)
        {
            string currentPath = this.GetType().Assembly.Location.Split(new[] { "bin" }, StringSplitOptions.None)[0];


            if (i_Checkbox.Checked)
            {
                i_Checkbox.BackgroundImage = Image.FromFile(string.Format("{0}img//toggle_on.png", currentPath));
            }
            else
            {
                i_Checkbox.BackgroundImage = Image.FromFile(string.Format("{0}img//toggle_off.png", currentPath));
            }
        }
        private void CheckBoxToggle_Click(object sender, EventArgs e)
        {
            CheckBox currentCheckBox = sender as CheckBox;
            checkBoxToggleUpdate(currentCheckBox);
        }
        private void TextToSpeachCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox currentCheckBox = sender as CheckBox;
            MainFormRef.TextToSpeachStatus = currentCheckBox.Checked;
        }
        private void AutoLoginCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox currentCheckBox = sender as CheckBox;
            AutoLogin = currentCheckBox.Checked;
        }
    }
}
