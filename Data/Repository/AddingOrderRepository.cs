using ARMDel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ARMDel.Data.Repository
{
    public class AddingOrderRepository
    {
        public int GenerateOrdNumber()
        {
            int num = DataManager.AllOrders.Count + 1;
            return num;
        }
        public void AddOrder(DateTime DateOfAdded, int Number, string OperatorName, Client Client, PaymentMethod PaymentMethod, List<Tuple<Dish, int, string>> Products, Courier Courier, decimal DeliveryPrice, decimal Cost)
        {
            Order order = new Order(DateOfAdded, Number, OperatorName, Client, PaymentMethod, Products, Courier, DeliveryPrice, Cost);
            DataManager.AddOrder(order);
        }

        
    }
}
