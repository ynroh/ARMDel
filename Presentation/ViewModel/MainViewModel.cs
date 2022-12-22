using ARMDel.Presentation.View;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ARMDel.Presentation.ViewModel
{
    public class MainViewModel
    {
        public ICommand OpenAddingOrderWindowCommand { get; }

        public MainViewModel()
        {
            OpenAddingOrderWindowCommand = new DelegateCommand(OpenAddOrderWindow);
        }

        private void OpenAddOrderWindow()
        {
            var AddingOrderViewModel = new AddingOrderViewModel();
            var addingOrderWindow = new AddingOrder() { DataContext = AddingOrderViewModel };
            addingOrderWindow.Show();
        }
    }
}

