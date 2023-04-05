namespace AppWinFormsCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MaximizeBox = true;
            MinimizeBox = true;
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            var item = tbListItem.Text;
            if (!string.IsNullOrEmpty(item)) // item == null OR item == "" (string.Empty)
            {
                lbItemsList.Items.Add(item);
                tbListItem.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(
                    "Нет данныех в текстовом поле - нечего добавлять в список.",
                    "Сообщение",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information);
            }
        }

        private void bnAdd_MouseHover(object sender, EventArgs e)
        {
            var position = ((Button)sender).PointToClient(Cursor.Position);
            lbItemsList.Items.Add($"X: {position.X}; Y: {position.Y}"); 
        }
    }
}