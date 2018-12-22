using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using SoczewkiChorzow.Model;
namespace SoczewkiChorzow.ModelView
{
    public class UsersMV : ViewModelBase
    {
      

        private ICommand cmdEdit;
        private ICommand cmdAdd;
        private ICommand cmdRemove;

        public ICommand CmdAdd
        {
            get
            {
                if (cmdAdd == null)
                {
                    cmdAdd = new RelayCommand(x => OpenAdd());
                }
                return cmdAdd;
            }
        }

        public ICommand CmdEdit
        {
            get
            {
                if (cmdEdit == null)
                {
                    cmdEdit = new RelayCommand(x => OpenEdit(x));
                }
                return cmdEdit;
            }
        }

        public ICommand CmdRemove
        {
            get
            {
                if (cmdRemove == null)
                {
                    cmdRemove = new RelayCommand(x => OpenRemove(x));
                }
                return cmdRemove;
            }
        }

        private List<User> users = AccessDataUser.GetUsers();

        public List<User> Users
        {
            get
            {
                return users;
            }
            set
            {
                users = AccessDataUser.GetUsers();
                OnPropertyChanged("Users");
            }
        }

        private void OpenAdd()
        {
            SoczewkiChorzow.View.Userdetails userDetalist = new View.Userdetails();
            SettingConfiguration.UserSelected = -1;
            userDetalist.ShowDialog();

        }

        private void OpenEdit(object o)
        {
            DataGrid dg = (DataGrid)o as DataGrid;

            User u = (User) dg.SelectedItem as User;
            SettingConfiguration.UserSelected = (int)u.Id;
            View.Userdetails userDetalist = new View.Userdetails();
            userDetalist.ShowDialog();
        }

        private void OpenRemove(object o)
        {
            DataGrid dg = (DataGrid)o as DataGrid;
            User u = (User)dg.SelectedItem as User;
            AccessDataUser.Remove(u);            
        }
    }
}
