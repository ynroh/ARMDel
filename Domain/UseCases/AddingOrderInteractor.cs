using ARMDel.Data.Repository;
using ARMDel.Domain.Entities;
using ARMDel.Presentation.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Windows.Media;

namespace ARMDel.Domain.UseCases
{
    internal class AddingOrderInteractor
    {
        private AddingOrderRepository orderRepository = new AddingOrderRepository();
        private AddingClientRepository clientRepository = new AddingClientRepository();
        private AddingAddressRepository addressRepository = new AddingAddressRepository();
        private Calculator calculator = new Calculator();
        public decimal CalcOrdrCost(List<Tuple<Dish, int, string>> tuples, decimal DelCost) 
        {
            decimal res = 0;
            
            res = calculator.CalculateOrderCost(tuples);

            if (res < 1200)
                res += DelCost;
            return res;
        }

        public Address СonvertDataToAddress(string District, string Street, string Building, int Apartment, int Entrance, bool HaveNoIntercom, bool HaveIntercom, int Floor)
        {
            bool wrongDistrict = true;
            bool haveintercom = false;

            foreach (var p in DataManager.Alldistricts)
                if (p.Title == District)
                    wrongDistrict = false;

            if (District == "")
                throw new ArgumentException("Район не заполнен!");
            else if (wrongDistrict == true)
                    throw new ArgumentException("Заданный район не существует!");
            else if (Building == "")
                throw new ArgumentException("Дом не заполнен!");
            else if (Apartment == 0)
                throw new ArgumentException("Квартира не заполнена!");
            else if (Entrance == 0)
                throw new ArgumentException("Подъезд не заполнен!");
            else if (Floor == 0)
                throw new ArgumentException("Этаж не заполнен!");
            else if (HaveNoIntercom == false && HaveIntercom == false)
                throw new ArgumentException("Укажите наличие домофона!");

            else if (HaveNoIntercom == true)
                haveintercom = false;
            else if (HaveIntercom == true)
                haveintercom = true;
            return addressRepository.AddAddress(District, Street, Building, Apartment, Entrance, Floor, haveintercom);
        }
        public Client СonvertDataToClient(string ClientName, string PhoneNumber, Address Address)
        {
            if (ClientName == "")
                throw new ArgumentException("Имя клиента не заполнено!");
            else if (PhoneNumber == null)
                throw new ArgumentNullException("Номер телефона не заполнен!");
            else if (PhoneNumber.Length != 10)
                throw new ArgumentNullException("Номер телефона должен содеражать 10 цифр!");
            else
                return clientRepository.AddClient(ClientName, PhoneNumber, Address);
        }
        
        public void AddOrder(DateTime DateOfAdded, string OperatorName, Client client, Courier courier, bool CashPayment, bool CardPayment, List<Tuple<Dish, int, string>> Products, decimal orderCost, decimal delCost)
        {

            PaymentMethod paymentMethod = PaymentMethod.PaymentByCard;

            if (CardPayment == false && CashPayment == false)
                throw new ArgumentException("Укажите способ оплаты!");
            if (Products.Count == 0)
                throw new ArgumentException("В заказе ничего нет!");
            else if (CardPayment == true)
                paymentMethod = PaymentMethod.PaymentByCard;
            else if (CashPayment == true)
                paymentMethod = PaymentMethod.PaymentInCash;

            int number = orderRepository.GenerateOrdNumber();

            orderRepository.AddOrder(DateOfAdded, number, OperatorName, client, paymentMethod, Products, courier, delCost, orderCost);
            
        }
    }
}
