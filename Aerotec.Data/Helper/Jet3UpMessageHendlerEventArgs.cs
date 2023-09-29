// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

using Aerotec.Data.Resources;

namespace Aerotec.Data.Helper
{
    public class Jet3UpMessageHendlerEventArgs : EventArgs
    {
        public Jet3UpMessageHendlerEventArgs(Jet3UpStatusMessageType type, string message)
        {
            Type = type;
            Message = message;
        }
        public string Message { get; }
        public Jet3UpStatusMessageType Type { get; }
    }
}
