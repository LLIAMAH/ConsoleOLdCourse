using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NetworkExperiments
{
    public partial class FMain : Form
    {
        private const int listeningPort = 43000;
        private const int clientPort = 43001;
        private readonly IPEndPoint _ipEndPoint;

        private UdpClient _serverUdp;
        private UdpClient _clientUdp;

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
        }

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
        }

        private void SendCallback(IAsyncResult ar)
        {
            UdpClient u = (UdpClient)ar.AsyncState;
            UpdateCrossThread(lbResultsUDP, $"Number of bytes sent: {u.EndSend(ar)}");
        }
    }
}