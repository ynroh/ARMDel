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
            DataManager.AddOrder(order1);
            DataManager.AddOrder(order2);
            DataManager.AddOrder(order3);
        }
    }
}
