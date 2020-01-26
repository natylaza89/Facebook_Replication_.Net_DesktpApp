using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DP_Task1.custom_components
{
    public class AppSettings
    {
        private static readonly string sr_FileFullPath;
        private static AppSettings s_Instance;
        public string AccessToken { get; set; }
        public bool AutoLogin { get; set; }
        public int SideBarColor { get; set; }
        public bool TextToSpeachStatus { get; set; }


        static AppSettings()
        {
            sr_FileFullPath = Application.ExecutablePath + ".settings.xml";
        }

        private AppSettings()
        {

        }


        public static AppSettings Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    s_Instance = AppSettings.FromFileOrDefault();
                }

                return s_Instance;
            }
        }

        public void Save()
        {
            using (FileStream stream = new FileStream(sr_FileFullPath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                serializer.Serialize(stream, this);
            }
        }

        public static AppSettings FromFileOrDefault()
        {
            AppSettings loadedSettings = null;

            if (File.Exists(sr_FileFullPath))
            {
                using (FileStream stream = new FileStream(sr_FileFullPath, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    loadedSettings = (AppSettings)serializer.Deserialize(stream);
                }
            }
            else
            {
                /// C# 3.0 feature: Object Initializer
                loadedSettings = new AppSettings()
                {
                    AutoLogin = false,
                    AccessToken = null,
                    TextToSpeachStatus = true,
                    //SideBarColor = Color.White.ToArgb(),
                };
            }

            return loadedSettings;
        }
    }

}
