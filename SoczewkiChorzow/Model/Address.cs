using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace SoczewkiChorzow.Model
{
    public class Address
    {
        public int Id { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public string NumerDomu { get; set; }
    }

    public static class AccessDataAddress
    {
        public static void Save(Address address)
        {
            try
            {
                DateBaseContext db = new DateBaseContext();
                db.Addresses.Add(address);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
            }
        }

    }
}
