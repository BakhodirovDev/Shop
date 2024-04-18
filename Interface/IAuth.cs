using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Interface
{
    public interface IAuth
    {
        Users UserShowLists();
        void Register();
        bool Login(string username, string password);

        int ChangeRole(Users users, Role role);
    }
}
