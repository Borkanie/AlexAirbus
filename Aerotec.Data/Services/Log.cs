namespace Aerotec.Data.Services
{
    public static class Log
    {
        public static bool DEBUG = false;
        private static string file = "Log.txt";
        public static void Write(string text)
        {
            if (DEBUG)
            {
                if (!File.Exists(file))
                {
                    _ = File.Create(file);
                }

                try
                {
                    using (StreamWriter sw = new(file, true))
                    {
                        // true argument specifies that we want to append to the file
                        sw.WriteLine(text);
                    }
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
