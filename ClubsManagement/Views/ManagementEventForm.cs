using ClubsManagement.Model;
using ClubsManagement.Controler;
using System;
using System.Windows.Forms;

namespace ClubsManagement.Views
{
    public partial class ManagementEventForm : Form
    {
        private ManagementEvent ManageEvent;
        private DBEvent DBEvent = new DBEvent();

        public ManagementEventForm()
        {
            InitializeComponent();
        }

        private void Management_Event_Form_Load(object sender, EventArgs e)
        {
            ManageEvent = ManagementEvent.GetManageEvent();

            DGEvents.AutoGenerateColumns = true;

            foreach(var anEvent in ManageEvent.Events)
            {
                DGEvents.Rows.Add(anEvent.Id, anEvent.Name, anEvent.Start, anEvent.End, anEvent.Club.Name);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DGEvents.Rows.Clear();

            Management_Event_Form_Load(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Add_Event_Click(object sender, EventArgs e)
        {
            var addEventForm = new AddEventForm();
            addEventForm.ShowDialog();
        }

        private void btn_Mod_Event_Click(object sender, EventArgs e)
        {
            var selectedRow = DGEvents.CurrentRow.Cells;
            var selectedEvent = selectedRow[0].Value.ToString();
            var idOfSelectedEvent = int.Parse(selectedEvent);

            var modifyEventForm = new ModificationEventForm(ManageEvent.GetEventById(idOfSelectedEvent));
            modifyEventForm.ShowDialog();
        }

        private void DG_Event_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_Mod_Event_Click(sender, e);
        }
    }
}
