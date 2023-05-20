namespace DatabaseExperimentsNET
{
    partial class FMain
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
            this.bnLoadData = new System.Windows.Forms.Button();
            this.courseDBDataSet = new DatabaseExperimentsNET.CourseDBDataSet();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHouseNr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbApartmentsNr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.countryCitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bnAdd = new System.Windows.Forms.Button();
            this.bnClear = new System.Windows.Forms.Button();
            this.countriesTableAdapter = new DatabaseExperimentsNET.CourseDBDataSetTableAdapters.CountriesTableAdapter();
            this.countryCitiesTableAdapter = new DatabaseExperimentsNET.CourseDBDataSetTableAdapters.CountryCitiesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.courseDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryCitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bnLoadData
            // 
            this.bnLoadData.Location = new System.Drawing.Point(12, 12);
            this.bnLoadData.Name = "bnLoadData";
            this.bnLoadData.Size = new System.Drawing.Size(228, 100);
            this.bnLoadData.TabIndex = 0;
            this.bnLoadData.Text = "Load Data";
            this.bnLoadData.UseVisualStyleBackColor = true;
            this.bnLoadData.Click += new System.EventHandler(this.bnLoadData_Click);
            // 
            // courseDBDataSet
            // 
            this.courseDBDataSet.DataSetName = "CourseDBDataSet";
            this.courseDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvOutput
            // 
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Location = new System.Drawing.Point(12, 118);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.RowHeadersWidth = 62;
            this.dgvOutput.RowTemplate.Height = 28;
            this.dgvOutput.Size = new System.Drawing.Size(1558, 419);
            this.dgvOutput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(156, 579);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(290, 26);
            this.tbLogin.TabIndex = 3;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(156, 611);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(290, 26);
            this.tbFirstName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 614);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "First name";
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Location = new System.Drawing.Point(156, 643);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(290, 26);
            this.tbMiddleName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 646);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Middle name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(156, 675);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(290, 26);
            this.tbLastName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 678);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Last name";
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(156, 807);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(290, 26);
            this.tbStreet.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 810);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Street";
            // 
            // tbHouseNr
            // 
            this.tbHouseNr.Location = new System.Drawing.Point(156, 839);
            this.tbHouseNr.Name = "tbHouseNr";
            this.tbHouseNr.Size = new System.Drawing.Size(290, 26);
            this.tbHouseNr.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 842);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "House #";
            // 
            // tbApartmentsNr
            // 
            this.tbApartmentsNr.Location = new System.Drawing.Point(156, 871);
            this.tbApartmentsNr.Name = "tbApartmentsNr";
            this.tbApartmentsNr.Size = new System.Drawing.Size(290, 26);
            this.tbApartmentsNr.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 874);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Apartments #";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(156, 707);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(290, 26);
            this.dtpBirthDate.TabIndex = 16;
            // 
            // cbCountry
            // 
            this.cbCountry.DataSource = this.countriesBindingSource;
            this.cbCountry.DisplayMember = "Name";
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(156, 739);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(290, 28);
            this.cbCountry.TabIndex = 17;
            this.cbCountry.ValueMember = "Id";
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.courseDBDataSet;
            // 
            // cbCity
            // 
            this.cbCity.DataSource = this.countryCitiesBindingSource;
            this.cbCity.DisplayMember = "Name";
            this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(156, 773);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(290, 28);
            this.cbCity.TabIndex = 18;
            this.cbCity.ValueMember = "Id";
            // 
            // countryCitiesBindingSource
            // 
            this.countryCitiesBindingSource.DataMember = "CountryCities";
            this.countryCitiesBindingSource.DataSource = this.courseDBDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 712);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Birth date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 742);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Country";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 776);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "City";
            // 
            // bnAdd
            // 
            this.bnAdd.Location = new System.Drawing.Point(178, 903);
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(131, 40);
            this.bnAdd.TabIndex = 22;
            this.bnAdd.Text = "Add";
            this.bnAdd.UseVisualStyleBackColor = true;
            this.bnAdd.Click += new System.EventHandler(this.bnAdd_Click);
            // 
            // bnClear
            // 
            this.bnClear.Location = new System.Drawing.Point(315, 903);
            this.bnClear.Name = "bnClear";
            this.bnClear.Size = new System.Drawing.Size(131, 40);
            this.bnClear.TabIndex = 23;
            this.bnClear.Text = "Clear";
            this.bnClear.UseVisualStyleBackColor = true;
            this.bnClear.Click += new System.EventHandler(this.bnClear_Click);
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // countryCitiesTableAdapter
            // 
            this.countryCitiesTableAdapter.ClearBeforeFill = true;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 966);
            this.Controls.Add(this.bnClear);
            this.Controls.Add(this.bnAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.tbApartmentsNr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbHouseNr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMiddleName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOutput);
            this.Controls.Add(this.bnLoadData);
            this.Name = "FMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryCitiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnLoadData;
        private CourseDBDataSet courseDBDataSet;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHouseNr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbApartmentsNr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bnAdd;
        private System.Windows.Forms.Button bnClear;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private CourseDBDataSetTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.BindingSource countryCitiesBindingSource;
        private CourseDBDataSetTableAdapters.CountryCitiesTableAdapter countryCitiesTableAdapter;
    }
}

