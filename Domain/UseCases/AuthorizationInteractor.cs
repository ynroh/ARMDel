using ARMDel.Domain.Entities;
using ARMDel.Data.Repository;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Domain.UseCases
{
    public class AuthorizationInteractor
    {
        
        AutorizationRepository autorizationRepository = new AutorizationRepository();
        private string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
       
        public void TryAuthorize(string inputLogin, string inputPassword)
        {
            if (inputLogin == null)
                throw new AuthorizeException("Введите логин!");
            if (inputPassword == null)
                throw new AuthorizeException("Введите пароль!");
            bool IsLoginTrue = false;
            int index = 0;
            int usersCount = DataManager.AllUsers.Count;
            string passwordHash = GetHash(inputPassword);

            for (int i = 0; i < usersCount; i++)
                if (DataManager.AllUsers[i].Login == inputLogin)
                {
                    IsLoginTrue = true;
                    index = i;
                }

            if (IsLoginTrue == false)
                    throw new AuthorizeException("Несуществующий логин");
            else if (!(DataManager.AllUsers[index].Password == passwordHash))
                throw new AuthorizeException("Неверный пароль");
            else  autorizationRepository.Authorize(DataManager.AllUsers[index]);
        }
    }
    
    class AuthorizeException : Exception
    {
        public AuthorizeException(string message)
            : base(message) { }
    }
}

