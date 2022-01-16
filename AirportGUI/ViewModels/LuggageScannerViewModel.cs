using Airport;
using AirportGUI.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AirportGUI.ViewModels
{
    public class LuggageScannerViewModel
    {
        public ObservableCollection<Luggage> Luggages { get; set; }

        public ICommand ShowItems { get; }

        public LuggageScanner Scanner { get; }

        public LuggageScannerViewModel(int speed, Belt<Luggage> belt, LuggageItemsViewModel items)
        {
            Scanner = new LuggageScanner(speed, belt);
            Luggages = new ObservableCollection<Luggage>();
            Luggages.Add(new Luggage(new Label("", "", DateTime.Now), 3));
            ShowItems = new ShowItemsCommand(items);
        }
    }
}
