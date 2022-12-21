using ARMDel.Presentation.View;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ARMDel.Presentation.ViewModel
{
    public class AuthorizationWindowViewModel
    {
        public ICommand OpenMainWindowCommand { get; }
        public AuthorizationWindowViewModel()
        {
            OpenMainWindowCommand = new DelegateCommand(OpenMainWindow);
        }

        private void OpenMainWindow()
        {
            var mainWindowViewModel = new MainWindowViewModel(); 
            var mainWindow = new MainWindow() { DataContext = mainWindowViewModel }; 
            mainWindow.Show(); 
        }
    }
}
