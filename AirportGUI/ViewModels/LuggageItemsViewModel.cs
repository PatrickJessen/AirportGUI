using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGUI.ViewModels
{
    public class LuggageItemsViewModel : ViewModelBase
    {
        private string item1;
        public string Item1
        {
            get { return item1; }
            set
            {
                item1 = value;
                OnPropertyChanged(nameof(item1));
            }
        }
        private string item2;
        public string Item2
        {
            get { return item2; }
            set
            {
                item2 = value;
                OnPropertyChanged(nameof(item2));
            }
        }
        private string item3;
        public string Item3
        {
            get { return item3; }
            set
            {
                item3 = value;
                OnPropertyChanged(nameof(item3));
            }
        }

        private string visibility;
        public string Visibility
        {
            get { return visibility; }
            set
            {
                visibility = value;
                OnPropertyChanged(nameof(visibility));
            }
        }

        private bool isVisible;
        public bool IsVisible
        {
            get
            {
                return isVisible;
            }
            set
            {
                isVisible = value;
                if (isVisible == true)
                    Visibility = "Visible";
                else
                    Visibility = "Hidden";
            }
        }

        public LuggageItemsViewModel()
        {
            Visibility = "Hidden";
        }
    }
}
