using FlightSimulator.Model;
using FlightSimulator.Model.Interface;
using FlightSimulator.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FlightSimulator.ViewModels
{
    class LeftCommands
    {
        private ICommand settingCommand;
        public ICommand SettingCommand
        {
            get
            {
                return settingCommand ?? (settingCommand = new CommandHandler(() => SettingsClick()));
            }
        }
        private void SettingsClick()
        {
            SettingsWindow s = new SettingsWindow();
            s.DataContext = new Windows.SettingsWindowViewModel(ApplicationSettingsModel.Instance);
            s.ShowDialog();
        }
        private ICommand connectCommand;
        public ICommand ConnectCommand
        {
            get
            {
                return connectCommand ?? (connectCommand = new CommandHandler(() => ConnectClick()));
            }

        } 
        private void ConnectClick()
        {
            ISettingsModel settings = ApplicationSettingsModel.Instance;
            DataReaderServer.Instance.Connect(settings.FlightInfoPort, "127.0.0.1");
            TelnetClient.Instance.Connect(settings.FlightServerIP,settings.FlightCommandPort);
            FlightBoardModel.Instance.Start();
        }

    }
}
