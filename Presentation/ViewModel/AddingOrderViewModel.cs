using ARMDel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ARMDel.Presentation.ViewModel
{
    public class AddingOrderViewModel: DependencyObject
    {
        #region PROPERTYS
        public string ClientName
        {
            get { return (string)GetValue(ClientNameClientNameProperty); }
            set { SetValue(ClientNameClientNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ClientNameClientName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClientNameClientNameProperty =
            DependencyProperty.Register("ClientNameClientName", typeof(string), typeof(AddingOrderViewModel), new PropertyMetadata(""));



        public int[] PhoneNumber
        {
            get { return (int[])GetValue(PhoneNumberProperty); }
            set { SetValue(PhoneNumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PhoneNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PhoneNumberProperty =
            DependencyProperty.Register("PhoneNumber", typeof(int[]), typeof(AddingOrderViewModel), new PropertyMetadata(null));



        public string District
        {
            get { return (string)GetValue(DistrictProperty); }
            set { SetValue(DistrictProperty, value); }
        }

        // Using a DependencyProperty as the backing store for District.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DistrictProperty =
            DependencyProperty.Register("District", typeof(string), typeof(AddingOrderViewModel), new PropertyMetadata(""));



        public Courier CourierName
        {
            get { return (Courier)GetValue(CourierNameProperty); }
            set { SetValue(CourierNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CourierName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CourierNameProperty =
            DependencyProperty.Register("CourierName", typeof(Courier), typeof(AddingOrderViewModel), new PropertyMetadata(null));



        public string Street
        {
            get { return (string)GetValue(StreetProperty); }
            set { SetValue(StreetProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Street.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StreetProperty =
            DependencyProperty.Register("Street", typeof(string), typeof(AddingOrderViewModel), new PropertyMetadata(""));
       
        
        public string Building
        {
            get { return (string)GetValue(BuildingProperty); }
            set { SetValue(BuildingProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Building.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BuildingProperty =
            DependencyProperty.Register("Building", typeof(string), typeof(AddingOrderViewModel), new PropertyMetadata(""));



        public int Entrance
        {
            get { return (int)GetValue(EntranceProperty); }
            set { SetValue(EntranceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Entrance.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EntranceProperty =
            DependencyProperty.Register("Entrance", typeof(int), typeof(AddingOrderViewModel), new PropertyMetadata(0));



        public int Apartment
        {
            get { return (int)GetValue(ApartmentProperty); }
            set { SetValue(ApartmentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Apartment.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ApartmentProperty =
            DependencyProperty.Register("Apartment", typeof(int), typeof(AddingOrderViewModel), new PropertyMetadata(0));



        public int Floor
        {
            get { return (int)GetValue(FloorProperty); }
            set { SetValue(FloorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Floor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FloorProperty =
            DependencyProperty.Register("Floor", typeof(int), typeof(AddingOrderViewModel), new PropertyMetadata(0));



        public bool HaveIntercom
        {
            get { return (bool)GetValue(HaveIntercomProperty); }
            set { SetValue(HaveIntercomProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HaveIntercom.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HaveIntercomProperty =
            DependencyProperty.Register("HaveIntercom", typeof(bool), typeof(AddingOrderViewModel), new PropertyMetadata(false));



        public bool HaveNoIntercom
        {
            get { return (bool)GetValue(HaveNoIntercomProperty); }
            set { SetValue(HaveNoIntercomProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HaveNoIntercom.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HaveNoIntercomProperty =
            DependencyProperty.Register("HaveNoIntercom", typeof(bool), typeof(AddingOrderViewModel), new PropertyMetadata(false));



        public bool CashPayment
        {
            get { return (bool)GetValue(CashPaymentProperty); }
            set { SetValue(CashPaymentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CashPayment.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CashPaymentProperty =
            DependencyProperty.Register("CashPayment", typeof(bool), typeof(AddingOrderViewModel), new PropertyMetadata(false));



        public bool CardPayment
        {
            get { return (bool)GetValue(CardPaymentProperty); }
            set { SetValue(CardPaymentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CardPayment.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CardPaymentProperty =
            DependencyProperty.Register("CardPayment", typeof(bool), typeof(AddingOrderViewModel), new PropertyMetadata(false));



        public decimal DeliveryCost
        {
            get { return (decimal)GetValue(DeliveryCostProperty); }
            set { SetValue(DeliveryCostProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DeliveryCost.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DeliveryCostProperty =
            DependencyProperty.Register("DeliveryCost", typeof(decimal), typeof(AddingOrderViewModel), new PropertyMetadata(0m));



        public decimal OrderCost
        {
            get { return (decimal)GetValue(OrderCostProperty); }
            set { SetValue(OrderCostProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OrderCost.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OrderCostProperty =
            DependencyProperty.Register("OrderCost", typeof(decimal), typeof(AddingOrderViewModel), new PropertyMetadata(0m));
        #endregion


    }
}

