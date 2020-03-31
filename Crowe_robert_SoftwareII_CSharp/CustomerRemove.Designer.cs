namespace Crowe_robert_SoftwareII_CSharp
{
    partial class CustomerRemove
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
            this.components = new System.ComponentModel.Container();
            this.btCustomerRemoveCancel = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.dgvDelC = new System.Windows.Forms.DataGridView();
            this.btSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.u05oDKEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u05oDKEntitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btCustomerRemoveCancel
            // 
            this.btCustomerRemoveCancel.Location = new System.Drawing.Point(226, 106);
            this.btCustomerRemoveCancel.Name = "btCustomerRemoveCancel";
            this.btCustomerRemoveCancel.Size = new System.Drawing.Size(119, 41);
            this.btCustomerRemoveCancel.TabIndex = 2;
            this.btCustomerRemoveCancel.Text = "Cancel";
            this.btCustomerRemoveCancel.UseVisualStyleBackColor = true;
            this.btCustomerRemoveCancel.Click += new System.EventHandler(this.btCustomerRemoveCancel_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(226, 59);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(119, 41);
            this.btDel.TabIndex = 3;
            this.btDel.Text = "Delete";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // dgvDelC
            // 
            this.dgvDelC.AllowUserToAddRows = false;
            this.dgvDelC.AllowUserToDeleteRows = false;
            this.dgvDelC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelC.Location = new System.Drawing.Point(13, 12);
            this.dgvDelC.Name = "dgvDelC";
            this.dgvDelC.ReadOnly = true;
            this.dgvDelC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDelC.Size = new System.Drawing.Size(189, 308);
            this.dgvDelC.TabIndex = 4;
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(226, 12);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(119, 41);
            this.btSelect.TabIndex = 5;
            this.btSelect.Text = "Select";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Crowe_robert_SoftwareII_CSharp.customer);
            // 
            // u05oDKEntitiesBindingSource
            // 
            this.u05oDKEntitiesBindingSource.DataSource = typeof(Crowe_robert_SoftwareII_CSharp.U05oDKEntities);
            // 
            // CustomerRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.dgvDelC);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btCustomerRemoveCancel);
            this.Name = "CustomerRemove";
            this.Text = "CustomerRemove";
            this.Load += new System.EventHandler(this.CustomerRemove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u05oDKEntitiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCustomerRemoveCancel;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.DataGridView dgvDelC;
        private System.Windows.Forms.BindingSource u05oDKEntitiesBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Label label1;
    }
}