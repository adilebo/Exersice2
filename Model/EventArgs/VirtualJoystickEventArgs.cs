using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSimulator.Model.Interface;

namespace FlightSimulator.Model.EventArgs
{
    public class VirtualJoystickEventArgs
    {
        private ITelnetClient client;
        public VirtualJoystickEventArgs()
        {
            client = TelnetClient.Instance;
        }

        private double aileron;
        public double Aileron
        {
            get
            {
                return aileron;
            }
            set
            {
                aileron = value;
                client.Write("set /controls/flight/aileron " + aileron.ToString());
            }
        }

        private double elevator;
        public double Elevator
        {
            get
            {
                return elevator;
            }
            set
            {
                elevator = value;
                client.Write("set /controls/flight/elevator " + elevator.ToString());
            }
        }

        private double throttle;
        public double Throttle
        {
            get
            {
                return throttle;
            }
            set
            {
                throttle = value;
                client.Write("set /controls/engines/current-engine/throttle " + throttle.ToString());
            }
        }

        private double rudder;
        public double Rudder
        {
            get
            {
                return rudder;
            }
            set
            {
                rudder = value;
                client.Write("set /controls/flight/rudder " + rudder.ToString());
            }
        }
    }
}
