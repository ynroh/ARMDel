using ARMDel.Domain.Entities;
using ARMDel.Domain.UseCases;
using ARMDel.Presentation.View;
using Prism.Commands;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ARMDel.Presentation.ViewModel
{
    public class AuthorizationViewModel: BaseViewModel
    {
        
        private readonly AuthorizationInteractor authorizationInteractor = new AuthorizationInteractor();

        private string login;
        private string password;
        private string message;
        public string Message
        {
            get { return message; }
            set 
            { 
                message = value; 
                OnPropertyChanged("Message");
            }
        }
        public string Login
        {
            get { return login; }
            set
            {
                login = value;
                OnPropertyChanged("Login");
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }
        public ICommand AuthorizeCommand { get; }

        public AuthorizationViewModel()
        {
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
        private async void Authorize()
        {
            //ВРЕМЕННО
            TESTDATA TESTDATA = new TESTDATA();
            TESTDATA.MakeFakeData();
            //ВРЕМЕННО
            try
            {
               await Task.Run(() => authorizationInteractor.TryAuthorize(Login, Password));
                if (typeof(Operator).IsInstanceOfType(DataManager.currentUser))
                    OpenMainWindow();
                if (typeof(Admin).IsInstanceOfType(DataManager.currentUser))
                OpenAdminMenu();
            }
            catch (AuthorizeException e)
            {
                Message = e.Message;
            }
        }

    }
}
