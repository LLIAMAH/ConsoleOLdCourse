using System.Globalization;

namespace LocalizaedApp2
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void tbLogin_Validated(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb != null)
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    provErrors.SetError(tb, Resources.ResMesagges.Error_Login_Value_Cannot_Be_Empty);
                }
                else
                {
                    provErrors.SetError(tb, string.Empty);
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
                    provErrors.SetError(tb, Resources.ResMesagges.Error_Password_Value_Cannot_Be_Empty);
                }
                else if (tb.Text.Length < 6)
                {
                    provErrors.SetError(tb, Resources.ResMesagges.Error_Password_Length_Must_Be_6_Characters_More);
                }
                else
                {
                    provErrors.SetError(tb, string.Empty);
                }
            }
        }

        private void bnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.ResMesagges.Message_Successfully_LoggedIn);
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.ResMesagges.Message_Log_In_Process_Cancelled);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures & ~CultureTypes.NeutralCultures);
            foreach (var cultureInfo in cultures)
            {
                listBox1.Items.Add($"{cultureInfo.Name}: \t{cultureInfo.DisplayName}");
            }
        }
    }
}