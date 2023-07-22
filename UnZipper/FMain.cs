using System.IO.Compression;

namespace UnZipper
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void bnBrowse_Click(object sender, EventArgs e)
        {
            if (fbdBrowse.ShowDialog() == DialogResult.OK)
            {
                var di = new DirectoryInfo(fbdBrowse.SelectedPath);
                if (di.Exists)
                {
                    var fullList = GetFiles(di);
                    foreach (var fileInfo in fullList)
                        lbItems.Items.Add(fileInfo);
                }
            }
        }

        private List<FileInfo> GetFiles(DirectoryInfo di)
        {
            var list = new List<FileInfo>();
            list.AddRange(di.GetFiles());
            foreach (var directoryInfo in di.GetDirectories())
            {
                list.AddRange(GetFiles(directoryInfo));
            }

            return list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var path = "C:\\Temp\\Course";
            var zipName = "Result.zip";
			var combined = Path.Combine(path, zipName);
			var fi = new FileInfo(combined);
            if (fi.Exists)
                fi.Delete();

            var selected = lbItems.SelectedItems;
            if (selected.Count > 0)
            {
                using (var zip = ZipFile.Open(fi.FullName, ZipArchiveMode.Create))
                {
                    foreach (var file in selected.Cast<FileInfo>())
                    {
                        zip.CreateEntryFromFile(file.FullName, file.Name);
                    }
                }
            }
        }
    }
}