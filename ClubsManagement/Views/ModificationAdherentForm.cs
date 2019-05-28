using ClubsManagement.Controler;
using ClubsManagement.Model;
using System;
using System.Windows.Forms;

namespace ClubsManagement.Views
{
    public partial class ModificationAdherentForm : Form
    {
        private DBAdherent DBAdherent = new DBAdherent();
        private Adherent AdherentToModify;
        private ManagementClub ManageClub;
        private ManagementAdherent ManageAdherent;

        public ModificationAdherentForm(Adherent AdherentToModify)
        {
            InitializeComponent();

            this.AdherentToModify = AdherentToModify;
            ManageClub = ManagementClub.GetManagementClub();
            ManageAdherent = ManagementAdherent.GetManagementAdherent();
        }

        private void Modification_Adherent_Form_Load(object sender, EventArgs e)
        {
            txtAdherentLastName.Text = AdherentToModify.LastName;
            txtAdherentFirstName.Text = AdherentToModify.FirstName;
            txtAdherentBirthDate.Text = AdherentToModify.BirthDate.ToShortDateString();
            txtAdherentZipCode.Text = AdherentToModify.ZipCode;
            txtAdherentCity.Text = AdherentToModify.City;
            txtAdherentAddress.Text = AdherentToModify.Address;

            foreach (var club in ManageClub.Clubs)
            {
                if(club.Name != null)
                {
                    cmbAdherentClub.Items.Add(club.Name);
                }
            }

            if (AdherentToModify.Club != null)
            {
                cmbAdherentClub.Text = AdherentToModify.Club.Name;
            }
        }

        private void btn_Mod_Adherent_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(txtAdherentBirthDate.Text, out DateTime birthDate))
            {
                MessageBox.Show("Veuillez renseigner une date valide.", "Date non valide", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtAdherentLastName.Text != string.Empty && txtAdherentFirstName.Text != string.Empty 
                && txtAdherentZipCode.Text != string.Empty && txtAdherentCity.Text != string.Empty 
                && txtAdherentAddress.Text != string.Empty)
            {
                AdherentToModify.BirthDate = birthDate;
                AdherentToModify.LastName = txtAdherentLastName.Text;
                AdherentToModify.FirstName = txtAdherentFirstName.Text;
                AdherentToModify.ZipCode = txtAdherentZipCode.Text;
                AdherentToModify.City = txtAdherentCity.Text;
                AdherentToModify.Address = txtAdherentAddress.Text;
                AdherentToModify.Club = ManageClub.GetClubByName(cmbAdherentClub.Text);

                DBAdherent.ModifyAdherent(AdherentToModify);

                MessageBox.Show("Les modifications ont bien été effectuées.", "Modifications réussies", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champ(s) non rempli(s)", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MonthCalendar_Adherent_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtAdherentBirthDate.Text = MonthCalendarAdherent.SelectionStart.ToShortDateString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Del_Adherent_Click(object sender, EventArgs e)
        {
            try
            {
                DBAdherent.DeleteAdherent(AdherentToModify);
                ManageAdherent.DeleteAdherent(AdherentToModify);

                MessageBox.Show("Adhérent supprimé.", "Suppression réussie", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Impossible de supprimer l'adhérent.", "Suppression impossible", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}   