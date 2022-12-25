using ARMDel.Data.Repository;
using ARMDel.Domain.UseCases;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ARMDel.Presentation.ViewModel
{
    public class AddingOperatorViewModel: BaseViewModel
    {
        AddingOperatorRepository operatorRepository = new AddingOperatorRepository();
        AddingOperatorInteractor operatorInteractor = new AddingOperatorInteractor();

        #region PROPERTYS   
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

        private string surname;

        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                OnPropertyChanged("Surname");
            }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        private string middleName;

        public string MiddleName
        {
            get { return middleName; }
            set
            {
                middleName = value;
                OnPropertyChanged("MiddleName");
            }
        }

#endregion
        public ICommand AddOperarorCommand { get;set; }

        public AddingOperatorViewModel()
        {
            AddOperarorCommand = new DelegateCommand(TryAddOperaror);
        }

        private void TryAddOperaror()
        {
            try
            {
                AddOperaror();
                MessageBox.Show("Оператор добавлен");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddOperaror()
        {
            string name = operatorInteractor.CreateName(Surname, Name, MiddleName);
            Login = operatorRepository.GenerateLogin(Surname, Name, MiddleName);
            Password = operatorRepository.GeneratePass();
            operatorInteractor.AddOperator(name, Login, Password);
        }
    }
}
