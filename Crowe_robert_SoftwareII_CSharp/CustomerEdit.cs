using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Crowe_robert_SoftwareII_CSharp
{
    public partial class CustomerEdit : Form
    {
        #region Hide Main
        Main MainFormHolder;
        public CustomerEdit(Main hform) : this()
        {
            MainFormHolder = hform;
        }

        private void closeChildForm()
        {
            MainFormHolder.Show();
            this.Close();
        }

        #endregion
        private int selectionIndex;
        private BindingList<customer> custList = new BindingList<customer>();
        private string name, phone, address, city, zip, country;
        private bool bName=true, bPhone = true, bAddress = true, bCity = true, bZip = true, bCustAdd=false, bZipInt=false, active;

        private int GetSelectionIndex() { return selectionIndex; }

        private void SetSelectionIndex()
        {
            selectionIndex = 0;
            selectionIndex = Convert.ToInt32(dgvModC.Rows[Convert.ToInt32(dgvModC.CurrentCell.RowIndex)].Cells[0].Value.ToString());
        }

        public CustomerEdit() { InitializeComponent(); }

        private void MasterValid()
        {
            dbHelper.isValid(tbNameE, label1);
            dbHelper.isValid(tbPhoneE, label2);
            dbHelper.isValid(tbAddressE, label3);
            dbHelper.isValid(tbCityE, label4);
            dbHelper.isValid(tbZipE, label5);
            dbHelper.IsValidInt(tbZipE, label5);
        }

        private void tbNameE_Validating(object sender, CancelEventArgs e)
        {
            bName = dbHelper.isValid(tbNameE, label1);
        }

        private void tbPhoneE_Validating(object sender, CancelEventArgs e)
        {
            bPhone = dbHelper.isValid(tbNameE, label2);
        }

        private void tbAddressE_Validating(object sender, CancelEventArgs e)
        {
            bAddress = dbHelper.isValid(tbNameE, label3);
        }

        private void tbCityE_Validating(object sender, CancelEventArgs e)
        {
            bCity = dbHelper.isValid(tbNameE, label4);
        }

        private void tbZipE_Validating(object sender, CancelEventArgs e)
        {
            bZip = dbHelper.isValid(tbNameE, label5);
            bZipInt = dbHelper.IsValidInt(tbZipE, label5); 
        }

        private string Who(){return dbHelper.loginName;}

        private void btCustomerEditCancel_Click(object sender, EventArgs e){closeChildForm();}

        private void CustomerEdit_Load(object sender, EventArgs e) { LoadDgv(); }

        private void LoadDgv()
        {
            using (var context = new U05oDKEntities())
            {
                var holder = context.customers.ToList();
                var bindHolder = new BindingList<customer>(holder);
                custList = bindHolder;
                dbHelper.isEmptyCust(bindHolder);

                dgvModC.DataSource = custList;
                dgvModC.RowHeadersVisible = false;
                dgvModC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvModC.Columns["address"].Visible = false;
                dgvModC.Columns["appointments"].Visible = false;
                dgvModC.Refresh();
            }
        }

        private bool AllValid()
        {
            if(bName != false && bPhone != false && bAddress != false && bCity != false && bZip != false && bZipInt != false) { return true; }
            else { return false; }
        }

        private void UpdateDgv()
        {
            using (var context = new U05oDKEntities())
            {
                var holder = context.customers.ToList();
                var bindHolder = new BindingList<customer>(holder);
                dbHelper.isEmptyCust(bindHolder);
                custList.Clear();
                custList = bindHolder;
                dgvModC.DataSource = custList;
            }
        }

        private void GetCustomer()
        {
            using (var context = new U05oDKEntities())
            {
                var indexHolder = GetSelectionIndex();
                var custHolder = context.customers.Find(indexHolder); 
                var addressHolder = custHolder.address;
                var cityHolder = addressHolder.city;
                var countryHolder = cityHolder.country;

                tbNameE.Text = custHolder.customerName; name = custHolder.customerName;
                tbPhoneE.Text = addressHolder.phone; phone = addressHolder.phone;
                tbAddressE.Text = addressHolder.address1; address = addressHolder.address1;
                tbCityE.Text = cityHolder.city1; city = cityHolder.city1;
                tbZipE.Text = addressHolder.postalCode; zip = addressHolder.postalCode;
                cbCountry.Text = countryHolder.country1; country = countryHolder.country1;
                active = custHolder.active;
                if (custHolder.active == true){rbYesE.Checked = true;}
                else if (custHolder.active == false){rbNoE.Checked = true;}
                else {MessageBox.Show("Active not set to true/false");}
            }
        }

        private void SetCustomer()
        {
            using (var context = new U05oDKEntities())
            {
                var indexHolder = GetSelectionIndex();
                var custHolder = context.customers.Find(indexHolder);
                var addressHolder = custHolder.address;
                var cityHolder = addressHolder.city;
                var countryHolder = cityHolder.country;
                DateTime n = new DateTime(); n = DateTime.UtcNow;

                countryHolder.country1 = cbCountry.Text;
                if (cbCountry.Text != country)
                {
                    countryHolder.lastUpdate = n;
                    countryHolder.lastUpdateBy = Who();
                }

                cityHolder.city1 = tbCityE.Text;
                cityHolder.country = countryHolder;
                if(tbCityE.Text != city)
                {
                    cityHolder.lastUpdate = n;
                    cityHolder.lastUpdateBy = Who();
                }

                addressHolder.address1 = tbAddressE.Text;
                addressHolder.phone = tbPhoneE.Text;
                addressHolder.postalCode = tbZipE.Text; ;
                addressHolder.city = cityHolder;
                if((tbAddressE.Text != address)||(tbPhoneE.Text != phone)||(tbZipE.Text != zip))
                {
                    addressHolder.lastUpdate = n;
                    addressHolder.lastUpdateBy = Who();
                }

                custHolder.customerName = tbNameE.Text;
                if (rbYesE.Checked == true){custHolder.active = true; custHolder.lastUpdateBy = Who(); }
                else if (rbNoE.Checked == true){custHolder.active = false; custHolder.lastUpdateBy = Who(); }
                else {MessageBox.Show("Active error");}

                if((tbNameE.Text != name) || (custHolder.active != active))
                {
                    custHolder.lastUpdate = n;
                    custHolder.lastUpdateBy = Who();
                }
                custHolder.address = addressHolder;
                context.SaveChanges();
            };
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            SetSelectionIndex();
            GetCustomer();
            bCustAdd = true;
        }

        private void btSaveE_Click(object sender, EventArgs e)
        {
            if (dbHelper.IsCustSelected(bCustAdd) == true)
            {
                MasterValid();
                if (AllValid() == true)
                {
                    dbHelper.SetDirty();
                    SetCustomer();
                    UpdateDgv();
                }
            }
        }
    } 
}
