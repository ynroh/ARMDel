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
    public class MainWindowViewModel
    {
        public ICommand OpenAddingOrderWindowCommand { get; }
        public ICommand BackToAutWindowCommand { get; }

        public MainWindowViewModel()
        {
            OpenAddingOrderWindowCommand = new DelegateCommand(OpenAddOrderWindow);
            BackToAutWindowCommand = new DelegateCommand(BackToAutWindow);
        }

        private void OpenAddOrderWindow()
        {
            var AddingOrderViewModel = new AddingOrderViewModel();
            var addingOrderWindow = new AddingOrder() { DataContext = AddingOrderViewModel };
            addingOrderWindow.Show();
        }
        private void BackToAutWindow()
        {

        }
    }
}

