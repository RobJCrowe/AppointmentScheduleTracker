namespace Crowe_robert_SoftwareII_CSharp
{
    partial class Report3
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
            this.btReport3Cancel = new System.Windows.Forms.Button();
            this.dgvReport3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport3)).BeginInit();
            this.SuspendLayout();
            // 
            // btReport3Cancel
            // 
            this.btReport3Cancel.Location = new System.Drawing.Point(12, 397);
            this.btReport3Cancel.Name = "btReport3Cancel";
            this.btReport3Cancel.Size = new System.Drawing.Size(119, 41);
            this.btReport3Cancel.TabIndex = 5;
            this.btReport3Cancel.Text = "Cancel";
            this.btReport3Cancel.UseVisualStyleBackColor = true;
            this.btReport3Cancel.Click += new System.EventHandler(this.btReport3Cancel_Click);
            // 
            // dgvReport3
            // 
            this.dgvReport3.AllowUserToAddRows = false;
            this.dgvReport3.AllowUserToDeleteRows = false;
            this.dgvReport3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport3.Location = new System.Drawing.Point(13, 12);
            this.dgvReport3.Name = "dgvReport3";
            this.dgvReport3.ReadOnly = true;
            this.dgvReport3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvReport3.Size = new System.Drawing.Size(775, 378);
            this.dgvReport3.TabIndex = 6;
            // 
            // Report3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvReport3);
            this.Controls.Add(this.btReport3Cancel);
            this.Name = "Report3";
            this.Text = "Report3";
            this.Load += new System.EventHandler(this.Report3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btReport3Cancel;
        private System.Windows.Forms.DataGridView dgvReport3;
    }
}