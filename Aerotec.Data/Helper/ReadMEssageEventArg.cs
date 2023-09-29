// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

namespace Aerotec.Data.Helper
{
    public class ReadMEssageEventArg : EventArgs
    {
        public string Text { get; }
        public ReadMEssageEventArg(string text)
        {
            Text = text;
        }
    }
}