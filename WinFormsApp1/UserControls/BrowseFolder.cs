using System.ComponentModel;

namespace WinFormsApp1.UserControls
{
    [DefaultEvent("PathChanged")]
    public partial class BrowseFolder : UserControl
    {
        public string Path => tbPath.Text;
        //{
        //    get
        //    {
        //        return tbPath.Text;
        //    }
        //}
        public event EventHandler<EventArgs> PathChanged;

        public BrowseFolder()
        {
            InitializeComponent();
        }

        private void bnBrowse_Click(object sender, EventArgs e)
        {
            if(fbdBrowse.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = fbdBrowse.SelectedPath;
                this.PathChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
