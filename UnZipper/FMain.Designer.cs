namespace UnZipper
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
            tbZipFile = new TextBox();
            bnBrowse = new Button();
            lbItems = new ListBox();
            button1 = new Button();
            fbdBrowse = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // tbZipFile
            // 
            tbZipFile.Location = new Point(12, 12);
            tbZipFile.Name = "tbZipFile";
            tbZipFile.Size = new Size(408, 31);
            tbZipFile.TabIndex = 0;
            // 
            // bnBrowse
            // 
            bnBrowse.Location = new Point(426, 12);
            bnBrowse.Name = "bnBrowse";
            bnBrowse.Size = new Size(112, 34);
            bnBrowse.TabIndex = 1;
            bnBrowse.Text = "Browse...";
            bnBrowse.UseVisualStyleBackColor = true;
            bnBrowse.Click += bnBrowse_Click;
            // 
            // lbItems
            // 
            lbItems.FormattingEnabled = true;
            lbItems.ItemHeight = 25;
            lbItems.Location = new Point(12, 49);
            lbItems.Name = "lbItems";
            lbItems.SelectionMode = SelectionMode.MultiExtended;
            lbItems.Size = new Size(526, 679);
            lbItems.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(544, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1443, 735);
            Controls.Add(button1);
            Controls.Add(lbItems);
            Controls.Add(bnBrowse);
            Controls.Add(tbZipFile);
            Name = "FMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbZipFile;
        private Button bnBrowse;
        private ListBox lbItems;
        private Button button1;
        private FolderBrowserDialog fbdBrowse;
    }
}