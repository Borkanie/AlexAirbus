using Aerotec.Data.Factories;
using Aerotec.Data.Helper;
using Aerotec.Data.Interface.Services;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aerotec.Data.Services
{
    public class TCPClientService : IClientService
    {
        private string HTZ = "";
        private string signature = "";
        private string ANR = "";
        private string BTIDX = "";
        private string controllerId = "";
        private int expectedQuantity = 0;
        private int current = 0;

        private FontSizeEnum fontSizeEnum;
        private TcpClient client;
        private NetworkStream tcpClientStream;
        public bool Connect(string Ip, int timeout)
        {
            client = new TcpClient(Ip, timeout);
            tcpClientStream = client.GetStream();
            return true;
        }

        public void ContinueWriting()
        {
            
        }

        public bool IsConnected()
        {
            return client != null;
        }

        public void Send(string text)
        {
            if(IsConnected())
            {
                byte[] SENDBYTES = Encoding.ASCII.GetBytes(text);
                client.Client.Send(SENDBYTES);
            }            
        }
        private string GetFinalMessage()
        {
            DateTime currentDate = DateTime.Now;
            var formattedDate = currentDate.ToString("dd/MM/yyyy");

            return formattedDate + $" Anzahl Soll:{expectedQuantity} Ist:{current}";
        }
        public void StartWriting(FontSizeEnum size,string HTZ, string signature, string ANR, string BTIDX, string controllerId, int expectedQuantity)
        {
            this.HTZ = HTZ;
            this.signature = signature;
            this.ANR = ANR;
            this.BTIDX = BTIDX;
            this.controllerId = controllerId;
            this.fontSizeEnum = size;
            this.expectedQuantity = expectedQuantity;

            string message;
            message = Jet3UpMessageBuilder.Start().Create().SetSize(FontSizeEnum.ISO1_5x3).Write(HTZ, signature, ANR, BTIDX, controllerId).End();            
            Send(message);            
            Send("^0=CC0" + Constants.vbTab + expectedQuantity.ToString() + Constants.vbTab + "3999" + Constants.vbCrLf);
            Send("^0!EQ" + Constants.vbCrLf);
        }

        public void StopCommand()
        {
            
        }
    }
}
