using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSimulator.Model.EventArgs;

namespace FlightSimulator.ViewModels
{ 
    class JoystickCommands
    {
        private VirtualJoystickEventArgs model;

        public JoystickCommands()
        {
            model = new VirtualJoystickEventArgs();
        }

        public double AlieronCommand
        {
            set
            {
                model.Aileron = value;
            }
        }

        public double ElevatorCommand
        {
            set
            {
                model.Elevator = value;
            }
        }

        public double ThrottleCommand
        {
            set
            {
                model.Throttle = value;
            }
        }

        public double RudderCommand
        {
            set
            {
                model.Rudder = value;
            }
        }

    }
}
