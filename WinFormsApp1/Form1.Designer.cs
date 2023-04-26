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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            tabPage2 = new TabPage();
            radioButton7 = new RadioButton();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Top;
            textBox2.Location = new Point(0, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1778, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.BackColor = Color.Yellow;
            textBox3.ForeColor = Color.Red;
            textBox3.Location = new Point(1479, 187);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(231, 35);
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
            textBox1.Location = new Point(1479, 91);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Horizontal;
            textBox1.Size = new Size(231, 35);
            textBox1.TabIndex = 8;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.BackColor = Color.Yellow;
            textBox4.ForeColor = Color.Red;
            textBox4.Location = new Point(1479, 132);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(231, 35);
            textBox4.TabIndex = 9;
            textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // button5
            // 
            button5.Location = new Point(1591, 228);
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
            listBox1.Location = new Point(961, 228);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(459, 554);
            listBox1.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3", "Double item 1", "Double item 2" });
            comboBox1.Location = new Point(568, 175);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(383, 33);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(594, 265);
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
            checkBox1.Location = new Point(123, 281);
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
            radioButton5.Location = new Point(715, 691);
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
            radioButton6.Location = new Point(715, 726);
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
            groupBox1.Location = new Point(123, 590);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 228);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Кандидаты ПИД\"\"\"";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(145, 152);
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
            radioButton3.Location = new Point(145, 117);
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
            radioButton2.Location = new Point(145, 82);
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
            radioButton1.Location = new Point(145, 47);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(58, 29);
            radioButton1.TabIndex = 19;
            radioButton1.TabStop = true;
            radioButton1.Text = "Да";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(548, 391);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(526, 323);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(389, 31);
            dateTimePicker1.TabIndex = 23;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 31);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1778, 949);
            tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1770, 911);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 224);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(radioButton7);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1770, 911);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Checked = true;
            radioButton7.Location = new Point(292, 234);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(141, 29);
            radioButton7.TabIndex = 0;
            radioButton7.TabStop = true;
            radioButton7.Text = "radioButton7";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1770, 911);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1770, 911);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 34);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1770, 911);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 34);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1770, 911);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "tabPage6";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 34);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(1770, 911);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "tabPage7";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1778, 980);
            Controls.Add(tabControl1);
            Controls.Add(dateTimePicker1);
            Controls.Add(monthCalendar1);
            Controls.Add(groupBox1);
            Controls.Add(radioButton6);
            Controls.Add(radioButton5);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(button5);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Наше суперсокое GUI риложение";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private TabPage tabPage2;
        private RadioButton radioButton7;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
    }
}