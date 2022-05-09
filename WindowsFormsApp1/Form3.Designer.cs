namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerDBDataSet = new WindowsFormsApp1.CustomerDBDataSet();
            this.membershipsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membershipIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencyContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencyPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencyRelationshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentFrequencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weeklyPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weeklyAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalTrainerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoTrainerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dieticianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipExpiryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClearSearch = new System.Windows.Forms.Button();
            this.SearchCust = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.membershipIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.districtDataGridViewTextBoxColumn,
            this.postCodeDataGridViewTextBoxColumn,
            this.emergencyContactDataGridViewTextBoxColumn,
            this.emergencyPhoneDataGridViewTextBoxColumn,
            this.emergencyRelationshipDataGridViewTextBoxColumn,
            this.membershipTypeDataGridViewTextBoxColumn,
            this.membershipDurationDataGridViewTextBoxColumn,
            this.paymentFrequencyDataGridViewTextBoxColumn,
            this.paymentMethodDataGridViewTextBoxColumn,
            this.weeklyPriceDataGridViewTextBoxColumn,
            this.weeklyAmountDataGridViewTextBoxColumn,
            this.paymentAmountDataGridViewTextBoxColumn,
            this.personalTrainerDataGridViewTextBoxColumn,
            this.videoTrainerDataGridViewTextBoxColumn,
            this.dieticianDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.membershipExpiryDataGridViewTextBoxColumn,
            this.membershipStartDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.membershipsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1229, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // customerDBDataSet
            // 
            this.customerDBDataSet.DataSetName = "CustomerDBDataSet";
            this.customerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membershipsBindingSource
            // 
            this.membershipsBindingSource.DataMember = "memberships";
            this.membershipsBindingSource.DataSource = this.customerDBDataSet;
            // 
            // membershipIDDataGridViewTextBoxColumn
            // 
            this.membershipIDDataGridViewTextBoxColumn.DataPropertyName = "Membership ID";
            this.membershipIDDataGridViewTextBoxColumn.HeaderText = "Membership ID";
            this.membershipIDDataGridViewTextBoxColumn.Name = "membershipIDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // districtDataGridViewTextBoxColumn
            // 
            this.districtDataGridViewTextBoxColumn.DataPropertyName = "District";
            this.districtDataGridViewTextBoxColumn.HeaderText = "District";
            this.districtDataGridViewTextBoxColumn.Name = "districtDataGridViewTextBoxColumn";
            // 
            // postCodeDataGridViewTextBoxColumn
            // 
            this.postCodeDataGridViewTextBoxColumn.DataPropertyName = "Post Code";
            this.postCodeDataGridViewTextBoxColumn.HeaderText = "Post Code";
            this.postCodeDataGridViewTextBoxColumn.Name = "postCodeDataGridViewTextBoxColumn";
            // 
            // emergencyContactDataGridViewTextBoxColumn
            // 
            this.emergencyContactDataGridViewTextBoxColumn.DataPropertyName = "Emergency Contact";
            this.emergencyContactDataGridViewTextBoxColumn.HeaderText = "Emergency Contact";
            this.emergencyContactDataGridViewTextBoxColumn.Name = "emergencyContactDataGridViewTextBoxColumn";
            // 
            // emergencyPhoneDataGridViewTextBoxColumn
            // 
            this.emergencyPhoneDataGridViewTextBoxColumn.DataPropertyName = "Emergency Phone";
            this.emergencyPhoneDataGridViewTextBoxColumn.HeaderText = "Emergency Phone";
            this.emergencyPhoneDataGridViewTextBoxColumn.Name = "emergencyPhoneDataGridViewTextBoxColumn";
            // 
            // emergencyRelationshipDataGridViewTextBoxColumn
            // 
            this.emergencyRelationshipDataGridViewTextBoxColumn.DataPropertyName = "Emergency Relationship";
            this.emergencyRelationshipDataGridViewTextBoxColumn.HeaderText = "Emergency Relationship";
            this.emergencyRelationshipDataGridViewTextBoxColumn.Name = "emergencyRelationshipDataGridViewTextBoxColumn";
            // 
            // membershipTypeDataGridViewTextBoxColumn
            // 
            this.membershipTypeDataGridViewTextBoxColumn.DataPropertyName = "Membership Type";
            this.membershipTypeDataGridViewTextBoxColumn.HeaderText = "Membership Type";
            this.membershipTypeDataGridViewTextBoxColumn.Name = "membershipTypeDataGridViewTextBoxColumn";
            // 
            // membershipDurationDataGridViewTextBoxColumn
            // 
            this.membershipDurationDataGridViewTextBoxColumn.DataPropertyName = "Membership Duration";
            this.membershipDurationDataGridViewTextBoxColumn.HeaderText = "Membership Duration";
            this.membershipDurationDataGridViewTextBoxColumn.Name = "membershipDurationDataGridViewTextBoxColumn";
            // 
            // paymentFrequencyDataGridViewTextBoxColumn
            // 
            this.paymentFrequencyDataGridViewTextBoxColumn.DataPropertyName = "Payment Frequency";
            this.paymentFrequencyDataGridViewTextBoxColumn.HeaderText = "Payment Frequency";
            this.paymentFrequencyDataGridViewTextBoxColumn.Name = "paymentFrequencyDataGridViewTextBoxColumn";
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "Payment Method";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "Payment Method";
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            // 
            // weeklyPriceDataGridViewTextBoxColumn
            // 
            this.weeklyPriceDataGridViewTextBoxColumn.DataPropertyName = "Weekly Price";
            this.weeklyPriceDataGridViewTextBoxColumn.HeaderText = "Weekly Price";
            this.weeklyPriceDataGridViewTextBoxColumn.Name = "weeklyPriceDataGridViewTextBoxColumn";
            // 
            // weeklyAmountDataGridViewTextBoxColumn
            // 
            this.weeklyAmountDataGridViewTextBoxColumn.DataPropertyName = "Weekly Amount";
            this.weeklyAmountDataGridViewTextBoxColumn.HeaderText = "Weekly Amount";
            this.weeklyAmountDataGridViewTextBoxColumn.Name = "weeklyAmountDataGridViewTextBoxColumn";
            // 
            // paymentAmountDataGridViewTextBoxColumn
            // 
            this.paymentAmountDataGridViewTextBoxColumn.DataPropertyName = "Payment Amount";
            this.paymentAmountDataGridViewTextBoxColumn.HeaderText = "Payment Amount";
            this.paymentAmountDataGridViewTextBoxColumn.Name = "paymentAmountDataGridViewTextBoxColumn";
            // 
            // personalTrainerDataGridViewTextBoxColumn
            // 
            this.personalTrainerDataGridViewTextBoxColumn.DataPropertyName = "Personal Trainer";
            this.personalTrainerDataGridViewTextBoxColumn.HeaderText = "Personal Trainer";
            this.personalTrainerDataGridViewTextBoxColumn.Name = "personalTrainerDataGridViewTextBoxColumn";
            // 
            // videoTrainerDataGridViewTextBoxColumn
            // 
            this.videoTrainerDataGridViewTextBoxColumn.DataPropertyName = "Video Trainer";
            this.videoTrainerDataGridViewTextBoxColumn.HeaderText = "Video Trainer";
            this.videoTrainerDataGridViewTextBoxColumn.Name = "videoTrainerDataGridViewTextBoxColumn";
            // 
            // dieticianDataGridViewTextBoxColumn
            // 
            this.dieticianDataGridViewTextBoxColumn.DataPropertyName = "Dietician";
            this.dieticianDataGridViewTextBoxColumn.HeaderText = "Dietician";
            this.dieticianDataGridViewTextBoxColumn.Name = "dieticianDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "24/7";
            this.dataGridViewTextBoxColumn1.HeaderText = "24/7";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // membershipExpiryDataGridViewTextBoxColumn
            // 
            this.membershipExpiryDataGridViewTextBoxColumn.DataPropertyName = "Membership Expiry";
            this.membershipExpiryDataGridViewTextBoxColumn.HeaderText = "Membership Expiry";
            this.membershipExpiryDataGridViewTextBoxColumn.Name = "membershipExpiryDataGridViewTextBoxColumn";
            // 
            // membershipStartDataGridViewTextBoxColumn
            // 
            this.membershipStartDataGridViewTextBoxColumn.DataPropertyName = "Membership Start";
            this.membershipStartDataGridViewTextBoxColumn.HeaderText = "Membership Start";
            this.membershipStartDataGridViewTextBoxColumn.Name = "membershipStartDataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(264, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(264, 46);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(137, 20);
            this.textBox4.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchCust);
            this.groupBox1.Controls.Add(this.ClearSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(28, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 113);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Criteria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Street:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "City:";
            // 
            // ClearSearch
            // 
            this.ClearSearch.Location = new System.Drawing.Point(95, 85);
            this.ClearSearch.Name = "ClearSearch";
            this.ClearSearch.Size = new System.Drawing.Size(109, 22);
            this.ClearSearch.TabIndex = 9;
            this.ClearSearch.Text = "Clear";
            this.ClearSearch.UseVisualStyleBackColor = true;
            // 
            // SearchCust
            // 
            this.SearchCust.Location = new System.Drawing.Point(292, 85);
            this.SearchCust.Name = "SearchCust";
            this.SearchCust.Size = new System.Drawing.Size(109, 22);
            this.SearchCust.TabIndex = 10;
            this.SearchCust.Text = "Search";
            this.SearchCust.UseVisualStyleBackColor = true;
            this.SearchCust.Click += new System.EventHandler(this.SearchCust_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1301, 576);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencyRelationshipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentFrequencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weeklyPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weeklyAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalTrainerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoTrainerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dieticianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipExpiryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource membershipsBindingSource;
        private CustomerDBDataSet customerDBDataSet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SearchCust;
        private System.Windows.Forms.Button ClearSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}