using ClubsManagement.Controler;
using ClubsManagement.Model;
using System;
using System.Windows.Forms;

namespace ClubsManagement.Views
{
    public partial class ModificationEventForm : Form
    {
        private Event EventToModify;
        private DBEvent DBEvent = new DBEvent();
        private ManagementEvent ManageEvent;

        public ModificationEventForm(Event EventToModify)
        {
            InitializeComponent();

            this.EventToModify = EventToModify;
            ManageEvent = ManagementEvent.GetManageEvent();
        }

        private void Modification_Event_Form_Load(object sender, EventArgs e)
        {
            txtEventTitle.Text = EventToModify.Name;
            txtEventStart.Text = EventToModify.Start.ToShortDateString();
            txtEventEnd.Text = EventToModify.End.ToShortDateString();
            txtEventClub.Text = EventToModify.Club.Name;
        }

        private void btn_Mod_Event_Click(object sender, EventArgs e)
        {
            if (!(DateTime.TryParse(txtEventStart.Text, out DateTime start)
                && DateTime.TryParse(txtEventEnd.Text, out DateTime end)))
            {
                MessageBox.Show("Veuillez renseigner une date valide.", "Date non valide", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtEventTitle.Text != string.Empty)
            {
                var name = txtEventTitle.Text;

                if (start <= end)
                {
                    EventToModify.Name = name;
                    EventToModify.Start = start;
                    EventToModify.End = end;

                    DBEvent.ModifyEvent(EventToModify);

                    MessageBox.Show("Les modifications ont bien été effectuées.", "Modification réussies", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Attention, la date de fin de l'événement doit être supérieure à la date de début.", 
                        "date non valide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champ(s) vide(s)", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Del_Event_Click(object sender, EventArgs e)
        {
            try
            {
                DBEvent.DeleteEvent(EventToModify);
                ManageEvent.DeleteEvent(EventToModify);

                MessageBox.Show("La suppression a bien été effectuée.", "Suppression réussie", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch
            {
                MessageBox.Show("Suppression impossible.", "Erreur", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
