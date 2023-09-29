// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

using Aerotec.Data.Helper;

namespace Aerotec.Data.Interface.Services
{
    public interface IClientService
    {
        public bool Connect(string Ip, int timeout);

        public void Send(string text, bool final = false);

        public void StartWriting(FontSizeEnum size, string HTZ, string signature, string ANR, string BTIDX, string controllerId, int expectedQuantity);

        public void ContinueWriting();

        public bool IsConnected();

        public void StopCommand();

        public event EventHandler<Jet3UpMessageHendlerEventArgs> Jet3UpMessageHendler;
    }
}
