using Aerotec.Data.Helper;
using Aerotec.Data.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerotec.Data.Services
{
    public class TCPMockUpClient : IClientService
    {
        public bool Connect(string Ip, int timeout)
        {
            return true;
        }

        public void ContinueWriting()
        {
            
        }

        public bool IsConnected()
        {
            return true;
        }

        public void Send(string text)
        {
            
        }

        public void StartWriting(FontSizeEnum size, string HTZ, string signature, string ANR, string BTIDX, string controllerId, int expectedQuantity)
        {
            
        }

        public void StopCommand()
        {
            
        }
    }
}
