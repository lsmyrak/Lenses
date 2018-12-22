using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SoczewkiChorzow.Model;
namespace SoczewkiChorzow.ModelView
{
    public class SoczewkiMV:ViewModelBase
    {
        private ICommand cmdADM;
        private ICommand cmdAdd;
        private ICommand cmdEdit;
        private ICommand cmdRemove;
        private ICommand cmdArchivum;

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

        private void OpenAdmin()
        {
            // dopisac spr uprawnień
            new View.Admins().ShowDialog(); ;
        }
    }
}
