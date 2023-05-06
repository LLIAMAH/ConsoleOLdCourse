using System.Globalization;

namespace LocalizedApp
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void tbLogin_Validated(object sender, EventArgs e)
        {
            //var tb = sender as TextBox;
            //var tb1 = tbLogin;

            var tb = sender as TextBox;
            if (tb != null)
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    prvdLoginErrors.SetError(tb, "Login cannot be empty");
                }
                else
                {
                    prvdLoginErrors.SetError(tb, string.Empty);
                }
            }
        }

        private void tbPassword_Validated(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb != null)
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    prvdLoginErrors.SetError(tb, "Password cannot be empty");
                }
                else if (tb.Text.Length < 6)
                {
                    prvdLoginErrors.SetError(tb, "Password must be 6 characters or more.");
                }
                else
                {
                    prvdLoginErrors.SetError(tb, string.Empty);
                }
            }
        }

        private void bnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login successful");
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We cancelled process of the log in.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ciInfo =
                CultureInfo.GetCultures(CultureTypes.AllCultures & ~CultureTypes.NeutralCultures);
            foreach (var cultureInfo in ciInfo)
            {
                listBox1.Items.Add($"{cultureInfo.DisplayName}: {cultureInfo.Name}");
            }
        }
    }
}