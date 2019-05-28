using ClubsManagement.Controler;
using ClubsManagement.Model;
using System;
using System.Windows.Forms;

namespace ClubsManagement.Views
{
    public partial class AddAdherentForm : Form
    {
        private ManagementAdherent ManageAdherent;
        private ManagementClub ManageClub;
        private DBAdherent DBAdherent = new DBAdherent();
       
        public AddAdherentForm()
        {
            InitializeComponent();
        }

        private void AddAdherentForm_Load(object sender, EventArgs e)
        {
            ManageClub = ManagementClub.GetManagementClub();
            ManageAdherent = ManagementAdherent.GetManagementAdherent();

            foreach (var club in ManageClub.Clubs)
            {
                if (club.Name != null)
                {
                    cmbAdherentClub.Items.Add(club.Name);
                }
            }
        }

        private void btn_Add_Adherent_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(txtAdherentBirthDate.Text, out DateTime birthDate))
            {
                MessageBox.Show("Veuillez renseigner une date valide.", "Date non valide", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtAdherentLastName.Text != string.Empty && txtAdherentFirstName.Text != string.Empty 
                && birthDate.ToString() != string.Empty && txtAdherentZipCode.Text != string.Empty 
                && txtAdherentCity.Text != string.Empty && txtAdherentAddress.Text != string.Empty)
            {
                var lastName = txtAdherentLastName.Text;
                var firstName = txtAdherentFirstName.Text;
                var zipCode = txtAdherentZipCode.Text;
                var city = txtAdherentCity.Text;
                var address = txtAdherentAddress.Text;
                var subscription = 150;
                var club = ManageClub.GetClubByName(cmbAdherentClub.Text);

                var newAdherent = new Adherent(lastName, firstName, zipCode, address, city, birthDate, subscription, club);

                ManageAdherent.AddAdherent(newAdherent);
                DBAdherent.AddAdherent(newAdherent);

                ManageAdherent.UpdateManagementAdherent();
                DBAdherent.UpdateAdherent();

                MessageBox.Show("L'adhérent a bien été ajouté.", "Ajout réussi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champ(s) vide(s)", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MonthCalendar_Adherent_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtAdherentBirthDate.Text = MonthCalendarAdherent.SelectionStart.ToShortDateString();   
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
