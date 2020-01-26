using System.Speech.Synthesis;

namespace DP_Task1.custom_components
{

    public class MessageAnnouncer
    {
        private static readonly SpeechSynthesizer m_FbTextToSpeach;
        private static MessageAnnouncer m_Instance;
        public string MessageToAnnounce { get; set; }

        static MessageAnnouncer()
        {
            m_FbTextToSpeach = new SpeechSynthesizer();
        }
        private MessageAnnouncer()
        {
        }
        public static MessageAnnouncer Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    m_Instance = new MessageAnnouncer();
                }

                return m_Instance;
            }
        }

        public void MessageAnnouncement(string i_Message = null)
        {
            if (!string.IsNullOrEmpty(i_Message))
            {
                MessageToAnnounce = i_Message;
            }

            m_FbTextToSpeach.SpeakAsync(MessageToAnnounce);
        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}
