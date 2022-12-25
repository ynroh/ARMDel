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
        static private List<Operator> allOperators = new List<Operator>();
        static private List<Administrator> allAdmins = new List<Administrator>();

        #region PROPERTYS



        static public List<Operator> AllOperators
        {
            get { return allOperators; }
            set { allOperators = value; }
        }



        static public List<Administrator> AllAdmins
        {
            get { return allAdmins; }
            set { allAdmins = value; }
        }

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
        static public List<District> Alldistricts
        {
            get { return alldistricts; }
            set { alldistricts = value; }
        }

        public static void SerializeOrders()
        {
            string fileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\..\..\Data\Files\Orders.json";
            string json = JsonConvert.SerializeObject(AllOrders, Formatting.Indented);
            File.WriteAllText(fileName, json);
        }
        public static void DeserializeOrders()
        {
            string fileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\..\..\Data\Files\Orders.json";
            string jsonString = File.ReadAllText(fileName);
            AllOrders = JsonConvert.DeserializeObject<List<Order>>(jsonString);
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
           

            string fileNameOperators = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\..\..\Data\Files\Operators.json";
            string fileNameAdmins = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\..\..\Data\Files\Admins.json";
            string jsonStringOperators= File.ReadAllText(fileNameOperators);
            AllOperators = JsonConvert.DeserializeObject<List<Operator>>(jsonStringOperators);
            string jsonStringAdmins = File.ReadAllText(fileNameAdmins);
            AllAdmins = JsonConvert.DeserializeObject<List<Administrator>>(jsonStringAdmins);

            foreach (var p in AllOperators)
                AllUsers.Add(p);
            foreach (var p in AllAdmins)
                AllUsers.Add(p);
        }

        public static void SerializeOperators()
        {
            string fileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\..\..\Data\Files\Operators.json";
            string json = JsonConvert.SerializeObject(AllOperators, Formatting.Indented);
            File.WriteAllText(fileName, json);
        }

       

        static public void AddOrder(Order order)
        {
            AllOrders.Add(order);
            SerializeOrders();
        }
        static public void AddOperator(User oper)
        {
            AllUsers.Add(oper);
            SerializeOperators();
        }

        static public void AddCourier(Courier courier)
        {
            AllCouriers.Add(courier);
        }
    }
}
