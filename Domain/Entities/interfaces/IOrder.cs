using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARMDel.Domain.Entities;

namespace ARMDel.Domain.Repository
{
    public interface IOrder
    {
         DateTime DateOfAdded { get; }
         int Number { get; }
         string OperatorName { get; }
         Client Client { get; }
         List<Tuple<Dish, int, string>> Products { get; }
         Courier Courier { get; }
         decimal DeliveryPrice { get; }
         PaymentMethod PaymentMethod { get; }
         decimal Cost { get; }
    }
}
