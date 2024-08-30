using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace supermarket.viewmodel
{
    public class Rellaycommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action action;

        public Rellaycommand(Action value)
        { 
            action = value;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            action();
        }
    }
}
