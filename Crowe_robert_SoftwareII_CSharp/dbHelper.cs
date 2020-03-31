using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Crowe_robert_SoftwareII_CSharp
{
    public class dbHelper
    {
        public static int CustomerId { get; set; }
        public static int AppointmentId { get; set; }
        public static int CountryId { get; set; }
        public static int CityId { get; set; }
        public static int AddressId { get; set; }
        public static int viewId { get; set; }
        public static string loginName { get; set; }
        public static user user1 { get; set; }
        public static int fkey { get; set; }
        public static bool isDirty;
        public static void SetDirty() { isDirty = true; }
        public static bool GetDirty() { return isDirty; }
        public static void ClearDirty() { isDirty = false; }
        public static string cultureHolder { get; set; }
        public static List<customer> GetCustomers()
        {
            using (var context = new U05oDKEntities())
            {
                return context.customers.ToList();
            }
        }
        public static List<appointment> GetAppointments()
        {
            using (var context = new U05oDKEntities())
            {
                return context.appointments.ToList();
            }
        }

        public static customer GetCustomer(int index)
        {
            using (var context = new U05oDKEntities())
            {
                customer cHolder = context.customers.Find(index);
                return cHolder;
            }
        }

        public static bool isValid(TextBox t, Label a)
        {
                if (t.Text.Length == 0)
                {
                    MessageBox.Show(a.Text + " must not be empty.");
                    return false;
                }
                else if (t.Text.Length > 0){ return true;}
                else { MessageBox.Show("You've hit the else :("); return false; }
        }

        public static bool IsValidInt(TextBox t, Label a)
        {
            int intParse;
            if (!int.TryParse(t.Text, out intParse))
            {

                MessageBox.Show(a.Text + " must be an integer");
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool IsCustSelected(bool b)
        {
            if (b == false)
            {
                MessageBox.Show("You haven't selected a customer yet.");
                return false;
            }
            else { return true; }
        }
        public static bool IsOverlapping(DateTime inStart, DateTime inEnd)
        {
            List<appointment> allAppts = GetAppointments().Where(y=>y.userId == dbHelper.user1.userId).ToList();
            DateTime aStart = inStart.ToUniversalTime();
            DateTime aEnd = inEnd.ToUniversalTime();

            for (int i = 0; i < allAppts.Count(); i++)
            {
                DateTime bStart = allAppts[i].start;
                DateTime bEnd = allAppts[i].end;

                if (aStart < bEnd && bStart < aEnd) //Used code from https://stackoverflow.com/a/13513973 for overlap checking
                {
                    MessageBox.Show("Scheduling Conflict: Overlapping meeting times. Please Try Again.");
                    return false;
                }
            }
            return true;
        }

        public static void isEmpty(BindingList<apptMain> am)
        {
            if (am.Count() == 0)
            {
                MessageBox.Show("No appointments to show.");
            }
        }
        public static void isEmptyCust(BindingList<customer> am)
        {
            if (am.Count() == 0)
            {
                MessageBox.Show("No appointments to show.");
            }
        }

        public static bool IsOverlappingUpdate(DateTime inStart, DateTime inEnd, int apptID)
        {
            List<appointment> allAppts = GetAppointments().Where(y => y.userId == dbHelper.user1.userId).ToList();
            DateTime aStart = inStart.ToUniversalTime();
            DateTime aEnd = inEnd.ToUniversalTime();

            for (int i = 0; i < allAppts.Count(); i++)
            {
                DateTime bStart = allAppts[i].start;
                DateTime bEnd = allAppts[i].end;
                if (allAppts[i].appointmentId != apptID)
                {
                    if (aStart < bEnd && bStart < aEnd) //Used code from https://stackoverflow.com/a/13513973 for overlap checking
                    {
                        MessageBox.Show("Scheduling Conflict: Overlapping meeting times. Please Try Again.");
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool IsNotifiable()
        {
            List<appointment> allAppts = GetAppointments();
            DateTime aStart = DateTime.UtcNow;
            DateTime aEnd = aStart.AddMinutes(15);
            string dStart = aStart.ToLocalTime().ToString();
            string dEnd = aEnd.ToLocalTime().ToString();

            for (int i = 0; i < allAppts.Count(); i++)
            {
                DateTime bStart = allAppts[i].start;
                if ((bStart >= aStart)&&(bStart<=aEnd))
                {
                    customer custHolder = GetCustomer(allAppts[i].customerId);
                    string title = "URGENT!!!";
                    MessageBox.Show("You have an appointment soon with:\nName: "+custHolder.customerName+"\nAppointment Type: "+allAppts[i].type+"\nAppointment Start: "+allAppts[i].start.ToLocalTime().ToString("MM/dd/yyyy hh:mm:ss tt")+"\nAppointment End: "+ allAppts[i].end.ToLocalTime().ToString("MM/dd/yyyy hh:mm:ss tt"), title);
                }
            }
            return true;
        }
        public static bool IsHappening()
        {
            List<appointment> allAppts = GetAppointments();
            DateTime aStart = DateTime.UtcNow;
            
            for (int i = 0; i < allAppts.Count(); i++)
            {
                DateTime bStart = allAppts[i].start;
                DateTime bEnd = allAppts[i].end;
                if ((aStart >= bStart) && (aStart <= bEnd))
                {
                    customer custHolder = GetCustomer(allAppts[i].customerId);
                    string title = "URGENT!!!";
                    MessageBox.Show("You have an appointment occuring now with:\nName: " + custHolder.customerName + "\nAppointment Type: " + allAppts[i].type + "\nAppointment Start: " + allAppts[i].start.ToLocalTime().ToString("MM/dd/yyyy hh:mm:ss tt") + "\nAppointment End: " + allAppts[i].end.ToLocalTime().ToString("MM/dd/yyyy hh:mm:ss tt"), title);
                }
            }
            return true;
        }

        public static bool IsStartTimeFirst(DateTimePicker start, DateTimePicker end)
        {
            DateTime startD = Convert.ToDateTime(start.Value);
            DateTime endD = Convert.ToDateTime(end.Value);

            if (startD.ToString("MM/dd/yyyy") == endD.ToString("MM/dd/yyyy"))
            {
                if (startD.CompareTo(endD) == 0)
                { MessageBox.Show("You must have different start and end times"); return false; }
                if (startD.CompareTo(endD) > 0)
                {
                    MessageBox.Show("Your start time beings after your end time!"); return false;
                }
                if (startD.CompareTo(endD) == -1)
                {
                    bool holder = IsBetweenBhours(startD, endD);
                    if (holder == false)
                    { return false; }
                    else { return true; }
                }
                return false;
            }
            else
            {
                MessageBox.Show("The dates must match.");
                return false;
            }

            bool IsBetweenBhours(DateTime s, DateTime e)
            {
                int sTime = Convert.ToInt16(s.ToString("HH"));
                int eTime = Convert.ToInt16(e.ToString("HH"));
                bool bStartStatus = false, bEndStatus = false;
                if (check(sTime) == false)
                {
                    MessageBox.Show("Business hour: 8AM - 5PM. Please adjust your start time");
                    return false;
                }
                else { bStartStatus = true; }
                if (check(eTime) == false)
                {
                    MessageBox.Show("Business hour: 8AM - 5PM. Please adjust your end time");
                    return false;
                }
                else { bEndStatus = true; }

                if ((bStartStatus == true) && (bEndStatus == true)) { return true; }
                else { return false; }

                bool check(int takeInt)
                {
                    List<int> officeHours = new List<int>() { 8, 9, 10, 11, 12, 13, 14, 15, 16};
                    bool contains = officeHours.Any(n => n == takeInt);
                    return contains;
                }
            }
        }

        public static BindingList<apptRemoveHolder> TimeConverter(BindingList<apptMain> bi)
        {
            BindingList<dbHelper.apptRemoveHolder> biOut = new BindingList<apptRemoveHolder>();
            for (int i = 0; i < bi.Count(); i++)
            {
                biOut.Add(new dbHelper.apptRemoveHolder());
                biOut[i].Appointment = bi[i].Appointment;
                biOut[i].CustomerId = bi[i].CustomerId;
                biOut[i].UserId = bi[i].UserId;
                biOut[i].Customer = bi[i].Customer;
                biOut[i].Start = bi[i].Start.ToLocalTime().ToString("MM/dd/yyyy hh:mm:ss tt");
                biOut[i].End = bi[i].End.ToLocalTime().ToString("MM/dd/yyyy hh:mm:ss tt");
            }
            return biOut;
        }

        public static void LogData(string name, bool success)
        {
            string path = "2019_log.txt", boolInfo;
            if (success == true)
            {
                boolInfo = " That attempt was successful.";
            }
            else if (success == false)
            {
                boolInfo = " That attempt failed.";
            }
            else { boolInfo = "null"; }
            DateTime n = DateTime.UtcNow;
            string nS = n.ToString("MM/dd/yyyy HH:mm:ss");
            nS = nS + " UTC.";
            string compiled;
            compiled = "\nA user named: " + name + " attempted to login at " + nS + boolInfo + Environment.NewLine;
            File.AppendAllText(path, compiled);
        }

        public class apptRemoveHolder
        {
            public int Appointment { get; set; }
            public int CustomerId { get; set; }
            public int UserId { get; set; }
            public string Customer { get; set; }
            public string Start { get; set; }
            public string End { get; set; }
            public apptRemoveHolder(){}
            public apptRemoveHolder(int appt, string customer,  int cId, int uId, string endS, string startS)
            {
                Appointment = appt;
                Customer = customer;
                CustomerId = cId;
                UserId = uId;

                Start = startS;
                End = endS;
            }
            ~apptRemoveHolder() { }
        }

        public class apptMain
        {
            public int Appointment { get; set; }
            public int CustomerId { get; set; }
            public int UserId { get; set; }
            public string Customer { get; set; }
            public DateTime Start { get; set; }
            public DateTime End { get; set; }

            public apptMain() { }
            public apptMain(int appt, string customer, int cId, int uId, DateTime start, DateTime end)
            {
                
                Appointment = appt;
                Customer = customer;
                CustomerId = cId;
                UserId = uId;

                Start = start;
                End = end;
            }
            ~apptMain() { }
        }
    }
}
        

