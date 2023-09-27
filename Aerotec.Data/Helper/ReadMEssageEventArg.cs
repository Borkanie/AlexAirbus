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