using AirportGUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportGUI.Commands
{
    public class ShowItemsCommand : CommandBase
    {
        private LuggageItemsViewModel items;
        public ShowItemsCommand(LuggageItemsViewModel items)
        {
            this.items = items;
        }

        public override void Execute(object parameter)
        {
            items.IsVisible = !items.IsVisible;
        }
    }
}
