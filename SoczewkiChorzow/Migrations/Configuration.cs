namespace SoczewkiChorzow.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Runtime.ExceptionServices;
    using SoczewkiChorzow.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<SoczewkiChorzow.Model.DateBaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SoczewkiChorzow.Model.DateBaseContext db)
        {
            try
            { 
                db = new DateBaseContext();
                User userAdmin = db.User.FirstOrDefault(x => x.Login.Equals("Admin"));
                if (userAdmin != null)
                {
                    db.User.Remove(userAdmin);
                }
                Address address = new Address()
                {
                    Miasto = "Sosnowiec",
                    Ulica = "Kaliska",
                    NumerDomu = "43/28"
                };

                User u = new User()
                {
                    Login = "Admin",
                    Password = "toor",
                    Rola = "Administrator",
                    Uprawnienia = "Administrator",
                    Name = "£ukasz",
                    Surname = "Smyrak",
                    Status = true,
                    Address = address
                };
                db.User.Add(u);
                db.SaveChanges();
            }

            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
            }
        }
    }
}
