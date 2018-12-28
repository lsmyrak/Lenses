using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using SoczewkiChorzow.Model;
namespace SoczewkiChorzow.ModelView
{
    public class LogowanieMV : ViewModelBase
    {
        private ICommand cmdLogin;
        private ICommand cmdCanel;

        private string login;
        private string password;

        public ICommand CmdLogin
        {
            get
            {
                if (cmdLogin == null)
                {
                    cmdLogin = new RelayCommand(x => OpenLogin());
                }
                return cmdLogin;
            }
        }

        public ICommand CmdCancel
        {
            get
            {
                if (cmdCanel == null)
                {
                    cmdCanel = new RelayCommand(x => OpenCancel());
                }
                return cmdCanel;
            }
        }

        public string LoginMV
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
                OnPropertyChanged(nameof(LoginMV));
            }
        }

        public string PasswordMV
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged(nameof(PasswordMV));
            }
        }

        private void OpenLogin()
        {
            SettingConfiguration.UserID = AccessDataUser.ValidUser(LoginMV, PasswordMV);

            if (SettingConfiguration.UserID != -1)
            {                
                MainWindow ms = new MainWindow();
                ms.Show();

            }
            else
            {
                MessageBox.Show("Błędny login lub hasło");
            }

        }

        private void OpenCancel()
        {
            Environment.Exit(0);
        }
    }
}
