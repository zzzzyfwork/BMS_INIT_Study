using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BMS_INIT.Base
{
    public class Command : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            DoExecute?.Invoke(parameter);

        }

        public Action<object> DoExecute { get; set; }
        public Command(Action<object> doExecute) 
        {
            DoExecute = doExecute;

        }
        public Command() :this(null)
        {

        }
    }
}
