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
            bnFGetDrives = new Button();
            tvFileSystem = new TreeView();
            button1 = new Button();
            rtbContext = new RichTextBox();
            bnWrite = new Button();
            bnRead = new Button();
            bnReadStruct = new Button();
            bnWriteStruct = new Button();
            SuspendLayout();
            // 
            // bnFGetDrives
            // 
            bnFGetDrives.Location = new Point(12, 12);
            bnFGetDrives.Name = "bnFGetDrives";
            bnFGetDrives.Size = new Size(480, 66);
            bnFGetDrives.TabIndex = 0;
            bnFGetDrives.Text = "Get Drives";
            bnFGetDrives.UseVisualStyleBackColor = true;
            bnFGetDrives.Click += bnFGetDrives_Click;
            // 
            // tvFileSystem
            // 
            tvFileSystem.Location = new Point(12, 84);
            tvFileSystem.Name = "tvFileSystem";
            tvFileSystem.Size = new Size(480, 509);
            tvFileSystem.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(712, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rtbContext
            // 
            rtbContext.Location = new Point(529, 151);
            rtbContext.Name = "rtbContext";
            rtbContext.Size = new Size(758, 465);
            rtbContext.TabIndex = 3;
            rtbContext.Text = "";
            // 
            // bnWrite
            // 
            bnWrite.Location = new Point(529, 101);
            bnWrite.Name = "bnWrite";
            bnWrite.Size = new Size(174, 44);
            bnWrite.TabIndex = 4;
            bnWrite.Text = "Write";
            bnWrite.UseVisualStyleBackColor = true;
            bnWrite.Click += bnWrite_Click;
            // 
            // bnRead
            // 
            bnRead.Location = new Point(712, 101);
            bnRead.Name = "bnRead";
            bnRead.Size = new Size(174, 44);
            bnRead.TabIndex = 5;
            bnRead.Text = "Read";
            bnRead.UseVisualStyleBackColor = true;
            bnRead.Click += bnRead_Click;
            // 
            // bnReadStruct
            // 
            bnReadStruct.Location = new Point(906, 12);
            bnReadStruct.Name = "bnReadStruct";
            bnReadStruct.Size = new Size(149, 43);
            bnReadStruct.TabIndex = 6;
            bnReadStruct.Text = "Read struct";
            bnReadStruct.UseVisualStyleBackColor = true;
            bnReadStruct.Click += bnReadStruct_Click;
            // 
            // bnWriteStruct
            // 
            bnWriteStruct.Location = new Point(1061, 12);
            bnWriteStruct.Name = "bnWriteStruct";
            bnWriteStruct.Size = new Size(149, 43);
            bnWriteStruct.TabIndex = 7;
            bnWriteStruct.Text = "WriteStruct";
            bnWriteStruct.UseVisualStyleBackColor = true;
            bnWriteStruct.Click += bnWriteStruct_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 713);
            Controls.Add(bnWriteStruct);
            Controls.Add(bnReadStruct);
            Controls.Add(bnRead);
            Controls.Add(bnWrite);
            Controls.Add(rtbContext);
            Controls.Add(button1);
            Controls.Add(tvFileSystem);
            Controls.Add(bnFGetDrives);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button bnFGetDrives;
        private TreeView tvFileSystem;
        private Button button1;
        private RichTextBox rtbContext;
        private Button bnWrite;
        private Button bnRead;
        private Button bnReadStruct;
        private Button bnWriteStruct;
    }
}