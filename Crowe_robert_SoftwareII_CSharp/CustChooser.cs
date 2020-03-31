using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Crowe_robert_SoftwareII_CSharp
{
    public partial class CustChooser : Form
    {
        #region main
        ApptUpdate AppUpdateFormHolder;
        public CustChooser(ApptUpdate auform) : this()
        {
            AppUpdateFormHolder = auform;
        }

        #endregion endMain
        private BindingList<customer> custList = new BindingList<customer>();
        private int index { get; set; }
        public CustChooser()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetSelection()
        {
            dbHelper.fkey = Convert.ToInt32(dgvCust.Rows[Convert.ToInt32(dgvCust.CurrentCell.RowIndex)].Cells[0].Value.ToString());
        }

        private int GetSelection()
        {
            return dbHelper.fkey;
        }

        private void LoadDgv()
        {
            var holder = dbHelper.GetCustomers();
            BindingList<customer> bindList = new BindingList<customer>(holder);
            custList = bindList;
            dbHelper.isEmptyCust(bindList);
            dgvCust.DataSource = custList;
            dgvCust.RowHeadersVisible = false;
            dgvCust.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCust.Columns["address"].Visible = false;
            dgvCust.Columns["appointments"].Visible = false;
            dgvCust.Refresh();
        }
    
        private void btChoose_Click(object sender, EventArgs e)
        {
            SetSelection();
            dbHelper.fkey = GetSelection();
            this.Close();
        }

        private void CustChooser_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }
    }
}
