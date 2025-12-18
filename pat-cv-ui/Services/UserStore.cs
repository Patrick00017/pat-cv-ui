using pat_cv_ui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pat_cv_ui.services
{
    public interface IUserStore
    {
        List<User> GetAll();
    }

    class UserStore : IUserStore
    {
        public List<User> GetAll()
        {
            return new List<User>() {
                new User() { Name="patrick", Email="742679653@qq.com" },
                new User() { Name="huanghao", Email="742679653@gmail.com" }
            };
        }
    }
}
