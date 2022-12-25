using ARMDel.Domain.Entities;
using ARMDel.Domain.UseCases;
using ARMDel.Presentation.View;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public class AddingOrderViewModel : DependencyObject
    {
        #region PROPERTYS

        public ICollectionView InOrder
        {
            get { return (ICollectionView)GetValue(InOrderProperty); }
            set { SetValue(InOrderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for InOrder.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InOrderProperty =
            DependencyProperty.Register("InOrder", typeof(ICollectionView), typeof(AddingOrderViewModel), new PropertyMetadata(null));



        public string Note
        {
            get { return (string)GetValue(NoteProperty); }
            set { SetValue(NoteProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Note.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NoteProperty =
            DependencyProperty.Register("Note", typeof(string), typeof(AddingOrderViewModel), new PropertyMetadata(""));


        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty); }
            set { SetValue(QuantityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Quantity.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty QuantityProperty =
            DependencyProperty.Register("Quantity", typeof(int), typeof(AddingOrderViewModel), new PropertyMetadata(1));



        public Dish SelectedDish
        {
            get { return (Dish)GetValue(SelectedDishProperty); }
            set { SetValue(SelectedDishProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedDish.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedDishProperty =
            DependencyProperty.Register("SelectedDish", typeof(Dish), typeof(AddingOrderViewModel), new PropertyMetadata(null));



        public Tuple<Dish, int, string> SelectedProduct
        {
            get { return (Tuple<Dish, int, string>)GetValue(SelectedProductProperty); }
            set { SetValue(SelectedProductProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedProduct.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedProductProperty =
            DependencyProperty.Register("SelectedProduct", typeof(Tuple<Dish, int, string>), typeof(AddingOrderViewModel), new PropertyMetadata(null));




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



        public string FilterDish
        {
            get { return (string)GetValue(FilterProductProperty); }
            set { SetValue(FilterProductProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterProduct.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterProductProperty =
            DependencyProperty.Register("FilterProduct", typeof(string), typeof(AddingOrderViewModel), new PropertyMetadata("", FilterDish_Changed));

        private static void FilterDish_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as AddingOrderViewModel;
            if (current != null)
            {
                current.DishList.Filter = null;
                current.DishList.Filter = current.IsDishFiltered;
            }
        }



        public ICollectionView DishList
        {
            get { return (ICollectionView)GetValue(ProductListProperty); }
            set { SetValue(ProductListProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ProductList.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProductListProperty =
            DependencyProperty.Register("ProductList", typeof(ICollectionView), typeof(AddingOrderViewModel), new PropertyMetadata(null));


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



        public string PhoneNumber
        {
            get { return (string)GetValue(PhoneNumberProperty); }
            set { SetValue(PhoneNumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PhoneNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PhoneNumberProperty =
            DependencyProperty.Register("string", typeof(string), typeof(AddingOrderViewModel), new PropertyMetadata(""));



        public string District
        {
            get { return (string)GetValue(DistrictProperty); }
            set { SetValue(DistrictProperty, value); }
        }

        // Using a DependencyProperty as the backing store for District.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DistrictProperty =
            DependencyProperty.Register("District", typeof(string), typeof(AddingOrderViewModel), new PropertyMetadata("", District_Changed));

        private static void District_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as AddingOrderViewModel;
            if (current != null)
            {
                current.DeliveryCost = current.calc.CalculateDelCost(current.District);
            }
        }

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


        AddingOrderInteractor  addingOrderInteractor = new AddingOrderInteractor();
        Calculator calc = new Calculator();


        public ICommand AssignCourierCommand { get; }
        public ICommand AddDishCommand { get; }
        public ICommand AddQuantityCommand { get; }
        public ICommand ReduceQuantityCommand { get; }
        public ICommand SaveDishCommand { get; }
        public ICommand DeleteDishCommand { get; }
        public ICommand SaveOrderCommand { get; }

        private List<Tuple<Dish, int, string>> Products = new List<Tuple<Dish, int, string>>();
        private List<Tuple<Dish, int, string>> tuples = new List<Tuple<Dish, int, string>>();

        public AddingOrderViewModel()
        {
            CourierList = CollectionViewSource.GetDefaultView(DataManager.AllCouriers);
            DishList = CollectionViewSource.GetDefaultView(DataManager.AllDishes);
            

            AssignCourierCommand = new DelegateCommand(TryAssignCourier);
            AddDishCommand = new DelegateCommand(TryAddDish);
            AddQuantityCommand = new DelegateCommand(AddQuantity);
            ReduceQuantityCommand = new DelegateCommand(ReduceQuantity);
            SaveDishCommand = new DelegateCommand(SaveDish);
            DeleteDishCommand = new DelegateCommand(TryDeleteDish);
            SaveOrderCommand = new DelegateCommand(TrySaveOrder);
        }

        private void TrySaveOrder()
        {
            try
            {
                SaveOrder();
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SaveOrder()
        {
            Address address = addingOrderInteractor.СonvertDataToAddress(District, Street, Building, Apartment, Entrance, HaveNoIntercom, HaveIntercom, Floor);
            Client client = addingOrderInteractor.СonvertDataToClient(ClientName, PhoneNumber, address);
            addingOrderInteractor.AddOrder(DateTime.Today, DataManager.currentUser.Name, client, Courier, CashPayment, CardPayment, Products, OrderCost, DeliveryCost);
        }

        private void TryDeleteDish()
        {
            try
            {
                DeleteDish();
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteDish()
        {
            if (SelectedProduct == null)
                throw new ArgumentException("Сначала выберите блюдо из списка!");
            else
            {
                for (int i = Products.Count - 1; i >= 0; i--)
                {
                    if (Products[i].Item1 == SelectedProduct.Item1)
                        Products.Remove(Products[i]);
                }
                List<Tuple<Dish, int, string>> tuples = new List<Tuple<Dish, int, string>>(Products);
                InOrder = CollectionViewSource.GetDefaultView(tuples);
                OrderCost = addingOrderInteractor.CalcOrdrCost(tuples, DeliveryCost);
            }
        }

        private void SaveDish()
        {
            Products.Add(Tuple.Create(SelectedDish, Quantity, Note));
            Quantity = 1;
            Note = "";
            List<Tuple<Dish, int, string>> tuples = new List<Tuple<Dish, int, string>>(Products);
            InOrder = CollectionViewSource.GetDefaultView(tuples);
            OrderCost = addingOrderInteractor.CalcOrdrCost(tuples, DeliveryCost);
        }

        private void AddQuantity()
        {
            Quantity += 1;
        }

        private void ReduceQuantity()
        {
            if(Quantity>1)
                Quantity -= 1;
        }
        private void AddDish()
        {
            if (SelectedDish == null)
                throw new ArgumentException("Сначала выберите блюдо из списка!");
            else
            {
                var dishInfo = new DishInfo() { DataContext = MainViewModel.AddingOrderViewModel};
                dishInfo.ShowDialog();
            }
        }

        private void TryAddDish()
        {
            try
            {
                AddDish();
            }
            catch(ArgumentException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
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

        private bool IsDishFiltered(object obj)
        {
            bool res = true;
            Dish current = obj as Dish;
            if (!string.IsNullOrEmpty(FilterDish) && current != null && !current.Title.Contains(FilterDish))
                res = false;
            return res;
        }
    }
}

