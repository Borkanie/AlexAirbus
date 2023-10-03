using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerotec.Data.Helper
{
    public class Jet3UpCommunicationInterruptedErrorEventArgs :  EventArgs
    {
        public Exception Exception { get; }

        public bool ErrorWhenReading { get; }

        public Jet3UpCommunicationInterruptedErrorEventArgs(Exception error, bool errorWhenReading)
        {
            Exception = error;
            ErrorWhenReading = errorWhenReading;
        }
    }
}
