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
        private UserViewModel userViewModel;

        public Command(Action<object> execute, Predicate<object> canExecute)
        {
            this._execute = execute;
            this._canExecute = canExecute;
        }
        public Command(UserViewModel userViewModel)
        {
            this.userViewModel = userViewModel;
        }
        public bool CanExecute(object parameter)
        {
            if (_canExecute != null)
            {
                return _canExecute(parameter);
            }
            return true;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public void Execute(object parameter)
        {
            userViewModel.QueryData();
            if (_execute != null)
            {
                _execute(parameter);
            }
        }
    }
}
