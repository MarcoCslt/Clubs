using ClubsManagement.Controler;
using System;
using System.Windows.Forms;

namespace ClubsManagement.Views
{
    public partial class ManagementAdherentForm : Form
    {
        private ManagementAdherent ManageAdherent;
       
        public ManagementAdherentForm()
        {
            InitializeComponent();
        }

        private void Management_Adherent_Form_Load(object sender, EventArgs e)
        {
            DGAdherents.Rows.Clear();

            ManageAdherent = ManagementAdherent.GetManagementAdherent();

            DGAdherents.AutoGenerateColumns = true;
            DGAdherents.AutoResizeColumns();

            foreach (var adherent in ManageAdherent.Adherents)
            {
                DGAdherents.Rows.Add(adherent.LicenceNumber, adherent.LastName, adherent.FirstName, adherent.ZipCode,
                                     adherent.City, adherent.Address, adherent.Subscription, adherent.Club.Name);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Management_Adherent_Form_Load(sender, e);
        }

        private void btn_Add_Adherent_Click(object sender, EventArgs e)
        {
            var addAdherentForm = new AddAdherentForm();
            addAdherentForm.ShowDialog();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Mod_Adherent_Click(object sender, EventArgs e)
        {
            var selectedRow = DGAdherents.CurrentRow.Cells;
            var selectedAdherent = selectedRow[0].Value.ToString();
            var idOfSelectedAdherent = int.Parse(selectedAdherent);

            var modifyAdherentForm = new ModificationAdherentForm(ManageAdherent.GetAdherentById(idOfSelectedAdherent));
            modifyAdherentForm.ShowDialog();
        }

        private void DGAdherents_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_Mod_Adherent_Click(sender, e);
        }
    }
}
