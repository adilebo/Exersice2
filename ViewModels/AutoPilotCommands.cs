using FlightSimulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FlightSimulator.Model.EventArgs;

namespace FlightSimulator.ViewModels
{
    class AutoPilotCommands : BaseNotify
    {
        private String content = "";
        private bool isSend = false;
        private AutoPilot model = new AutoPilot();

        public String CurrBackground
        {
            get
            {
                if (content != "")
                {
                    if (!isSend)
                    {
                        return "Pink";

                    }
                    isSend = false;
                }
                return "White";
            }
        }

        public String Content
        {
            get { return content; }

            set
            {
                content = value;
                NotifyPropertyChanged("Content");
                NotifyPropertyChanged("CurrBackground");
            }
        }
        
        private ICommand clearCommand;
        public ICommand ClearCommand
        {
            get { 
                      return clearCommand ?? (clearCommand = new CommandHandler(() => ClearClick()));
                }

            }
        private void ClearClick()
        {
            content = "";
            NotifyPropertyChanged("Content");
            NotifyPropertyChanged("CurrBackground");
        }

        
        private ICommand okCommand;
        public ICommand OkCommand
        {
            get
            {
                return okCommand ?? (okCommand = new CommandHandler(() => OKClick()));
            }
        }
        
        private void OKClick()
        {
            model.SendCommands(content);
            isSend = true;
            NotifyPropertyChanged("CurrBackground");
        }
    }
}
