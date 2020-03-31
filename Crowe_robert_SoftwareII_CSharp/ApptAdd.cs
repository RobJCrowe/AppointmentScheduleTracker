using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Crowe_robert_SoftwareII_CSharp
{
    public partial class ApptAdd : Form
    {
        #region Hide Main
        Main MainFormHolder;
        public ApptAdd(Main hform) : this()
        {
            MainFormHolder = hform;
        }

        private void closeChildForm()
        {
            MainFormHolder.Show();
            this.Close();
        }

        #endregion
        private bool bTitle=false, bDescription= false, bLocation= false, bContact= false, bUrl= false, bApptAdd = false, bIsStartFirst = false, bNotOverlapping = false;
        private BindingList<customer> custList = new BindingList<customer>();
        BindingList<dbHelper.apptMain> apptHolder = new BindingList<dbHelper.apptMain>();
        BindingList<dbHelper.apptRemoveHolder> apptHolderDisplay = new BindingList<dbHelper.apptRemoveHolder>();
        public customer cust { get; set; }
        public ApptAdd() { InitializeComponent(); }
        private int selectionIndex;
        private int GetSelectionIndex() { return selectionIndex; }
        private void SetSelectionIndex()
        {
            selectionIndex = 0;
            selectionIndex = Convert.ToInt32(dgvCust.Rows[Convert.ToInt32(dgvCust.CurrentCell.RowIndex)].Cells[0].Value.ToString());
        }
        private void btApptAddCancel_Click(object sender, EventArgs e) { closeChildForm(); }
        private string Who() { return dbHelper.loginName; }

        private void ApptAdd_Load(object sender, EventArgs e)
        {
            dtpStart.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            dtpEnd.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            LoadCustDgv();
            LoadApptDgv();
            cbType.Text = "Initial consultation";
            
            dtpEnd.Value = DateTime.Now.AddMinutes(30);
        }

        private bool AllValid()
        {
            if (bTitle != false && bDescription != false && bLocation != false && bContact != false && bUrl != false && bIsStartFirst != false && bNotOverlapping != false)
            { return true; }
            else { return false; }
        }
        private void MasterValid()
        {
            dbHelper.isValid(tbTitleA, label1);
            dbHelper.isValid(tbDescA, lbDescription);
            dbHelper.isValid(tbLocationA, label3);
            dbHelper.isValid(tbContactA, label4);
            dbHelper.isValid(tbUrlA, label6);
        }
     
        private void LoadCustDgv()
        {
            using (var context = new U05oDKEntities())
            {
                var holder = context.customers.ToList();
                var bindHolder = new BindingList<customer>(holder);

                dbHelper.isEmptyCust(bindHolder);
                custList = bindHolder;

                dgvCust.DataSource = custList;
                dgvCust.RowHeadersVisible = false;
                dgvCust.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCust.Columns["address"].Visible = false;
                dgvCust.Columns["appointments"].Visible = false;
                dgvCust.Refresh();
            }
        }

        private void tbTitleA_Validating(object sender, CancelEventArgs e)
        {
            bTitle = dbHelper.isValid(tbTitleA, label1);
        }

        private void tbDescA_Validating(object sender, CancelEventArgs e)
        {
            bDescription = dbHelper.isValid(tbDescA, lbDescription);
        }

        private void tbLocationA_Validating(object sender, CancelEventArgs e)
        {
           bLocation = dbHelper.isValid(tbLocationA, label3);
        }

        private void tbContactA_Validating(object sender, CancelEventArgs e)
        {
           bContact = dbHelper.isValid(tbContactA, label4);
        }

        private void tbUrlA_Validating(object sender, CancelEventArgs e)
        {
           bUrl = dbHelper.isValid(tbUrlA, label6);
        }

        private void dtpEnd_Validating(object sender, CancelEventArgs e)
        {
            bIsStartFirst = dbHelper.IsStartTimeFirst(dtpStart, dtpEnd);
        }

        private void LoadApptDgv()
        {
            using (var context = new U05oDKEntities())
            {
                var holder = dbHelper.GetAppointments().Where(y => y.userId == dbHelper.user1.userId).Join(dbHelper.GetCustomers(), a => a.customerId, c => c.customerId, (appointment, customer) => new dbHelper.apptMain { Appointment = appointment.appointmentId, Customer = customer.customerName, CustomerId = customer.customerId, UserId = appointment.userId, Start = appointment.start, End = appointment.end });
                BindingList<dbHelper.apptMain> bindHolder = new BindingList<dbHelper.apptMain>(holder.OrderBy(o=>o.Start).ToList());
                    apptHolder = bindHolder;
                dbHelper.isEmpty(bindHolder);
                apptHolderDisplay = dbHelper.TimeConverter(apptHolder);
                
                dgvAppt.DataSource = apptHolderDisplay;
                dgvAppt.RowHeadersVisible = false;
                dgvAppt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAppt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvAppt.Columns["CustomerId"].Visible = false;
                dgvAppt.Columns["UserId"].Visible = false;
                dgvAppt.Update();
            }
        }

        private void DgvFormatter(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Columns["user"].Visible = false;
            dgv.Columns["appointmentId"].Visible = false;
            dgv.Columns["customerId"].Visible = false;
            dgv.Columns["userId"].Visible = false;
            dgv.Columns["title"].Visible = false;
            dgv.Columns["description"].Visible = false;
            dgv.Columns["location"].Visible = false;
            dgv.Columns["contact"].Visible = false;
            dgv.Columns["type"].Visible = false;
            dgv.Columns["url"].Visible = false;
            dgv.Columns["createDate"].Visible = false;
            dgv.Columns["createdBy"].Visible = false;
            dgv.Columns["lastUpdate"].Visible = false;
            dgv.Columns["lastUpdateBy"].Visible = false;
            dgv.Columns["customer"].Visible = false;
            dgv.Refresh();
        }

        private void AddAppt()
        {
            string hStartS = dtpStart.Value.ToUniversalTime().ToString("MM/dd/yyyy HH:mm:ss");
            DateTime hStart = Convert.ToDateTime(hStartS);
            string hEndS = dtpEnd.Value.ToUniversalTime().ToString("MM/dd/yyyy HH:mm:ss");
            DateTime hEnd = Convert.ToDateTime(hEndS);
            DateTime n = new DateTime(); n = DateTime.UtcNow;

            var appt = new appointment()
            {
                title = tbTitleA.Text,
                description = tbDescA.Text,
                location = tbLocationA.Text,
                contact = tbContactA.Text,
                type = cbType.Text,
                url = tbUrlA.Text,
                start = hStart,
                end = hEnd,
                customerId=cust.customerId,
                userId=dbHelper.user1.userId,
                lastUpdateBy = Who(),
                lastUpdate = n,
                createDate = n,
                createdBy = Who(),
            };
            using (var context = new U05oDKEntities())
            {
                context.appointments.Add(appt);
                context.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetSelectionIndex();
            int indexer = GetSelectionIndex();
            using (var context = new U05oDKEntities())
            {
                cust = context.customers.Find(indexer);
                lbSelect.Visible = true;
                lbSelect.Text = "Selected: " + cust.customerName;
            }
            bApptAdd = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dbHelper.IsCustSelected(bApptAdd) == true)
            {
                MasterValid();
                bIsStartFirst = dbHelper.IsStartTimeFirst(dtpStart, dtpEnd);
                if(bIsStartFirst == false) { return; }
                DateTime testStart = Convert.ToDateTime(dtpStart.Value.ToString("MM/dd/yyyy HH:mm:ss"));
                DateTime testEnd = Convert.ToDateTime(dtpEnd.Value.ToString("MM/dd/yyyy HH:mm:ss"));
                bNotOverlapping = dbHelper.IsOverlapping(testStart, testEnd);
                if (bNotOverlapping == false) { return; }
                if (AllValid() == true)
                {
                    dbHelper.SetDirty();
                    AddAppt();
                    closeChildForm();
                }
            }
        }
    }
}

