namespace ConsoleAppCore.Classes
{
    public static class StaticThread
    {
        public static void ThreadTests()
        {
            var list = new List<PersonalThread>();

            var thread1 = new PersonalThread("Thread 1");
            var thread2 = new PersonalThread("Thread 2");
            var thread3 = new PersonalThread("Thread 3");
            var thread4 = new PersonalThread("Thread 4");
            var thread5 = new PersonalThread("Thread 5");
            var thread6 = new PersonalThread("Thread 6");

            thread1.WriteMessage = WriteTextMessage;
            thread2.WriteMessage = WriteTextMessage;
            thread3.WriteMessage = WriteTextMessage;
            thread4.WriteMessage = WriteTextMessage;
            thread5.WriteMessage = WriteTextMessage;


            list.Add(thread1);
            list.Add(thread2);
            list.Add(thread3);
            list.Add(thread4);
            list.Add(thread5);
            list.Add(thread6);

            foreach (var item in list)
            {
                item.Start();
            }
        }

        private static void WriteTextMessage(string processname)
        {
            Console.WriteLine($"Process [{processname}] => finished to work.");
        }
    }
}
