using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoczewkiChorzow.Model;
namespace SoczewkiChorzow.Interfaces
{
    interface IAccessDataUser
    {
        User GetUser();
        User GetUser(int Id);
        List<User> GetUsers();
        List<User> GetUsers(string type);

        void Save(User user);
        void Update(User user);
        void Remove(User user);

        bool ValidUser(string login);
        bool ValiudUSer(string login, string password);
        bool GetPermissions(int id, string permissions);
    }
}
