namespace LocalizedApp2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lUserName = new Label();
            tbLogin = new TextBox();
            tbPassword = new TextBox();
            lPassword = new Label();
            bnLogin = new Button();
            bnCancel = new Button();
            errorValidation = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorValidation).BeginInit();
            SuspendLayout();
            // 
            // lUserName
            // 
            resources.ApplyResources(lUserName, "lUserName");
            errorValidation.SetError(lUserName, resources.GetString("lUserName.Error"));
            errorValidation.SetIconAlignment(lUserName, (ErrorIconAlignment)resources.GetObject("lUserName.IconAlignment"));
            errorValidation.SetIconPadding(lUserName, (int)resources.GetObject("lUserName.IconPadding"));
            lUserName.Name = "lUserName";
            // 
            // tbLogin
            // 
            resources.ApplyResources(tbLogin, "tbLogin");
            errorValidation.SetError(tbLogin, resources.GetString("tbLogin.Error"));
            errorValidation.SetIconAlignment(tbLogin, (ErrorIconAlignment)resources.GetObject("tbLogin.IconAlignment"));
            errorValidation.SetIconPadding(tbLogin, (int)resources.GetObject("tbLogin.IconPadding"));
            tbLogin.Name = "tbLogin";
            tbLogin.Validated += tbLogin_Validated;
            // 
            // tbPassword
            // 
            resources.ApplyResources(tbPassword, "tbPassword");
            errorValidation.SetError(tbPassword, resources.GetString("tbPassword.Error"));
            errorValidation.SetIconAlignment(tbPassword, (ErrorIconAlignment)resources.GetObject("tbPassword.IconAlignment"));
            errorValidation.SetIconPadding(tbPassword, (int)resources.GetObject("tbPassword.IconPadding"));
            tbPassword.Name = "tbPassword";
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.Validated += tbPassword_Validated;
            // 
            // lPassword
            // 
            resources.ApplyResources(lPassword, "lPassword");
            errorValidation.SetError(lPassword, resources.GetString("lPassword.Error"));
            errorValidation.SetIconAlignment(lPassword, (ErrorIconAlignment)resources.GetObject("lPassword.IconAlignment"));
            errorValidation.SetIconPadding(lPassword, (int)resources.GetObject("lPassword.IconPadding"));
            lPassword.Name = "lPassword";
            // 
            // bnLogin
            // 
            resources.ApplyResources(bnLogin, "bnLogin");
            errorValidation.SetError(bnLogin, resources.GetString("bnLogin.Error"));
            errorValidation.SetIconAlignment(bnLogin, (ErrorIconAlignment)resources.GetObject("bnLogin.IconAlignment"));
            errorValidation.SetIconPadding(bnLogin, (int)resources.GetObject("bnLogin.IconPadding"));
            bnLogin.Name = "bnLogin";
            bnLogin.UseVisualStyleBackColor = true;
            bnLogin.Click += bnLogin_Click;
            // 
            // bnCancel
            // 
            resources.ApplyResources(bnCancel, "bnCancel");
            errorValidation.SetError(bnCancel, resources.GetString("bnCancel.Error"));
            errorValidation.SetIconAlignment(bnCancel, (ErrorIconAlignment)resources.GetObject("bnCancel.IconAlignment"));
            errorValidation.SetIconPadding(bnCancel, (int)resources.GetObject("bnCancel.IconPadding"));
            bnCancel.Name = "bnCancel";
            bnCancel.UseVisualStyleBackColor = true;
            // 
            // errorValidation
            // 
            errorValidation.ContainerControl = this;
            resources.ApplyResources(errorValidation, "errorValidation");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bnCancel);
            Controls.Add(bnLogin);
            Controls.Add(tbPassword);
            Controls.Add(lPassword);
            Controls.Add(tbLogin);
            Controls.Add(lUserName);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorValidation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lUserName;
        private TextBox tbLogin;
        private TextBox tbPassword;
        private Label lPassword;
        private Button bnLogin;
        private Button bnCancel;
        private ErrorProvider errorValidation;
    }
}