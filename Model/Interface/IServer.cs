using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator.Model.Interface
{
    public interface IServer
    {
        void Connect(int port, string ip);
        void Disconnect();
        string Read();
    }
}
