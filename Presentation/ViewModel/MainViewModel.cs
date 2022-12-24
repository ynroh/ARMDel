using ARMDel.Domain.Entities;
using ARMDel.Domain.Repository;
using ARMDel.Domain.UseCases;
using ARMDel.Presentation.View;
using Prism.Commands;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace ARMDel.Presentation.ViewModel
{
    public class MainViewModel: DependencyObject
    {
        private readonly ShowingOrderInteractor showingOrderInteractor = new ShowingOrderInteractor();
        public string Name { get;}
        private readonly DateTime currentDate = new DateTime();
        private List<Order> OrdersByDate = new List<Order>();
        public string Colour { get; set; }

        #region PROPERTYS



        public string FilterText
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterText", typeof(string), typeof(MainViewModel), new PropertyMetadata("", FilterText_Changed));

        private static void FilterText_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as MainViewModel;
            if (current != null)
            {
                current.OrderList.Filter = null;
                current.OrderList.Filter = current.IsOrderFiltered;
            }
        }


        public IOrder SelectedOrder
        {
            get { return (IOrder)GetValue(SelectedOrderProperty); }
            set { SetValue(SelectedOrderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedOrder.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedOrderProperty =
            DependencyProperty.Register("SelectedOrder", typeof(IOrder), typeof(MainViewModel), new PropertyMetadata(null));


        public ICollectionView OrderList
        {
            get { return (ICollectionView)GetValue(OrderListProperty); }
            set { SetValue(OrderListProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OrderList.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OrderListProperty =
            DependencyProperty.Register("OrderList", typeof(ICollectionView), typeof(MainViewModel), new PropertyMetadata(null));


        public DateTime ChosenDate
        {
            get { return (DateTime)GetValue(ChosenDateProperty); }
            set { SetValue(ChosenDateProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ChosenDate.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ChosenDateProperty =
            DependencyProperty.Register("ChosenDate", typeof(DateTime), typeof(MainViewModel), new PropertyMetadata(DateTime.Today, ChosenDate_Changed));

        private static void ChosenDate_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as MainViewModel;
            if (current != null)
            {
                current.ShowOrderByDate();
            }
        }

        public string TodayDate
        {
            get { return currentDate.ToShortDateString(); }
        }
        #endregion
        public ICommand OpenAddingOrderWindowCommand { get; }
        public MainViewModel()
        {
            OpenAddingOrderWindowCommand = new DelegateCommand(OpenAddOrderWindow);
            Name = DataManager.currentUser.Name;
            currentDate = DateTime.Today;
            OrdersByDate = showingOrderInteractor.FindOrderByDate(currentDate);
            List<OrderViewModel> OrdersByDateVM = new List<OrderViewModel>();
            foreach (var o in OrdersByDate)
                OrdersByDateVM.Add(new OrderViewModel(o));
            OrderList = CollectionViewSource.GetDefaultView(OrdersByDateVM);
            OrderList.Filter = IsOrderFiltered;
        }


        private void OpenAddOrderWindow()
        {
            var AddingOrderViewModel = new AddingOrderViewModel();
            var addingOrderWindow = new AddingOrder() { DataContext = AddingOrderViewModel };
            addingOrderWindow.Show();
        }
        private void ShowOrderByDate()
        {
            OrdersByDate.Clear();
            List<OrderViewModel> OrdersByDateVM = new List<OrderViewModel>();
            OrdersByDate = showingOrderInteractor.FindOrderByDate(ChosenDate);
            foreach (var o in OrdersByDate)
                OrdersByDateVM.Add(new OrderViewModel(o));
            OrderList = CollectionViewSource.GetDefaultView(OrdersByDateVM);
        }

        private bool IsOrderFiltered(object obj)
        {
            bool res = true;
            OrderViewModel current = obj as OrderViewModel;
            if (!string.IsNullOrEmpty(FilterText) && current != null && !current.OperatorName.Contains(FilterText))
                res = false;
            return res;
        }
    }
}

