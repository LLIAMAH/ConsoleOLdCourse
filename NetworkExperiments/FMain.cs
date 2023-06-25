using System.Net;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;
using NetworkExperiments.TcpClasses;

namespace NetworkExperiments
{
    public partial class FMain : Form
    {
        private const int BufferSize = 1024;

        private const int listeningPort = 43000;
        private const int clientPort = 43001;
        private readonly IPEndPoint _ipEndPoint;

        // Here is UDP communication classes
        private UdpClient _serverUdp;
        private UdpClient _clientUdp;

        // Here is TCP communication classes
        private const int tcpListeningPort = 43005;
        private const int tcpClientPort = 43006;

        private TcpListener _serverTcp;
        private TcpClient _clientTcp;
        private TcpClient _clientTcp2;

        public static ManualResetEvent connectDone = new ManualResetEvent(false);
        public static ManualResetEvent connectDone2 = new ManualResetEvent(false);

        public FMain()
        {
            InitializeComponent();

            // 127.0.0.1
            var ipAddressListeners = IPAddress.Any;
            this._ipEndPoint = new IPEndPoint(ipAddressListeners, listeningPort);
            this._serverUdp = new UdpClient(this._ipEndPoint);

            var ipAddressClients = IPAddress.Parse("127.0.0.1");
            var localEndpoint = new IPEndPoint(ipAddressClients, clientPort);
            this._clientUdp = new UdpClient(localEndpoint);


            var tcpListenerEndPoint = new IPEndPoint(ipAddressListeners, tcpListeningPort);
            this._serverTcp = new TcpListener(tcpListenerEndPoint);

            this._clientTcp = new TcpClient(AddressFamily.InterNetwork);
            this._clientTcp2 = new TcpClient(AddressFamily.InterNetwork);
        }

        #region UDP
        private void bnListenUDP_Click(object sender, EventArgs e)
        {
            this._serverUdp.BeginReceive(new AsyncCallback(ServerReceiveCallback), this._serverUdp);
        }

        private void ServerReceiveCallback(IAsyncResult ar)
        {
            var localEndPoint = new IPEndPoint(IPAddress.Any, listeningPort);

            byte[] buffer = _serverUdp.EndReceive(ar, ref localEndPoint);
            var message = Encoding.UTF8.GetString(buffer);
            UpdateCrossThread(lbResultsUDP, $"(Server) Received packet ({localEndPoint}): {message}");

            if (!message.Equals("STOP"))
                _serverUdp.BeginReceive(new AsyncCallback(ServerReceiveCallback), _serverUdp);
        }

        private void UpdateCrossThread(ListBox listBox, string message)
        {
            if (listBox.InvokeRequired)
                listBox.Invoke(new Action(() => listBox.Items.Add(message)));
            else
                listBox.Items.Add(message);
        }

        private void bnSendUDP_Click(object sender, EventArgs e)
        {
            var messageToSend = tbMessageUDP.Text;
            if (!string.IsNullOrEmpty(messageToSend))
            {
                var bytes = Encoding.UTF8.GetBytes(messageToSend);

                var sentToEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), listeningPort);

                this._clientUdp.BeginSend(bytes, bytes.Length,
                    sentToEndPoint, new AsyncCallback(SendCallback),
                    this._clientUdp);

                tbMessageUDP.Clear();
            }


