using ARMDel.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Domain.Entities
{
    public static class DataManager
    {
        static public IUser currentUser;
        static public List<User> AllUsers = new List<User>();
        static public List<Order> AllOrders { get; }
        //static public List<User> AllUsers { get;}
        static public List<Product> AllProducts { get;}
        static public List<Courier> AllCouriers { get;}

        static public void AddOrder(Order order)
        {
            AllOrders.Add(order);
        }
        static public void AddOperator(Operator oper)
        {
            AllUsers.Add(oper);
        }
        static public void AddProduct(Product product)
        {
            AllProducts.Add(product);
        }
        static public void AddCourier(Courier courier)
        {
            AllCouriers.Add(courier);
        }
    }
}
