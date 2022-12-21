using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace ARMDel.Domain.Entities
{
    public enum OrderorderForDeliveryStatus
    {
        Added,
        SentToKitchen,
        Ready,
        TransferredToCourier,
        Delivered
    };
    public enum PickupOrderStatus
    {
        Added,
        SentToKitchen,
        Ready,
        GivenToTheClient
    };
    public enum PaymentMethod
    {
        PaymentByCard,
        PaymentInCash
    };
    public abstract class Order
    {
        public DateTime DateOfAdded { get; }
        public DateTime CompletionDate { get; }
        public int Number { get; }
        public string OperatorName { get; }
        public Client Client { get; }
        public List<(Product product, int quantity, string note)> Products { get; }

        public PaymentMethod PaymentMethod { get; }
        public float Cost { get; }

        private bool IsNormalParameters(DateTime DateOfAdded, DateTime CompletionDate, int Number, string OperatorName, Client Client, PaymentMethod PaymentMethod, List<(Product product, int quantity, string note)> Products, float Cost)
        {
            bool isNormal = true;
            bool NullDateOfAdded = DateOfAdded == null;
            bool NullCompletionDateOfAdded = CompletionDate == null;
            bool InvalidNumber = Number <= 0;
            bool NullOperatorName = OperatorName == null;
            bool NullClient = Client == null;
            bool NullProducts = Products == null;
            bool InvalidCost = Cost <= 0;
            if (NullDateOfAdded)
            {
                isNormal = false;
                throw new ArgumentNullException("Null DateOfAdded");
            }
            else if (NullCompletionDateOfAdded)
            {
                isNormal = false;
                throw new ArgumentNullException("Null CompletionDate");
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
            return isNormal;
        }

        public Order(DateTime DateOfAdded, DateTime CompletionDate, int Number, string OperatorName, Client Client, PaymentMethod PaymentMethod, List<(Product product, int quantity, string note)> Products, float Cost)
        {
            if (IsNormalParameters(DateOfAdded, CompletionDate, Number, OperatorName, Client, PaymentMethod, Products, Cost) == true)
            {
                this.DateOfAdded = DateOfAdded;
                this.CompletionDate = CompletionDate;
                this.Number = Number;
                this.OperatorName = OperatorName;
                this.Client = Client;
                this.PaymentMethod = PaymentMethod;
                this.Cost = Cost;
                this.Products = Products;
            }
        }
    }
    public class OrderForDelivery : Order
    {
        public OrderorderForDeliveryStatus Status { get; }
        public Courier Courier { get; }
        public float DeliveryPrice { get; }

        private bool IsNormalParameters(Courier Courier, float DeliveryPrice)
        {
            bool isNormal = true;
            bool NullCourier = Courier == null;
            bool IvalidDeliveryPrice = DeliveryPrice <= 0;
            if (NullCourier)
            {
                isNormal = false;
                throw new ArgumentNullException("Null Courier");
            }
            if (IvalidDeliveryPrice)
            {
                isNormal = false;
                throw new ArgumentException("DeliveryPrice must be greater than 0");
            }
            return isNormal;
        }

        public OrderForDelivery(DateTime DateOfAdded, DateTime CompletionDate, int Number, string OperatorName, Client Client, PaymentMethod PaymentMethod, List<(Product product, int quantity, string note)> Products, float Cost, OrderorderForDeliveryStatus Status, Courier Courier, float DeliveryPrice) : base(DateOfAdded, CompletionDate, Number, OperatorName, Client, PaymentMethod, Products, Cost)
        {
            if (IsNormalParameters(Courier, DeliveryPrice) == true)
            {
                this.Status = Status;
                this.Courier = Courier;
                this.DeliveryPrice = DeliveryPrice;
            }
        }
    }

    public class PickupOrder : Order
    {
        public PickupOrderStatus Status { get; }
        public PickupOrder(DateTime DateOfAdded, DateTime CompletionDate, int Number, string OperatorName, Client Client, PaymentMethod PaymentMethod, List<(Product product, int quantity, string note)> Products, float Cost, PickupOrderStatus Status) : base(DateOfAdded, CompletionDate, Number, OperatorName, Client, PaymentMethod, Products, Cost)
        {
            this.Status = Status;
        }
    }
}
