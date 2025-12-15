using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pat_cv_ui.models
{
    public class UserManager
    {
        public static ObservableCollection<User> _databaseUsers = new ObservableCollection<User>() { 
            new User() { Name="patrick", Email="742679653@qq.com" },
            new User() { Name="huanghao", Email="742679653@gmail.com" }
        };

        public static ObservableCollection<User> getUsers() { return _databaseUsers; }

        public static void addUser(User user)
        {
            _databaseUsers.Add(user);
        }
    }
}