            var threadSocket = new ThreadingSocket();
            threadSocket.SetMessage(messageToSend);
            threadSocket.Start();
        }

        private void SendCallback(IAsyncResult ar)
        {
            UdpClient u = (UdpClient)ar.AsyncState;
            UpdateCrossThread(lbResultsUDP, $"Number of bytes sent: {u.EndSend(ar)}");
        }
        #endregion


        private async void bnListenTCP_Click(object sender, EventArgs e)
        {
            this._serverTcp.Start();
            var continueToWork = true;

            //var remoteClient = await this._serverTcp.AcceptTcpClientAsync();

            //if (remoteClient.Connected)
            //{
            //    var remoteClientStream = remoteClient.GetStream();

            //    var bufferRead = new byte[BufferSize];
            //    await remoteClientStream.ReadAsync(bufferRead, 0, BufferSize);

            //    var messageRead = Encoding.UTF8.GetString(bufferRead);
            //    UpdateCrossThread(lbResultsTCP, $"Message received: {messageRead}");

            //    var messageSent = "Data received";
            //    var bufferWrite = Encoding.UTF8.GetBytes(messageSent);

            //    await remoteClientStream.WriteAsync(bufferWrite, 0, bufferWrite.Length);

            //    remoteClientStream.Close();
            //    remoteClient.Close();
            //}

            await Task.Run(async () =>
            {
                ITcpPool pool = new TcpPool();
                try
                {
                    while (true)
                    {
                        var client = await this._serverTcp.AcceptTcpClientAsync();
                        var controller = new TcpController(client) as ITcpController;

                        pool.Add(controller);

                        await pool.Work();
                        Thread.Sleep(10);
                    }
                }
                catch (Exception ex)
                {
                    UpdateCrossThread(lbResultsTCP, ex.Message);
                }
                finally
                {
                    pool?.Dispose();
                }
            });
        }

        private async void bnConnectTcp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this._clientTcp.Connected)
                    await this._clientTcp.ConnectAsync(IPAddress.Parse("127.0.0.1"), tcpListeningPort);
            }
            catch (Exception ex)
            {
                UpdateCrossThread(lbResultTCP2, ex.Message);
            }
        }

        private async void bnSendTCP_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this._clientTcp.Connected)
                    UpdateCrossThread(lbResultsTCP, "Client was not connected. Press Connect button.");

                var stream = this._clientTcp.GetStream();
                var message = tbMessageTCP.Text;
                if (!string.IsNullOrEmpty(message))
                {
                    var data = Encoding.UTF8.GetBytes(message);
                    await stream.WriteAsync(data, 0, data.Length);
                }

                var readingBuffer = new byte[BufferSize];
                var result = await stream.ReadAsync(readingBuffer, 0, BufferSize);
                if (result > 0)
                {
                    message = StreamReaderConvertor.Convert(readingBuffer, result);
                    UpdateCrossThread(lbResultsTCP, message);
                }

                tbMessageTCP.Clear();
            }
            catch (Exception ex)
            {
                UpdateCrossThread(lbResultsTCP, ex.Message);
            }
        }

        private async void bnConnectTcp2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this._clientTcp2.Connected)
                    await this._clientTcp2.ConnectAsync(IPAddress.Parse("127.0.0.1"), tcpListeningPort);
            }
            catch (Exception ex)
            {
                UpdateCrossThread(lbResultTCP2, ex.Message);
            }
        }

        private async void bnSendTcp2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this._clientTcp2.Connected)
                    UpdateCrossThread(lbResultTCP2, "Client was not connected. Press Connect button.");

                var stream = this._clientTcp2.GetStream();
                var message = tbMessageTcp2.Text;
                if (!string.IsNullOrEmpty(message))
                {
                    var data = Encoding.UTF8.GetBytes(message);
                    await stream.WriteAsync(data, 0, data.Length);
                }

                var readingBuffer = new byte[BufferSize];
                var result = await stream.ReadAsync(readingBuffer, 0, BufferSize);
                if (result > 0)
                {
                    message = StreamReaderConvertor.Convert(readingBuffer, result);
                    UpdateCrossThread(lbResultTCP2, message);
                }

                tbMessageTcp2.Clear();
            }
            catch (Exception ex)
            {
                UpdateCrossThread(lbResultTCP2, ex.Message);
            }
        }
    }

    public class ThreadingSocket
    {
        private Thread _thread;
        private Socket _socket;
        private string _message;

        public void Start()
        {
            this._socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            this._thread = new Thread(Work);
            this._thread.Start();
        }

        private void Work()
        {
            var bytes = Encoding.UTF8.GetBytes(this._message);
            this._socket.Send(bytes, SocketFlags.None);
        }

        public void SetMessage(string messageToSend)
        {
            this._message = messageToSend;
        }
    }
}