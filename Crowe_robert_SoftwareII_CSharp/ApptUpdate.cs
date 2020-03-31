using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Crowe_robert_SoftwareII_CSharp
{
    public partial class ApptUpdate : Form
    {
        private string title, description, location, contact, type, url, start, end;
        private bool bTitle = true, bDescription = true, bLocation = true, bContact = true, bUrl = true, bApptAdd=false, bIsStartFirst = false, bNotOverlapping = false;
        private int userIdSelect, custID;
        private int GetUserIdSelect(){return userIdSelect;}
        private void SetUserIdSelect(){userIdSelect = apptHolder.userId;}

        private int GetCustIdSelect() { return dbHelper.fkey; }
        private void SetCustIdSelect()
        {
            dbHelper.fkey = apptHolder.customerId;
            custID = dbHelper.fkey;
        }

        private int apptSelectionIndex;
        private int GetApptSelectionIndex() { return apptSelectionIndex; }
        private void SetApptSelectionIndex() //sets value of index based upon appointmentId
        {
            apptSelectionIndex = 0;
            apptSelectionIndex = Convert.ToInt32(dgvAppt.Rows[Convert.ToInt32(dgvAppt.CurrentCell.RowIndex)].Cells[0].Value.ToString());
        }

        private appointment apptHolder;
        private appointment GetApptHolder(){return apptHolder;}
        private void SetApptHolder()
        { 
                int index = GetApptSelectionIndex();
                using (var context = new U05oDKEntities())
                {
                    apptHolder = context.appointments.Find(index);
                }
        }

        private BindingList<customer> custList = new BindingList<customer>();
        BindingList<dbHelper.apptMain> aHolder = new BindingList<dbHelper.apptMain>();
        BindingList<dbHelper.apptRemoveHolder> aHolderDisplay = new BindingList<dbHelper.apptRemoveHolder>();
        private customer CustId { get; set; }
        
        private string Who() { return dbHelper.loginName; }

        #region Hide Main
        Main MainFormHolder;

        private void tbTitleE_Validating(object sender, CancelEventArgs e)
        {
           bTitle = dbHelper.isValid(tbTitleE, label1);
        }

        private void tbDescE_Validating(object sender, CancelEventArgs e)
        {
           bDescription = dbHelper.isValid(tbDescE, lbDescription);
        }

        private void tbLocationE_Validating(object sender, CancelEventArgs e)
        {
           bLocation = dbHelper.isValid(tbLocationE, label3);
        }

        private void tbContactE_Validating(object sender, CancelEventArgs e)
        {
           bContact = dbHelper.isValid(tbContactE, label4);
        }

        private void dtpEnd_Validating(object sender, CancelEventArgs e)
        {
            bIsStartFirst = dbHelper.IsStartTimeFirst(dtpStart, dtpEnd);
        }

        private void tbUrlE_Validating(object sender, CancelEventArgs e)
        {
           bUrl = dbHelper.isValid(tbUrlE, label6);
        }

        public ApptUpdate(Main hform) : this()
        {
            MainFormHolder = hform;
        }

        private void closeChildForm()
        {
            MainFormHolder.Show();
            this.Close();
        }

        #endregion
        public ApptUpdate(){InitializeComponent();}

        private void ApptUpdate_Load(object sender, EventArgs e)
        {
            dtpStart.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            dtpEnd.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            LoadApptDgv();
            
        }

        private bool AllValid()
        {
            if (bTitle != false && bDescription != false && bLocation != false && bContact != false && bUrl != false && bIsStartFirst != false && bNotOverlapping != false)
            { return true; }
            else { return false; }
        }

        private void MasterValid()
        {
                dbHelper.isValid(tbTitleE, label1);
                dbHelper.isValid(tbDescE, lbDescription);
                dbHelper.isValid(tbLocationE, label3);
                dbHelper.isValid(tbContactE, label4);
                dbHelper.IsStartTimeFirst(dtpStart, dtpEnd);
                dbHelper.isValid(tbUrlE, label6);
        }

        private void LoadApptDgv()
        {
            using (var context = new U05oDKEntities())
            {
                var holder = dbHelper.GetAppointments().Where(y => y.userId == dbHelper.user1.userId).Join(dbHelper.GetCustomers(), a => a.customerId, c => c.customerId, (appointment, customer) => new dbHelper.apptMain { Appointment = appointment.appointmentId, Customer = customer.customerName, CustomerId = customer.customerId, UserId = appointment.userId, Start = appointment.start, End = appointment.end });
                BindingList<dbHelper.apptMain> bindHolder = new BindingList<dbHelper.apptMain>(holder.OrderBy(j=>j.Start).ToList());
                aHolder = bindHolder;
                aHolderDisplay = dbHelper.TimeConverter(aHolder);
            }
            dbHelper.isEmpty(aHolder);
            dgvAppt.DataSource = aHolderDisplay;
            dgvAppt.RowHeadersVisible = false;
            dgvAppt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppt.Columns["CustomerId"].Visible = false;
            dgvAppt.Columns["UserId"].Visible = false;
            dgvAppt.Update();
        }

        private void UpdateDgv()
        {
            var holder = dbHelper.GetAppointments().Where(y => y.userId == dbHelper.user1.userId).Join(dbHelper.GetCustomers(), a => a.customerId, c => c.customerId, (appointment, customer) => new dbHelper.apptMain { Appointment = appointment.appointmentId, Customer = customer.customerName, CustomerId = customer.customerId, UserId = appointment.userId, Start = appointment.start, End = appointment.end });
            BindingList<dbHelper.apptMain> bindHolder = new BindingList<dbHelper.apptMain>(holder.OrderBy(i=>i.Start).ToList());
            aHolder.Clear();
            aHolder = bindHolder;
            dbHelper.isEmpty(bindHolder);
            aHolderDisplay = dbHelper.TimeConverter(aHolder);
            dgvAppt.DataSource = aHolderDisplay;
            dgvAppt.Refresh();
        }
        
        private void GetAppt()
        {
            DateTime localStart = apptHolder.start.ToLocalTime();
            string hStartS = localStart.ToString("MM/dd/yyyy HH:mm:ss");
            DateTime hStart = Convert.ToDateTime(hStartS);

            DateTime localEnd = apptHolder.end.ToLocalTime();
            string hEndS = localEnd.ToString("MM/dd/yyyy HH:mm:ss");
            DateTime hEnd = Convert.ToDateTime(hEndS);

            tbTitleE.Text = apptHolder.title; title = tbTitleE.Text;
            tbDescE.Text = apptHolder.description; description = tbDescE.Text;
            tbLocationE.Text = apptHolder.location; location = tbLocationE.Text;
            tbContactE.Text = apptHolder.contact; contact = tbContactE.Text;
            cbType.Text = apptHolder.type; type = cbType.Text;
            tbUrlE.Text = apptHolder.url; url = tbUrlE.Text;
            dtpStart.Value = hStart; start = dtpStart.Value.ToString();
            dtpEnd.Value = hEnd; end = dtpEnd.Value.ToString();
        }

        private void SetUpdateAppt()
        {
            using (var context = new U05oDKEntities())
            {
                appointment ah = new appointment();
                ah = context.appointments.Find(GetApptSelectionIndex());

            DateTime n = new DateTime();
            n = DateTime.UtcNow;
                string hStartS = dtpStart.Value.ToUniversalTime().ToString("MM/dd/yyyy HH:mm:ss");
                DateTime hStart = Convert.ToDateTime(hStartS);
                string hEndS = dtpEnd.Value.ToUniversalTime().ToString("MM/dd/yyyy HH:mm:ss");
                DateTime hEnd = Convert.ToDateTime(hEndS);

                ah.title = tbTitleE.Text; 
                ah.description = tbDescE.Text; 
                ah.location = tbLocationE.Text; 
                ah.contact = tbContactE.Text; 
                ah.type = cbType.Text; 
                ah.url = tbUrlE.Text; 
                ah.start = hStart;
                ah.end = hEnd; 
                ah.appointmentId = GetApptSelectionIndex();
                ah.customerId = GetCustIdSelect();
                ah.userId = GetUserIdSelect();

                if((tbTitleE.Text != title) || (tbDescE.Text != description) || (tbLocationE.Text != location) || (tbContactE.Text != contact) || (cbType.Text != type) || (tbUrlE.Text != url) ||  (dtpStart.Value.ToString() != start) || (dtpEnd.Value.ToString() != end) || (dbHelper.fkey != custID))
                {
                    ah.lastUpdateBy = Who();
                    ah.lastUpdate = n;
                }
                context.SaveChanges();
            }
        }

        private void btApptUpdateCancel_Click(object sender, EventArgs e) {closeChildForm(); }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (dbHelper.IsCustSelected(bApptAdd) == true)
            {
                MasterValid();
                DateTime testStart = Convert.ToDateTime(dtpStart.Value.ToString("MM/dd/yyyy HH:mm:ss"));
                DateTime testEnd = Convert.ToDateTime(dtpEnd.Value.ToString("MM/dd/yyyy HH:mm:ss"));
                bNotOverlapping = dbHelper.IsOverlappingUpdate(testStart, testEnd, GetApptSelectionIndex());
                if (bNotOverlapping == false) { return; }
                if (AllValid() == true)
                {
                    SetUpdateAppt();
                    UpdateDgv();
                    dbHelper.SetDirty();
                    closeChildForm();
                }
            }
        }

        private void btSelectAppt_Click(object sender, EventArgs e)
        {
            SetApptSelectionIndex();
            SetApptHolder();
            SetCustIdSelect();
            SetUserIdSelect();
            GetAppt();
            bApptAdd = true;
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            CustChooser cChooser = new CustChooser(this);
            cChooser.ShowDialog();
        }
        
    }
}
