using Aerotec.Data.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerotec.Data.Interface.Services
{
    public interface IClientService
    {
        public bool Connect(string Ip, int timeout);

        public void Send(string text);

        public void StartWriting(FontSizeEnum size,string HTZ, string signature, string ANR, string BTIDX, string controllerId, int expectedQuantity);

        public void ContinueWriting();

        public bool IsConnected();

        public void StopCommand();
    }
}
