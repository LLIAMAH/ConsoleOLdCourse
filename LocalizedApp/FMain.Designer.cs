namespace LocalizedApp
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
            bnOK = new Button();
            bnCancel = new Button();
            prvdLoginErrors = new ErrorProvider(components);
            button1 = new Button();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)prvdLoginErrors).BeginInit();
            SuspendLayout();
            // 
            // lLogin
            // 
            resources.ApplyResources(lLogin, "lLogin");
            prvdLoginErrors.SetError(lLogin, resources.GetString("lLogin.Error"));
            prvdLoginErrors.SetIconAlignment(lLogin, (ErrorIconAlignment)resources.GetObject("lLogin.IconAlignment"));
            prvdLoginErrors.SetIconPadding(lLogin, (int)resources.GetObject("lLogin.IconPadding"));
            lLogin.Name = "lLogin";
            // 
            // tbLogin
            // 
            resources.ApplyResources(tbLogin, "tbLogin");
            prvdLoginErrors.SetError(tbLogin, resources.GetString("tbLogin.Error"));
            prvdLoginErrors.SetIconAlignment(tbLogin, (ErrorIconAlignment)resources.GetObject("tbLogin.IconAlignment"));
            prvdLoginErrors.SetIconPadding(tbLogin, (int)resources.GetObject("tbLogin.IconPadding"));
            tbLogin.Name = "tbLogin";
            tbLogin.Validated += tbLogin_Validated;
            // 
            // tbPassword
            // 
            resources.ApplyResources(tbPassword, "tbPassword");
            prvdLoginErrors.SetError(tbPassword, resources.GetString("tbPassword.Error"));
            prvdLoginErrors.SetIconAlignment(tbPassword, (ErrorIconAlignment)resources.GetObject("tbPassword.IconAlignment"));
            prvdLoginErrors.SetIconPadding(tbPassword, (int)resources.GetObject("tbPassword.IconPadding"));
            tbPassword.Name = "tbPassword";
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.Validated += tbPassword_Validated;
            // 
            // lPassword
            // 
            resources.ApplyResources(lPassword, "lPassword");
            prvdLoginErrors.SetError(lPassword, resources.GetString("lPassword.Error"));
            prvdLoginErrors.SetIconAlignment(lPassword, (ErrorIconAlignment)resources.GetObject("lPassword.IconAlignment"));
            prvdLoginErrors.SetIconPadding(lPassword, (int)resources.GetObject("lPassword.IconPadding"));
            lPassword.Name = "lPassword";
            // 
            // bnOK
            // 
            resources.ApplyResources(bnOK, "bnOK");
            prvdLoginErrors.SetError(bnOK, resources.GetString("bnOK.Error"));
            prvdLoginErrors.SetIconAlignment(bnOK, (ErrorIconAlignment)resources.GetObject("bnOK.IconAlignment"));
            prvdLoginErrors.SetIconPadding(bnOK, (int)resources.GetObject("bnOK.IconPadding"));
            bnOK.Name = "bnOK";
            bnOK.UseVisualStyleBackColor = true;
            bnOK.Click += bnOK_Click;
            // 
            // bnCancel
            // 
            resources.ApplyResources(bnCancel, "bnCancel");
            prvdLoginErrors.SetError(bnCancel, resources.GetString("bnCancel.Error"));
            prvdLoginErrors.SetIconAlignment(bnCancel, (ErrorIconAlignment)resources.GetObject("bnCancel.IconAlignment"));
            prvdLoginErrors.SetIconPadding(bnCancel, (int)resources.GetObject("bnCancel.IconPadding"));
            bnCancel.Name = "bnCancel";
            bnCancel.UseVisualStyleBackColor = true;
            bnCancel.Click += bnCancel_Click;
            // 
            // prvdLoginErrors
            // 
            prvdLoginErrors.ContainerControl = this;
            resources.ApplyResources(prvdLoginErrors, "prvdLoginErrors");
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            prvdLoginErrors.SetError(button1, resources.GetString("button1.Error"));
            prvdLoginErrors.SetIconAlignment(button1, (ErrorIconAlignment)resources.GetObject("button1.IconAlignment"));
            prvdLoginErrors.SetIconPadding(button1, (int)resources.GetObject("button1.IconPadding"));
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            resources.ApplyResources(listBox1, "listBox1");
            prvdLoginErrors.SetError(listBox1, resources.GetString("listBox1.Error"));
            listBox1.FormattingEnabled = true;
            prvdLoginErrors.SetIconAlignment(listBox1, (ErrorIconAlignment)resources.GetObject("listBox1.IconAlignment"));
            prvdLoginErrors.SetIconPadding(listBox1, (int)resources.GetObject("listBox1.IconPadding"));
            listBox1.Name = "listBox1";
            // 
            // FMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(bnCancel);
            Controls.Add(bnOK);
            Controls.Add(tbPassword);
            Controls.Add(lPassword);
            Controls.Add(tbLogin);
            Controls.Add(lLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FMain";
            ((System.ComponentModel.ISupportInitialize)prvdLoginErrors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lLogin;
        private TextBox tbLogin;
        private TextBox tbPassword;
        private Label lPassword;
        private Button bnOK;
        private Button bnCancel;
        private ErrorProvider prvdLoginErrors;
        private ListBox listBox1;
        private Button button1;
    }
}