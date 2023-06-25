
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;
using AppWinFormsCore.Classes;
using AppWinFormsCore.Forms;

namespace AppWinFormsCore
{
    public partial class Form1 : Form
    {
        private const string RootDir = "C:\\Temp\\Files";

        public Form1()
        {
            InitializeComponent();

            MaximizeBox = true;
            MinimizeBox = true;
        }

        private void bnFGetDrives_Click(object sender, EventArgs e)
        {
            var driveInfos = DriveInfo.GetDrives();
            foreach (var info in driveInfos)
            {
                var treeNode = new TreeNode(info.Name);
                var treeNodeDiskInformation = new TreeNode("Disk Details..");
                if (info.IsReady)
                {
                    treeNodeDiskInformation.Nodes.Add(info.DriveFormat);
                    treeNodeDiskInformation.Nodes.Add(info.VolumeLabel);
                    treeNodeDiskInformation.Nodes.Add(info.AvailableFreeSpace.ToString());
                    treeNodeDiskInformation.Nodes.Add(info.DriveType.ToString());
                    treeNodeDiskInformation.Nodes.Add(info.IsReady.ToString());
                    treeNodeDiskInformation.Nodes.Add(info.RootDirectory.ToString());
                    treeNodeDiskInformation.Nodes.Add(info.TotalFreeSpace.ToString());
                    treeNodeDiskInformation.Nodes.Add(info.TotalSize.ToString());

                    // WindowState: C:\Test\Test\Test.log
                    // Linux: //sdfasdf/fsadfasdf/sadf.lok

                    var directoryInfo = info.RootDirectory;
                    //var directoryInfo1 =  new DirectoryInfo(@"C:\");

                    var directories = directoryInfo.GetDirectories();

                    var treeNodeDirectories = new TreeNode("Directories");
                    foreach (var directory in directories)
                        treeNodeDirectories.Nodes.Add(new TreeNode(directory.Name));

                    var files = directoryInfo.GetFiles();
                    var treeNodeFiles = new TreeNode("Files");
                    foreach (var fileInfo in files)
                    {
                        treeNodeFiles.Nodes.Add(new TreeNode(fileInfo.Name));
                    }

                    treeNode.Nodes.Add(treeNodeDiskInformation);
                    treeNode.Nodes.Add(treeNodeDirectories);
                    treeNode.Nodes.Add(treeNodeFiles);
                }

                // File, Directory - static
                // FileInfo, DirectoryInfo - new

                tvFileSystem.Nodes.Add(treeNode);
            }
        }

        //private TreeNode GetDiskFNode()
        //{
        //    var disk = new DirectoryInfo("F:");

        //    var result = new TreeNode(disk.Name);

        //    foreach (var directoryInfo in disk.GetDirectories())
        //    {
        //        var node = GetDirectoreisAndFiles(directoryInfo);
        //        result.Nodes.Add(node);
        //    }

        //    foreach (var fileInfo in disk.GetFiles())
        //    {
        //        result.Nodes.Add(new TreeNode(fileInfo.Name));
        //    }

        //    return result;
        //}

        //private TreeNode GetDirectoreisAndFiles(DirectoryInfo directory)
        //{
        //    var result = new TreeNode(directory.Name);

        //    try
        //    {
        //        foreach (var directoryInfo in directory.GetDirectories())
        //        {
        //            var node = GetDirectoreisAndFiles(directoryInfo);
        //            result.Nodes.Add(node);
        //        }
        //        foreach (var fileInfo in directory.GetFiles())
        //        {
        //            result.Nodes.Add(new TreeNode(fileInfo.Name));
        //        }
        //    }
        //    catch(UnauthorizedAccessException){}

        //    return result;
        //    ;
        //}

        // 1 *, 2, * 3 ,4 ,5 ,6 

        public long FactCycle(int input)
        {
            long i = 1;
            long multResult = 1;
            while (i <= input)
            {
                multResult = multResult * i;
                i++;
            }

            return multResult;
        }

