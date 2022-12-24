using ARMDel.Domain.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ARMDel.Domain.Entities
{
    public static class DataManager
    {
        static public IUser currentUser { get; set; }   



        static private List<User> allUsers = new List<User>();
        static private List<Order> allOrders = new List<Order>();
        static private List<Product> allProducts = new List<Product>();
        static private List<Courier> allCouriers = new List<Courier>();
        static private List<District> alldistricts = new List<District>();

        static public List<District> Alldistricts
        {
            get { return alldistricts; }
            set { alldistricts = value; }
        }

        public static void DeserializeDistricts()
        {
            string fileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+ @"\..\..\Data\Files\Districts.json"; 
            string jsonString = File.ReadAllText(fileName);
            Alldistricts = JsonConvert.DeserializeObject<List<District>>(jsonString);
        }
        public static void DeserializeCouriers()
        {
            string fileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\..\..\Data\Files\Couriers.json";
            string jsonString = File.ReadAllText(fileName);
            AllCouriers = JsonConvert.DeserializeObject<List<Courier>>(jsonString);
        }
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
