namespace UnZipper.Classes
{
    public interface IPushToList
    {
        void Push(FileInfo[] fileInfos);
    }

    public class PushToList : IPushToList
    {
        private readonly ListBox _listBox;

        public PushToList(ListBox listBox)
        {
            this._listBox = listBox;
        }

        public void Push(FileInfo[] fileInfos)
        {
            foreach (var fileInfo in fileInfos)
                this._listBox.Items.Add(fileInfo);
        }
    }
}
