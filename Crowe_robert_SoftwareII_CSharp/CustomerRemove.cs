using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Crowe_robert_SoftwareII_CSharp
{
    public partial class CustomerRemove : Form
    {
        #region Hide Main
        Main MainFormHolder;
        private BindingList<customer> custList = new BindingList<customer>();
        bool bSelected = false; bool bHasAppointments = true;
        private int selectionIndex;
        private int rowIndex;
        public CustomerRemove(Main hform) : this()
        {
            MainFormHolder = hform;
        }

        private void closeChildForm()
        {
            MainFormHolder.Show();
            this.Close();
        }

        #endregion
        public CustomerRemove()
        {
            InitializeComponent();
        }

        private void LoadDgv()
        {
            using (var context = new U05oDKEntities())
            {
                var holder = context.customers.ToList();
                var bindHolder = new BindingList<customer>(holder);
                custList = bindHolder;
                dbHelper.isEmptyCust(bindHolder);
            }

            dgvDelC.DataSource = custList;
            dgvDelC.RowHeadersVisible = false;
            dgvDelC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDelC.Columns["address"].Visible = false;
            dgvDelC.Columns["appointments"].Visible = false;
            dgvDelC.Refresh();
        }

        private int GetSelectionIndex() { return selectionIndex; }
        private int GetRowIndex() { return rowIndex; }
        private void SetSelectionIndex()
        {
            selectionIndex = 0;
            selectionIndex = Convert.ToInt32(dgvDelC.Rows[Convert.ToInt32(dgvDelC.CurrentCell.RowIndex)].Cells[0].Value.ToString());
        }

        private void SetRowIndex()
        {
            rowIndex = 0;
            rowIndex = dgvDelC.CurrentCell.RowIndex;
        }

        private void UpdateDgv()
        {
            using (var context = new U05oDKEntities())
            {
                var holder = context.customers.ToList();
                var bindHolder = new BindingList<customer>(holder);
                dbHelper.isEmptyCust(bindHolder);
                custList = bindHolder;
            }
            dgvDelC.Refresh();
        }

        private void CustomerRemove_Load(object sender, EventArgs e){LoadDgv();}

        private void btCustomerRemoveCancel_Click(object sender, EventArgs e){closeChildForm();}

        private void RemoveCustomer()
        {
                using (var context = new U05oDKEntities())
                {
                    var custTemp = context.customers.Find(GetSelectionIndex());
                    context.customers.Remove(custTemp);
                    context.SaveChanges();
                }
            
        }
        private bool HasAppointments()
        {
            using (var context = new U05oDKEntities())
            {
                bool holder = dbHelper.GetAppointments().Where(n => n.customerId == GetSelectionIndex()).Any();
                return holder;
            }
        }

    private void btDel_Click(object sender, EventArgs e)
    {
            try
            {
                if (bSelected == true)
                {
                    bHasAppointments = HasAppointments();
                    if (bHasAppointments == false)
                    {
                        try
                        {
                            custList.RemoveAt(GetRowIndex());
                            RemoveCustomer();
                            label1.Visible = false;
                            closeChildForm();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else { MessageBox.Show("Please remove any appointments associated with " + custList[GetRowIndex()].customerName); }
                }
                else { MessageBox.Show("You must select a customer first"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.InnerException.ToString()); }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            selectionIndex = 0;
            selectionIndex = Convert.ToInt32(dgvDelC.Rows[Convert.ToInt32(dgvDelC.CurrentCell.RowIndex)].Cells[0].Value.ToString());
            SetRowIndex();
            label1.Text = "Selected: " + custList[GetRowIndex()].customerName;
            label1.Visible = true;
            bSelected = true;
        }
    }
}
