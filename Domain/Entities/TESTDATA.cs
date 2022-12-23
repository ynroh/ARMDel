using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Domain.Entities
{
    public class TESTDATA
    {
        static DateTime date = new DateTime(2022, 12, 15);
        Operator op1 = new Operator("Саша", "n", "e4uWWtS8oOQatR3nsxNjoQ==");
        Operator op2 = new Operator("Макс", "User", "j5v+nRNFI3yzsrIFhk2gdQ==");
        Admin Admin = new Admin("админ", "Admin", "46/tAEewgFnQ+toQ9ADB5Q==");
        Order order1 = new Order(1, "Bbb", DateTime.Today) ;
        Order order2 = new Order(2, "Sss", DateTime.Today);
        Order order3 = new Order(3, "Bbb", date);
        private string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
        
        public void MakeFakeData()
        {
            string pass = GetHash(op1.Password);
            DataManager.AddOperator(op1);
            DataManager.AddOperator(op2);
            DataManager.AddOperator(Admin);
            DataManager.AddOrder(order1);
            DataManager.AddOrder(order2);
            DataManager.AddOrder(order3);
        }
    }
}
