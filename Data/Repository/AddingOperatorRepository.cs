using ARMDel.Domain.Entities;
using System;
using System.Text;
using System.Security.Cryptography;

namespace ARMDel.Data.Repository
{
    public class AddingOperatorRepository
    {
        public string CreateName(string surname, string name, string middlename)
        {
            string res = "";
            res += surname + " " + name + " " + middlename;
            return res;
        }

        public string GenerateLogin(string surname, string name, string middlename)
        {
            string res = "";
            res += surname + name[0] + middlename[0];
            return res;
        }

        public string GeneratePass()
        {
            int length = 7;
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        public void AddOPerator(string name, string login, string pass)
        {
            string password = GetHash(pass);

            Operator oper = new Operator(name, login, password);
            DataManager.AddOperator(oper);
        }
    }
}
