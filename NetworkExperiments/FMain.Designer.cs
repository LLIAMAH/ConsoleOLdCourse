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
            bnSendTCP = new Button();
            tbMessageTCP = new TextBox();
            bnListenTCP = new Button();
            lbResultsTCP = new ListBox();
            bnSendTcp2 = new Button();
            tbMessageTcp2 = new TextBox();
            lbResultTCP2 = new ListBox();
            bnConnectTcp = new Button();
            bnConnectTcp2 = new Button();
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
            // bnSendTCP
            // 
            bnSendTCP.Location = new Point(1211, 536);
            bnSendTCP.Name = "bnSendTCP";
            bnSendTCP.Size = new Size(133, 38);
            bnSendTCP.TabIndex = 7;
            bnSendTCP.Text = "Send";
            bnSendTCP.UseVisualStyleBackColor = true;
            bnSendTCP.Click += bnSendTCP_Click;
            // 
            // tbMessageTCP
            // 
            tbMessageTCP.Location = new Point(825, 543);
            tbMessageTCP.Name = "tbMessageTCP";
            tbMessageTCP.Size = new Size(380, 31);
            tbMessageTCP.TabIndex = 6;
            // 
            // bnListenTCP
            // 
            bnListenTCP.Location = new Point(825, 12);
            bnListenTCP.Name = "bnListenTCP";
            bnListenTCP.Size = new Size(134, 50);
            bnListenTCP.TabIndex = 5;
            bnListenTCP.Text = "Listen";
            bnListenTCP.UseVisualStyleBackColor = true;
            bnListenTCP.Click += bnListenTCP_Click;
            // 
            // lbResultsTCP
            // 
            lbResultsTCP.FormattingEnabled = true;
            lbResultsTCP.ItemHeight = 25;
            lbResultsTCP.Location = new Point(825, 76);
            lbResultsTCP.Name = "lbResultsTCP";
            lbResultsTCP.Size = new Size(519, 454);
            lbResultsTCP.TabIndex = 4;
            // 
            // bnSendTcp2
            // 
            bnSendTcp2.Location = new Point(1769, 536);
            bnSendTcp2.Name = "bnSendTcp2";
            bnSendTcp2.Size = new Size(133, 38);
            bnSendTcp2.TabIndex = 10;
            bnSendTcp2.Text = "Send";
            bnSendTcp2.UseVisualStyleBackColor = true;
            bnSendTcp2.Click += bnSendTcp2_Click;
            // 
            // tbMessageTcp2
            // 
            tbMessageTcp2.Location = new Point(1383, 543);
            tbMessageTcp2.Name = "tbMessageTcp2";
            tbMessageTcp2.Size = new Size(380, 31);
            tbMessageTcp2.TabIndex = 9;
            // 
            // lbResultTCP2
            // 
            lbResultTCP2.FormattingEnabled = true;
            lbResultTCP2.ItemHeight = 25;
            lbResultTCP2.Location = new Point(1383, 76);
            lbResultTCP2.Name = "lbResultTCP2";
            lbResultTCP2.Size = new Size(519, 454);
            lbResultTCP2.TabIndex = 8;
            // 
            // bnConnectTcp
            // 
            bnConnectTcp.Location = new Point(1210, 12);
            bnConnectTcp.Name = "bnConnectTcp";
            bnConnectTcp.Size = new Size(134, 50);
            bnConnectTcp.TabIndex = 11;
            bnConnectTcp.Text = "Connect";
            bnConnectTcp.UseVisualStyleBackColor = true;
            bnConnectTcp.Click += bnConnectTcp_Click;
            // 
            // bnConnectTcp2
            // 
            bnConnectTcp2.Location = new Point(1768, 12);
            bnConnectTcp2.Name = "bnConnectTcp2";
            bnConnectTcp2.Size = new Size(134, 50);
            bnConnectTcp2.TabIndex = 12;
            bnConnectTcp2.Text = "Connect";
            bnConnectTcp2.UseVisualStyleBackColor = true;
            bnConnectTcp2.Click += bnConnectTcp2_Click;
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2351, 762);
            Controls.Add(bnConnectTcp2);
            Controls.Add(bnConnectTcp);
            Controls.Add(bnSendTcp2);
            Controls.Add(tbMessageTcp2);
            Controls.Add(lbResultTCP2);
            Controls.Add(bnSendTCP);
            Controls.Add(tbMessageTCP);
            Controls.Add(bnListenTCP);
            Controls.Add(lbResultsTCP);
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
        private Button bnSendTCP;
        private TextBox tbMessageTCP;
        private Button bnListenTCP;
        private ListBox lbResultsTCP;
        private Button bnSendTcp2;
        private TextBox tbMessageTcp2;
        private ListBox lbResultTCP2;
        private Button bnConnectTcp;
        private Button bnConnectTcp2;
    }
}