using Aerotec.Data.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
