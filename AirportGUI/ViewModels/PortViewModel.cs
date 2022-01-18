using Airport;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGUI.ViewModels
{
    public class PortViewModel
    {
        public ObservableCollection<Luggage> Luggages { get; set; }
        public Port Port { get; set; }

        public PortViewModel(int number, int capacity)
        {
            Port = new Port(number, capacity);
        }
    }
}
