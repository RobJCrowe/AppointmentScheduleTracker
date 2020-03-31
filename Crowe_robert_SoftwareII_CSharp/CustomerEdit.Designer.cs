namespace Crowe_robert_SoftwareII_CSharp
{
    partial class CustomerEdit
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
            this.btCustomerEditCancel = new System.Windows.Forms.Button();
            this.btSaveE = new System.Windows.Forms.Button();
            this.rbNoE = new System.Windows.Forms.RadioButton();
            this.rbYesE = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCityE = new System.Windows.Forms.TextBox();
            this.tbZipE = new System.Windows.Forms.TextBox();
            this.tbAddressE = new System.Windows.Forms.TextBox();
            this.tbPhoneE = new System.Windows.Forms.TextBox();
            this.tbNameE = new System.Windows.Forms.TextBox();
            this.dgvModC = new System.Windows.Forms.DataGridView();
            this.btSelect = new System.Windows.Forms.Button();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModC)).BeginInit();
            this.SuspendLayout();
            // 
            // btCustomerEditCancel
            // 
            this.btCustomerEditCancel.Location = new System.Drawing.Point(201, 344);
            this.btCustomerEditCancel.Name = "btCustomerEditCancel";
            this.btCustomerEditCancel.Size = new System.Drawing.Size(119, 41);
            this.btCustomerEditCancel.TabIndex = 1;
            this.btCustomerEditCancel.Text = "Cancel";
            this.btCustomerEditCancel.UseVisualStyleBackColor = true;
            this.btCustomerEditCancel.Click += new System.EventHandler(this.btCustomerEditCancel_Click);
            // 
            // btSaveE
            // 
            this.btSaveE.Location = new System.Drawing.Point(76, 344);
            this.btSaveE.Name = "btSaveE";
            this.btSaveE.Size = new System.Drawing.Size(119, 41);
            this.btSaveE.TabIndex = 26;
            this.btSaveE.Text = "Save";
            this.btSaveE.UseVisualStyleBackColor = true;
            this.btSaveE.Click += new System.EventHandler(this.btSaveE_Click);
            // 
            // rbNoE
            // 
            this.rbNoE.AutoSize = true;
            this.rbNoE.Location = new System.Drawing.Point(125, 169);
            this.rbNoE.Name = "rbNoE";
            this.rbNoE.Size = new System.Drawing.Size(41, 17);
            this.rbNoE.TabIndex = 25;
            this.rbNoE.TabStop = true;
            this.rbNoE.Text = "NO";
            this.rbNoE.UseVisualStyleBackColor = true;
            // 
            // rbYesE
            // 
            this.rbYesE.AutoSize = true;
            this.rbYesE.Location = new System.Drawing.Point(76, 169);
            this.rbYesE.Name = "rbYesE";
            this.rbYesE.Size = new System.Drawing.Size(46, 17);
            this.rbYesE.TabIndex = 24;
            this.rbYesE.TabStop = true;
            this.rbYesE.Text = "YES";
            this.rbYesE.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Active";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Zip Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Name";
            // 
            // tbCityE
            // 
            this.tbCityE.Location = new System.Drawing.Point(76, 90);
            this.tbCityE.Name = "tbCityE";
            this.tbCityE.Size = new System.Drawing.Size(192, 20);
            this.tbCityE.TabIndex = 21;
            this.tbCityE.Validating += new System.ComponentModel.CancelEventHandler(this.tbCityE_Validating);
            // 
            // tbZipE
            // 
            this.tbZipE.Location = new System.Drawing.Point(76, 116);
            this.tbZipE.Name = "tbZipE";
            this.tbZipE.Size = new System.Drawing.Size(192, 20);
            this.tbZipE.TabIndex = 22;
            this.tbZipE.WordWrap = false;
            this.tbZipE.Validating += new System.ComponentModel.CancelEventHandler(this.tbZipE_Validating);
            // 
            // tbAddressE
            // 
            this.tbAddressE.Location = new System.Drawing.Point(76, 64);
            this.tbAddressE.Name = "tbAddressE";
            this.tbAddressE.Size = new System.Drawing.Size(192, 20);
            this.tbAddressE.TabIndex = 20;
            this.tbAddressE.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddressE_Validating);
            // 
            // tbPhoneE
            // 
            this.tbPhoneE.Location = new System.Drawing.Point(76, 38);
            this.tbPhoneE.Name = "tbPhoneE";
            this.tbPhoneE.Size = new System.Drawing.Size(192, 20);
            this.tbPhoneE.TabIndex = 19;
            this.tbPhoneE.WordWrap = false;
            this.tbPhoneE.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhoneE_Validating);
            // 
            // tbNameE
            // 
            this.tbNameE.Location = new System.Drawing.Point(76, 12);
            this.tbNameE.Name = "tbNameE";
            this.tbNameE.Size = new System.Drawing.Size(192, 20);
            this.tbNameE.TabIndex = 18;
            this.tbNameE.Validating += new System.ComponentModel.CancelEventHandler(this.tbNameE_Validating);
            // 
            // dgvModC
            // 
            this.dgvModC.AllowUserToAddRows = false;
            this.dgvModC.AllowUserToDeleteRows = false;
            this.dgvModC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModC.Location = new System.Drawing.Point(481, 15);
            this.dgvModC.Name = "dgvModC";
            this.dgvModC.ReadOnly = true;
            this.dgvModC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvModC.Size = new System.Drawing.Size(195, 308);
            this.dgvModC.TabIndex = 34;
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(481, 344);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(119, 41);
            this.btSelect.TabIndex = 35;
            this.btSelect.Text = "Select";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // cbCountry
            // 
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Items.AddRange(new object[] {
            "Afghanistan",
            "Akrotiri",
            "Albania",
            "Algeria",
            "American Samoa",
            "Andorra",
            "Angola",
            "Anguilla",
            "Antarctica",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Aruba",
            "Ashmore and Cartier Islands",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas, The",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Bassas da India",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bermuda",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Bouvet Island",
            "Brazil",
            "British Indian Ocean Territory",
            "British Virgin Islands",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burma",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Cayman Islands",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Christmas Island",
            "Clipperton Island",
            "Cocos (Keeling) Islands",
            "Colombia",
            "Comoros",
            "Congo, Democratic Republic of the",
            "Congo, Republic of the",
            "Cook Islands",
            "Coral Sea Islands",
            "Costa Rica",
            "Cote d\'Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Dhekelia",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Europa Island",
            "Falkland Islands (Islas Malvinas)",
            "Faroe Islands",
            "Fiji",
            "Finland",
            "France",
            "French Guiana",
            "French Polynesia",
            "French Southern and Antarctic Lands",
            "Gabon",
            "Gambia, The",
            "Gaza Strip",
            "Georgia",
            "Germany",
            "Ghana",
            "Gibraltar",
            "Glorioso Islands",
            "Greece",
            "Greenland",
            "Grenada",
            "Guadeloupe",
            "Guam",
            "Guatemala",
            "Guernsey",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Heard Island and McDonald Islands",
            "Holy See (Vatican City)",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Isle of Man",
            "Israel",
            "Italy",
            "Jamaica",
            "Jan Mayen",
            "Japan",
            "Jersey",
            "Jordan",
            "Juan de Nova Island",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, North",
            "Korea, South",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macau",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Martinique",
            "Mauritania",
            "Mauritius",
            "Mayotte",
            "Mexico",
            "Micronesia, Federated States of",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montserrat",
            "Morocco",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Navassa Island",
            "Nepal",
            "Netherlands",
            "Netherlands Antilles",
            "New Caledonia",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Niue",
            "Norfolk Island",
            "Northern Mariana Islands",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paracel Islands",
            "Paraguay",
            "Peru",
            "Philippines",
            "Pitcairn Islands",
            "Poland",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Reunion",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Helena",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Pierre and Miquelon",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia and Montenegro",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Georgia and the South Sandwich Islands",
            "Spain",
            "Spratly Islands",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Svalbard",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trinidad and Tobago",
            "Tromelin Island",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Turks and Caicos Islands",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Virgin Islands",
            "Wake Island",
            "Wallis and Futuna",
            "West Bank",
            "Western Sahara",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.cbCountry.Location = new System.Drawing.Point(76, 142);
            this.cbCountry.MaxDropDownItems = 4;
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(192, 21);
            this.cbCountry.TabIndex = 23;
            // 
            // CustomerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.dgvModC);
            this.Controls.Add(this.btSaveE);
            this.Controls.Add(this.rbNoE);
            this.Controls.Add(this.rbYesE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCityE);
            this.Controls.Add(this.tbZipE);
            this.Controls.Add(this.tbAddressE);
            this.Controls.Add(this.tbPhoneE);
            this.Controls.Add(this.tbNameE);
            this.Controls.Add(this.btCustomerEditCancel);
            this.Name = "CustomerEdit";
            this.Text = "Modify Customer";
            this.Load += new System.EventHandler(this.CustomerEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCustomerEditCancel;
        private System.Windows.Forms.Button btSaveE;
        private System.Windows.Forms.RadioButton rbNoE;
        private System.Windows.Forms.RadioButton rbYesE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCityE;
        private System.Windows.Forms.TextBox tbZipE;
        private System.Windows.Forms.TextBox tbAddressE;
        private System.Windows.Forms.TextBox tbPhoneE;
        private System.Windows.Forms.TextBox tbNameE;
        private System.Windows.Forms.DataGridView dgvModC;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.ComboBox cbCountry;
    }
}