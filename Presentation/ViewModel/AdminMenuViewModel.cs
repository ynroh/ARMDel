using ARMDel.Domain.Entities;
using ARMDel.Presentation.View;
using ARMDel.Presentation.View.Admin;
using ARMDel.Presentation.ViewModel;
using Prism.Commands;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ARMDel.Presentation.ViewModel
{
    public class AdminMenuViewModel: BaseViewModel
    {
        public string AdminName { get; }
        public ICommand OpenAddOperatorWinCommand { get; }
        
        public AdminMenuViewModel()
        {
            AdminName = DataManager.currentUser.Name;
            OpenAddOperatorWinCommand = new DelegateCommand(OpenAddOperatorWin);
        }

        private void OpenAddOperatorWin()
        {
            var AddingOperatorViewModel = new AddingOperatorViewModel();
            var addingOperator = new AddingOperator() { DataContext = AddingOperatorViewModel };
            addingOperator.Show();
        }
    }
}
