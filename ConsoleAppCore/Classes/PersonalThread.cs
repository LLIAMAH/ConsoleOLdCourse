namespace ConsoleAppCore.Classes
{
    public delegate void WriteEndMessage(string processName);

    public class PersonalThread : IDisposable
    {
        private readonly Thread _thread;
        private readonly string _name;
        private static readonly object _mutex = new();

        public WriteEndMessage WriteMessage;

        public PersonalThread(string threadName)
        {
            this._name = threadName;
            _thread = new Thread(Work);
        }

        private void Work()
        {
            for (var i = 0; i < 1_000; i++)
            {
                lock (_mutex)
                {
                    using (var sw = new StreamWriter("testThreads.txt", true))
                    {
                        sw.WriteLine($"Thread: {this._name}, item: {i + 1}");
                    }
                }
                Thread.Sleep(20);
            }

            lock (_mutex)
            {
                WriteMessage?.Invoke(_name);
                //WriteMessage(_name);
            }
        }

        public void Start()
        {
            this._thread.Start();
        }

        public void Dispose() { }
    }
}
