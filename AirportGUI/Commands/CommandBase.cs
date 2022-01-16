using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AirportGUI.Commands
{
    // Helper class for ICommand
    public abstract class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged;

        // Sets the default of CanExecute to true. can be overriden
        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        // Exceutes ones a button binded to it is pressed.
        public abstract void Execute(object parameter);

        // Invokes CanExecuteChanged EventHandler.
        protected void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
