using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library
{
    public class Command:ICommand
    {
        Action<Object> _execute;
        Predicate<Object> _canExecute;

        public Command(Action<object> execute, Predicate<object> canExecute)
        {
            this._execute = execute;
            this._canExecute = canExecute;
        }
    }
}
