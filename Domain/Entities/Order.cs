using ARMDel.Presentation.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using ARMDel.Domain.Repository;

namespace ARMDel.Domain.Entities
{
    public enum PaymentMethod 
    {
        PaymentByCard,
        PaymentInCash
    };
    public class Order 
    {

        public DateTime DateOfAdded { get; }
        public int Number { get; }
        public string OperatorName { get; }
        public Client Client { get; }
        public List<Tuple<Dish, int, string>> Products { get; }
        public Courier Courier { get; }
        public decimal DeliveryPrice { get; }
        public PaymentMethod PaymentMethod { get; }
        public decimal Cost { get; }

        private bool IsNormalParameters(DateTime DateOfAdded, int Number, string OperatorName, Client Client, List<Tuple<Dish, int, string>> Products, Courier Courier, decimal DeliveryPrice, decimal Cost)
        {
            bool isNormal = true;
            bool NullDateOfAdded = DateOfAdded == null;
            bool InvalidNumber = Number <= 0;
            bool NullOperatorName = OperatorName == null;
            bool NullClient = Client == null;
            bool NullProducts = Products == null;
            bool InvalidCost = Cost <= 0;
            bool NullCourier = Courier == null;
            bool IvalidDeliveryPrice = DeliveryPrice < 0;
            if (NullDateOfAdded)
            {
                isNormal = false;
                throw new ArgumentNullException("Null DateOfAdded");
            }
            else if (InvalidNumber)
            {
                isNormal = false;
                throw new ArgumentException("Number must be greater than 0");
            }
            else if (NullOperatorName)
            {
                isNormal = false;
                throw new ArgumentNullException("Null OperatorName");
            }
            else if (NullClient)
            {
                isNormal = false;
                throw new ArgumentNullException("Null Client");
            }
            else if (NullProducts)
            {
                isNormal = false;
                throw new ArgumentNullException("Null Products");
            }
            else if (InvalidCost)
            {
                isNormal = false;
                throw new ArgumentException("Cost must be greater than 0");
            }
            else if (NullCourier)
            {
                isNormal = false;
                throw new ArgumentNullException("Null Courier");
            }
            else if (IvalidDeliveryPrice)
            {
                isNormal = false;
                throw new ArgumentException("DeliveryPrice must be < 0");
            }
            return isNormal;
        }

        public Order(DateTime DateOfAdded, int Number, string OperatorName, Client Client, PaymentMethod PaymentMethod, List<Tuple<Dish, int, string>> Products, Courier Courier, decimal DeliveryPrice, decimal Cost)
        {
            if (IsNormalParameters( DateOfAdded,  Number,  OperatorName,  Client, Products,  Courier,  DeliveryPrice,  Cost) == true)
            {
                this.DateOfAdded = DateOfAdded;
                this.Number = Number;
                this.OperatorName = OperatorName;
                this.Client = Client;
                this.PaymentMethod = PaymentMethod;
                this.Cost = Cost;
                this.Products = Products;
                this.Courier = Courier;
                this.DeliveryPrice = DeliveryPrice;
            }
        }
        //ВРЕМЕННО
        public Order(int Number, string OperatorName, DateTime date)
        {
            this.Number = Number;
            this.OperatorName = OperatorName;
            this.DateOfAdded = date;
        }
    }
}
