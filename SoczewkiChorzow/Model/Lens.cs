using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace SoczewkiChorzow.Model
{
    public class Lens
    {
        public int Id { get; set; }
        public bool Status { get; set; } = true;
        public virtual User User { get; set; }

        public string PacjentName { get; set; }
        public string NazwaZabiegu { get; set; }
        public string Oko { get; set; }
        public decimal Cena { get; set; }
        public string Uwagi { get; set; }
        public DateTime DataBadania { get; set; }
        public virtual User LekarzProwadzacy { get; set; } // <-
        public DateTime DataZabiegu { get; set; }
        public virtual User Operator { get; set; } //<-
        public bool KartotekaZaniesiona { get; set; }

        public DateTime DataZamoieniaE { get; set; }
        public string NazwaMoceE { get; set; }
        public DateTime DataDostawyE { get; set; }
        public string UwagiE { get; set; }
    }

    public static class AccessDataLens
    {
        public static Lens GetLens()
        {
            return new Lens();
        }

        public static Lens GetLens(int Id)
        {
            Lens lens = null;
            try
            {
                DateBaseContext db = new DateBaseContext();
                lens = db.Lens.FirstOrDefault(x => x.Id == Id);
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
            }
            return lens;
        }

        public static List<Lens> GetLenses()
        {
            List<Lens> listLens = null;
            try
            {
                DateBaseContext db = new DateBaseContext();
                listLens = db.Lens.Where(x => x.Status == true).ToList();
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
            }
            return listLens;
        }

        public static void Save(Lens l)
        {
            
            try
            {
                DateBaseContext db = new DateBaseContext();
                var operator_ = db.User.FirstOrDefault(x => x.Id == l.Operator.Id);
                var lekarzPr = db.User.FirstOrDefault(x => x.Id == l.LekarzProwadzacy.Id);
                var user = db.User.FirstOrDefault(x => x.Id == l.User.Id);
                Lens lens = new Lens
                {
                    DataBadania = l.DataBadania,
                    DataDostawyE = l.DataDostawyE,
                    DataZabiegu = l.DataZabiegu,
                    Cena = l.Cena,
                    DataZamoieniaE = l.DataZamoieniaE,
                    KartotekaZaniesiona = l.KartotekaZaniesiona,
                    LekarzProwadzacy = lekarzPr,
                    NazwaMoceE = l.NazwaMoceE,
                    NazwaZabiegu = l.NazwaZabiegu,
                    Oko = l.Oko,
                    Operator = operator_,
                    PacjentName = l.PacjentName,
                    Status = l.Status,
                    Uwagi = l.Uwagi,
                    UwagiE = l.UwagiE,
                    User = user,
                };
                
                db.Lens.Add(lens);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
            }
        }

        public static void Update(Lens lens)
        {
            try
            {
                DateBaseContext db = new DateBaseContext();
                Lens lensUp = db.Lens.FirstOrDefault(x => x.Id == lens.Id);

                lensUp.Id = lens.Id;
                lensUp.Status = lens.Status;
                lensUp.User = lens.User;
                lensUp.PacjentName = lens.PacjentName;
                lensUp.NazwaZabiegu = lens.NazwaZabiegu;
                lensUp.Oko = lens.Oko;
                lensUp.Cena = lens.Cena;
                lensUp.Uwagi = lens.Uwagi;
                lensUp.DataBadania = lens.DataBadania;
                lensUp.LekarzProwadzacy = lens.LekarzProwadzacy;
                lensUp.DataZabiegu = lens.DataZabiegu;
                lensUp.Operator = lens.Operator;
                lensUp.KartotekaZaniesiona = lens.KartotekaZaniesiona;
                lensUp.DataZamoieniaE = lens.DataDostawyE;
                lensUp.NazwaMoceE = lens.NazwaMoceE;
                lensUp.DataDostawyE = lens.DataDostawyE;
                lensUp.UwagiE = lens.UwagiE;

                db.SaveChanges();
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
            }
        }
        public static void UpdateE(int Id, DateTime DataZamowieniaE, string Nazwa_MoceE, DateTime DataDostayE, string UwagiE)
        {
            Lens lens = null;
            try
            {
                DateBaseContext db = new DateBaseContext();
                lens = db.Lens.FirstOrDefault(x => x.Id == Id);

                lens.DataZamoieniaE = DataZamowieniaE;
                lens.NazwaMoceE = Nazwa_MoceE;
                lens.DataDostawyE = DataDostayE;
                lens.UwagiE = UwagiE;

                db.SaveChanges();
            }
            catch (Exception e)
            {
                ExceptionDispatchInfo.Capture(e).Throw();
            }
        }
    }
}

