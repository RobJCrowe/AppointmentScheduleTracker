using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Crowe_robert_SoftwareII_CSharp
{
    public partial class Main : Form
    {
        #region Hide Login
        Login LoginFormHolder;
        public Main(Login hform) : this()
        {
            LoginFormHolder = hform;
        }

        private void closeChildForm()
        {
            LoginFormHolder.clearInputs();
            LoginFormHolder.Show();
            this.Close();
        }

        #endregion

        public Main(){InitializeComponent();}

        BindingList<dbHelper.apptMain> aHolder = new BindingList<dbHelper.apptMain>();
        BindingList<dbHelper.apptRemoveHolder> aHolderDisplay = new BindingList<dbHelper.apptRemoveHolder>();
        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            timer1.Enabled = true;

            dbHelper.viewId = 1;
            SetApptList(dbHelper.viewId);
            dbHelper.IsNotifiable();
            dbHelper.IsHappening();
        }

        private void SetApptList(int chooser)
        {
            user userHolder = dbHelper.user1;
            int chooserValue;
            if (chooser == 2) { chooserValue = 7; label1.Text = "7 DAY OUTLOOK"; }
            else if (chooser == 3) { chooserValue = 30; label1.Text = "30 DAY OUTLOOK"; }    
            else if (chooser == 4) { chooserValue = 9; label1.Text = "WEEKLY VIEW"; }
            else if (chooser == 5) { chooserValue = 32; label1.Text = "MONTHLY VIEW"; }
            else {chooserValue = 0; label1.Text = "SHOWING ALL APPOINTMENTS"; }
            aHolder.Clear();

            if (chooserValue == 0)
            {
                    using (var context = new U05oDKEntities())
                    {
                    var holder = dbHelper.GetAppointments().Where(n => n.userId == dbHelper.user1.userId).Join(dbHelper.GetCustomers(), a => a.customerId, c => c.customerId, (appointment, customer) => new dbHelper.apptMain { Appointment = appointment.appointmentId, Customer = customer.customerName, CustomerId = customer.customerId, UserId = appointment.userId, Start = appointment.start, End = appointment.end }).OrderBy(o => o.Start);
                    BindingList<dbHelper.apptMain> bindHolder = new BindingList<dbHelper.apptMain>(holder.OrderBy(i=>i.Start).ToList());
                    dgvMain.DataSource = null;
                    aHolder = bindHolder;
                    dbHelper.isEmpty(bindHolder);
                    aHolderDisplay = dbHelper.TimeConverter(aHolder);
                    dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvMain.DataSource = aHolderDisplay;
                    DgvFormatter(dgvMain);
                }
            } 
            else if ((chooserValue==7)||(chooserValue==30))
            {
                DateTime today = DateTime.Today;
                DateTime bound = today.AddDays(chooserValue).AddHours(23);
                var holder = dbHelper.GetAppointments().Where(n => n.userId == dbHelper.user1.userId && (n.start >= today && n.start <= bound)).Join(dbHelper.GetCustomers(), a => a.customerId, c => c.customerId, (appointment, customer) => new dbHelper.apptMain { Appointment = appointment.appointmentId, Customer = customer.customerName, CustomerId = customer.customerId, UserId = appointment.userId, Start = appointment.start, End = appointment.end }).OrderBy(o => o.Start);
                //Date checking in Where derived from https://stackoverflow.com/a/2237452
                //Lamda Warrant #1: The use of lamdas in this case is particular helpful because there are several conditional that we are testing for. This significantly cut down on both the complexity of the code but also on the amount of time spent in development. Then once we have a match we can throw the applicable information into a new object that is more beneficial for display purposes.
                BindingList<dbHelper.apptMain> bindHolder = new BindingList<dbHelper.apptMain>(holder.OrderBy(i=>i.Start).ToList());
                dgvMain.DataSource = null;
                aHolder = bindHolder;
                aHolderDisplay = dbHelper.TimeConverter(aHolder);
                dbHelper.isEmpty(bindHolder);
                dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMain.DataSource = aHolderDisplay;
                DgvFormatter(dgvMain);
            }
            else if (chooserValue == 9)
            {
                var allAppts = dbHelper.GetAppointments().Where(y => y.userId == dbHelper.user1.userId).ToList();
                List<appointment> chosenAppts = new List<appointment>();
                DateTime now = DateTime.Now;
                int nowInt = GetWeekNumber(now);

                for (int i = 0; i < allAppts.Count(); i++)
                {
                    DateTime start = allAppts[i].start;
                    DateTime transformed = start.ToLocalTime();
                    int getWeekNumber = GetWeekNumber(transformed);
                    if (getWeekNumber == nowInt)
                    {
                        chosenAppts.Add(allAppts[i]);
                    }
                }

                var preHolder = dbHelper.GetAppointments().Where(n => n.userId == dbHelper.user1.userId).Join(dbHelper.GetCustomers(), a => a.customerId, c => c.customerId, (appointment, customer) => new dbHelper.apptMain { Appointment = appointment.appointmentId, Customer = customer.customerName, CustomerId = customer.customerId, UserId = appointment.userId, Start = appointment.start, End = appointment.end }).OrderBy(o => o.Start);
                //Date checking in Where derived from https://stackoverflow.com/a/2237452
                var holder = preHolder.Where(e=>chosenAppts.Any(g=>e.Appointment == g.appointmentId)).ToList();
                //Lamda Warrant #2: I had some extra work that I needed to be performed on the allAppts list as a selection criteria. A simple lamda expression was then able to grab the matching objects sharing the same appointmentId which was a better use of my time and the code is easier to understand compared to the alternative.
                BindingList<dbHelper.apptMain> bindHolder = new BindingList<dbHelper.apptMain>(holder.OrderBy(i => i.Start).ToList());
                dgvMain.DataSource = null;
                aHolder = bindHolder;
                aHolderDisplay = dbHelper.TimeConverter(aHolder);
                dbHelper.isEmpty(bindHolder);
                dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMain.DataSource = aHolderDisplay;
                DgvFormatter(dgvMain);
            }
            else if (chooserValue == 32)
            {
                var allAppts = dbHelper.GetAppointments().Where(y => y.userId == dbHelper.user1.userId).ToList();
                List<appointment> chosenAppts = new List<appointment>();
                DateTime now = DateTime.Now;
                string monthNow = now.ToString("yyyy-MM");

                for (int i = 0; i < allAppts.Count(); i++)
                {
                    DateTime start = allAppts[i].start;
                    DateTime transformed = start.ToLocalTime();
                    string monthFromAllAppts = transformed.ToString("yyyy-MM");
                    if (monthNow == monthFromAllAppts)
                    {
                        chosenAppts.Add(allAppts[i]);
                    }
                }

                var preHolder = dbHelper.GetAppointments().Where(n => n.userId == dbHelper.user1.userId).Join(dbHelper.GetCustomers(), a => a.customerId, c => c.customerId, (appointment, customer) => new dbHelper.apptMain { Appointment = appointment.appointmentId, Customer = customer.customerName, CustomerId = customer.customerId, UserId = appointment.userId, Start = appointment.start, End = appointment.end }).OrderBy(o => o.Start);
                //Date checking in Where derived from https://stackoverflow.com/a/2237452
                var holder = preHolder.Where(e => chosenAppts.Any(g => e.Appointment == g.appointmentId)).ToList();
                BindingList<dbHelper.apptMain> bindHolder = new BindingList<dbHelper.apptMain>(holder.OrderBy(i => i.Start).ToList());
                dgvMain.DataSource = null;
                aHolder = bindHolder;
                aHolderDisplay = dbHelper.TimeConverter(aHolder);
                dbHelper.isEmpty(bindHolder);
                dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMain.DataSource = aHolderDisplay;
                DgvFormatter(dgvMain);
            }
            else { MessageBox.Show("Invalid chooserVale!"); }
        }
        private int GetWeekNumber(DateTime start)
        {
            DateTime local = start.ToLocalTime();
            string eval = local.ToString("MM/dd/yyyy HH:mm:ss");
            DateTime evalTime = Convert.ToDateTime(eval);

            //The following code used to get the week# is from https://docs.microsoft.com/en-us/dotnet/api/system.globalization.calendar.getweekofyear
            CultureInfo myCI = new CultureInfo(dbHelper.cultureHolder);
            Calendar myCal = myCI.Calendar;
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            int value = myCal.GetWeekOfYear(evalTime, myCWR, myFirstDOW);
            return value;
        }

        private void DgvFormatter(DataGridView d)
        {
            d.RowHeadersVisible = false;
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.ClearSelection();

            d.Columns["CustomerId"].Visible = false;
            d.Columns["UserId"].Visible = false;
            d.Refresh();
        }

        #region menu
        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e){closeChildForm();}

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerAdd customerAdd = new CustomerAdd(this);
            this.Hide();
            customerAdd.Show();
        }

        private void editCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerEdit customerEdit = new CustomerEdit(this);
            this.Hide();
            customerEdit.Show();
        }

        private void removeCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerRemove customerRemove = new CustomerRemove(this);
            this.Hide();
            customerRemove.Show();
        }

        private void addAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApptAdd apptAdd = new ApptAdd(this);
            this.Hide();
            apptAdd.Show();
        }

        private void updateAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApptUpdate apptUpdate = new ApptUpdate(this);
            this.Hide();
            apptUpdate.Show();
        }

        private void removeAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApptRemove apptRemove = new ApptRemove(this);
            this.Hide();
            apptRemove.Show();
        }

        private void appointmentTypesByMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report1 report1 = new Report1(this);
            this.Hide();
            report1.Show();
        }

        private void consultantScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report2 report2 = new Report2(this);
            report2.ShowDialog();
        }

        private void additionalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report3 report3 = new Report3(this);
            this.Hide();
            report3.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(dbHelper.GetDirty() == true)
            {
                dbHelper.ClearDirty();
                SetApptList(dbHelper.viewId);
            }
        }
        #endregion

        private void btMainAll_Click(object sender, EventArgs e)
        {
            lbOutlook.Visible = false;
            dbHelper.viewId = 1;
            SetApptList(dbHelper.viewId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbOutlook.Visible = true;
            dbHelper.viewId = 2;
            SetApptList(dbHelper.viewId);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbOutlook.Visible = true;
            dbHelper.viewId = 3;
            SetApptList(dbHelper.viewId);
        }

        private void btWeekly_Click(object sender, EventArgs e)
        {
            lbOutlook.Visible = false;
            dbHelper.viewId = 4;
            SetApptList(dbHelper.viewId);
        }

        private void btMonthly_Click(object sender, EventArgs e)
        {
            lbOutlook.Visible = false;
            dbHelper.viewId = 5;
            SetApptList(dbHelper.viewId);
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath); //used code from http://www.csharp-examples.net/get-application-directory/
            System.Diagnostics.Process.Start(path);
        }
    }
    }

