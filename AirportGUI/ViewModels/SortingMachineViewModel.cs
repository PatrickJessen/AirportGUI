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

        //public SortingMachine Sorter { get; }

        //public SortingMachineViewModel(int speed, Belt<Luggage> belt)
        //{
        //    Sorter = new SortingMachine(speed, belt);
        //    for (int i = 0; i < Sorter.Ports.Length; i++)
        //        Sorter.Ports[i].OnPortIsFull += SortingMachineViewModel_OnPortIsFull;
        //    Luggages = new ObservableCollection<Luggage>();
        //    Sorter.OnConsumed += Sorter_OnConsumed;
        //    Sorter.Start();
        //}

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
