namespace WinFormsApp1.UserControls
{
    partial class BrowseFolder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bnBrowse = new Button();
            tbPath = new TextBox();
            fbdBrowse = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // bnBrowse
            // 
            bnBrowse.Location = new Point(510, 3);
            bnBrowse.Name = "bnBrowse";
            bnBrowse.Size = new Size(112, 34);
            bnBrowse.TabIndex = 32;
            bnBrowse.Text = "Browse...";
            bnBrowse.UseVisualStyleBackColor = true;
            bnBrowse.Click += bnBrowse_Click;
            // 
            // tbPath
            // 
            tbPath.Location = new Point(5, 6);
            tbPath.Name = "tbPath";
            tbPath.ReadOnly = true;
            tbPath.Size = new Size(499, 31);
            tbPath.TabIndex = 31;
            // 
            // BrowseFolder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bnBrowse);
            Controls.Add(tbPath);
            Name = "BrowseFolder";
            Size = new Size(626, 41);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bnBrowse;
        private TextBox tbPath;
        private FolderBrowserDialog fbdBrowse;
    }
}
