namespace Crowe_robert_SoftwareII_CSharp
{
    partial class CustChooser
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
            this.dgvCust = new System.Windows.Forms.DataGridView();
            this.btChoose = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCust
            // 
            this.dgvCust.AllowUserToAddRows = false;
            this.dgvCust.AllowUserToDeleteRows = false;
            this.dgvCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCust.Location = new System.Drawing.Point(13, 13);
            this.dgvCust.Name = "dgvCust";
            this.dgvCust.ReadOnly = true;
            this.dgvCust.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCust.Size = new System.Drawing.Size(162, 318);
            this.dgvCust.TabIndex = 0;
            // 
            // btChoose
            // 
            this.btChoose.Location = new System.Drawing.Point(236, 65);
            this.btChoose.Name = "btChoose";
            this.btChoose.Size = new System.Drawing.Size(126, 44);
            this.btChoose.TabIndex = 1;
            this.btChoose.Text = "Select";
            this.btChoose.UseVisualStyleBackColor = true;
            this.btChoose.Click += new System.EventHandler(this.btChoose_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(236, 129);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(126, 44);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // CustChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 347);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btChoose);
            this.Controls.Add(this.dgvCust);
            this.Name = "CustChooser";
            this.Text = "CustChooser";
            this.Load += new System.EventHandler(this.CustChooser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCust;
        private System.Windows.Forms.Button btChoose;
        private System.Windows.Forms.Button btClose;
    }
}