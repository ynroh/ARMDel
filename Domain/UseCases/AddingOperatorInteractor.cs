using ARMDel.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ARMDel.Domain.UseCases
{
    public class AddingOperatorInteractor
    {
        AddingOperatorRepository operatorRepository = new AddingOperatorRepository();
        public string CreateName(string Surname, string Name, string MiddleName)
        {
            if (Surname == "")
                throw new Exception("Введите фамилию!");
            else if (Name == "")
                throw new Exception("Введите имя!");
            else if (MiddleName == "")
                throw new Exception("Введите Отчество!");
            else
            {
                foreach (var s in Surname)
                    if (!(s >= 'а' && s <= 'я' || s >= 'А' && s <= 'Я'))
                        throw new Exception("Фамилия может содержать только буквы русского алфавита!");
                foreach (var n in Name)
                    if (!(n >= 'а' && n <= 'я' || n >= 'А' && n <= 'Я'))
                        throw new Exception("Имя может содержать только буквы русского алфавита!");
                foreach (var n in MiddleName)
                    if (!(n >= 'а' && n <= 'я' || n >= 'А' && n <= 'Я'))
                        throw new Exception("Отчество может содержать только буквы русского алфавита!");
            }
            return operatorRepository.CreateName(Surname, Name, MiddleName);
        }
        public void AddOperator(string name, string login, string pass)
        { 
            if(name == "")
                throw new ArgumentNullException("name");
            else if (login == "")
                throw new ArgumentNullException("login");
            else if (pass == "")
                throw new ArgumentNullException("password");

            operatorRepository.AddOPerator(name, login, pass);
        }
    }
}
