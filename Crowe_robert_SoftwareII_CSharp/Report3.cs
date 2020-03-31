using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Crowe_robert_SoftwareII_CSharp
{
    public partial class Report3 : Form
    {
        #region Hide Main
        Main MainFormHolder;
        public Report3(Main hform) : this()
        {
            MainFormHolder = hform;
        }

        private void closeChildForm()
        {
            MainFormHolder.Show();
            this.Close();
        }

        #endregion

        public Report3()
        {
            InitializeComponent();
        }

        private void Report3_Load(object sender, EventArgs e)
        {
            using (var context = new U05oDKEntities())
            {
                var appts = context.appointments.OrderBy(i => i.start).ThenBy(j => j.userId).ToList();
                var holder = from o in appts
                             let gr = new { Start = o.start.ToString("yyyy-MMM"), User=o.userId }
                             group o by gr into ogr
                             let duration= Math.Round(ogr.Sum(z=> z.end.Subtract(z.start).TotalHours),2)
                             select new { Month = ogr.Key.Start, User=ogr.Key.User, Hours = duration };

                dgvReport3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvReport3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvReport3.DataSource = holder.ToList();
                dgvReport3.RowHeadersVisible = false;
                dgvReport3.ClearSelection();
            }
        }
        
        private void btReport3Cancel_Click(object sender, EventArgs e)
        {
            closeChildForm();
        }
    }
}
