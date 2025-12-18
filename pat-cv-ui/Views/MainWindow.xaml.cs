using System.Windows;
using System.Windows.Controls;

namespace pat_cv_ui.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public MainViewModel mainViewModel { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            // mainViewModel = new MainViewModel();
            // this.DataContext = mainViewModel;
        }

        private void DataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
        //    User user = sender as User;
        //    mainViewModel.SelectedUser(user);
        }
    }
}