// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

using Aerotec.Data.Factories;
using Aerotec.Data.Helper;
using Aerotec.Data.Interface.Services;
using Microsoft.VisualBasic;
using System.Net.Sockets;
using System.Text;

namespace Aerotec.Data.Services
{
    public class TCPClientService : IClientService
    {
        private int expectedQuantity = 0;
        private TcpClient client;
        private NetworkStream tcpClientStream;
        // CancellationTokenSource to allow task cancellation
        private CancellationTokenSource? cancellationTokenSource;
        public event EventHandler<Jet3UpMessageHendlerEventArgs> Jet3UpMessageHendler;
        public event EventHandler<Jet3UpCommunicationInterruptedErrorEventArgs> Jet3UpCommunicationInterrupted;

        public bool Connect(string Ip, int port)
        {
            client = new TcpClient(Ip, port);
            tcpClientStream = client.GetStream();
            tcpClientStream.ReadTimeout = 2000;
            return true;
        }

        public void ContinueWriting()
        {
            Send("^0!GO");
        }

        public bool IsConnected()
        {
            return client != null;
        }

        public void Send(string text, bool final = false)
        {
            Log.Write(text);
            if (IsConnected())
            {
                byte[] SENDBYTES = Encoding.ASCII.GetBytes(text + Constants.vbCrLf);
                try
                {
                    lock (client)
                    {
                        _ = client.Client.Send(SENDBYTES);
                    }
                }
                catch (Exception ex)
                {
                    Jet3UpCommunicationInterrupted?.Invoke(this, new Jet3UpCommunicationInterruptedErrorEventArgs(ex, true));
                }

            }
        }

        public void StartWriting(FontSizeEnum size,int rotation,MachineTypeEnum machine, string HTZ, string signature, string ANR, string BTIDX, string controllerId, int expectedQuantity, string? anzahl)
        {
            this.expectedQuantity = expectedQuantity;
            string message;
            Send("^0!RC");
            var jet3upMessageBuilder = Jet3UpMessageBuilder.Start().Create().SetSize(size, rotation, machine);
            
            message = (anzahl == null) ? jet3upMessageBuilder.Write(HTZ, signature, ANR, BTIDX, controllerId).End():
                jet3upMessageBuilder.Write(HTZ, signature, ANR, BTIDX, controllerId, anzahl).End();

            Send(message);
            Send("^0=CC0" + Constants.vbTab + expectedQuantity.ToString() + Constants.vbTab + "3999");
            Send("^0!GO");
            StartListening();
        }

        public void StopListening()
        {
            cancellationTokenSource?.Cancel();
            cancellationTokenSource = null;
        }

        public void StopCommand()
        {
            StopListening();
            Send("^0!ST");
        }

        public void StartListening()
        {
            if (IsConnected())
            {
                if (cancellationTokenSource == null)
                {
                    // Create a CancellationTokenSource for task cancellation
                    cancellationTokenSource = new CancellationTokenSource();
                    _ = Task.Run(() => ListenForResponses(cancellationTokenSource.Token));
                }
            }
        }

        private void ListenForResponses(CancellationToken cancellationToken)
        {
            Thread.Sleep(2000);
            byte[] buffer = new byte[15 + NumberOfDigitsInInt(expectedQuantity)]; // Adjust the buffer size as needed
            try
            {
                while (true)
                {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        return;
                    }
                    Thread.Sleep(250);

                    int bytesRead = AskForCurrentIndex(ref buffer);
                    if (bytesRead > 0)
                    {
                        string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        // Process the response here
                        // You can raise an event or do whatever is necessary with the response data
                        if (cancellationToken.IsCancellationRequested)
                        {
                            return;
                        }
                        int val = int.Parse(response.Split('C')[2].Split('\t')[0]);
                        if (val < expectedQuantity)
                        {
                            ContinueWriting();
                        }
                        Jet3UpMessageHendler?.Invoke(this, new Jet3UpMessageHendlerEventArgs(Resources.Jet3UpStatusMessageType.Marked, response.Split('C')[2].Split('\t')[0]));
                    }

                }
            }
            catch (Exception ex)
            {
                Jet3UpCommunicationInterrupted?.Invoke(this, new Jet3UpCommunicationInterruptedErrorEventArgs(ex, false));
            }
        }

        private int NumberOfDigitsInInt(int expectedQuantity)
        {
            int result = 0;
            while (expectedQuantity > 0)
            {
                expectedQuantity = expectedQuantity / 10;
                result++;
            }
            return result;
        }

        private int AskForCurrentIndex(ref byte[] buffer)
        {
            int bytesRead;
            string getCurrentIndex = "^0?CC";
            Send(getCurrentIndex);
            lock (client)
            {
                bytesRead = tcpClientStream.Read(buffer, 0, buffer.Length);
            }

            return bytesRead;
        }
    }
}
