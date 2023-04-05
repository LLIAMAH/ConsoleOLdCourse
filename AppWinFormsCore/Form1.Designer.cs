namespace AppWinFormsCore
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
            tbListItem = new TextBox();
            bnAdd = new Button();
            lbItemsList = new ListBox();
            SuspendLayout();
            // 
            // tbListItem
            // 
            tbListItem.Location = new Point(22, 12);
            tbListItem.Name = "tbListItem";
            tbListItem.Size = new Size(545, 31);
            tbListItem.TabIndex = 0;
            tbListItem.Text = "Привет ученики";
            // 
            // bnAdd
            // 
            bnAdd.Location = new Point(573, 12);
            bnAdd.Name = "bnAdd";
            bnAdd.Size = new Size(245, 116);
            bnAdd.TabIndex = 1;
            bnAdd.Text = "button1";
            bnAdd.UseVisualStyleBackColor = true;
            bnAdd.Click += bnAdd_Click;
            bnAdd.MouseHover += bnAdd_MouseHover;
            // 
            // lbItemsList
            // 
            lbItemsList.FormattingEnabled = true;
            lbItemsList.ItemHeight = 25;
            lbItemsList.Location = new Point(22, 49);
            lbItemsList.Name = "lbItemsList";
            lbItemsList.Size = new Size(545, 329);
            lbItemsList.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 642);
            Controls.Add(lbItemsList);
            Controls.Add(bnAdd);
            Controls.Add(tbListItem);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbListItem;
        private Button bnAdd;
        private ListBox lbItemsList;
    }
}