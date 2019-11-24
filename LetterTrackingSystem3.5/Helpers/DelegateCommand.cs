using System;
using System.Windows.Input;

namespace HospitalManagementSystem.Helpers
{

    public class DelegateCommand : ICommand
    {
        public delegate void MyDelegate(object parameters);
        private readonly Action _command;
        private readonly MyDelegate _commandParameterized;
        private readonly Func<bool> _canExecute;
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public DelegateCommand(Action command, Func<bool> canExecute = null)
        {
            if (command == null)
                throw new ArgumentNullException();
            _canExecute = canExecute;
            _command = command;
        }
        public DelegateCommand(MyDelegate command, Func<bool> canExecute = null)
        {
            if (command == null)
                throw new ArgumentNullException();
            _canExecute = canExecute;
            _commandParameterized = command;
        }


        public void Execute(object parameter)
        {


            if (parameter != null)
            {
                _commandParameterized(parameter);
            }
            else
            {
                _command();
            }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute();
        }

    }

}