using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Crowe_robert_SoftwareII_CSharp
{
    public partial class Report2 : Form
    {
            
        #region Hide Main
        Main MainFormHolder;
        public Report2(Main hform) : this()
        {
            MainFormHolder = hform;
        }

        private void closeChildForm()
        {
            MainFormHolder.Show();
            this.Close();
        }

        #endregion
        public Report2()
        {
            InitializeComponent();
        }
        private int selectionIndex;
        private BindingList<dbHelper.apptRemoveHolder> bi2 = new BindingList<dbHelper.apptRemoveHolder>();
        U05oDKEntities context = new U05oDKEntities();

        private void LoadDgv()
        {
            List<user> result = context.users.ToList();
            dgv2ReportUser.DataSource = result;
            dgv2ReportUser.RowHeadersVisible = false;
            dgv2ReportUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv2ReportUser.Columns["appointments"].Visible = false;
            dgv2ReportUser.Refresh();
            dgv2ReportUser.Rows[0].Selected = true;
        }

        private void LoadApptDgv()
        {
            dgvReport2appt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport2appt.DataSource = bi2;
            dgvReport2appt.RowHeadersVisible = false;
            dgvReport2appt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport2appt.Columns["CustomerId"].Visible = false;
            dgvReport2appt.Columns["UserId"].Visible = false;
        }

        public int GetSelectionIndex(){return selectionIndex;}
        public void SetSelectionIndex()
        {
            selectionIndex = 0;
            selectionIndex = Convert.ToInt32(dgv2ReportUser.Rows[Convert.ToInt32(dgv2ReportUser.CurrentCell.RowIndex)].Cells[0].Value.ToString());
        }
        private void SetApptList()
        {
            bi2.Clear();
            int currentIndex = GetSelectionIndex();
            var holder = dbHelper.GetAppointments().Where(w=>w.userId == currentIndex).Join(dbHelper.GetCustomers(), a => a.customerId, c => c.customerId, (appointment, customer) => new dbHelper.apptRemoveHolder { Appointment = appointment.appointmentId, Customer = customer.customerName, CustomerId = customer.customerId, UserId = appointment.userId, Start = appointment.start.ToLocalTime().ToString("MM/dd/yyyy hh:mm:ss tt"), End = appointment.end.ToLocalTime().ToString("MM/dd/yyyy hh:mm:ss tt") }).OrderBy(t=>t.Start);
            BindingList<dbHelper.apptRemoveHolder> bindHolder = new BindingList<dbHelper.apptRemoveHolder>(holder.ToList());
            bi2 = bindHolder;
            if(bindHolder.Count() == 0) { MessageBox.Show("No appointments to show."); ; }
            LoadApptDgv();
            
        }
        private void Report2_Load(object sender, EventArgs e){LoadDgv();}
        private void btReport2Cancel_Click(object sender, EventArgs e)
        {
            context.Dispose();
            closeChildForm();
        }

        private void btReport2Select_Click(object sender, EventArgs e)
        {
            SetSelectionIndex();
            SetApptList();
        }
    }
}
