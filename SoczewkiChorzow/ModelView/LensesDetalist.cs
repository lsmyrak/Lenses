using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SoczewkiChorzow.Model;
namespace SoczewkiChorzow.ModelView
{
    public class LensesDetalist : ViewModelBase
    {
        private ICommand cmdSave;
        private ICommand cmdCancel;
        public List<User> LekarzProwadzacyList { get; } = AccessDataUser.GetUsers("Lekarz Prowadzący");
        public List<User> OperatorList { get; } = AccessDataUser.GetUsers("Operator");
        public User ZalogowanyUser = AccessDataUser.GetUser(SettingConfiguration.UserID);
        // fileds
        private bool status;
        private string pacjetName;
        private string nazwaZabiegu;
        private string oko;
        private decimal cena;
        private string uwagi;
        private DateTime dataBadania;
        private User lekarzProwadzacy;
        private DateTime dataZabiegu;
        private User operator_;
        private bool kartotekaZaniesiona;
        private DateTime dataZamowienia;
        private string nazwa_moce;
        private DateTime dataDostawy;
        private string uwagiE;


        public bool Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
                OnPropertyChanged(nameof(Status));
            }

        }

        public string PacjentName
        {
            get
            {
                return pacjetName;
            }
            set
            {
                pacjetName = value;
                OnPropertyChanged(nameof(PacjentName));
            }
        }

        public string NazwaZabiegu
        {
            get
            {
                return nazwaZabiegu;
            }
            set
            {
                nazwaZabiegu = value;
                OnPropertyChanged(nameof(NazwaZabiegu));
            }
        }

        public string Oko
        {
            get
            {
                return oko;
            }
            set
            {
                oko = value;
                OnPropertyChanged(nameof(Oko));
            }
        }

        public decimal Cena
        {
            get
            {
                return cena;
            }
            set
            {
                cena = value; OnPropertyChanged(nameof(Cena));
            }
        }

        public string Uwagi
        {
            get
            {
                return uwagi;

            }
            set
            {
                uwagi = value;
                OnPropertyChanged(nameof(Cena));
            }
        }

        public DateTime DataBAdania
        {
            get
            {
                return dataBadania;
            }
            set
            {
                dataBadania = value;
                OnPropertyChanged(nameof(dataBadania));
            }
        }

        public User LekarzProwadzacy
        {
            get
            {
                return lekarzProwadzacy;
            }

            set
            {
                lekarzProwadzacy = value;
                OnPropertyChanged(nameof(lekarzProwadzacy));
            }
        }

        public DateTime DataZabiegu
        {
            get
            {
                return dataZabiegu;

            }
            set
            {
                dataZabiegu = value;
                OnPropertyChanged(nameof(DataZabiegu));
            }
        }


        public User Operator_
        {
            get
            {
                return operator_;
            }

            set
            {
                operator_ = value;
                OnPropertyChanged(nameof(Operator_));
            }
        }


        public bool KartotekaZaniesiona
        {
            get
            {
                return kartotekaZaniesiona;
            }
            set
            {
                kartotekaZaniesiona = value;
                OnPropertyChanged(nameof(KartotekaZaniesiona));
            }

        }

        public DateTime DataZamowienia
        {
            get
            {
                return dataZamowienia;

            }
            set
            {
                dataZamowienia = value;
                OnPropertyChanged(nameof(DataZamowienia));
            }
        }

        public string Nazwa_Moce
        {
            get
            {
                return nazwa_moce;

            }
            set
            {
                nazwa_moce = value;
                OnPropertyChanged(nameof(Nazwa_Moce));
            }
        }

        public DateTime DataDostawy
        {
            get
            {
                return dataDostawy;

            }
            set
            {
                dataDostawy = value;
                OnPropertyChanged(nameof(DataDostawy));
            }
        }
        public string UwagiE
        {
            get
            {
                return uwagiE;
            }
            set
            {
                uwagiE = value;
                OnPropertyChanged(nameof(UwagiE));
            }
        }

        public ICommand CmdSave
        {
            get
            {
                if (cmdSave == null)
                {
                    cmdSave = new RelayCommand(x => OpenAdd());
                }
                return cmdSave;
            }
        }

        private void OpenAdd()
        {
            Lens lens = new Lens
            {
                Cena = Cena,
                DataBadania= dataBadania,
                DataDostawyE = DataDostawy,
                DataZabiegu = DataZabiegu,
                DataZamoieniaE = DataZamowienia,
                KartotekaZaniesiona = KartotekaZaniesiona,
                LekarzProwadzacy = LekarzProwadzacy,
                NazwaMoceE = Nazwa_Moce,
                NazwaZabiegu = NazwaZabiegu,
                Oko = Oko,
                Operator = Operator_,
                PacjentName = PacjentName,
                Status = Status,
                User = ZalogowanyUser,
                Uwagi = Uwagi,
                UwagiE = UwagiE
            };
            AccessDataLens.Save(lens);
        }
    }
}
