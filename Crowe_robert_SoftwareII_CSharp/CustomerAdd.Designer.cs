namespace Crowe_robert_SoftwareII_CSharp
{
    partial class CustomerAdd
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
            this.btCustomerAddCancel = new System.Windows.Forms.Button();
            this.tbNameA = new System.Windows.Forms.TextBox();
            this.tbPhoneA = new System.Windows.Forms.TextBox();
            this.tbAddressA = new System.Windows.Forms.TextBox();
            this.tbZipA = new System.Windows.Forms.TextBox();
            this.tbCityA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbYesA = new System.Windows.Forms.RadioButton();
            this.rbNoA = new System.Windows.Forms.RadioButton();
            this.btSaveA = new System.Windows.Forms.Button();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btCustomerAddCancel
            // 
            this.btCustomerAddCancel.Location = new System.Drawing.Point(201, 344);
            this.btCustomerAddCancel.Name = "btCustomerAddCancel";
            this.btCustomerAddCancel.Size = new System.Drawing.Size(119, 41);
            this.btCustomerAddCancel.TabIndex = 10;
            this.btCustomerAddCancel.Text = "Cancel";
            this.btCustomerAddCancel.UseVisualStyleBackColor = true;
            this.btCustomerAddCancel.Click += new System.EventHandler(this.btCustomerAddCancel_Click);
            // 
            // tbNameA
            // 
            this.tbNameA.Location = new System.Drawing.Point(76, 12);
            this.tbNameA.Name = "tbNameA";
            this.tbNameA.Size = new System.Drawing.Size(192, 20);
            this.tbNameA.TabIndex = 1;
            this.tbNameA.Validating += new System.ComponentModel.CancelEventHandler(this.tbNameA_Validating);
            // 
            // tbPhoneA
            // 
            this.tbPhoneA.Location = new System.Drawing.Point(76, 38);
            this.tbPhoneA.Name = "tbPhoneA";
            this.tbPhoneA.Size = new System.Drawing.Size(192, 20);
            this.tbPhoneA.TabIndex = 2;
            this.tbPhoneA.WordWrap = false;
            this.tbPhoneA.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhoneA_Validating);
            // 
            // tbAddressA
            // 
            this.tbAddressA.Location = new System.Drawing.Point(76, 64);
            this.tbAddressA.Name = "tbAddressA";
            this.tbAddressA.Size = new System.Drawing.Size(192, 20);
            this.tbAddressA.TabIndex = 3;
            this.tbAddressA.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddressA_Validating);
            // 
            // tbZipA
            // 
            this.tbZipA.Location = new System.Drawing.Point(76, 116);
            this.tbZipA.Name = "tbZipA";
            this.tbZipA.Size = new System.Drawing.Size(192, 20);
            this.tbZipA.TabIndex = 5;
            this.tbZipA.WordWrap = false;
            this.tbZipA.Validating += new System.ComponentModel.CancelEventHandler(this.tbZipA_Validating);
            // 
            // tbCityA
            // 
            this.tbCityA.Location = new System.Drawing.Point(76, 90);
            this.tbCityA.Name = "tbCityA";
            this.tbCityA.Size = new System.Drawing.Size(192, 20);
            this.tbCityA.TabIndex = 4;
            this.tbCityA.Validating += new System.ComponentModel.CancelEventHandler(this.tbCityA_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Zip Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Active";
            // 
            // rbYesA
            // 
            this.rbYesA.AutoSize = true;
            this.rbYesA.Checked = true;
            this.rbYesA.Location = new System.Drawing.Point(76, 169);
            this.rbYesA.Name = "rbYesA";
            this.rbYesA.Size = new System.Drawing.Size(46, 17);
            this.rbYesA.TabIndex = 7;
            this.rbYesA.TabStop = true;
            this.rbYesA.Text = "YES";
            this.rbYesA.UseVisualStyleBackColor = true;
            this.rbYesA.CheckedChanged += new System.EventHandler(this.rbYesA_CheckedChanged);
            // 
            // rbNoA
            // 
            this.rbNoA.AutoSize = true;
            this.rbNoA.Location = new System.Drawing.Point(125, 169);
            this.rbNoA.Name = "rbNoA";
            this.rbNoA.Size = new System.Drawing.Size(41, 17);
            this.rbNoA.TabIndex = 8;
            this.rbNoA.TabStop = true;
            this.rbNoA.Text = "NO";
            this.rbNoA.UseVisualStyleBackColor = true;
            this.rbNoA.CheckedChanged += new System.EventHandler(this.rbNoA_CheckedChanged);
            // 
            // btSaveA
            // 
            this.btSaveA.Location = new System.Drawing.Point(76, 344);
            this.btSaveA.Name = "btSaveA";
            this.btSaveA.Size = new System.Drawing.Size(119, 41);
            this.btSaveA.TabIndex = 9;
            this.btSaveA.Text = "Save";
            this.btSaveA.UseVisualStyleBackColor = true;
            this.btSaveA.Click += new System.EventHandler(this.btSaveA_Click);
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
            this.cbCountry.TabIndex = 6;
            // 
            // CustomerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.btSaveA);
            this.Controls.Add(this.rbNoA);
            this.Controls.Add(this.rbYesA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCityA);
            this.Controls.Add(this.tbZipA);
            this.Controls.Add(this.tbAddressA);
            this.Controls.Add(this.tbPhoneA);
            this.Controls.Add(this.tbNameA);
            this.Controls.Add(this.btCustomerAddCancel);
            this.Name = "CustomerAdd";
            this.Text = "Create New Customer";
            this.Load += new System.EventHandler(this.CustomerAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCustomerAddCancel;
        private System.Windows.Forms.TextBox tbNameA;
        private System.Windows.Forms.TextBox tbPhoneA;
        private System.Windows.Forms.TextBox tbAddressA;
        private System.Windows.Forms.TextBox tbZipA;
        private System.Windows.Forms.TextBox tbCityA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbYesA;
        private System.Windows.Forms.RadioButton rbNoA;
        private System.Windows.Forms.Button btSaveA;
        private System.Windows.Forms.ComboBox cbCountry;
    }
}