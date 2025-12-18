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
        public services.IUserStore _userStore = null;

        public ObservableCollection<User> Users { get; private set; } = 
            new ObservableCollection<User>();

        public ICommand ShowWindowCommand { get; set; }
        public ICommand AddUserCommand { get; set; }

        private DelegateCommand _commandLoad = null;
        public DelegateCommand CommandLoad =>
            _commandLoad ?? (_commandLoad = new DelegateCommand(CommandLoadExecute));

        private void CommandLoadExecute()
        {
            Users.Clear();
            List<User> users = _userStore.GetAll();
            foreach (User user in users)
                Users.Add(user);
        }

        public string? NameWait2Add { get; set; }
        public string? EmailWait2Add { get; set; }

        public MainWindowViewModel(services.IUserStore userStore) 
        {
            //Users = UserManager.getUsers();

            // inject
            _userStore = userStore;

            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
            AddUserCommand = new RelayCommand(AddUser, CanAddUser);
        }

        public void SelectedUser(User user)
        {
            NameWait2Add = user.Name;
            EmailWait2Add = user.Email;
        }

        private bool CanShowWindow(object obj) {  return true; }
        private void ShowWindow(object obj)
        {
            var mainWindow = obj as Window;
            Greeting greetingWin = new Greeting();
            greetingWin.Owner = mainWindow;
            greetingWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            greetingWin.Show();
        }

        private bool CanAddUser(object obj) { return true; }
        private void AddUser(object obj)
        {
            if (NameWait2Add != null && EmailWait2Add != null)
            {
                Users.Add(new User() { Name = NameWait2Add, Email = EmailWait2Add });
            }
        }
    }
}
