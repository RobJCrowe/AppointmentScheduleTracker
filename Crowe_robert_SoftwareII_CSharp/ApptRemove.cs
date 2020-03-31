using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Crowe_robert_SoftwareII_CSharp
{
    public partial class ApptRemove : Form
    {
        private int selectionIndex, rowIndex;
        private bool bSelected = false;
        BindingList<dbHelper.apptMain> aHolder = new BindingList<dbHelper.apptMain>();
        BindingList<dbHelper.apptRemoveHolder> aHolderDisplay = new BindingList<dbHelper.apptRemoveHolder>();
        #region Hide Main
        Main MainFormHolder;
        
        public ApptRemove(Main hform) : this()
        {
            MainFormHolder = hform;
        }

        private void closeChildForm()
        {
            MainFormHolder.Show();
            this.Close();
        }

        #endregion
        public ApptRemove(){ InitializeComponent(); }

        private void ApptRemove_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void LoadDgv()
        {
            using (var context = new U05oDKEntities())
            {
                var holder = dbHelper.GetAppointments().Where(y => y.userId == dbHelper.user1.userId).ToList().Join(dbHelper.GetCustomers(), a => a.customerId, c => c.customerId, (appointment, customer) => new dbHelper.apptMain { Appointment = appointment.appointmentId, Customer = customer.customerName, CustomerId = customer.customerId, UserId = appointment.userId, Start = appointment.start, End = appointment.end});
                BindingList<dbHelper.apptMain> bindHolder = new BindingList<dbHelper.apptMain>(holder.OrderBy(i=>i.Start).ToList());
                aHolder = bindHolder;
                dbHelper.isEmpty(bindHolder);
                aHolderDisplay = dbHelper.TimeConverter(aHolder);
            }
            dgvApptRemove.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvApptRemove.DataSource = aHolderDisplay;
            dgvApptRemove.RowHeadersVisible = false;
            dgvApptRemove.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvApptRemove.Columns["CustomerId"].Visible = false;
            dgvApptRemove.Columns["UserId"].Visible = false;
            dgvApptRemove.Refresh();
        }
        private int GetSelectionIndex() { return selectionIndex; }
        private int GetRowIndex() { return rowIndex; }
        private void SetSelectionIndex()
        {
            selectionIndex = 0;
            selectionIndex = Convert.ToInt32(dgvApptRemove.Rows[Convert.ToInt32(dgvApptRemove.CurrentCell.RowIndex)].Cells[0].Value.ToString());
        }
        private void SetRowIndex()
        {
            rowIndex = 0;
            rowIndex = dgvApptRemove.CurrentCell.RowIndex;
        }
        private void UpdateDgv()
        {
            using (var context = new U05oDKEntities())
            {
                var holder = dbHelper.GetAppointments().Where(y => y.userId == dbHelper.user1.userId).ToList().Join(dbHelper.GetCustomers(), a => a.customerId, c => c.customerId, (appointment, customer) => new dbHelper.apptMain { Appointment = appointment.appointmentId, Customer = customer.customerName, Start = appointment.start, End = appointment.end });
                BindingList<dbHelper.apptMain> bindHolder = new BindingList<dbHelper.apptMain>(holder.OrderBy(s=>s.Start).ToList());
                aHolder = bindHolder;
                dbHelper.isEmpty(bindHolder);
                aHolderDisplay = dbHelper.TimeConverter(aHolder);
            }
            dgvApptRemove.Refresh();
        }

        private void btApptRemoveCancel_Click(object sender, EventArgs e)
        {
            closeChildForm();
        }
        private void RemoveCustomer()
        {
            using (var context = new U05oDKEntities())
            {
                var apptTemp = context.appointments.Find(GetSelectionIndex());
                context.appointments.Remove(apptTemp);
                context.SaveChanges();
            }
        }

        private void Select_Click(object sender, EventArgs e)
        {
            SetSelectionIndex();
            SetRowIndex();
            label1.Visible = true; label1.Text = "Selected: " + Convert.ToString(aHolder[GetRowIndex()].Appointment);
            bSelected = true;
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (bSelected == true)
            {
                try
                {
                    aHolder.RemoveAt(GetRowIndex());
                    RemoveCustomer();
                    dbHelper.SetDirty();
                    closeChildForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else { MessageBox.Show("You must make a selection."); }
        }
    }
}
