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

        static private List<User> allUsers = new List<User>();
        static private List<Order> allOrders = new List<Order>();
        static private List<Product> allProducts = new List<Product>();
        static private List<Courier> allCouriers = new List<Courier>();

        #region PROPERTYS
        static public List<User> AllUsers
        {
            get { return allUsers; }
        }

        static public List<Order> AllOrders
        {
            get { return allOrders; }
            set { allOrders = value; }
        }

        static public List<Product> AllProducts
        {
            get { return allProducts; }
            set { allProducts = value; }
        }

        static public List<Courier> AllCouriers
        {
            get { return allCouriers; }
            set { allCouriers = value; }
        }
        #endregion

        static public void AddOrder(Order order)
        {
            AllOrders.Add(order);
        }
        static public void AddOperator(User oper)
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
