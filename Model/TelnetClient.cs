using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator.Model
{
    class TelnetClient : Interface.ITelnetClient
    {

        private TcpClient client = null;
        private BinaryWriter writer = null;

        #region Singelton
        private static TelnetClient instance=null;
        private TelnetClient() { }
        public static TelnetClient Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TelnetClient();
                }
                return instance;
            }
        }
        #endregion

        public void Connect(string ip, int port)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ip), port);
            client = new TcpClient();
            client.Connect(ep);
            NetworkStream stream = client.GetStream();
            writer = new BinaryWriter(stream);
        }

        public void Disconnect()
        {
            client.Close();
            client = null;
            writer = null;
        }

        public void Write(string command)
        {
            writer?.Write(command);
            writer?.Flush();
        }
    }
}
