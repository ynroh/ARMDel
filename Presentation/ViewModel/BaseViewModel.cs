using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Presentation.ViewModel
{
    public class BaseViewModel: INotifyPropertyChanged
    {
        public string this[string columnName] => throw new NotImplementedException();

        public string Error => throw new NotImplementedException();

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
