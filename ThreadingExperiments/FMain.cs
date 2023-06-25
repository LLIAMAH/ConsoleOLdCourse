using System.Diagnostics.PerformanceData;
using System.Threading;

namespace ThreadingExperiments
{
    public partial class FMain : Form
    {
        private List<FileWriterThread> _listThreads;

        public FMain()
        {
            InitializeComponent();
        }

        private void bnWoThread_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                lbOutput.Items.Add(i.ToString());
                Thread.Sleep(1000);
            }
        }

        private async void bnAddNumbers_Click(object sender, EventArgs e)
        {
            await Task.Run(() => Print10Numbers(lbOutput));
        }

        private void Print10Numbers(ListBox listBox)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox.Items.Add(i.ToString());
                Thread.Sleep(1000);
            }
        }

        private void bnWriteToFile_Click(object sender, EventArgs e)
        {
            var fileName = "C:\\Temp\\Threads\\TempThreadInfo.log";

            this._listThreads = new List<FileWriterThread>();
            _listThreads.Add(new FileWriterThread(fileName, 1));
            _listThreads.Add(new FileWriterThread(fileName, 2));
            _listThreads.Add(new FileWriterThread(fileName, 3));
            _listThreads.Add(new FileWriterThread(fileName, 4));
            _listThreads.Add(new FileWriterThread(fileName, 5));
            _listThreads.Add(new FileWriterThread(fileName, 6));
            _listThreads.Add(new FileWriterThread(fileName, 7));
            _listThreads.Add(new FileWriterThread(fileName, 8));
            _listThreads.Add(new FileWriterThread(fileName, 9));
            _listThreads.Add(new FileWriterThread(fileName, 10));
            _listThreads.Add(new FileWriterThread(fileName, 11));
            _listThreads.Add(new FileWriterThread(fileName, 12));
            _listThreads.Add(new FileWriterThread(fileName, 13));
            _listThreads.Add(new FileWriterThread(fileName, 14));
            _listThreads.Add(new FileWriterThread(fileName, 15));
            _listThreads.Add(new FileWriterThread(fileName, 16));
            _listThreads.Add(new FileWriterThread(fileName, 17));
            _listThreads.Add(new FileWriterThread(fileName, 18));
            _listThreads.Add(new FileWriterThread(fileName, 19));
            _listThreads.Add(new FileWriterThread(fileName, 20));

            foreach (var item in _listThreads)
                item.Start();
        }

        private void bnStopAllProcesses_Click(object sender, EventArgs e)
        {
            if(this._listThreads != null && this._listThreads.Count > 0)
                foreach(var item in _listThreads)
                    item.Stop();
        }
    }

    //public class FileWritingThreadPool
    //{
    //    // iThreadCounter

    //    public void Add(FileWriterThread thread)
    //    {

    //    }

    //    public void Start()
    //    {
    //        foreach (var item in listThreads)
    //            item.Start();
    //    }
    //}

    public class FileWriterThread
    {
        private Thread _thread;
        private readonly string _fileName;
        private readonly int _threadId;

        private static object _mutex = new object();
        public event EventHandler<EventArgs> StoppedWork;

        private bool _continueToWork = false;

        public FileWriterThread(string fileName, int threadId)
        {
            this._fileName = fileName;
            this._threadId = threadId;
        }

        public void Start()
        {
            this._continueToWork = true;
            this._thread = new Thread(Work);
            this._thread.Start();
        }

        public void Stop()
        {
            this._continueToWork = false;
        }

        private void Work()
        {
            try
            {
                long iCounter = 0;
                while (iCounter < 50 && this._continueToWork)
                {
                    lock (_mutex)
                    {
                        using (var writer = new StreamWriter(this._fileName, true))
                        {
                            writer.WriteLine($"Thread: {this._threadId}; row written - {iCounter + 1}");
                            writer.Flush();
                        }
                    }

                    iCounter++;
                    Thread.Sleep(100);
                }
            }
            catch (Exception ex)
            {
                using (var logWriter = new StreamWriter($"C:\\Temp\\Threads\\ThreadLog_{this._threadId}.log", true))
                {
                    logWriter.WriteLine(ex);
                    logWriter.Flush();
                }
            }
            finally
            {
                this.StoppedWork?.Invoke(this, EventArgs.Empty);
            }
        }

        private Action WriteToListbox(ListBox listBox, int threadId)
        {
            Action writeAction = () =>
            {
                listBox.Items.Add($"Thread {threadId} - finished.");
            };

            return writeAction;
        }
    }
}