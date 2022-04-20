namespace WindowsFormsApp1
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.postcode = new System.Windows.Forms.TextBox();
            this.addCity = new System.Windows.Forms.MaskedTextBox();
            this.addStreet = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MembershipType = new System.Windows.Forms.GroupBox();
            this.Premium = new System.Windows.Forms.RadioButton();
            this.Regular = new System.Windows.Forms.RadioButton();
            this.Basic = new System.Windows.Forms.RadioButton();
            this.payFreq = new System.Windows.Forms.GroupBox();
            this.annually = new System.Windows.Forms.RadioButton();
            this.monthly = new System.Windows.Forms.RadioButton();
            this.fortnightly = new System.Windows.Forms.RadioButton();
            this.weekly = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PersonalDetails = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bday = new System.Windows.Forms.DateTimePicker();
            this.region = new System.Windows.Forms.ComboBox();
            this.emRel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.emNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.emCon = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.orderdeets = new System.Windows.Forms.GroupBox();
            this.display1 = new System.Windows.Forms.RichTextBox();
            this.payMethod = new System.Windows.Forms.GroupBox();
            this.Cash = new System.Windows.Forms.RadioButton();
            this.BT = new System.Windows.Forms.RadioButton();
            this.CC = new System.Windows.Forms.RadioButton();
            this.DD = new System.Windows.Forms.RadioButton();
            this.Duration = new System.Windows.Forms.GroupBox();
            this.twoyear = new System.Windows.Forms.RadioButton();
            this.oneyear = new System.Windows.Forms.RadioButton();
            this.half = new System.Windows.Forms.RadioButton();
            this.quarter = new System.Windows.Forms.RadioButton();
            this.extras = new System.Windows.Forms.GroupBox();
            this.PT = new System.Windows.Forms.CheckBox();
            this.alltime = new System.Windows.Forms.CheckBox();
            this.Diet = new System.Windows.Forms.CheckBox();
            this.vids = new System.Windows.Forms.CheckBox();
            this.cancel = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.form_clear = new System.Windows.Forms.Button();
            this.MembershipType.SuspendLayout();
            this.payFreq.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.PersonalDetails.SuspendLayout();
            this.orderdeets.SuspendLayout();
            this.payMethod.SuspendLayout();
            this.Duration.SuspendLayout();
            this.extras.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // addNum
            // 
            this.addNum.Location = new System.Drawing.Point(70, 91);
            this.addNum.Margin = new System.Windows.Forms.Padding(2);
            this.addNum.Name = "addNum";
            this.addNum.Size = new System.Drawing.Size(47, 20);
            this.addNum.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Unit/House:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Street:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Town:";
            // 
            // postcode
            // 
            this.postcode.Location = new System.Drawing.Point(69, 194);
            this.postcode.Margin = new System.Windows.Forms.Padding(2);
            this.postcode.Name = "postcode";
            this.postcode.Size = new System.Drawing.Size(76, 20);
            this.postcode.TabIndex = 7;
            // 
            // addCity
            // 
            this.addCity.Location = new System.Drawing.Point(69, 142);
            this.addCity.Margin = new System.Windows.Forms.Padding(2);
            this.addCity.Name = "addCity";
            this.addCity.Size = new System.Drawing.Size(161, 20);
            this.addCity.TabIndex = 5;
            // 
            // addStreet
            // 
            this.addStreet.Location = new System.Drawing.Point(70, 118);
            this.addStreet.Margin = new System.Windows.Forms.Padding(2);
            this.addStreet.Name = "addStreet";
            this.addStreet.Size = new System.Drawing.Size(160, 20);
            this.addStreet.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Post Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Region:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Phone:";
            // 
            // MembershipType
            // 
            this.MembershipType.Controls.Add(this.Premium);
            this.MembershipType.Controls.Add(this.Regular);
            this.MembershipType.Controls.Add(this.Basic);
            this.MembershipType.Location = new System.Drawing.Point(5, 226);
            this.MembershipType.Margin = new System.Windows.Forms.Padding(2);
            this.MembershipType.Name = "MembershipType";
            this.MembershipType.Padding = new System.Windows.Forms.Padding(2);
            this.MembershipType.Size = new System.Drawing.Size(221, 110);
            this.MembershipType.TabIndex = 12;
            this.MembershipType.TabStop = false;
            this.MembershipType.Text = "Membership Type:";
            // 
            // Premium
            // 
            this.Premium.AutoSize = true;
            this.Premium.Location = new System.Drawing.Point(5, 63);
            this.Premium.Margin = new System.Windows.Forms.Padding(2);
            this.Premium.Name = "Premium";
            this.Premium.Size = new System.Drawing.Size(123, 17);
            this.Premium.TabIndex = 2;
            this.Premium.TabStop = true;
            this.Premium.Text = "Premium ($20/week)";
            this.Premium.UseVisualStyleBackColor = true;
            // 
            // Regular
            // 
            this.Regular.AutoSize = true;
            this.Regular.Location = new System.Drawing.Point(5, 40);
            this.Regular.Margin = new System.Windows.Forms.Padding(2);
            this.Regular.Name = "Regular";
            this.Regular.Size = new System.Drawing.Size(120, 17);
            this.Regular.TabIndex = 1;
            this.Regular.TabStop = true;
            this.Regular.Text = "Regular ($15/week)";
            this.Regular.UseVisualStyleBackColor = true;
            // 
            // Basic
            // 
            this.Basic.AutoSize = true;
            this.Basic.Location = new System.Drawing.Point(5, 18);
            this.Basic.Margin = new System.Windows.Forms.Padding(2);
            this.Basic.Name = "Basic";
            this.Basic.Size = new System.Drawing.Size(109, 17);
            this.Basic.TabIndex = 0;
            this.Basic.TabStop = true;
            this.Basic.Text = "Basic ($10/week)";
            this.Basic.UseVisualStyleBackColor = true;
            // 
            // payFreq
            // 
            this.payFreq.Controls.Add(this.annually);
            this.payFreq.Controls.Add(this.monthly);
            this.payFreq.Controls.Add(this.fortnightly);
            this.payFreq.Controls.Add(this.weekly);
            this.payFreq.Location = new System.Drawing.Point(364, 226);
            this.payFreq.Margin = new System.Windows.Forms.Padding(2);
            this.payFreq.Name = "payFreq";
            this.payFreq.Padding = new System.Windows.Forms.Padding(2);
            this.payFreq.Size = new System.Drawing.Size(110, 110);
            this.payFreq.TabIndex = 14;
            this.payFreq.TabStop = false;
            this.payFreq.Text = "Payment:";
            // 
            // annually
            // 
            this.annually.AutoSize = true;
            this.annually.Location = new System.Drawing.Point(5, 86);
            this.annually.Margin = new System.Windows.Forms.Padding(2);
            this.annually.Name = "annually";
            this.annually.Size = new System.Drawing.Size(58, 17);
            this.annually.TabIndex = 3;
            this.annually.TabStop = true;
            this.annually.Text = "Annual";
            this.annually.UseVisualStyleBackColor = true;
            // 
            // monthly
            // 
            this.monthly.AutoSize = true;
            this.monthly.Location = new System.Drawing.Point(5, 63);
            this.monthly.Margin = new System.Windows.Forms.Padding(2);
            this.monthly.Name = "monthly";
            this.monthly.Size = new System.Drawing.Size(62, 17);
            this.monthly.TabIndex = 2;
            this.monthly.TabStop = true;
            this.monthly.Text = "Monthly";
            this.monthly.UseVisualStyleBackColor = true;
            // 
            // fortnightly
            // 
            this.fortnightly.AutoSize = true;
            this.fortnightly.Location = new System.Drawing.Point(5, 39);
            this.fortnightly.Margin = new System.Windows.Forms.Padding(2);
            this.fortnightly.Name = "fortnightly";
            this.fortnightly.Size = new System.Drawing.Size(73, 17);
            this.fortnightly.TabIndex = 1;
            this.fortnightly.TabStop = true;
            this.fortnightly.Text = "Fortnightly";
            this.fortnightly.UseVisualStyleBackColor = true;
            // 
            // weekly
            // 
            this.weekly.AutoSize = true;
            this.weekly.Location = new System.Drawing.Point(5, 18);
            this.weekly.Margin = new System.Windows.Forms.Padding(2);
            this.weekly.Name = "weekly";
            this.weekly.Size = new System.Drawing.Size(61, 17);
            this.weekly.TabIndex = 0;
            this.weekly.TabStop = true;
            this.weekly.Text = "Weekly";
            this.weekly.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PersonalDetails);
            this.groupBox4.Controls.Add(this.orderdeets);
            this.groupBox4.Controls.Add(this.payMethod);
            this.groupBox4.Controls.Add(this.Duration);
            this.groupBox4.Controls.Add(this.payFreq);
            this.groupBox4.Controls.Add(this.MembershipType);
            this.groupBox4.Controls.Add(this.extras);
            this.groupBox4.Location = new System.Drawing.Point(20, 105);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(697, 409);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // PersonalDetails
            // 
            this.PersonalDetails.Controls.Add(this.label12);
            this.PersonalDetails.Controls.Add(this.bday);
            this.PersonalDetails.Controls.Add(this.region);
            this.PersonalDetails.Controls.Add(this.emRel);
            this.PersonalDetails.Controls.Add(this.label1);
            this.PersonalDetails.Controls.Add(this.label11);
            this.PersonalDetails.Controls.Add(this.fname);
            this.PersonalDetails.Controls.Add(this.emNum);
            this.PersonalDetails.Controls.Add(this.postcode);
            this.PersonalDetails.Controls.Add(this.label10);
            this.PersonalDetails.Controls.Add(this.label2);
            this.PersonalDetails.Controls.Add(this.emCon);
            this.PersonalDetails.Controls.Add(this.lname);
            this.PersonalDetails.Controls.Add(this.label9);
            this.PersonalDetails.Controls.Add(this.label3);
            this.PersonalDetails.Controls.Add(this.label8);
            this.PersonalDetails.Controls.Add(this.phone);
            this.PersonalDetails.Controls.Add(this.label5);
            this.PersonalDetails.Controls.Add(this.addNum);
            this.PersonalDetails.Controls.Add(this.label6);
            this.PersonalDetails.Controls.Add(this.addStreet);
            this.PersonalDetails.Controls.Add(this.label7);
            this.PersonalDetails.Controls.Add(this.label4);
            this.PersonalDetails.Controls.Add(this.addCity);
            this.PersonalDetails.Location = new System.Drawing.Point(5, 0);
            this.PersonalDetails.Name = "PersonalDetails";
            this.PersonalDetails.Size = new System.Drawing.Size(469, 221);
            this.PersonalDetails.TabIndex = 27;
            this.PersonalDetails.TabStop = false;
            this.PersonalDetails.Text = "Personal Details:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(212, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Birthday:";
            // 
            // bday
            // 
            this.bday.Location = new System.Drawing.Point(263, 194);
            this.bday.Name = "bday";
            this.bday.Size = new System.Drawing.Size(200, 20);
            this.bday.TabIndex = 8;
            // 
            // region
            // 
            this.region.AutoCompleteCustomSource.AddRange(new string[] {
            "Northland",
            "Auckland",
            "Waikato",
            "Bay of Plenty",
            "Gisborne",
            "Hawke\'s Bay",
            "Taranaki",
            "Manwatu-Whanganui",
            "Wellington",
            "Tasman",
            "Nelson",
            "Marlborough",
            "West Coast",
            "Canterbury",
            "Otago",
            "Southland"});
            this.region.FormattingEnabled = true;
            this.region.Items.AddRange(new object[] {
            "Northland",
            "Auckland",
            "Waikato",
            "Bay of Plenty",
            "Gisborne",
            "Hawke\'s Bay",
            "Taranaki",
            "Manawatu-Whanganui",
            "Wellington",
            "Tasman",
            "Nelson",
            "Marlborough",
            "West Coast",
            "Canterbury",
            "Otago",
            "Southland"});
            this.region.Location = new System.Drawing.Point(70, 169);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(121, 21);
            this.region.TabIndex = 6;
            this.region.Text = "Select...";
            // 
            // emRel
            // 
            this.emRel.Location = new System.Drawing.Point(319, 60);
            this.emRel.Margin = new System.Windows.Forms.Padding(2);
            this.emRel.Name = "emRel";
            this.emRel.Size = new System.Drawing.Size(145, 20);
            this.emRel.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(247, 63);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Relationship:";
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(70, 16);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(137, 20);
            this.fname.TabIndex = 0;
            // 
            // emNum
            // 
            this.emNum.Location = new System.Drawing.Point(319, 38);
            this.emNum.Margin = new System.Windows.Forms.Padding(2);
            this.emNum.Name = "emNum";
            this.emNum.Size = new System.Drawing.Size(145, 20);
            this.emNum.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(218, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Emergency Phone:";
            // 
            // emCon
            // 
            this.emCon.Location = new System.Drawing.Point(319, 16);
            this.emCon.Margin = new System.Windows.Forms.Padding(2);
            this.emCon.Name = "emCon";
            this.emCon.Size = new System.Drawing.Size(145, 20);
            this.emCon.TabIndex = 9;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(70, 42);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(137, 20);
            this.lname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Emergency Contact:";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(69, 67);
            this.phone.Margin = new System.Windows.Forms.Padding(2);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(152, 20);
            this.phone.TabIndex = 2;
            // 
            // orderdeets
            // 
            this.orderdeets.Controls.Add(this.display1);
            this.orderdeets.Location = new System.Drawing.Point(479, 0);
            this.orderdeets.Margin = new System.Windows.Forms.Padding(2);
            this.orderdeets.Name = "orderdeets";
            this.orderdeets.Padding = new System.Windows.Forms.Padding(2);
            this.orderdeets.Size = new System.Drawing.Size(211, 399);
            this.orderdeets.TabIndex = 26;
            this.orderdeets.TabStop = false;
            this.orderdeets.Text = "Order Details";
            // 
            // display1
            // 
            this.display1.Location = new System.Drawing.Point(5, 18);
            this.display1.Name = "display1";
            this.display1.Size = new System.Drawing.Size(201, 376);
            this.display1.TabIndex = 0;
            this.display1.TabStop = false;
            this.display1.Text = "";
            // 
            // payMethod
            // 
            this.payMethod.Controls.Add(this.Cash);
            this.payMethod.Controls.Add(this.BT);
            this.payMethod.Controls.Add(this.CC);
            this.payMethod.Controls.Add(this.DD);
            this.payMethod.Location = new System.Drawing.Point(231, 340);
            this.payMethod.Margin = new System.Windows.Forms.Padding(2);
            this.payMethod.Name = "payMethod";
            this.payMethod.Padding = new System.Windows.Forms.Padding(2);
            this.payMethod.Size = new System.Drawing.Size(244, 59);
            this.payMethod.TabIndex = 16;
            this.payMethod.TabStop = false;
            this.payMethod.Text = "Payment Method";
            // 
            // Cash
            // 
            this.Cash.AutoSize = true;
            this.Cash.Location = new System.Drawing.Point(100, 39);
            this.Cash.Margin = new System.Windows.Forms.Padding(2);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(49, 17);
            this.Cash.TabIndex = 3;
            this.Cash.TabStop = true;
            this.Cash.Text = "Cash";
            this.Cash.UseVisualStyleBackColor = true;
            // 
            // BT
            // 
            this.BT.AutoSize = true;
            this.BT.Location = new System.Drawing.Point(100, 17);
            this.BT.Margin = new System.Windows.Forms.Padding(2);
            this.BT.Name = "BT";
            this.BT.Size = new System.Drawing.Size(92, 17);
            this.BT.TabIndex = 1;
            this.BT.TabStop = true;
            this.BT.Text = "Bank Transfer";
            this.BT.UseVisualStyleBackColor = true;
            // 
            // CC
            // 
            this.CC.AutoSize = true;
            this.CC.Location = new System.Drawing.Point(0, 38);
            this.CC.Margin = new System.Windows.Forms.Padding(2);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(77, 17);
            this.CC.TabIndex = 2;
            this.CC.TabStop = true;
            this.CC.Text = "Credit Card";
            this.CC.UseVisualStyleBackColor = true;
            // 
            // DD
            // 
            this.DD.AutoSize = true;
            this.DD.Location = new System.Drawing.Point(0, 16);
            this.DD.Margin = new System.Windows.Forms.Padding(2);
            this.DD.Name = "DD";
            this.DD.Size = new System.Drawing.Size(81, 17);
            this.DD.TabIndex = 0;
            this.DD.TabStop = true;
            this.DD.Text = "Direct Debit";
            this.DD.UseVisualStyleBackColor = true;
            // 
            // Duration
            // 
            this.Duration.Controls.Add(this.twoyear);
            this.Duration.Controls.Add(this.oneyear);
            this.Duration.Controls.Add(this.half);
            this.Duration.Controls.Add(this.quarter);
            this.Duration.Location = new System.Drawing.Point(231, 226);
            this.Duration.Margin = new System.Windows.Forms.Padding(2);
            this.Duration.Name = "Duration";
            this.Duration.Padding = new System.Windows.Forms.Padding(2);
            this.Duration.Size = new System.Drawing.Size(112, 110);
            this.Duration.TabIndex = 13;
            this.Duration.TabStop = false;
            this.Duration.Text = "Duration:";
            // 
            // twoyear
            // 
            this.twoyear.AutoSize = true;
            this.twoyear.Location = new System.Drawing.Point(5, 86);
            this.twoyear.Margin = new System.Windows.Forms.Padding(2);
            this.twoyear.Name = "twoyear";
            this.twoyear.Size = new System.Drawing.Size(75, 17);
            this.twoyear.TabIndex = 3;
            this.twoyear.TabStop = true;
            this.twoyear.Text = "24 Months";
            this.twoyear.UseVisualStyleBackColor = true;
            // 
            // oneyear
            // 
            this.oneyear.AutoSize = true;
            this.oneyear.Location = new System.Drawing.Point(5, 63);
            this.oneyear.Margin = new System.Windows.Forms.Padding(2);
            this.oneyear.Name = "oneyear";
            this.oneyear.Size = new System.Drawing.Size(75, 17);
            this.oneyear.TabIndex = 2;
            this.oneyear.TabStop = true;
            this.oneyear.Text = "12 Months";
            this.oneyear.UseVisualStyleBackColor = true;
            // 
            // half
            // 
            this.half.AutoSize = true;
            this.half.Location = new System.Drawing.Point(5, 39);
            this.half.Margin = new System.Windows.Forms.Padding(2);
            this.half.Name = "half";
            this.half.Size = new System.Drawing.Size(69, 17);
            this.half.TabIndex = 1;
            this.half.TabStop = true;
            this.half.Text = "6 Months";
            this.half.UseVisualStyleBackColor = true;
            // 
            // quarter
            // 
            this.quarter.AutoSize = true;
            this.quarter.Location = new System.Drawing.Point(5, 18);
            this.quarter.Margin = new System.Windows.Forms.Padding(2);
            this.quarter.Name = "quarter";
            this.quarter.Size = new System.Drawing.Size(69, 17);
            this.quarter.TabIndex = 0;
            this.quarter.TabStop = true;
            this.quarter.Text = "3 Months";
            this.quarter.UseVisualStyleBackColor = true;
            // 
            // extras
            // 
            this.extras.Controls.Add(this.PT);
            this.extras.Controls.Add(this.alltime);
            this.extras.Controls.Add(this.Diet);
            this.extras.Controls.Add(this.vids);
            this.extras.Location = new System.Drawing.Point(5, 340);
            this.extras.Margin = new System.Windows.Forms.Padding(2);
            this.extras.Name = "extras";
            this.extras.Padding = new System.Windows.Forms.Padding(2);
            this.extras.Size = new System.Drawing.Size(223, 59);
            this.extras.TabIndex = 15;
            this.extras.TabStop = false;
            this.extras.Text = "Optional Extras";
            // 
            // PT
            // 
            this.PT.AutoSize = true;
            this.PT.Location = new System.Drawing.Point(115, 17);
            this.PT.Margin = new System.Windows.Forms.Padding(2);
            this.PT.Name = "PT";
            this.PT.Size = new System.Drawing.Size(103, 17);
            this.PT.TabIndex = 1;
            this.PT.Text = "Personal Trainer";
            this.PT.UseVisualStyleBackColor = true;
            // 
            // alltime
            // 
            this.alltime.AutoSize = true;
            this.alltime.Location = new System.Drawing.Point(5, 17);
            this.alltime.Margin = new System.Windows.Forms.Padding(2);
            this.alltime.Name = "alltime";
            this.alltime.Size = new System.Drawing.Size(87, 17);
            this.alltime.TabIndex = 0;
            this.alltime.Text = "24/7 Access";
            this.alltime.UseVisualStyleBackColor = true;
            // 
            // Diet
            // 
            this.Diet.AutoSize = true;
            this.Diet.Location = new System.Drawing.Point(5, 38);
            this.Diet.Margin = new System.Windows.Forms.Padding(2);
            this.Diet.Name = "Diet";
            this.Diet.Size = new System.Drawing.Size(106, 17);
            this.Diet.TabIndex = 2;
            this.Diet.Text = "Diet Consultation";
            this.Diet.UseVisualStyleBackColor = true;
            // 
            // vids
            // 
            this.vids.AutoSize = true;
            this.vids.Location = new System.Drawing.Point(115, 38);
            this.vids.Margin = new System.Windows.Forms.Padding(2);
            this.vids.Name = "vids";
            this.vids.Size = new System.Drawing.Size(99, 17);
            this.vids.TabIndex = 3;
            this.vids.Text = "Online Tutorials";
            this.vids.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Tomato;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(20, 519);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(122, 37);
            this.cancel.TabIndex = 20;
            this.cancel.TabStop = false;
            this.cancel.Text = "Exit";
            this.cancel.UseVisualStyleBackColor = false;
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.LimeGreen;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(536, 520);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(181, 37);
            this.confirm.TabIndex = 18;
            this.confirm.TabStop = false;
            this.confirm.Text = "Sign Up";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(384, 520);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(139, 37);
            this.calculate.TabIndex = 17;
            this.calculate.TabStop = false;
            this.calculate.Text = "Confirm Order";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // form_clear
            // 
            this.form_clear.Location = new System.Drawing.Point(148, 520);
            this.form_clear.Name = "form_clear";
            this.form_clear.Size = new System.Drawing.Size(150, 36);
            this.form_clear.TabIndex = 19;
            this.form_clear.TabStop = false;
            this.form_clear.Text = "Clear/New Registration";
            this.form_clear.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 568);
            this.Controls.Add(this.form_clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrationForm";
            this.Text = "City Gym Registration";
            this.MembershipType.ResumeLayout(false);
            this.MembershipType.PerformLayout();
            this.payFreq.ResumeLayout(false);
            this.payFreq.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.PersonalDetails.ResumeLayout(false);
            this.PersonalDetails.PerformLayout();
            this.orderdeets.ResumeLayout(false);
            this.payMethod.ResumeLayout(false);
            this.payMethod.PerformLayout();
            this.Duration.ResumeLayout(false);
            this.Duration.PerformLayout();
            this.extras.ResumeLayout(false);
            this.extras.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox MembershipType;
        private System.Windows.Forms.GroupBox payFreq;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox extras;
        private System.Windows.Forms.CheckBox vids;
        private System.Windows.Forms.CheckBox Diet;
        private System.Windows.Forms.CheckBox PT;
        private System.Windows.Forms.CheckBox alltime;
        private System.Windows.Forms.RadioButton Premium;
        private System.Windows.Forms.RadioButton Regular;
        private System.Windows.Forms.RadioButton Basic;
        private System.Windows.Forms.RadioButton monthly;
        private System.Windows.Forms.RadioButton fortnightly;
        private System.Windows.Forms.RadioButton weekly;
        private System.Windows.Forms.RadioButton annually;
        private System.Windows.Forms.DateTimePicker bday;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.GroupBox Duration;
        private System.Windows.Forms.RadioButton twoyear;
        private System.Windows.Forms.RadioButton oneyear;
        private System.Windows.Forms.RadioButton half;
        private System.Windows.Forms.RadioButton quarter;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox postcode;
        private System.Windows.Forms.MaskedTextBox addCity;
        private System.Windows.Forms.MaskedTextBox addStreet;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox emRel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox emNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox emCon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox payMethod;
        private System.Windows.Forms.GroupBox orderdeets;
        private System.Windows.Forms.RadioButton Cash;
        private System.Windows.Forms.RadioButton BT;
        private System.Windows.Forms.RadioButton CC;
        private System.Windows.Forms.RadioButton DD;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.RichTextBox display1;
        private System.Windows.Forms.Button form_clear;
        private System.Windows.Forms.GroupBox PersonalDetails;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox region;
    }
}

