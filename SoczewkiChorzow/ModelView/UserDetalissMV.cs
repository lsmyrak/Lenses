using SoczewkiChorzow.Model;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
namespace SoczewkiChorzow.ModelView
{
    public class UserDetalissMV : ViewModelBase
    {
        User user;
        Address address;
        public UserDetalissMV()
        {

            if (SettingConfiguration.UserSelected != -1)
            {
                user = AccessDataUser.GetUser(SettingConfiguration.UserSelected);
                address = user.Address;
            }
            else
            {
                user = new User();
                address = new Address();
            }

        }


        private ICommand cmdCanncel;
        private ICommand cmdSave;
        private List<string> roleList = new List<string>
        {
            "Operator","Administrator","User"
        };

        public string Name
        {
            get
            {
                return user.Name;
            }
            set
            {
                user.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Surname
        {
            get
            {
                return user.Surname;
            }
            set
            {
                user.Surname = value;
                OnPropertyChanged(nameof(Surname));
            }
        }
        public string Login
        {
            get
            {
                return user.Login;
            }
            set
            {
                user.Login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        public string Password
        {
            get
            {
                return user.Password;
            }
            set
            {
                user.Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public bool Status
        {
            get
            {
                return user.Status;
            }
            set
            {
                user.Status = value;
                OnPropertyChanged(nameof(Status));
            }
        }

        public string Rola
        {
            get
            {
                return user.Rola;
            }
            set
            {
                user.Rola = value;
                OnPropertyChanged(nameof(Rola));
            }
        }

        public string Uprawnienia
        {
            get
            {
                return user.Uprawnienia;
            }
            set
            {
                user.Uprawnienia = value;
                OnPropertyChanged(nameof(Uprawnienia));
            }
        }

        public string Miasto
        {
            get
            {
                return address.Miasto;
            }
            set
            {
                address.Miasto = value;
                OnPropertyChanged(nameof(Miasto));
            }
        }

        public string Ulica
        {
            get
            {
                return address.Ulica;
            }
            set
            {
                address.Ulica = value;
                OnPropertyChanged(nameof(Ulica));
            }
        }

        public string NumerDomu
        {
            get
            {
                return address.NumerDomu;
            }
            set
            {
                address.NumerDomu = value;
                OnPropertyChanged(nameof(NumerDomu));
            }
        }

        public List<string> RoleList
        {
            get
            {
                return roleList;
            }
            set
            {
                roleList = value;
                OnPropertyChanged(nameof(RoleList));
            }
        }

        public List<string> UprawnieniaList { get; } = new List<string>(){   "Administrator","Operator","Zamawiajacy"
        };

        public ICommand CmdCanncel
        {
            get
            {
                if (cmdCanncel == null)
                {
                    cmdCanncel = new RelayCommand(x => Cancel(x));
                }
                return cmdCanncel;
            }
        }

        public ICommand CmdSave
        {
            get
            {
                if (cmdSave == null)
                {
                    cmdSave = new RelayCommand(x => Save());
                }
                return cmdSave;
            }
        }

        private void Save()
        {

            user.Address = address;

            if (SettingConfiguration.UserSelected == -1)
                AccessDataUser.Save(user);
            else
                AccessDataUser.Update(user);

            Name = string.Empty;
            Surname = string.Empty;
            Login = string.Empty;
            Password = string.Empty;
            Status = false;
            Rola = string.Empty;
            Uprawnienia = string.Empty;
            Miasto = string.Empty;
            Ulica = string.Empty;
            NumerDomu = string.Empty;
        }



        private void Cancel(object o)
        {
            SettingConfiguration.UserSelected = -1;
            Window w = (Window)o as Window;
            w.Close();
        }
    }
}
