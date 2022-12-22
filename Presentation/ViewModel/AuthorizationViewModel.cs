using ARMDel.Domain.Entities;
using ARMDel.Domain.UseCases;
using ARMDel.Presentation.View;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ARMDel.Presentation.ViewModel
{
    public class AuthorizationViewModel: BaseViewModel
    {
        AuthorizationInteractor authorizationInteractor = new AuthorizationInteractor();
        Operator oper = new Operator("vur","Name", "Password");

        private string login;
        public string Login
        {
            get { return login; }
            set
            {
                login = value;
                OnPropertyChanged("Login");
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        public ICommand OpenMainWindowCommand { get; }
        public ICommand OpenAdminMenuCommand { get; }
        public ICommand AuthorizeCommand { get; }

        public AuthorizationViewModel()
        {
            OpenMainWindowCommand = new DelegateCommand(OpenMainWindow);
            OpenAdminMenuCommand = new DelegateCommand(OpenAdminMenu);
            AuthorizeCommand = new DelegateCommand(Authorize);
        }

        private void OpenMainWindow()
        {
            var mainWindowViewModel = new MainViewModel(); 
            var mainWindow = new MainWindow() { DataContext = mainWindowViewModel }; 
            mainWindow.Show(); 
        }
        private void OpenAdminMenu()
        {
            var adminMenuViewModel = new AdminMenuViewModel();
            var adminMenu = new AdminMenu() { DataContext = adminMenuViewModel };
            adminMenu.Show();
        }
        private void Authorize()
        {
            DataManager.AddOperator(oper);
            authorizationInteractor.TryAuthorize(Login, Password);
            if (typeof(Operator).IsInstanceOfType(DataManager.currentUser))
                OpenMainWindow();

        }

    }
}
