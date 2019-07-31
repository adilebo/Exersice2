using FlightSimulator.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using FlightSimulator.Model;

namespace FlightSimulator.ViewModels
{
    public class FlightBoardViewModel : BaseNotify
    {
        private IFlightBoardModel model;

        public FlightBoardViewModel()
        {
            model = FlightBoardModel.Instance;
            model.PropertyChanged += Model_PropertyChanged;
        }

        private void Model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("Lon"))
            {
                Lon = model.Lon;
            }
            if (e.PropertyName.Equals("Lat"))
            {
                Lat = model.Lat;
            }
        }

        public void Start()
        {
            model.Start();
        }

        public void Connect(int port, string ip)
        {
            model.Connect(port, ip);
        }

        public void Disconnect()
        {
            model.Disconnect();
        }

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
    }
}

