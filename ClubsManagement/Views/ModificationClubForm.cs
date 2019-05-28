using ClubsManagement.Model;
using ClubsManagement.Controler;
using System;
using System.Windows.Forms;

namespace ClubsManagement.Views
{
    public partial class ModificationClubForm : Form
    {
        private DBClub DBClub = new DBClub();
        private Club ClubToModify;

        public ModificationClubForm(Club ClubToModify)
        {
            InitializeComponent();
            this.ClubToModify = ClubToModify;
        }

        private void Modification_Club_Form_Load(object sender, EventArgs e)
        {
            txtClubName.Text = ClubToModify.Name;
            txtClubUrl.Text = ClubToModify.Url;
            txtClubZipCode.Text = ClubToModify.ZipCode;
            txtCLubCity.Text = ClubToModify.City;
            txtClubAddress.Text = ClubToModify.Address;
            txtClubMail.Text = ClubToModify.Mail;
            txtClubTel.Text = ClubToModify.Telephone;
        }

        private void btn_Mod_Club_Click(object sender, EventArgs e)
        {

            if (txtClubName.Text != string.Empty && txtClubUrl.Text != string.Empty && txtClubZipCode.Text != string.Empty 
                && txtCLubCity.Text != string.Empty && txtClubAddress.Text != string.Empty 
                && txtClubMail.Text != string.Empty && txtClubTel.Text != string.Empty)
            {
                ClubToModify.Name = txtClubName.Text;
                ClubToModify.Url = txtClubUrl.Text;
                ClubToModify.ZipCode = txtClubZipCode.Text;
                ClubToModify.City = txtCLubCity.Text;
                ClubToModify.Address = txtClubAddress.Text;
                ClubToModify.Mail = txtClubMail.Text;
                ClubToModify.Telephone = txtClubTel.Text;

                DBClub.ModifyClub(ClubToModify);
                MessageBox.Show("Les modifications ont bien été effectuées.", "Modifications réussies", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champ(s) vide(s)", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
