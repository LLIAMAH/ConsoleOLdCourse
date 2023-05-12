namespace WinFormsApp1.Forms
{
    partial class FPersonData
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
            label1 = new Label();
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            label2 = new Label();
            dtpBirthDate = new DateTimePicker();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(12, 37);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(398, 31);
            tbFirstName.TabIndex = 1;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(12, 103);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(398, 31);
            tbLastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 2;
            label2.Text = "Last name";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(12, 175);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(398, 31);
            dtpBirthDate.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 147);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 5;
            label3.Text = "Birth date";
            // 
            // button1
            // 
            button1.Location = new Point(298, 212);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FPersonData
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 268);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(dtpBirthDate);
            Controls.Add(tbLastName);
            Controls.Add(label2);
            Controls.Add(tbFirstName);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FPersonData";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FPersonData";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private Label label2;
        private DateTimePicker dtpBirthDate;
        private Label label3;
        private Button button1;
    }
}