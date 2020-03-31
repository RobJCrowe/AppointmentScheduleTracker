using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Crowe_robert_SoftwareII_CSharp
{
    public partial class Report1 : Form
    {
        #region Hide Main
        Main MainFormHolder;
        public Report1(Main hform) : this()
        {
            MainFormHolder = hform;
        }

        private void closeChildForm()
        {
            MainFormHolder.Show();
            this.Close();
        }

        #endregion
        public Report1()
        {
            InitializeComponent();
        }

        private void Report1_Load(object sender, EventArgs e)
        {
            using (var context = new U05oDKEntities())
            {
                var appts = context.appointments.OrderBy(i => i.start ).ThenBy(j=>j.type).ToList();
                var holder = from o in appts
                             let gr = new { Start = o.start.ToString("yyyy-MMM"), Type = o.type }
                             group o by gr into ogr
                             let count = ogr.Count()
                             select new { Month = ogr.Key.Start, Type = ogr.Key.Type, Total = count };

                dgvReport1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvReport1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvReport1.DataSource = holder.ToList();
                dgvReport1.RowHeadersVisible = false;
                dgvReport1.ClearSelection();
            }
        }

        private void btReport1Cancel_Click(object sender, EventArgs e)
        {
            closeChildForm();
        }
    }
}
