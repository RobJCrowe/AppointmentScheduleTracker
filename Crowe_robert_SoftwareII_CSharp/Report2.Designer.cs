namespace Crowe_robert_SoftwareII_CSharp
{
    partial class Report2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btReport2Cancel = new System.Windows.Forms.Button();
            this.lbReport2 = new System.Windows.Forms.Label();
            this.btReport2Select = new System.Windows.Forms.Button();
            this.dgvReport2appt = new System.Windows.Forms.DataGridView();
            this.dgv2ReportUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport2appt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2ReportUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btReport2Cancel
            // 
            this.btReport2Cancel.Location = new System.Drawing.Point(669, 397);
            this.btReport2Cancel.Name = "btReport2Cancel";
            this.btReport2Cancel.Size = new System.Drawing.Size(119, 41);
            this.btReport2Cancel.TabIndex = 4;
            this.btReport2Cancel.Text = "Cancel";
            this.btReport2Cancel.UseVisualStyleBackColor = true;
            this.btReport2Cancel.Click += new System.EventHandler(this.btReport2Cancel_Click);
            // 
            // lbReport2
            // 
            this.lbReport2.AutoSize = true;
            this.lbReport2.Location = new System.Drawing.Point(59, 9);
            this.lbReport2.Name = "lbReport2";
            this.lbReport2.Size = new System.Drawing.Size(131, 13);
            this.lbReport2.TabIndex = 6;
            this.lbReport2.Text = "Please select a consultant";
            // 
            // btReport2Select
            // 
            this.btReport2Select.Location = new System.Drawing.Point(181, 198);
            this.btReport2Select.Name = "btReport2Select";
            this.btReport2Select.Size = new System.Drawing.Size(75, 23);
            this.btReport2Select.TabIndex = 7;
            this.btReport2Select.Text = "Select";
            this.btReport2Select.UseVisualStyleBackColor = true;
            this.btReport2Select.Click += new System.EventHandler(this.btReport2Select_Click);
            // 
            // dgvReport2appt
            // 
            this.dgvReport2appt.AllowUserToAddRows = false;
            this.dgvReport2appt.AllowUserToDeleteRows = false;
            this.dgvReport2appt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport2appt.Location = new System.Drawing.Point(296, 42);
            this.dgvReport2appt.Name = "dgvReport2appt";
            this.dgvReport2appt.Size = new System.Drawing.Size(629, 349);
            this.dgvReport2appt.TabIndex = 8;
            // 
            // dgv2ReportUser
            // 
            this.dgv2ReportUser.AllowUserToAddRows = false;
            this.dgv2ReportUser.AllowUserToDeleteRows = false;
            this.dgv2ReportUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2ReportUser.Location = new System.Drawing.Point(62, 42);
            this.dgv2ReportUser.Name = "dgv2ReportUser";
            this.dgv2ReportUser.ReadOnly = true;
            this.dgv2ReportUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgv2ReportUser.Size = new System.Drawing.Size(194, 150);
            this.dgv2ReportUser.TabIndex = 9;
            // 
            // Report2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.dgv2ReportUser);
            this.Controls.Add(this.dgvReport2appt);
            this.Controls.Add(this.btReport2Select);
            this.Controls.Add(this.lbReport2);
            this.Controls.Add(this.btReport2Cancel);
            this.Name = "Report2";
            this.Text = "Consultant Schedule";
            this.Load += new System.EventHandler(this.Report2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport2appt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2ReportUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReport2Cancel;
        private System.Windows.Forms.Label lbReport2;
        private System.Windows.Forms.Button btReport2Select;
        private System.Windows.Forms.DataGridView dgvReport2appt;
        private System.Windows.Forms.DataGridView dgv2ReportUser;
    }
}