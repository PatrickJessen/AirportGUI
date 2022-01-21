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
        private Belt<Luggage> counterBelt;
        private Belt<Luggage> scannedLuggageBelt;
        private LuggageScannerViewModel luggageScanner;
        private SortingMachineViewModel sorter;
        private PortViewModel[] ports;
        private Belt<Luggage>[] portBelts;
        public MainWindow()
        {
            InitializeComponent();
            counterBelt = new Belt<Luggage>(10);
            scannedLuggageBelt = new Belt<Luggage>(10);
            portBelts = new Belt<Luggage>[3];
            for (int i = 0; i < portBelts.Length; i++)
                portBelts[i] = new Belt<Luggage>(10);
            Counter1.DataContext = new CounterViewModel(2000, 1, counterBelt);
            Counter2.DataContext = new CounterViewModel(3000, 2, counterBelt);
            Counter3.DataContext = new CounterViewModel(1500, 3, counterBelt);

            luggageItems = new LuggageItemsViewModel();
            LuggageItems.DataContext = luggageItems;
            luggageScanner = new LuggageScannerViewModel(1000, counterBelt, scannedLuggageBelt, luggageItems);
            Scanner.DataContext = luggageScanner;

            ports = new PortViewModel[3];
            sorter = new SortingMachineViewModel(1000, scannedLuggageBelt, portBelts);
            for (int i = 0; i < ports.Length; i++)
                ports[i] = new PortViewModel(i, 3, 1000, portBelts[i]);
            Port1.DataContext = ports[0];
            Port2.DataContext = ports[1];
            Port3.DataContext = ports[2];
        }
    }
}
