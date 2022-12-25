using ARMDel.Domain.Entities;
using ARMDel.Domain.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Presentation.ViewModel
{
    public class OrderViewModel : IOrder, INotifyPropertyChanged
    {
        public OrderViewModel(Order order)
        {
            this.DateOfAdded = order.DateOfAdded;
            this.Number = order.Number;
            this.OperatorName = order.OperatorName;
            this.Client = order.Client;
            this.Products = order.Products;
            this.Courier = order.Courier;
            this.DeliveryPrice = order.DeliveryPrice;
            this.PaymentMethod = order.PaymentMethod;
            this.Cost = order.Cost;
        }

        private DateTime dateOfAdded;
        public DateTime DateOfAdded
        {
            get { return dateOfAdded; }
            set
            {
                dateOfAdded = value;
                OnPropertyChanged("DateOfAdded");
            }
        }



        private int number;
        public int Number
        {
            get { return number; }
            set
            {
                number = value;
                OnPropertyChanged("Number");
            }
        }



        private string operatorName;
        public string OperatorName
        {
            get { return operatorName; }
            set
            {
                operatorName = value;
                OnPropertyChanged("OperatorName");
            }
        }

        private Client client;
        public Client Client
        {
            get { return client; }
            set
            {
                client = value;
                OnPropertyChanged("Client");
            }
        }

        private List<Tuple<Dish, int, string>> products;
        public List<Tuple<Dish, int, string>> Products
        {
            get { return products; }
            set
            {
                products = value;
                OnPropertyChanged("Products");
            }
        }


        private Courier courier;
        public Courier Courier
        {
            get { return courier; }
            set
            {
                courier = value;
                OnPropertyChanged("Courier");
            }
        }

        private decimal deliveryPrice;
        public decimal DeliveryPrice
        {
            get { return deliveryPrice; }
            set
            {
                deliveryPrice = value;
                OnPropertyChanged("DeliveryPrice");
            }
        }

        private PaymentMethod paymentMethod;
        public PaymentMethod PaymentMethod
        {
            get { return paymentMethod; }
            set
            {
                paymentMethod = value;
                OnPropertyChanged("PaymentMethod");
            }
        }


        private decimal cost;
        public decimal Cost
        {
            get { return cost; }
            set
            {
                cost = value;
                OnPropertyChanged("Cost");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
