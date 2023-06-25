using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NetworkExperiments.TcpClasses
{
    public interface ITcpController : IDisposable
    {
        EndPoint RemoteEndPoint { get; }
        Task<string> ReadAsync();

        Task WriteAsync(string message);
    }

    public class TcpController : ITcpController
    {
        private const int BufferSize = 1024;
        private readonly TcpClient _client;
        private readonly NetworkStream _stream;

        public EndPoint RemoteEndPoint => this._client.Client.RemoteEndPoint;

        public TcpController(TcpClient client)
        {
            this._client = client;
            this._stream = this._client.GetStream();
        }

        public async Task<string> ReadAsync()
        {
            var data = new byte[BufferSize];
            var result = await this._stream.ReadAsync(data, 0, BufferSize);
            var message = StreamReaderConvertor.Convert(data, result);
            return message;
        }

        public async Task WriteAsync(string message)
        {
            var dataToSend = Encoding.UTF8.GetBytes(message);
            await this._stream.WriteAsync(dataToSend, 0, dataToSend.Length);
        }

        public void Dispose()
        {
            this._stream?.Close();
            this._stream?.Dispose();
            this._client?.Close();
            this._client?.Dispose();
        }
    }
}
