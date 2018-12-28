using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SoczewkiChorzow.Model;
namespace SoczewkiChorzow.ModelView
{
    public class SoczewkiMV : ViewModelBase
    {
        private ICommand cmdADM;
        private ICommand cmdAdd;
        private ICommand cmdEdit;
        private ICommand cmdRemove;
        private ICommand cmdArchivum;

        private bool canEnable;
        private List<Lens> lens = AccessDataLens.GetLenses();

        public List<Lens> Lens
        {
            get
            {
                return lens;
            }
            set
            {
                lens = AccessDataLens.GetLenses();
                OnPropertyChanged(nameof(Lens));
            }
        }

        public ICommand CmdADM
        {
            get
            {
                if (cmdADM == null)
                {
                    cmdADM = new RelayCommand(x => OpenAdmin());
                }
                return cmdADM;
            }
        }

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

        public bool CanEnable
        {
            get
            {
                return AccessDataUser.GetPermissions(SettingConfiguration.UserID, "Administrator"); 
            }
            set
            {
                canEnable = AccessDataUser.GetPermissions(SettingConfiguration.UserID,"Administrator");
                OnPropertyChanged(nameof(CanEnable));
            }
        }

        private void OpenAdmin()
        {
            new View.Admins().ShowDialog();
        }

        private void OpenAdd()
        {
            new View.LenesDetalist().ShowDialog();
        }
    }
}
