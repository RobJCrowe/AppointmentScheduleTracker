using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Crowe_robert_SoftwareII_CSharp
{
    public partial class CustomerAdd : Form
    {
        #region Hide Main
        Main MainFormHolder;
        public CustomerAdd(Main hform) : this()
        {
            MainFormHolder = hform;
        }

        private void closeChildForm()
        {
            MainFormHolder.Show();
            this.Close();
        }

        #endregion
        public bool active { get; set; }
        private bool bName= false, bPhone= false, bAddress= false, bCity= false, bZip=false, bZipInt = false;
        public CustomerAdd()
        {
            InitializeComponent();
        }

        private void CustomerAdd_Load(object sender, EventArgs e)
        {
            cbCountry.Text = "United States";
        }

        private string Who() { return dbHelper.loginName; }

        private void btCustomerAddCancel_Click(object sender, EventArgs e)
        {
            closeChildForm();
        }

        private bool AllValid()
        {
            if (bName != false && bPhone != false && bAddress != false && bCity != false && bZip != false && bZipInt != false) { return true; }
            else { return false; }
        }

        private void MasterValid()
        {
            dbHelper.isValid(tbNameA, label1);
            dbHelper.isValid(tbPhoneA, label2);
            dbHelper.isValid(tbAddressA, label3);
            dbHelper.isValid(tbCityA, label4);
            dbHelper.isValid(tbZipA, label5);
            dbHelper.IsValidInt(tbZipA, label5);
        }

        private void tbNameA_Validating(object sender, CancelEventArgs e)
        {
            bName = dbHelper.isValid(tbNameA, label1);
        }

        private void tbPhoneA_Validating(object sender, CancelEventArgs e)
        {
            bPhone = dbHelper.isValid(tbPhoneA, label2);
        }

        private void tbAddressA_Validating(object sender, CancelEventArgs e)
        {
            bAddress = dbHelper.isValid(tbAddressA, label3);
        }

        private void tbCityA_Validating(object sender, CancelEventArgs e)
        {
            bCity = dbHelper.isValid(tbCityA, label4);
        }

        private void tbZipA_Validating(object sender, CancelEventArgs e)
        {
            bZip = dbHelper.isValid(tbZipA, label5);
            bZipInt = dbHelper.IsValidInt(tbZipA, label5); 
        }

        public void NewCustomer()
        {
            DateTime n = new DateTime();
            n = DateTime.UtcNow;
            var co = new country()
            {
                country1 = cbCountry.Text,
                createDate = n,
                createdBy = Who(),
                lastUpdate = n,
                lastUpdateBy = Who()
            };
            var ci = new city()
            {
                city1 = tbCityA.Text,
                createDate = n,
                createdBy = Who(),
                lastUpdateBy = Who(),
                lastUpdate = n,
                country = co,
            };
            var addy = new address()
            {
                address1 = tbAddressA.Text,
                address2 = "nn",
                postalCode = tbZipA.Text,
                phone = tbPhoneA.Text,
                createDate = n,
                createdBy = Who(),
                lastUpdate = n,
                lastUpdateBy = Who(),
                city = ci,
            };
            var cust = new customer()
            {
                customerName = tbNameA.Text,
                active = this.active,
                createDate = n,
                createdBy = Who(),
                lastUpdate = n,
                lastUpdateBy = Who(),
                address = addy,

            };
            using (var context = new U05oDKEntities())
            {
                context.customers.Add(cust);
                context.SaveChanges();
            }
        }

        private void rbYesA_CheckedChanged(object sender, EventArgs e) { active = true; }

        private void rbNoA_CheckedChanged(object sender, EventArgs e) { active = false; }

        private void btSaveA_Click(object sender, EventArgs e)
        {
            MasterValid();
            if (AllValid() == true)
            {
                NewCustomer();
                dbHelper.SetDirty();
                closeChildForm();
            }
        }
    }
}
