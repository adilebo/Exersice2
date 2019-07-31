using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FlightSimulator.Model.Interface;
using System.Text.RegularExpressions;

namespace FlightSimulator.Model.EventArgs
{
    public class AutoPilot
    {
        //telnet for communicating with the server
        private ITelnetClient client;

        public AutoPilot()
        {
            client = TelnetClient.Instance;
        }

        //send the commands the user sent
        public void SendCommands(string commands)
        {
            string[] commandsArr = Regex.Split(commands, "\r\n");

            //do it on a different thread so the program will not stop
            new Thread(delegate () {
                foreach (string c in commandsArr)
                {
                    client.Write(c+"\r\n");
                    //wait 2 seconds between 2 commands 
                    Thread.Sleep(2000);
                }
            }).Start();
        }        
    }
}
