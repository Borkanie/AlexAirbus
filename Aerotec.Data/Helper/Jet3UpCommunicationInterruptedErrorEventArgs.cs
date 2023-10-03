namespace Aerotec.Data.Helper
{
    public class Jet3UpCommunicationInterruptedErrorEventArgs : EventArgs
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
