using Airport;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace AirportGUI.ViewModels
{
    public class CounterViewModel
    {
        public ObservableCollection<Luggage> Luggages { get; set; }
        private Counter counter;
        private Belt<Luggage> belt;
        public CounterViewModel(int speed, int number, Belt<Luggage> belt)
        {
            Random rand = new Random();
            this.belt = belt;
            counter = new Counter(speed, number, belt);
            Luggages = new ObservableCollection<Luggage>();
            Luggages.Add(new Luggage(new Label("", "", DateTime.Now), 3));

            counter.OnProduced += Counter_OnProduced;
            Thread t = new Thread(counter.Produce);
            t.Start();
        }

        private void Counter_OnProduced(object? sender, EventArgs e)
        {
            Application.Current.Dispatcher.BeginInvoke(new Action(() =>
            {
                Luggages.Add(belt.Items[belt.Items.Length - 1]);               
            }));
        }
    }
}
