namespace NetworkExperiments
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
            lbResultsUDP = new ListBox();
            bnListenUDP = new Button();
            tbMessageUDP = new TextBox();
            bnSendUDP = new Button();
            SuspendLayout();
            // 
            // lbResultsUDP
            // 
            lbResultsUDP.FormattingEnabled = true;
            lbResultsUDP.ItemHeight = 25;
            lbResultsUDP.Location = new Point(12, 76);
            lbResultsUDP.Name = "lbResultsUDP";
            lbResultsUDP.Size = new Size(519, 454);
            lbResultsUDP.TabIndex = 0;
            // 
            // bnListenUDP
            // 
            bnListenUDP.Location = new Point(12, 12);
            bnListenUDP.Name = "bnListenUDP";
            bnListenUDP.Size = new Size(134, 50);
            bnListenUDP.TabIndex = 1;
            bnListenUDP.Text = "Listen";
            bnListenUDP.UseVisualStyleBackColor = true;
            bnListenUDP.Click += bnListenUDP_Click;
            // 
            // tbMessageUDP
            // 
            tbMessageUDP.Location = new Point(12, 540);
            tbMessageUDP.Name = "tbMessageUDP";
            tbMessageUDP.Size = new Size(380, 31);
            tbMessageUDP.TabIndex = 2;
            // 
            // bnSendUDP
            // 
            bnSendUDP.Location = new Point(398, 536);
            bnSendUDP.Name = "bnSendUDP";
            bnSendUDP.Size = new Size(133, 38);
            bnSendUDP.TabIndex = 3;
            bnSendUDP.Text = "Send";
            bnSendUDP.UseVisualStyleBackColor = true;
            bnSendUDP.Click += bnSendUDP_Click;
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 762);
            Controls.Add(bnSendUDP);
            Controls.Add(tbMessageUDP);
            Controls.Add(bnListenUDP);
            Controls.Add(lbResultsUDP);
            Name = "FMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbResultsUDP;
        private Button bnListenUDP;
        private TextBox tbMessageUDP;
        private Button bnSendUDP;
    }
}