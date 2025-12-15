using pat_cv_ui.commands;
using pat_cv_ui.models;
using pat_cv_ui.views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace pat_cv_ui.viewmodels
{
    public class MainViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public ICommand ShowWindowCommand { get; set; }
        public ICommand AddUserCommand { get; set; }

        public string? NameWait2Add { get; set; }
        public string? EmailWait2Add { get; set; }

        public MainViewModel() {
            Users = UserManager.getUsers();
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
                UserManager.addUser(new User() { Name = NameWait2Add, Email = EmailWait2Add });
            }
        }
    }
}
