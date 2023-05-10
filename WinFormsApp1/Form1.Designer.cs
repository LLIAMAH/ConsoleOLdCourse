namespace WinFormsApp1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            button5 = new Button();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            monthCalendar1 = new MonthCalendar();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            tb1 = new TextBox();
            tb2 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSplitButton1 = new ToolStripSplitButton();
            toolStripComboBox1 = new ToolStripComboBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            testToolStripMenuItem = new ToolStripMenuItem();
            tbPath = new TextBox();
            bnBrowse = new Button();
            lbOutput = new ListBox();
            fbdBrowse = new FolderBrowserDialog();
            browseFolder1 = new UserControls.BrowseFolder();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Top;
            textBox2.Location = new Point(0, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1979, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.BackColor = Color.Yellow;
            textBox3.ForeColor = Color.Red;
            textBox3.Location = new Point(650, 280);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(432, 35);
            textBox3.TabIndex = 2;
            textBox3.TextAlign = HorizontalAlignment.Right;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 91);
            label1.Name = "label1";
            label1.Size = new Size(287, 25);
            label1.TabIndex = 6;
            label1.Text = "Какой либо красивеньккий ТЕКСТ";
            label1.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.Yellow;
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(650, 184);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Horizontal;
            textBox1.Size = new Size(432, 35);
            textBox1.TabIndex = 8;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.BackColor = Color.Yellow;
            textBox4.ForeColor = Color.Red;
            textBox4.Location = new Point(650, 225);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(432, 35);
            textBox4.TabIndex = 9;
            textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // button5
            // 
            button5.Location = new Point(762, 321);
            button5.Name = "button5";
            button5.Size = new Size(119, 66);
            button5.TabIndex = 10;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(53, 748);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(264, 104);
            listBox1.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3", "Double item 1", "Double item 2" });
            comboBox1.Location = new Point(458, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(383, 33);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(479, 130);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 13;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Indeterminate;
            checkBox1.Location = new Point(76, 130);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(232, 29);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Голосуй или не голосуй";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(299, 539);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(252, 29);
            radioButton5.TabIndex = 19;
            radioButton5.TabStop = true;
            radioButton5.Text = "Может таки не все козлы?";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(299, 573);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(211, 29);
            radioButton6.TabIndex = 20;
            radioButton6.TabStop = true;
            radioButton6.Text = "Нет, точно все козлы";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(53, 421);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(204, 228);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Кандидаты ПИД\"\"\"";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(23, 152);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(132, 29);
            radioButton4.TabIndex = 22;
            radioButton4.TabStop = true;
            radioButton4.Text = "Все казлы!!!";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(23, 117);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(139, 29);
            radioButton3.TabIndex = 21;
            radioButton3.TabStop = true;
            radioButton3.Text = "Против всех";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(23, 82);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(66, 29);
            radioButton2.TabIndex = 20;
            radioButton2.TabStop = true;
            radioButton2.Text = "Нет";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(23, 47);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(58, 29);
            radioButton1.TabIndex = 19;
            radioButton1.TabStop = true;
            radioButton1.Text = "Да";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(424, 274);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 22;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(101, 209);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(389, 31);
            dateTimePicker1.TabIndex = 23;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button2
            // 
            button2.Location = new Point(186, 274);
            button2.Name = "button2";
            button2.Size = new Size(201, 105);
            button2.TabIndex = 24;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // tb1
            // 
            tb1.Location = new Point(650, 421);
            tb1.Name = "tb1";
            tb1.Size = new Size(412, 31);
            tb1.TabIndex = 25;
            tb1.Validated += tb1_Validated;
            // 
            // tb2
            // 
            tb2.Location = new Point(650, 458);
            tb2.Name = "tb2";
            tb2.Size = new Size(412, 31);
            tb2.TabIndex = 26;
            tb2.TextChanged += tb2_TextChanged;
            tb2.Validated += tb2_Validated;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSplitButton1, toolStripComboBox1 });
            toolStrip1.Location = new Point(0, 64);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1979, 33);
            toolStrip1.TabIndex = 27;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 28);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(45, 28);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 33);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 31);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1979, 33);
            menuStrip1.TabIndex = 28;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(158, 34);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(158, 34);
            saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(155, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(158, 34);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(65, 29);
            viewToolStripMenuItem.Text = "View";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { testToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(144, 34);
            testToolStripMenuItem.Text = "&Test";
            // 
            // tbPath
            // 
            tbPath.Location = new Point(650, 588);
            tbPath.Name = "tbPath";
            tbPath.ReadOnly = true;
            tbPath.Size = new Size(499, 31);
            tbPath.TabIndex = 29;
            // 
            // bnBrowse
            // 
            bnBrowse.Location = new Point(1155, 585);
            bnBrowse.Name = "bnBrowse";
            bnBrowse.Size = new Size(112, 34);
            bnBrowse.TabIndex = 30;
            bnBrowse.Text = "Browse...";
            bnBrowse.UseVisualStyleBackColor = true;
            bnBrowse.Click += bnBrowse_Click;
            // 
            // lbOutput
            // 
            lbOutput.FormattingEnabled = true;
            lbOutput.ItemHeight = 25;
            lbOutput.Location = new Point(650, 633);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(617, 254);
            lbOutput.TabIndex = 31;
            // 
            // browseFolder1
            // 
            browseFolder1.Location = new Point(37, 655);
            browseFolder1.Name = "browseFolder1";
            browseFolder1.Size = new Size(637, 49);
            browseFolder1.TabIndex = 32;
            browseFolder1.PathChanged += browseFolder1_PathChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1979, 980);
            Controls.Add(browseFolder1);
            Controls.Add(lbOutput);
            Controls.Add(bnBrowse);
            Controls.Add(tbPath);
            Controls.Add(listBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(tb2);
            Controls.Add(tb1);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(monthCalendar1);
            Controls.Add(groupBox1);
            Controls.Add(radioButton6);
            Controls.Add(radioButton5);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(button5);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Наше суперсокое GUI риложение";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox4;
        private Button button5;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private Button button1;
        private CheckBox checkBox1;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private MonthCalendar monthCalendar1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private TextBox tb1;
        private TextBox tb2;
        private ErrorProvider errorProvider1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripComboBox toolStripComboBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem testToolStripMenuItem;
        private Button bnBrowse;
        private TextBox tbPath;
        private ListBox lbOutput;
        private FolderBrowserDialog fbdBrowse;
        private UserControls.BrowseFolder browseFolder1;
    }
}