using Airport;
using AirportGUI.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AirportGUI.ViewModels
{
    public class LuggageScannerViewModel : ViewModelBase
    {
        public ObservableCollection<Luggage> Luggages { get; set; }

        public ICommand ShowItems { get; }

        public LuggageScanner Scanner { get; }

        private LuggageItemsViewModel items;

        public LuggageScannerViewModel(int speed, Belt<Luggage> belt, LuggageItemsViewModel items)
        {
            Scanner = new LuggageScanner(speed, belt);
            Scanner.OnScanned += Scanner_OnScanned;
            Luggages = new ObservableCollection<Luggage>();
            this.items = items;
            ShowItems = new ShowItemsCommand(items);
        }

        private void Scanner_OnScanned(object? sender, Luggage e)
        {
            Debug.WriteLine("start");
            Application.Current.Dispatcher.BeginInvoke(new Action(() =>
            {
                Luggages.Add(new Luggage(new Label("", "", DateTime.Now), 3));
                items.Item1 = e.Items[0];
                items.Item2 = e.Items[1];
                items.Item3 = e.Items[1];
            }));
            Debug.WriteLine("end");
        }
    }
}
