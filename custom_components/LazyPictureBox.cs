using System.Windows.Forms;

namespace DP_Task1.custom_components
{
    class LazyPictureBox : PictureBox
    {

        public string URL { get; set; }

        public void Load(string i_ImageURL)
        {
            URL = i_ImageURL;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {

            if (base.ImageLocation == null)
            {
                base.ImageLocation = this.URL;
            }

            base.OnPaint(pe);
        }
    }
}
