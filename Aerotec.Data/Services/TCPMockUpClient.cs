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
        private FileInterface fileInterface;

        public event EventHandler<Jet3UpMessageHendlerEventArgs> Jet3UpMessageHendler;

        public TCPMockUpClient()
        {
            fileInterface = new FileInterface();
            fileInterface.TextReaderEvent += FileInterface_TextReaderEvent;
        }

        private void FileInterface_TextReaderEvent(object? sender, ReadMEssageEventArg e)
        {
            
            if (e.Text.Contains("error"))
            {
                Jet3UpMessageHendler?.Invoke(this, new Jet3UpMessageHendlerEventArgs(Resources.Jet3UpStatusMessageType.Error, "error"));
                return;
            }
            if(e.Text.Contains("write"))
            {
                Jet3UpMessageHendler?.Invoke(this, new Jet3UpMessageHendlerEventArgs(Resources.Jet3UpStatusMessageType.Marked, "one more"));
                return;
            }
            Jet3UpMessageHendler?.Invoke(this, new Jet3UpMessageHendlerEventArgs(Resources.Jet3UpStatusMessageType.Done, "done"));
        }

        public bool Connect(string Ip, int timeout)
        {
            if(tcpMockUpClient == null)
                tcpMockUpClient = new TCPMockUpClient();
            fileInterface.Write("Connect method called with IP: " + Ip + " and timeout: " + timeout);
            return true;
        }

        public void ContinueWriting()
        {
            fileInterface.Write("ContinueWriting method called");
        }

        public bool IsConnected()
        {
            fileInterface.Write("IsConnected method called");
            return true;
        }

        public void Send(string text, bool final = false)
        {
            fileInterface.Write("Send method called with text: " + text);
            if(final)
            {
                fileInterface.FinalizeReading();            
            }
        }

        public void StartWriting(FontSizeEnum size, string HTZ, string signature, string ANR, string BTIDX, string controllerId, int expectedQuantity)
        {
            string message;
            message = Jet3UpMessageBuilder.Start().Create().SetSize(FontSizeEnum.ISO1_5x3).Write(HTZ, signature, ANR, BTIDX, controllerId).End();
            Send(message);
            Send("^0=CC0" + Constants.vbTab + expectedQuantity.ToString() + Constants.vbTab + "3999" + Constants.vbCrLf);
            Send("^0!EQ" + Constants.vbCrLf);
            fileInterface.StartReading(expectedQuantity);
        }

        public void StopCommand()
        {
            fileInterface.StopReading();
            fileInterface.Write("StopCommand method called");
        }
    }
}
