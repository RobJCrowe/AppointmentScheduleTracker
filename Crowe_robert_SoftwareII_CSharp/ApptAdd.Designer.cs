namespace Crowe_robert_SoftwareII_CSharp
{
    partial class ApptAdd
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
            this.btApptAddCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbContactA = new System.Windows.Forms.TextBox();
            this.tbUrlA = new System.Windows.Forms.TextBox();
            this.tbLocationA = new System.Windows.Forms.TextBox();
            this.tbDescA = new System.Windows.Forms.TextBox();
            this.tbTitleA = new System.Windows.Forms.TextBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dgvCust = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvAppt = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbSelect = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppt)).BeginInit();
            this.SuspendLayout();
            // 
            // btApptAddCancel
            // 
            this.btApptAddCancel.Location = new System.Drawing.Point(196, 397);
            this.btApptAddCancel.Name = "btApptAddCancel";
            this.btApptAddCancel.Size = new System.Drawing.Size(119, 41);
            this.btApptAddCancel.TabIndex = 2;
            this.btApptAddCancel.Text = "Cancel";
            this.btApptAddCancel.UseVisualStyleBackColor = true;
            this.btApptAddCancel.Click += new System.EventHandler(this.btApptAddCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "URL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Location";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(8, 41);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(60, 13);
            this.lbDescription.TabIndex = 43;
            this.lbDescription.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Title";
            // 
            // tbContactA
            // 
            this.tbContactA.Location = new System.Drawing.Point(76, 90);
            this.tbContactA.Name = "tbContactA";
            this.tbContactA.Size = new System.Drawing.Size(192, 20);
            this.tbContactA.TabIndex = 37;
            this.tbContactA.Validating += new System.ComponentModel.CancelEventHandler(this.tbContactA_Validating);
            // 
            // tbUrlA
            // 
            this.tbUrlA.Location = new System.Drawing.Point(76, 142);
            this.tbUrlA.Name = "tbUrlA";
            this.tbUrlA.Size = new System.Drawing.Size(192, 20);
            this.tbUrlA.TabIndex = 39;
            this.tbUrlA.Validating += new System.ComponentModel.CancelEventHandler(this.tbUrlA_Validating);
            // 
            // tbLocationA
            // 
            this.tbLocationA.Location = new System.Drawing.Point(76, 64);
            this.tbLocationA.Name = "tbLocationA";
            this.tbLocationA.Size = new System.Drawing.Size(192, 20);
            this.tbLocationA.TabIndex = 36;
            this.tbLocationA.Validating += new System.ComponentModel.CancelEventHandler(this.tbLocationA_Validating);
            // 
            // tbDescA
            // 
            this.tbDescA.Location = new System.Drawing.Point(76, 38);
            this.tbDescA.Name = "tbDescA";
            this.tbDescA.Size = new System.Drawing.Size(192, 20);
            this.tbDescA.TabIndex = 35;
            this.tbDescA.WordWrap = false;
            this.tbDescA.Validating += new System.ComponentModel.CancelEventHandler(this.tbDescA_Validating);
            // 
            // tbTitleA
            // 
            this.tbTitleA.Location = new System.Drawing.Point(76, 12);
            this.tbTitleA.Name = "tbTitleA";
            this.tbTitleA.Size = new System.Drawing.Size(192, 20);
            this.tbTitleA.TabIndex = 34;
            this.tbTitleA.Validating += new System.ComponentModel.CancelEventHandler(this.tbTitleA_Validating);
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(76, 168);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(192, 20);
            this.dtpStart.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Start:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "End:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(76, 194);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(192, 20);
            this.dtpEnd.TabIndex = 51;
            this.dtpEnd.Validating += new System.ComponentModel.CancelEventHandler(this.dtpEnd_Validating);
            // 
            // dgvCust
            // 
            this.dgvCust.AllowUserToAddRows = false;
            this.dgvCust.AllowUserToDeleteRows = false;
            this.dgvCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCust.Location = new System.Drawing.Point(53, 225);
            this.dgvCust.Name = "dgvCust";
            this.dgvCust.ReadOnly = true;
            this.dgvCust.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCust.Size = new System.Drawing.Size(215, 150);
            this.dgvCust.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 41);
            this.button1.TabIndex = 53;
            this.button1.Text = "Select Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvAppt
            // 
            this.dgvAppt.AllowUserToAddRows = false;
            this.dgvAppt.AllowUserToDeleteRows = false;
            this.dgvAppt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppt.Location = new System.Drawing.Point(427, 38);
            this.dgvAppt.Name = "dgvAppt";
            this.dgvAppt.ReadOnly = true;
            this.dgvAppt.Size = new System.Drawing.Size(570, 337);
            this.dgvAppt.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Current Appointments:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 41);
            this.button2.TabIndex = 56;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbSelect
            // 
            this.lbSelect.AutoSize = true;
            this.lbSelect.Location = new System.Drawing.Point(286, 324);
            this.lbSelect.Name = "lbSelect";
            this.lbSelect.Size = new System.Drawing.Size(35, 13);
            this.lbSelect.TabIndex = 57;
            this.lbSelect.Text = "label9";
            this.lbSelect.Visible = false;
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
            this.cbType.TabIndex = 38;
            // 
            // ApptAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lbSelect);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvAppt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCust);
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
            this.Controls.Add(this.tbContactA);
            this.Controls.Add(this.tbUrlA);
            this.Controls.Add(this.tbLocationA);
            this.Controls.Add(this.tbDescA);
            this.Controls.Add(this.tbTitleA);
            this.Controls.Add(this.btApptAddCancel);
            this.MinimumSize = new System.Drawing.Size(916, 489);
            this.Name = "ApptAdd";
            this.Text = "ApptAdd";
            this.Load += new System.EventHandler(this.ApptAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btApptAddCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbContactA;
        private System.Windows.Forms.TextBox tbUrlA;
        private System.Windows.Forms.TextBox tbLocationA;
        private System.Windows.Forms.TextBox tbDescA;
        private System.Windows.Forms.TextBox tbTitleA;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DataGridView dgvCust;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvAppt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbSelect;
        private System.Windows.Forms.ComboBox cbType;
    }
}