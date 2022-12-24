using ARMDel.Domain.Entities;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace ARMDel.Presentation.ViewModel
{
    public class AddingOrderViewModel: DependencyObject
    {
        #region PROPERTYS



        public Courier SelectedCourier
        {
            get { return (Courier)GetValue(SelectedCourierProperty); }
            set { SetValue(SelectedCourierProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedCourier.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedCourierProperty =
            DependencyProperty.Register("SelectedCourier", typeof(Courier), typeof(AddingOrderViewModel), new PropertyMetadata(null));




        public string FilterCourier
        {
            get { return (string)GetValue(FilterCourierProperty); }
            set { SetValue(FilterCourierProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterCourier.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterCourierProperty =
            DependencyProperty.Register("FilterCourier", typeof(string), typeof(AddingOrderViewModel), new PropertyMetadata("", FilterCourier_Changed));


        private static void FilterCourier_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as AddingOrderViewModel;
            if (current != null)
            {
                current.CourierList.Filter = null;
                current.CourierList.Filter = current.IsCourierFiltered;
            }
        }



        public ICollectionView CourierList
        {
            get { return (ICollectionView)GetValue(CourierListProperty); }
            set { SetValue(CourierListProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CourierList.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CourierListProperty =
            DependencyProperty.Register("CourierList", typeof(ICollectionView), typeof(AddingOrderViewModel), new PropertyMetadata(null));




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



        public Courier Courier
        {
            get { return (Courier)GetValue(CourierProperty); }
            set { SetValue(CourierProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Courier.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CourierProperty =
            DependencyProperty.Register("Courier", typeof(Courier), typeof(AddingOrderViewModel), new PropertyMetadata(null));



        public string CourierName
        {
            get { return (string)GetValue(CourierNameProperty); }
            set { SetValue(CourierNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CourierName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CourierNameProperty =
            DependencyProperty.Register("CourierName", typeof(string), typeof(AddingOrderViewModel), new PropertyMetadata(""));



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

        public ICommand AssignCourierCommand { get; }
        public AddingOrderViewModel()
        {
            CourierList = CollectionViewSource.GetDefaultView(DataManager.AllCouriers);
            AssignCourierCommand = new DelegateCommand(TryAssignCourier);
        }

        private void AssignCourier()
        {
            if (SelectedCourier == null)
                throw new ArgumentException("Сначала выберите курьера из списка!");
            else
            {
                CourierName = SelectedCourier.CourierName;
                Courier = SelectedCourier;
            }
        }
        private void TryAssignCourier()
        {
            try
            {
                AssignCourier();
            }
            catch(ArgumentException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool IsCourierFiltered(object obj)
        {
            bool res = true;
            Courier current = obj as Courier;
            if (!string.IsNullOrEmpty(FilterCourier) && current != null && !current.CourierName.Contains(FilterCourier))
                res = false;
            return res;
        }
    }
}

