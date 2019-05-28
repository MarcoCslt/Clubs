using ClubsManagement.Controler;
using ClubsManagement.Views;
using System.Windows.Forms;

namespace ClubsManagement
{
    public partial class HomePage : Form
    {
        private ManagementLeague ManageLeague;
        private ManagementAdherent ManageAdherent;
        private ManagementClub ManageClub;
        private ManagementEvent ManageEvent;

        public HomePage()
        {
            InitializeComponent();

            ManageLeague = ManagementLeague.GetManagementLeague();
            ManageClub = ManagementClub.GetManagementClub();
            ManageAdherent = ManagementAdherent.GetManagementAdherent();
            ManageEvent = ManagementEvent.GetManageEvent();
        }

        private void btn_Adherents_Click(object sender, System.EventArgs e)
        {
            var ManageAdherentForm = new ManagementAdherentForm();
       
            ManageAdherentForm.ShowDialog();    
        }

        private void btn_Clubs_Click(object sender, System.EventArgs e)
        {
            var ManageClubForm = new ManagementClubForm();

            ManageClubForm.ShowDialog();
        }

        private void btn_Events_Click(object sender, System.EventArgs e)
        {
            var ManageEventForm = new ManagementEventForm();

            ManageEventForm.ShowDialog();
        }
    }
}