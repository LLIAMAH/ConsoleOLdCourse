namespace DataBindingExperiments
{
    partial class FMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbSurname = new TextBox();
            label3 = new Label();
            dtpBirthDate = new DateTimePicker();
            bnAdd = new Button();
            bnStore = new Button();
            lbPersons = new ListBox();
            bnDelete = new Button();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(123, 36);
            tbName.Name = "tbName";
            tbName.Size = new Size(199, 31);
            tbName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 3;
            label2.Text = "Surname:";
            // 
            // tbSurname
            // 
            tbSurname.Location = new Point(123, 73);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(199, 31);
            tbSurname.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 5;
            label3.Text = "Birth date:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(123, 113);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(199, 31);
            dtpBirthDate.TabIndex = 6;
            // 
            // bnAdd
            // 
            bnAdd.Location = new Point(328, 12);
            bnAdd.Name = "bnAdd";
            bnAdd.Size = new Size(148, 41);
            bnAdd.TabIndex = 7;
            bnAdd.Text = "Add new Item";
            bnAdd.UseVisualStyleBackColor = true;
            bnAdd.Click += bnAdd_Click;
            // 
            // bnStore
            // 
            bnStore.Location = new Point(328, 63);
            bnStore.Name = "bnStore";
            bnStore.Size = new Size(148, 41);
            bnStore.TabIndex = 8;
            bnStore.Text = "Store";
            bnStore.UseVisualStyleBackColor = true;
            bnStore.Click += bnStore_Click;
            // 
            // lbPersons
            // 
            lbPersons.FormattingEnabled = true;
            lbPersons.ItemHeight = 25;
            lbPersons.Location = new Point(12, 175);
            lbPersons.Name = "lbPersons";
            lbPersons.Size = new Size(478, 404);
            lbPersons.TabIndex = 9;
            lbPersons.DoubleClick += lbPersons_DoubleClick;
            // 
            // bnDelete
            // 
            bnDelete.Location = new Point(328, 113);
            bnDelete.Name = "bnDelete";
            bnDelete.Size = new Size(148, 41);
            bnDelete.TabIndex = 10;
            bnDelete.Text = "Delete";
            bnDelete.UseVisualStyleBackColor = true;
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 588);
            Controls.Add(bnDelete);
            Controls.Add(lbPersons);
            Controls.Add(bnStore);
            Controls.Add(bnAdd);
            Controls.Add(dtpBirthDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbSurname);
            Controls.Add(label1);
            Controls.Add(tbName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Persons list";
            Load += FMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private Label label1;
        private Label label2;
        private TextBox tbSurname;
        private Label label3;
        private DateTimePicker dtpBirthDate;
        private Button bnAdd;
        private Button bnStore;
        private ListBox lbPersons;
        private Button bnDelete;
    }
}