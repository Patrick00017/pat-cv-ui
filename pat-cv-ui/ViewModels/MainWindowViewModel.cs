using pat_cv_ui.Commands;
using pat_cv_ui.Models;
using pat_cv_ui.Views;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace pat_cv_ui.ViewModels
{
    public class MainWindowViewModel: BindableBase
    {
        private DelegateCommand _commandLoad = null;
        public DelegateCommand CommandLoad =>
            _commandLoad ?? (_commandLoad = new DelegateCommand(CommandLoadExecute));

        private void CommandLoadExecute()
        {
            
        }

        public 
    }
}
