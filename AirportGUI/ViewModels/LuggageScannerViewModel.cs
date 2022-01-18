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
        private string suspectLuggageText;
        public string SuspectLuggageText
        {
            get { return suspectLuggageText; }
            set
            {
                suspectLuggageText = value;
                OnPropertyChanged(nameof(suspectLuggageText));
            }
        }
        public ObservableCollection<Luggage> Luggages { get; set; }

        public ICommand ShowItems { get; }

        public LuggageScanner Scanner { get; }

        private LuggageItemsViewModel items;

        public LuggageScannerViewModel(int speed, Belt<Luggage> belt, Belt<Luggage> scannedBelt, LuggageItemsViewModel items)
        {
            Scanner = new LuggageScanner(speed, belt, scannedBelt);
            Scanner.OnScanned += Scanner_OnScanned;
            Scanner.OnScanning += Scanner_OnScanning;
            Scanner.OnSuspectLuggageFound += Scanner_OnSuspectLuggageFound;
            Luggages = new ObservableCollection<Luggage>();
            this.items = items;
            ShowItems = new ShowItemsCommand(items);
        }

        private void Scanner_OnSuspectLuggageFound(object? sender, Luggage e)
        {
            SuspectLuggageText = "SUSPECT LUGGAGE FOUND!";
        }

        private void Scanner_OnScanning(object? sender, Luggage e)
        {
            SuspectLuggageText = "";
        }

        private void Scanner_OnScanned(object? sender, Luggage e)
        {
            //SuspectLuggageText = "";
            Application.Current.Dispatcher.BeginInvoke(new Action(() =>
            {
                Luggages.Add(new Luggage(new Label("", "", DateTime.Now), 3));
                items.Item1 = e.Items[0];
                items.Item2 = e.Items[1];
                items.Item3 = e.Items[1];
            }));
        }
    }
}
