namespace LocalizedApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bnLogin_Click(object sender, EventArgs e)
        {

        }

        private void tbLogin_Validated(object sender, EventArgs e)
        {
            var login = tbLogin.Text;
            if (string.IsNullOrEmpty(login))
            {
                errorValidation.SetError(tbLogin, Properties.ValidationErrors.ValidationError_LoginIsEmpty);
            }
            else
            {
                errorValidation.SetError(tbLogin, string.Empty);
            }
        }

        private void tbPassword_Validated(object sender, EventArgs e)
        {
            var password = tbPassword.Text;
            if (string.IsNullOrEmpty(password))
            {
                errorValidation.SetError(tbPassword, Properties.ValidationErrors.ValidationError_PasswordIsEmpty);
            }
            else if (password.Length <= 4)
            {
                errorValidation.SetError(tbPassword, Properties.ValidationErrors.ValidationError_PasswordSize4CharsMore);
            }
            else
            {
                errorValidation.SetError(tbPassword, string.Empty);
            }
        }
    }
}