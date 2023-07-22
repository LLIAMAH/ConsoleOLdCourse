namespace UnZipper.Classes
{
    public interface IGetDir
    {
        public string SelectedPath { get; }
        public FileInfo[] Files { get; }
        public bool ShowAndOkDialog();
    }

    public class GetDir : IGetDir
    {
        private readonly FolderBrowserDialog _dlg;
        public string SelectedPath { get; private set; }

        public FileInfo[] Files
        {
            get
            {
                var di = new DirectoryInfo(this.SelectedPath);
                if (!di.Exists)
                    Enumerable.Empty<FileInfo>();

                return di.GetFiles("*,*", SearchOption.AllDirectories);
            }
        }

        public GetDir(FolderBrowserDialog dlg)
        {
            this._dlg = dlg;
        }

        public bool ShowAndOkDialog()
        {
            if (this._dlg.ShowDialog() == DialogResult.OK)
            {
                var directoryInfo = new DirectoryInfo(this._dlg.SelectedPath);
                if (directoryInfo.Exists)
                {
                    this.SelectedPath = directoryInfo.FullName;
                    return true;
                }
            }

            return false;
        }

        
    }
}
