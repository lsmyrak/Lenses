using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace SoczewkiChorzow.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual Address Address { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public bool Status { get; set; } = true;
        public string Rola { get; set; }
        public string Uprawnienia { get; set; }
    }

    public static class AccessDataUser
    {
        public static User GetUser()
        {
            return new User();
        }

        public static User GetUser(int id)
        {
            User user = null;
            try
            {
                DateBaseContext db = new DateBaseContext();
                user = db.User.FirstOrDefault(x => x.Id == id);
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
            }
            return user;
        }

        public static void Save(User user)
        {
            try
            {
                DateBaseContext db = new DateBaseContext();
                db.User.Add(user);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
            }
        }

        public static void Update(User user)
        {
            try
            {
                DateBaseContext db = new DateBaseContext();

                User userUp = db.User.FirstOrDefault(x => x.Id == user.Id);
                userUp.Name = user.Name;
                userUp.Surname = user.Surname;
                userUp.Password = user.Password;
                userUp.Login = user.Login;
                userUp.Address = user.Address;
                userUp.Status = user.Status;
                userUp.Rola = user.Rola;
                userUp.Uprawnienia = user.Uprawnienia;

                db.SaveChanges();
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
            }
        }

        public static void Remove(User user)
        {
            try
            {
                DateBaseContext db = new DateBaseContext();
                User u = db.User.FirstOrDefault(x => x.Id == user.Id);
                u.Status = false;
                u.Password = string.Empty;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
            }
        }

        public static List<User> GetUsers()
        {
            List<User> users = null;
            try
            {
                DateBaseContext db = new DateBaseContext();
                users = db.User.ToList();
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
            }
            return users;
        }

        public static List<User> GetUsers(string type)
        {
            List<User> users = null;
            try
            {
                DateBaseContext db = new DateBaseContext();
                users = db.User.Where(x => x.Rola.Equals(type) && x.Status == true).ToList();
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
            }
            return users;
        }
    }
}
