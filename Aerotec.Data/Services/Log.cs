using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Aerotec.Data.Services
{
    public static class Log
    {
        private static bool DEBUG = false;
        private static string file = "Log.txt";
        public static void Write(string text)
        {
            if(!DEBUG)
            {
                if (!File.Exists(file))
                {
                    File.Create(file);
                }
                try
                {
                    using (StreamWriter sw = new StreamWriter(file, true))
                    {
                        // true argument specifies that we want to append to the file
                        sw.WriteLine(text);
                    }
                }
                catch (Exception e)
                {
                }
            }            
        }
    }
}
