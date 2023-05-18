namespace DatabaseExperimentsNET
{
    partial class FMain
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
            this.bnLoadData = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bnLoadData
            // 
            this.bnLoadData.Location = new System.Drawing.Point(12, 12);
            this.bnLoadData.Name = "bnLoadData";
            this.bnLoadData.Size = new System.Drawing.Size(240, 100);
            this.bnLoadData.TabIndex = 0;
            this.bnLoadData.Text = "Load Data";
            this.bnLoadData.UseVisualStyleBackColor = true;
            this.bnLoadData.Click += new System.EventHandler(this.bnLoadData_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 20;
            this.lbOutput.Location = new System.Drawing.Point(12, 118);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(1411, 484);
            this.lbOutput.TabIndex = 1;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 779);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.bnLoadData);
            this.Name = "FMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnLoadData;
        private System.Windows.Forms.ListBox lbOutput;
    }
}

