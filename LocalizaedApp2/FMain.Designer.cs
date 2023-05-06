namespace LocalizaedApp2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            lLogin = new Label();
            tbLogin = new TextBox();
            tbPassword = new TextBox();
            lPassword = new Label();
            bnCancel = new Button();
            bnOK = new Button();
            provErrors = new ErrorProvider(components);
            button1 = new Button();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)provErrors).BeginInit();
            SuspendLayout();
            // 
            // lLogin
            // 
            resources.ApplyResources(lLogin, "lLogin");
            lLogin.Name = "lLogin";
            // 
            // tbLogin
            // 
            resources.ApplyResources(tbLogin, "tbLogin");
            tbLogin.Name = "tbLogin";
            tbLogin.Validated += tbLogin_Validated;
            // 
            // tbPassword
            // 
            resources.ApplyResources(tbPassword, "tbPassword");
            tbPassword.Name = "tbPassword";
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.Validated += tbPassword_Validated;
            // 
            // lPassword
            // 
            resources.ApplyResources(lPassword, "lPassword");
            lPassword.Name = "lPassword";
            // 
            // bnCancel
            // 
            resources.ApplyResources(bnCancel, "bnCancel");
            bnCancel.Name = "bnCancel";
            bnCancel.UseVisualStyleBackColor = true;
            bnCancel.Click += bnCancel_Click;
            // 
            // bnOK
            // 
            resources.ApplyResources(bnOK, "bnOK");
            bnOK.Name = "bnOK";
            bnOK.UseVisualStyleBackColor = true;
            bnOK.Click += bnOK_Click;
            // 
            // provErrors
            // 
            provErrors.ContainerControl = this;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            resources.ApplyResources(listBox1, "listBox1");
            listBox1.Name = "listBox1";
            // 
            // FMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(bnOK);
            Controls.Add(bnCancel);
            Controls.Add(tbPassword);
            Controls.Add(lPassword);
            Controls.Add(tbLogin);
            Controls.Add(lLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FMain";
            ((System.ComponentModel.ISupportInitialize)provErrors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lLogin;
        private TextBox tbLogin;
        private TextBox tbPassword;
        private Label lPassword;
        private Button bnCancel;
        private Button bnOK;
        private ErrorProvider provErrors;
        private ListBox listBox1;
        private Button button1;
    }
}