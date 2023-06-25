namespace ThreadingExperiments
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
            bnWoThread = new Button();
            lbOutput = new ListBox();
            bnAddNumbers = new Button();
            bnWriteToFile = new Button();
            bnStopAllProcesses = new Button();
            SuspendLayout();
            // 
            // bnWoThread
            // 
            bnWoThread.Location = new Point(12, 12);
            bnWoThread.Name = "bnWoThread";
            bnWoThread.Size = new Size(181, 82);
            bnWoThread.TabIndex = 0;
            bnWoThread.Text = "W/O Thread";
            bnWoThread.UseVisualStyleBackColor = true;
            bnWoThread.Click += bnWoThread_Click;
            // 
            // lbOutput
            // 
            lbOutput.FormattingEnabled = true;
            lbOutput.ItemHeight = 25;
            lbOutput.Location = new Point(12, 100);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(632, 479);
            lbOutput.TabIndex = 1;
            // 
            // bnAddNumbers
            // 
            bnAddNumbers.Location = new Point(199, 12);
            bnAddNumbers.Name = "bnAddNumbers";
            bnAddNumbers.Size = new Size(181, 82);
            bnAddNumbers.TabIndex = 2;
            bnAddNumbers.Text = "Add numbers in Task";
            bnAddNumbers.UseVisualStyleBackColor = true;
            bnAddNumbers.Click += bnAddNumbers_Click;
            // 
            // bnWriteToFile
            // 
            bnWriteToFile.Location = new Point(650, 100);
            bnWriteToFile.Name = "bnWriteToFile";
            bnWriteToFile.Size = new Size(314, 142);
            bnWriteToFile.TabIndex = 3;
            bnWriteToFile.Text = "Write to file";
            bnWriteToFile.UseVisualStyleBackColor = true;
            bnWriteToFile.Click += bnWriteToFile_Click;
            // 
            // bnStopAllProcesses
            // 
            bnStopAllProcesses.Location = new Point(998, 118);
            bnStopAllProcesses.Name = "bnStopAllProcesses";
            bnStopAllProcesses.Size = new Size(274, 109);
            bnStopAllProcesses.TabIndex = 4;
            bnStopAllProcesses.Text = "Stop all processes";
            bnStopAllProcesses.UseVisualStyleBackColor = true;
            bnStopAllProcesses.Click += bnStopAllProcesses_Click;
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1637, 721);
            Controls.Add(bnStopAllProcesses);
            Controls.Add(bnWriteToFile);
            Controls.Add(bnAddNumbers);
            Controls.Add(lbOutput);
            Controls.Add(bnWoThread);
            Name = "FMain";
            Text = "FMain";
            ResumeLayout(false);
        }

        #endregion

        private Button bnWoThread;
        private ListBox lbOutput;
        private Button bnAddNumbers;
        private Button bnWriteToFile;
        private Button bnStopAllProcesses;
    }
}