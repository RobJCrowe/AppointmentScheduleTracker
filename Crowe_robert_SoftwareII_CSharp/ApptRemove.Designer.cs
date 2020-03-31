namespace Crowe_robert_SoftwareII_CSharp
{
    partial class ApptRemove
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
            this.btApptRemoveCancel = new System.Windows.Forms.Button();
            this.dgvApptRemove = new System.Windows.Forms.DataGridView();
            this.btRemove = new System.Windows.Forms.Button();
            this.btSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApptRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // btApptRemoveCancel
            // 
            this.btApptRemoveCancel.Location = new System.Drawing.Point(296, 397);
            this.btApptRemoveCancel.Name = "btApptRemoveCancel";
            this.btApptRemoveCancel.Size = new System.Drawing.Size(119, 41);
            this.btApptRemoveCancel.TabIndex = 4;
            this.btApptRemoveCancel.Text = "Cancel";
            this.btApptRemoveCancel.UseVisualStyleBackColor = true;
            this.btApptRemoveCancel.Click += new System.EventHandler(this.btApptRemoveCancel_Click);
            // 
            // dgvApptRemove
            // 
            this.dgvApptRemove.AllowUserToAddRows = false;
            this.dgvApptRemove.AllowUserToDeleteRows = false;
            this.dgvApptRemove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApptRemove.Location = new System.Drawing.Point(13, 13);
            this.dgvApptRemove.Name = "dgvApptRemove";
            this.dgvApptRemove.ReadOnly = true;
            this.dgvApptRemove.Size = new System.Drawing.Size(735, 378);
            this.dgvApptRemove.TabIndex = 5;
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(171, 397);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(119, 41);
            this.btRemove.TabIndex = 6;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(46, 397);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(119, 41);
            this.btSelect.TabIndex = 7;
            this.btSelect.Text = "Select";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.Select_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // ApptRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.dgvApptRemove);
            this.Controls.Add(this.btApptRemoveCancel);
            this.MaximumSize = new System.Drawing.Size(916, 489);
            this.MinimumSize = new System.Drawing.Size(916, 489);
            this.Name = "ApptRemove";
            this.Text = "ApptRemove";
            this.Load += new System.EventHandler(this.ApptRemove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApptRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btApptRemoveCancel;
        private System.Windows.Forms.DataGridView dgvApptRemove;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Label label1;
    }
}