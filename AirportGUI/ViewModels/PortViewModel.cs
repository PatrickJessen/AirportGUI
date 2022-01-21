using Airport;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace AirportGUI.ViewModels
{
    public class PortViewModel : ViewModelBase
    {
        private bool startEmptyPort;
        public bool StartEmptyPort
        {
            get { return startEmptyPort; }
            set
            {
                startEmptyPort = value;
                OnPropertyChanged(nameof(startEmptyPort));
            }
        }
        public ObservableCollection<Luggage> Luggages { get; set; }
        public Port Port { get; set; }

        public PortViewModel(int number, int capacity, int speed, Belt<Luggage> belt)
        {
            Luggages = new ObservableCollection<Luggage>();
            Port = new Port(number, capacity, speed, belt);
            Port.OnSorted += Port_OnSorted;
            Port.OnPortIsFull += Port_OnPortIsFull;
        }

        private void Port_OnPortIsFull(object? sender, EventArgs e)
        {
            Application.Current.Dispatcher.BeginInvoke(new Action(() =>
            {
                Luggages.Clear();
                StartEmptyPort = true;
                StartEmptyPort = false;
            }));
        }

        private void Port_OnSorted(object? sender, ILuggage e)
        {
            Application.Current.Dispatcher.BeginInvoke(new Action(() =>
            {
                Luggages.Add(new Luggage(new Label("", "", DateTime.Now), 3));
            }));
        }
    }
}
