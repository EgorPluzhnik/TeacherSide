using System;
using System.Windows.Input;

namespace vrstud.test
{
    public class DelegateCommand : ICommand
    {
        private readonly Func<object, bool> _canExecuteAction;
        private readonly Action<object> _executeAction;

        public DelegateCommand(Action<object> executeAction, Func<object, bool> canExecuteAction)
        {
            _executeAction = executeAction;
            _canExecuteAction = canExecuteAction;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecuteAction?.Invoke(parameter) ?? true;
        }

        public void Execute(object parameter)
        {
            _executeAction(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void InvokeCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}