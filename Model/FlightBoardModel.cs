using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FlightSimulator.Model.Interface;

namespace FlightSimulator.Model
{
    class FlightBoardModel : IFlightBoardModel
    {
        private IServer server;
        private bool stop;

        #region Singelton
        private static FlightBoardModel instance = null;
        private FlightBoardModel()
        {
            server = DataReaderServer.Instance;
            stop = false;
        }
        public static FlightBoardModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FlightBoardModel();
                }
                return instance;
            }
        }
        #endregion

        

        private double lon;
        public double Lon
        {
            get
            {
                return lon;
            }
            set
            {
                lon = value;
                NotifyPropertyChanged("Lon");
            }
        }
        private double lat;
        public double Lat
        {
            get
            {
                return lat;
            }
            set
            {
                lat = value;
                NotifyPropertyChanged("Lat");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Connect(int port,string ip)
        {
            server.Connect(port,ip);
            stop = false;
        }

        public void Disconnect()
        {
            server.Disconnect();
            stop = true;
        }

        public void Start()
        {
            new Thread(delegate () {
                while (!stop)
                {
                    
                    string[] data = server.Read().Split(',');
                    Console.WriteLine(data);
                    Lon = Double.Parse(data[0]);
                    Lat = Double.Parse(data[1]);
                    Thread.Sleep(100);
                }
            }).Start();
        }

        public void NotifyPropertyChanged(string propName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
