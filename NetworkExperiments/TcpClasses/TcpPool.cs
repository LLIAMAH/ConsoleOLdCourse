using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkExperiments.TcpClasses
{
    public interface ITcpPool : IDisposable
    {
        bool Add(ITcpController controller);
        Task Work();
    }

    public class TcpPool : ITcpPool
    {
        private readonly IList<ITcpController> _controllers;

        public TcpPool()
        {
            this._controllers = new List<ITcpController>();
        }

        public bool Add(ITcpController controller)
        {
            if (!AlreadyContains(controller))
            {
                this._controllers.Add(controller);
                return true;
            }

            return false;
        }

        private bool AlreadyContains(ITcpController controller)
        {
            return _controllers.Any(tcpController => controller.RemoteEndPoint == tcpController.RemoteEndPoint);
        }

        public async Task Work()
        {
            var continueWork = true;
            while (continueWork)
            {
                foreach (var tcpController in this._controllers)
                {
                    var message = await tcpController.ReadAsync();

                    await PushMessageWrite(tcpController, message);
                    if(message.StartsWith("STOP"))
                        continueWork = false;
                }

                Thread.Sleep(10);
            }
        }

        private async Task PushMessageWrite(ITcpController messageSource, string message)
        {
            foreach (var controller in this._controllers)
            {
                await controller.WriteAsync(
                    $"Server response from ({messageSource.RemoteEndPoint}): {message}");
            }
        }

        public void Dispose()
        {
            foreach (var tcpController in this._controllers)
            {
                tcpController.Dispose();
            }

            this._controllers.Clear();
        }
    }
}
