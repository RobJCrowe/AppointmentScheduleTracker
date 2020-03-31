namespace Crowe_robert_SoftwareII_CSharp
{
    partial class ApptUpdate
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
            this.btApptUpdateCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbContactE = new System.Windows.Forms.TextBox();
            this.tbUrlE = new System.Windows.Forms.TextBox();
            this.tbLocationE = new System.Windows.Forms.TextBox();
            this.tbDescE = new System.Windows.Forms.TextBox();
            this.tbTitleE = new System.Windows.Forms.TextBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btSave = new System.Windows.Forms.Button();
            this.btSelect = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvAppt = new System.Windows.Forms.DataGridView();
            this.btSelectAppt = new System.Windows.Forms.Button();
            this.lbAppt = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppt)).BeginInit();
            this.SuspendLayout();
            // 
            // btApptUpdateCancel
            // 
            this.btApptUpdateCancel.Location = new System.Drawing.Point(196, 397);
            this.btApptUpdateCancel.Name = "btApptUpdateCancel";
            this.btApptUpdateCancel.Size = new System.Drawing.Size(119, 41);
            this.btApptUpdateCancel.TabIndex = 3;
            this.btApptUpdateCancel.Text = "Cancel";
            this.btApptUpdateCancel.UseVisualStyleBackColor = true;
            this.btApptUpdateCancel.Click += new System.EventHandler(this.btApptUpdateCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "URL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Location";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(8, 41);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(60, 13);
            this.lbDescription.TabIndex = 55;
            this.lbDescription.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Title";
            // 
            // tbContactE
            // 
            this.tbContactE.Location = new System.Drawing.Point(76, 90);
            this.tbContactE.Name = "tbContactE";
            this.tbContactE.Size = new System.Drawing.Size(192, 20);
            this.tbContactE.TabIndex = 51;
            this.tbContactE.Validating += new System.ComponentModel.CancelEventHandler(this.tbContactE_Validating);
            // 
            // tbUrlE
            // 
            this.tbUrlE.Location = new System.Drawing.Point(76, 142);
            this.tbUrlE.Name = "tbUrlE";
            this.tbUrlE.Size = new System.Drawing.Size(192, 20);
            this.tbUrlE.TabIndex = 53;
            this.tbUrlE.Validating += new System.ComponentModel.CancelEventHandler(this.tbUrlE_Validating);
            // 
            // tbLocationE
            // 
            this.tbLocationE.Location = new System.Drawing.Point(76, 64);
            this.tbLocationE.Name = "tbLocationE";
            this.tbLocationE.Size = new System.Drawing.Size(192, 20);
            this.tbLocationE.TabIndex = 50;
            this.tbLocationE.Validating += new System.ComponentModel.CancelEventHandler(this.tbLocationE_Validating);
            // 
            // tbDescE
            // 
            this.tbDescE.Location = new System.Drawing.Point(76, 38);
            this.tbDescE.Name = "tbDescE";
            this.tbDescE.Size = new System.Drawing.Size(192, 20);
            this.tbDescE.TabIndex = 49;
            this.tbDescE.WordWrap = false;
            this.tbDescE.Validating += new System.ComponentModel.CancelEventHandler(this.tbDescE_Validating);
            // 
            // tbTitleE
            // 
            this.tbTitleE.Location = new System.Drawing.Point(76, 12);
            this.tbTitleE.Name = "tbTitleE";
            this.tbTitleE.Size = new System.Drawing.Size(192, 20);
            this.tbTitleE.TabIndex = 48;
            this.tbTitleE.Validating += new System.ComponentModel.CancelEventHandler(this.tbTitleE_Validating);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(76, 194);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(192, 20);
            this.dtpEnd.TabIndex = 63;
            this.dtpEnd.Validating += new System.ComponentModel.CancelEventHandler(this.dtpEnd_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "End:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Start:";
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(76, 168);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(192, 20);
            this.dtpStart.TabIndex = 60;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(71, 397);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(119, 41);
            this.btSave.TabIndex = 67;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(286, 276);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(119, 41);
            this.btSelect.TabIndex = 66;
            this.btSelect.Text = "Change Customer";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "Current Appointments:";
            // 
            // dgvAppt
            // 
            this.dgvAppt.AllowUserToAddRows = false;
            this.dgvAppt.AllowUserToDeleteRows = false;
            this.dgvAppt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppt.Location = new System.Drawing.Point(427, 38);
            this.dgvAppt.Name = "dgvAppt";
            this.dgvAppt.ReadOnly = true;
            this.dgvAppt.Size = new System.Drawing.Size(561, 337);
            this.dgvAppt.TabIndex = 69;
            // 
            // btSelectAppt
            // 
            this.btSelectAppt.Location = new System.Drawing.Point(286, 229);
            this.btSelectAppt.Name = "btSelectAppt";
            this.btSelectAppt.Size = new System.Drawing.Size(119, 41);
            this.btSelectAppt.TabIndex = 71;
            this.btSelectAppt.Text = "Select Appointment";
            this.btSelectAppt.UseVisualStyleBackColor = true;
            this.btSelectAppt.Click += new System.EventHandler(this.btSelectAppt_Click);
            // 
            // lbAppt
            // 
            this.lbAppt.AutoSize = true;
            this.lbAppt.Location = new System.Drawing.Point(286, 210);
            this.lbAppt.Name = "lbAppt";
            this.lbAppt.Size = new System.Drawing.Size(37, 13);
            this.lbAppt.TabIndex = 72;
            this.lbAppt.Text = "lbAppt";
            this.lbAppt.Visible = false;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Initial consultation",
            "Status Update",
            "Member Review",
            "Exit Interview"});
            this.cbType.Location = new System.Drawing.Point(76, 116);
            this.cbType.MaxDropDownItems = 4;
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(192, 21);
            this.cbType.TabIndex = 52;
            // 
            // ApptUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lbAppt);
            this.Controls.Add(this.btSelectAppt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvAppt);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbContactE);
            this.Controls.Add(this.tbUrlE);
            this.Controls.Add(this.tbLocationE);
            this.Controls.Add(this.tbDescE);
            this.Controls.Add(this.tbTitleE);
            this.Controls.Add(this.btApptUpdateCancel);
            this.MaximumSize = new System.Drawing.Size(1016, 489);
            this.MinimumSize = new System.Drawing.Size(1016, 489);
            this.Name = "ApptUpdate";
            this.Text = "ApptUpdate";
            this.Load += new System.EventHandler(this.ApptUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btApptUpdateCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbContactE;
        private System.Windows.Forms.TextBox tbUrlE;
        private System.Windows.Forms.TextBox tbLocationE;
        private System.Windows.Forms.TextBox tbDescE;
        private System.Windows.Forms.TextBox tbTitleE;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvAppt;
        private System.Windows.Forms.Button btSelectAppt;
        private System.Windows.Forms.Label lbAppt;
        private System.Windows.Forms.ComboBox cbType;
    }
}