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
        static private List<Dish> allDishes = new List<Dish>();
        static private List<OtherProduct> allOtherProducts = new List<OtherProduct>();
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

        public static void DeserializeProducts()
        {
            string fileNameDishes = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\..\..\Data\Files\Dishes.json";
            string fileNameProducts = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\..\..\Data\Files\OtherProducts.json";
            
            string jsonStringDishes = File.ReadAllText(fileNameDishes);
            AllDishes = JsonConvert.DeserializeObject<List<Dish>>(jsonStringDishes);
            
            string jsonStringProducts = File.ReadAllText(fileNameProducts);
            AllOtherProducts = JsonConvert.DeserializeObject<List<OtherProduct>>(jsonStringProducts);

        }

        public static void DeserializeUsers()
        {
            List<Operator> operators = new List<Operator>();
            List<Admin> adminds = new List<Admin>();

            string fileNameOperators = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\..\..\Data\Files\Operators.json";
            string fileNameAdmins = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\..\..\Data\Files\Admins.json";
            string jsonStringOperators= File.ReadAllText(fileNameOperators);
            operators = JsonConvert.DeserializeObject<List<Operator>>(jsonStringOperators);
            string jsonStringAdmins = File.ReadAllText(fileNameAdmins);
            adminds = JsonConvert.DeserializeObject<List<Admin>>(jsonStringAdmins);

            foreach (var p in operators)
                AllUsers.Add(p);
            foreach (var p in adminds)
                AllUsers.Add(p);
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

        static public List<Dish> AllDishes
        {
            get { return allDishes; }
            set { allDishes = value; }
        }
        static public List<OtherProduct> AllOtherProducts
        {
            get { return allOtherProducts; }
            set { allOtherProducts = value; }
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

        static public void AddCourier(Courier courier)
        {
            AllCouriers.Add(courier);
        }
    }
}
