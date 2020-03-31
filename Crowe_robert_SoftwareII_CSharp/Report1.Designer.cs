namespace Crowe_robert_SoftwareII_CSharp
{
    partial class Report1
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
            this.btReport1Cancel = new System.Windows.Forms.Button();
            this.dgvReport1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport1)).BeginInit();
            this.SuspendLayout();
            // 
            // btReport1Cancel
            // 
            this.btReport1Cancel.Location = new System.Drawing.Point(12, 397);
            this.btReport1Cancel.Name = "btReport1Cancel";
            this.btReport1Cancel.Size = new System.Drawing.Size(119, 41);
            this.btReport1Cancel.TabIndex = 3;
            this.btReport1Cancel.Text = "Cancel";
            this.btReport1Cancel.UseVisualStyleBackColor = true;
            this.btReport1Cancel.Click += new System.EventHandler(this.btReport1Cancel_Click);
            // 
            // dgvReport1
            // 
            this.dgvReport1.AllowUserToAddRows = false;
            this.dgvReport1.AllowUserToDeleteRows = false;
            this.dgvReport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport1.Location = new System.Drawing.Point(13, 13);
            this.dgvReport1.Name = "dgvReport1";
            this.dgvReport1.ReadOnly = true;
            this.dgvReport1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvReport1.Size = new System.Drawing.Size(775, 378);
            this.dgvReport1.TabIndex = 4;
            // 
            // Report1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvReport1);
            this.Controls.Add(this.btReport1Cancel);
            this.Name = "Report1";
            this.Text = "Appointment Types by Month";
            this.Load += new System.EventHandler(this.Report1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btReport1Cancel;
        private System.Windows.Forms.DataGridView dgvReport1;
    }
}