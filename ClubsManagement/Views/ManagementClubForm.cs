using ClubsManagement.Model;
using ClubsManagement.Controler;
using System;
using System.Windows.Forms;

namespace ClubsManagement.Views
{
    public partial class ManagementClubForm : Form
    {
        private ManagementClub ManageClub;
        private DBClub DBClub;

        public ManagementClubForm()
        {
            InitializeComponent();
        }

        private void Management_Club_Form_Load(object sender, EventArgs e)
        {
            ManageClub = ManagementClub.GetManagementClub();
            DBClub = new DBClub();

            DGClubs.AutoGenerateColumns = true;
            DGClubs.AutoResizeColumns();

            foreach (var club in ManageClub.Clubs)
            {
                int numberOfAdherent= DBClub.CountAdherent(club);
                int numberOfEvent = DBClub.CountEvent(club);

                DGClubs.Rows.Add(club.Id, club.Name, club.ZipCode, club.City,
                                 club.Address, club.Mail, club.Telephone, club.League.Name, 
                                 numberOfAdherent, numberOfEvent);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DGClubs.Rows.Clear();

            Management_Club_Form_Load(sender, e);
        }

        private void btn_Add_Club_Click(object sender, EventArgs e)
        {
            var addClubForm = new AddClubForm();
            addClubForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DG_Club_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnModClub_Click(sender, e);
        }

        private void btnModClub_Click(object sender, EventArgs e)
        {
            var selectedRow = DGClubs.CurrentRow.Cells;
            var selectedClub = selectedRow[0].Value.ToString();
            var idOfSelectedClub = int.Parse(selectedClub);
            
            var modifyClubForm = new ModificationClubForm(ManageClub.GetClubById(idOfSelectedClub));
            modifyClubForm.ShowDialog();
        }
    }
}
