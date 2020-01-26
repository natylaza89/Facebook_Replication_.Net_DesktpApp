using DP_Task1.forms;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace DP_Task1.custom_components
{
    public static class SubFormFactory

    {
        public static Form SubForm { get; set; }


        public static Form CreateSubForm(string i_ClassName, User i_LoggedInUser, Album i_Album = null, AppMainForm i_MainForm = null)
        {

            if (i_ClassName == "buttonProfileForm")
            {
                SubForm = new ProfileForm(i_LoggedInUser, i_MainForm);

            }
            else if (i_ClassName == "buttonPostsForm")
            {

                SubForm = new PostsForm(i_LoggedInUser, i_MainForm);

            }
            else if (i_ClassName == "buttonEventsForm")
            {
                SubForm = new EventsForm(i_LoggedInUser);

            }
            else if (i_ClassName == "buttonAlbumsForm")
            {
                SubForm = new AlbumsForm(i_LoggedInUser, i_MainForm);

            }
            else if (i_ClassName == "buttonVideosForm")
            {
                SubForm = new VideosForm(i_LoggedInUser);
            }
            else if (i_ClassName == "buttonSettingsForm")
            {
                SubForm = new SettingsForm(i_LoggedInUser, i_MainForm);
            }
            else if (i_ClassName == "photosFormButtonLoader")
            {
                SubForm = new PhotosForm(i_LoggedInUser, i_Album, i_MainForm);
            }

            return SubForm;
        }
    }
}
