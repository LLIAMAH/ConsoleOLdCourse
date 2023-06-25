using System.Text;

namespace NetworkExperiments.TcpClasses
{
    public static class StreamReaderConvertor
    {
        // byte[1024] = { "some useful info", \0, \0, \0, \0, \0, \0, ... }
        public static string Convert(byte[] inputArray, int length)
        {
            var array = new byte[length];
            Array.Copy(inputArray, array, length);
            return Encoding.UTF8.GetString(array);
        }
    }
}
