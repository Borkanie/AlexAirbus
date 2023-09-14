using Aerotec.Data.Factories;
using Aerotec.Data.Helper;
using Aerotec.Data.Interface.Services;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerotec.Data.Services
{
    public class TCPMockUpClient : IClientService
    {
        private TCPMockUpClient tcpMockUpClient;
        private ConsoleInputWatcher watcher;

        public event EventHandler<Jet3UpMessageHendlerEventArgs> Jet3UpMessageHendler;

        public TCPMockUpClient()
        {
            // In your WPF code behind or wherever you want to show the console:

            // Call AllocConsole to create a new console window
            ConsoleHelper.AllocConsole();
            watcher = new ConsoleInputWatcher(); 
            watcher.OnConsoleInputReceived += Watcher_OnConsoleInputReceived;
        }

        private void Watcher_OnConsoleInputReceived(string input)
        {
            if (input != "error")
            {
                Jet3UpMessageHendler?.Invoke(this,new Jet3UpMessageHendlerEventArgs(Resources.Jet3UpStatusMessageType.Error, input));
            }
            else
            {
                Jet3UpMessageHendler?.Invoke(this, new Jet3UpMessageHendlerEventArgs(Resources.Jet3UpStatusMessageType.Marked, input));
            }
        }

        public bool Connect(string Ip, int timeout)
        {
            if(tcpMockUpClient == null)
                tcpMockUpClient = new TCPMockUpClient();
            watcher.WriteLine("Connect method called with IP: " + Ip + " and timeout: " + timeout);
            return true;
        }

        public void ContinueWriting()
        {
            watcher.WriteLine("ContinueWriting method called");
        }

        public bool IsConnected()
        {
            watcher.WriteLine("IsConnected method called");
            return true;
        }

        public void Send(string text)
        {
            watcher.WriteLine("Send method called with text: " + text);
        }

        public void StartWriting(FontSizeEnum size, string HTZ, string signature, string ANR, string BTIDX, string controllerId, int expectedQuantity)
        {
            string message;
            message = Jet3UpMessageBuilder.Start().Create().SetSize(FontSizeEnum.ISO1_5x3).Write(HTZ, signature, ANR, BTIDX, controllerId).End();
            Send(message);
            Send("^0=CC0" + Constants.vbTab + expectedQuantity.ToString() + Constants.vbTab + "3999" + Constants.vbCrLf);
            Send("^0!EQ" + Constants.vbCrLf);
        }

        public void StopCommand()
        {
            watcher.WriteLine("StopCommand method called");
        }
    }
}
