using ClubsManagement.Controler;
using ClubsManagement.Model;
using System;
using System.Windows.Forms;

namespace ClubsManagement.Views
{
    public partial class AddClubForm : Form
    {
        private ManagementClub ManageClub;
        private ManagementLeague ManageLeague;
        private DBClub DBClub = new DBClub();

        public AddClubForm()
        {
            InitializeComponent();

            ManageClub = ManagementClub.GetManagementClub();
            ManageLeague = ManagementLeague.GetManagementLeague();
        }

        private void Add_Club_Form_Load(object sender, EventArgs e)
        {
            foreach (var league in ManagementLeague.Leagues)
            {
                cmbClubLeague.Items.Add(league.Name);
            }
        }

        private void btn_Add_Club_Click(object sender, EventArgs e)
        {                
            if (txtClubName.Text != string.Empty && txtClubZipCode.Text != string.Empty 
                && txtClubCity.Text != string.Empty && txtClubAddress.Text != string.Empty 
                && txtClubMail.Text != string.Empty && txtClubTel.Text != string.Empty 
                && cmbClubLeague.SelectedItem.ToString() != string.Empty)
            {
                var name = txtClubName.Text;
                var zipCode = txtClubZipCode.Text;
                var city = txtClubCity.Text;
                var address = txtClubAddress.Text;
                var mail = txtClubMail.Text;
                var tel = txtClubTel.Text;
                var nameOfLeague = cmbClubLeague.SelectedItem.ToString();

                var league = ManageLeague.GetLeagueByName(nameOfLeague);
                var newClub = new Club(name, address, zipCode, city, mail, tel, league);

                ManageClub.AddClub(newClub);
                DBClub.AddClub(newClub);

                MessageBox.Show("Ajout du club réussi.", "Ajout club", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "champ(s) vide(s)", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
