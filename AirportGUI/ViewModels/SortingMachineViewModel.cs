using Airport;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AirportGUI.ViewModels
{
    public class SortingMachineViewModel
    {
        //public ObservableCollection<Luggage> Luggages { get; set; }

        public SortingMachine Sorter { get; }

        public SortingMachineViewModel(int speed, Belt<Luggage> belt, Belt<Luggage>[] portBelts)
        {
            Sorter = new SortingMachine(speed, belt, portBelts);
            Sorter.Start();
            Sorter.OnConsumed += Sorter_OnConsumed;
        }

        private void Sorter_OnConsumed(object? sender, Luggage e)
        {
            
        }

        //private void SortingMachineViewModel_OnPortIsFull(object? sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private void Sorter_OnConsumed(object? sender, Luggage e)
        //{
        //    Application.Current.Dispatcher.BeginInvoke(new Action(() =>
        //    {
        //        Luggages.Add(new Luggage(new Label("", "", DateTime.Now), 3));
        //    }));
        //}
    }
}
