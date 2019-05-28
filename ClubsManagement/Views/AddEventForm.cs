using ClubsManagement.Controler;
using ClubsManagement.Model;
using System;
using System.Windows.Forms;

namespace ClubsManagement.Views
{
    public partial class AddEventForm : Form
    {
        private ManagementClub ManageClub;
        private DBEvent DBEvent = new DBEvent();

        public AddEventForm()
        {
            InitializeComponent();

            ManageClub = ManagementClub.GetManagementClub();
        }

        private void Add_Event_Form_Load(object sender, EventArgs e)
        {
            foreach (var club in ManageClub.Clubs)
            {
                cmbEventClub.Items.Add(club.Name);
            }
        }

        private void btn_Add_Event_Click(object sender, EventArgs e)
        {
            if (!(DateTime.TryParse(txtEventStart.Text, out DateTime start)
                && DateTime.TryParse(txtEventEnd.Text, out DateTime end)))
            {
                MessageBox.Show("Veuillez renseigner une date valide.", "Date non valide", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtEventTitle.Text != string.Empty)
            {
                var nameOfClub = cmbEventClub.SelectedItem.ToString();
                var club = ManageClub.GetClubByName(nameOfClub);
                var name = txtEventTitle.Text;

                if (start <= end)
                {
                    var newEvent = new Event(name, start, end, club);
                    DBEvent.AddEvent(newEvent);

                    MessageBox.Show("L'ajout de l'événement a bien été effectué.", "Ajout réussi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Attention, la date de fin de l'événement doit être supérieure à la date de début.",
                        "Date non valide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champ(s) vide(s)", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
