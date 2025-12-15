using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace pat_cv_ui.commands
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action<Object> _excute { get; set; }
        private Predicate<Object> _canExcute { get; set; }

        public RelayCommand(Action<Object> excuteMethod, Predicate<Object> canExcuteMethod) {
            _excute = excuteMethod;
            _canExcute = canExcuteMethod;
        }

        public bool CanExecute(object? parameter)
        {
            return _canExcute(parameter);
        }

        public void Execute(object? parameter)
        {
            _excute(parameter);
        }
    }
}
