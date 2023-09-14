using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerotec.Data.Helper
{
    public class ConsoleInputWatcher
    {
        public delegate void ConsoleInputEventHandler(string input);
        public event ConsoleInputEventHandler OnConsoleInputReceived;
        Thread inputThread;
        private bool isWatching;
        public ConsoleInputWatcher()
        {
            StartWatching();
        }

        public void StartWatching()
        {
            isWatching = true;

            inputThread = new Thread(WatchConsoleInput);
            inputThread.Start();
        }

        public void StopWatching()
        {
            isWatching = false;
            inputThread.Abort();
        }

        public void WriteLine(string message)
        {
            if(isWatching)
            {
                StopWatching();
                Console.WriteLine(message);
                StartWatching();
            }
            else
            {
                Console.WriteLine(message);
            }
        }

        private void WatchConsoleInput()
        {
            while (isWatching)
            {
                string input = Console.ReadLine();
                OnConsoleInputReceived?.Invoke(input);
            }
        }
    }
}
