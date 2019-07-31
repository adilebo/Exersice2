using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlightSimulator.Model.Interface
{
    public interface IFlightBoardModel:INotifyPropertyChanged
    {
        double Lon { get; set; }
        double Lat { get; set; }
        void Connect(int port, string ip);
        void Disconnect();
        void Start();
    }
}
