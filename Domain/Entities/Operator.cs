using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Domain.Entities
{
    public class Operator : User
    {
        public Operator(string Name, string Login, string Password) : base(Name, Login, Password)
        { }

        public void AddOrder(DateTime DateOfAdded, DateTime CompletionDate, int Number, string OperatorName, Client Client, PaymentMethod PaymentMethod, List<(Product product, int quantity, string note)> Products, OrderStatus Status, Courier Courier, decimal DeliveryPrice, decimal Cost) 
        {
            Order order = new Order (DateOfAdded,  CompletionDate,  Number,  OperatorName,  Client,  PaymentMethod, Products,  Status,  Courier,  DeliveryPrice,  Cost);
            DataManager.AddOrder(order);
        }
    }
}
