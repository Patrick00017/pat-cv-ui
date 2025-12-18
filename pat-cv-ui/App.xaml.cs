using Example;
using pat_cv_ui.Utils;
using pat_cv_ui.Views;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace pat_cv_ui
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            var w = Container.Resolve<MainWindow>();
            return w;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<services.IUserStore, services.UserStore>();
        }
    }

}
