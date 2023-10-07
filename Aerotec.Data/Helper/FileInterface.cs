// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

namespace Aerotec.Data.Helper
{
    internal class FileInterface
    {
        private readonly string inputPath = Environment.CurrentDirectory + "\\" + "jet3up.in";
        private readonly string outputPath = Environment.CurrentDirectory + "\\" + "jet3up.out";
        private int lastLine = 0;
        public FileInterface()
        {
            if (!File.Exists(outputPath))
            {
                File.Create(outputPath).Close();
            }
            if (!File.Exists(inputPath))
            {
                throw new ArgumentException("No input file");
            }
        }
        // CancellationTokenSource to allow task cancellation
        private CancellationTokenSource? cancellationTokenSource;
        public void StopReading()
        {
            // Signal cancellation to the task
            cancellationTokenSource?.Cancel();
            cancellationTokenSource = null;
        }

        private void ReadLines(CancellationToken cancellationToken, int quantity)
        {
            try
            {
                int count = 0;
                using (StreamReader sr = new(inputPath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Check for cancellation request
                        if (cancellationToken.IsCancellationRequested)
                            break;

                        lastLine++;
                        TextReaderEvent?.Invoke(this, new ReadMEssageEventArg((++count).ToString()));
                        Thread.Sleep(1000);

                        if (lastLine == quantity)
                        {
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Handle exceptions if needed
            }
        }

        public void StartReading(int quantity)
        {
            if (!Reading)
            {
                // Create a CancellationTokenSource for task cancellation
                cancellationTokenSource = new CancellationTokenSource();
                lastLine = 0;
                _ = Task.Run(() => ReadLines(cancellationTokenSource.Token, quantity));
            }
        }

        public event EventHandler<ReadMEssageEventArg> TextReaderEvent;

        public void Write(string text)
        {
            try
            {
                using (StreamWriter sw = new(outputPath, true))
                {
                    // true argument specifies that we want to append to the file
                    sw.WriteLine(text);
                }
            }
            catch (Exception)
            {
            }
        }

        internal void FinalizeReading()
        {
            if (!Reading)
            {
                StartReading(1);
            }
        }

        public bool Reading
        {
            get { return cancellationTokenSource != null && !cancellationTokenSource.IsCancellationRequested; }
        }
    }
}
