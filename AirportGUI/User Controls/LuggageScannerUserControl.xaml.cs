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

namespace AirportGUI.User_Controls
{
    /// <summary>
    /// Interaction logic for SortingMachineUserControl.xaml
    /// </summary>
    public partial class LuggageScannerUserControl : UserControl
    {
        public LuggageScannerUserControl()
        {
            InitializeComponent();
        }

        private void DoubleAnimation_Completed(object sender, EventArgs e)
        {
            ((LuggageScannerViewModel)(this.DataContext)).Luggages.RemoveAt(0);
        }
    }
}
