using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using SoczewkiChorzow.Interfaces;
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

        public override string ToString()
        {
            return Name + " " + Surname;
        }
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

        public static bool ValidUser(string login)
        {
            bool retVal = false;
            User user = null;
            try
            {
                DateBaseContext db = new DateBaseContext();
                user = db.User.FirstOrDefault(x => x.Login.Equals(login));
                if (user == null)
                {
                    retVal = true;
                }
                else
                {
                    retVal = false;
                }
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
            }
            return retVal;
        }

        public static int ValidUser(string login, string password)
        {
            int retVal = -1;
            User user = null;            
            try
            {
                DateBaseContext db = new DateBaseContext();
                user = db.User.FirstOrDefault(x => x.Login.Equals(login) && x.Password.Equals(password) && x.Status==true);
                if (user!=null)
                {
                    retVal = user.Id;
                }
                else
                {
                    retVal = -1;
                }
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
            }
            return retVal;
        }

        public static bool GetPermissions(int Id, string uprawninie)
        {
            bool retVal = false;
            User user = null;
            try
            {
                DateBaseContext db = new DateBaseContext();
                user = db.User.FirstOrDefault(x => x.Id==Id && x.Uprawnienia.Equals(uprawninie) && x.Status == true);
                if (user != null)
                {
                    retVal = true;
                }
                else
                {
                    retVal = false;
                }
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
            }
            return retVal;
        }
    }
}
