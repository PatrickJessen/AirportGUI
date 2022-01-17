using AirportGUI.User_Controls;
using AirportGUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Airport;
using System.Threading;

namespace AirportGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LuggageItemsViewModel luggageItems;
        private SortingMachineViewModel sorter;
        private Belt<Luggage> belt;
        private LuggageScannerViewModel luggageScanner;
        public MainWindow()
        {
            InitializeComponent();
            belt = new Belt<Luggage>(10);
            //Counter1.DataContext = new CounterViewModel(2000, 1, belt);
            Counter2.DataContext = new CounterViewModel(3000, 2, belt);
            //Counter3.DataContext = new CounterViewModel(1500, 3, belt);

            luggageItems = new LuggageItemsViewModel();
            LuggageItems.DataContext = luggageItems;
            luggageScanner = new LuggageScannerViewModel(1000, belt, luggageItems);
            Scanner.DataContext = luggageScanner;
            //luggageScanner.Scanner.OnScanned += Scanner_OnScanned;

            SorterMachine1.DataContext = new SortingMachineViewModel(2000, belt);
            SorterMachine2.DataContext = new SortingMachineViewModel(2000, belt);
            SorterMachine3.DataContext = new SortingMachineViewModel(2000, belt);
        }

        //private void Scanner_OnScanned(object? sender, Luggage e)
        //{
        //    //Application.Current.Dispatcher.BeginInvoke(new Action(() =>
        //    //{
        //        luggageScanner.Luggages.Add(e);
        //    //}));
        //    luggageItems.Item1 = e.Items[0];
        //    luggageItems.Item2 = e.Items[1];
        //    luggageItems.Item3 = e.Items[2];
        //}
    }
}