        //                     5, 4, 3, 2, 1
        public long Fact(int input)
        {
            if (input == 0 || input == 1)
                return 1;

            //       5   *     Fact(4) = 4 + (3 * ( 2*1));
            //       4   *     Fact(3) = 3 * (2 * 1)
            //       3   *     Fact(2) = 2 * 1
            //       2   *     Fact(1) = 1
            return input * Fact(input - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Directory.Move("C:\\Temp\\Logs", "C:\\Temp\\Logs1");
            //if (File.Exists("C:\\Temp\\Logs1\\testLogFile1.log"))
            //{
            //    File.Delete("C:\\Temp\\Logs1\\testLogFile1.log");
            //}

            //File.Copy("C:\\Temp\\Logs1\\testLogFile.log", "C:\\Temp\\Logs1\\testLogFile1.log");
            try
            {
                throw new Exception("Some exception");

                var file = new FileInfo("C:\\Temp\\Logs1\\testLogFile1.log");
                var file2 = new FileInfo("C:\\Temp\\Logs1\\testLogFile2.log");
                if (file.Exists)
                {
                    if (file2.Exists)
                        file2.Delete();

                    file.CopyTo("C:\\Temp\\Logs1\\testLogFile2.log");
                }
            }
            catch (Exception ex)
            //catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Something went wrong!: {ex.Message}");
            }
        }

        // Stream - поток с файлами, памятью и сетевым потоком для ЗАПИСИ И ЧТЕНИЯ
        // Thread - поток (нить) - распараллеливанием

        private void bnWrite_Click(object sender, EventArgs e)
        {
            var context = rtbContext.Text;
            File.AppendAllText(Path.Combine(RootDir, "Temp1.txt"), context);
        }

        private void bnRead_Click(object sender, EventArgs e)
        {
            var context = File.ReadAllText(Path.Combine(RootDir, "Temp1.txt"));

            rtbContext.Text = context;
        }

        private void bnWriteStruct_Click(object sender, EventArgs e)
        {
            //var list = new List<Person>();

            //list.Add(new Person() { Id = 1, Name = "Vasiliy", Gender = Gender.Male });
            //list.Add(new Person() { Id = 2, Name = "Nastya", Gender = Gender.Female });
            //list.Add(new Person() { Id = 3, Name = "Egor", Gender = Gender.Male });

            //var fi = new FileInfo(Path.Combine(RootDir, "Structured.data"));
            //if (fi.Exists)
            //    fi.Delete();

            //// IDisposable
            ////using (<класс, который имплементирует интерфейс IDIsposable>)
            ////{

            ////} // <= - 

            ////using (var writer = new BinaryWriter(fi.Create()))
            ////{
            ////    foreach (var person in list)
            ////    {
            ////        writer.Write(person.Id);
            ////        writer.Write(person.Name);
            ////        writer.Write(((object)person.Gender).ToString());
            ////    }
            ////}

            //using (var stream = fi.Create())
            //{
            //    var formatter = new XmlSerializer(typeof(List<Person>));
            //    formatter.Serialize(stream, list);
            //}

        }

        private void bnReadStruct_Click(object sender, EventArgs e)
        {
            var list = new List<Person>();

            var fi = new FileInfo(Path.Combine(RootDir, "Structured.data"));
            if (!fi.Exists)
            {
                MessageBox.Show($"File doess not exist: {fi.FullName}");
                return;
            }

            using (var stream = fi.OpenRead())
            {
                var formatter = new XmlSerializer(typeof(List<Person>));
                list = formatter.Deserialize(stream) as List<Person>;

                if (list != null)
                {
                    rtbContext.Text = string.Empty;
                    var sb = new StringBuilder();
                    foreach (var person in list)
                    {
                        sb.Append(person.ToString());
                    }

                    rtbContext.Text = sb.ToString();
                }
            }


            //using (var reader = new BinaryReader(fi.OpenRead()))
            //{
            //    int pos = 0;
            //    int length = (int)reader.BaseStream.Length;
            //    while (pos < length)
            //    {
            //        var person = new Person();
            //        person.Id = reader.ReadInt64();
            //        person.Name = reader.ReadString();
            //        person.Gender = Parse(reader.ReadString());
            //        pos += sizeof(long);
            //        //pos += sizeof(string);
            //        //pos += sizeof(object);
            //    }
            //}

        }

        private Gender Parse(string str)
        {
            Gender g = Gender.Unknown;
            Enum.TryParse(str, out g);
            return g;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var testPath = openFileDialog1.FileName;
                var t = testPath;
            }
            
            //using (var form = FormFabricMethod.CreateForm(TypeOfForm.SomeToolsManagement))
            //{
            //    if (form.ShowDialog() == DialogResult.OK)
            //    {
            //        // Do some shit.
            //    }
            //}

            //var fabricElements = new WindowsListFabric();
            //var fabricInstance = new Fabric(fabricElements);

            //var button = fabricInstance.CreateButton();
        }
    }

    public class D : IDisposable
    {
        public void Dispose()
        {
        }
    }
}