using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace DP_Task1.forms
{
    public partial class EventsForm : Form
    {
        public User LoggedInUser { get; set; }
        public EventsForm(User i_LoggedInUser)
        {
            LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            fetchEventsDataIntoEventsForm();
        }
        private void fetchEventsDataIntoEventsForm()
        {
            eventBindingSource.DataSource = LoggedInUser.Events;
        }
    }
}
