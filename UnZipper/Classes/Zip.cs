using System.IO.Compression;

namespace UnZipper.Classes
{
    public interface IZip
    {
        void ZipTo(IEnumerable<FileInfo> files);
    }

    public interface IUnZip
    {
        public FileInfo[] Unzip();
    }

    public interface IZipUnzip : IZip, IUnZip { }

    public class Zip : IZip
    {
        private readonly FileInfo _zipFile;

        public Zip(FileInfo zipFile)
        {
            this._zipFile = zipFile;
        }

        public void ZipTo(IEnumerable<FileInfo> files)
        {
            if (files.Any())
            {
                using (var zip = ZipFile.Open(this._zipFile.FullName, ZipArchiveMode.Create))
                {
                    foreach (var file in files)
                    {
                        zip.CreateEntryFromFile(file.FullName, file.Name);
                    }
                }
            }
        }
    }

    public class ZipUnzip : Zip, IZipUnzip
    {
        public ZipUnzip(FileInfo zipFile) : base(zipFile)
        {
        }

        public FileInfo[] Unzip()
        {
            // Здесь должен быть функционал Unzip 
            return Enumerable.Empty<FileInfo>().ToArray();
        }
    }
}
