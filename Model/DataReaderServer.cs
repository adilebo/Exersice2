using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using FlightSimulator.Model.Interface;

namespace FlightSimulator.Model
{
    public class DataReaderServer : IServer
    {
        private TcpListener listener;
        private TcpClient client;
        private StreamReader reader;

        #region Singelton
        private DataReaderServer()
        {
            listener = null;
            client = null;
            reader = null;
        }
        private static DataReaderServer instance = null;
        public static DataReaderServer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataReaderServer();
                }
                return instance;
            }
        }

        #endregion

        public void Connect(int port, string ip)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ip), port);
            listener = new TcpListener(ep);
            listener.Start();            client = listener.AcceptTcpClient();
            reader = new StreamReader(client.GetStream());
        }

        public void Disconnect()
        {
            client.Close();
            listener.Stop();
        }

        public string Read()
        {
            return reader.ReadLine();
        }
    }
}
