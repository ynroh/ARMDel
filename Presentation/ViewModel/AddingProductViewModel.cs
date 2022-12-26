using ARMDel.Domain.UseCases;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ARMDel.Presentation.ViewModel
{
    public class AddingProductViewModel:BaseViewModel
    {
        #region PROPERTYS
        private bool newDish;

		public bool NewDish
		{
			get { return newDish; }
			set 
			{ 
				newDish = value; 
				OnPropertyChanged("NewDish");

            }
		}

        private bool newOtherProduct;

        public bool NewOtherProduct
        {
            get { return newOtherProduct; }
            set
            {
                newOtherProduct = value;
                OnPropertyChanged("NewDish");

            }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");

            }
        }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");

            }
        }

        private float weight;
        public float Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                OnPropertyChanged("Weight");

            }
        }

        private string ingredients;
        public string Ingredients
        {
            get { return ingredients; }
            set
            {
                ingredients = value;
                OnPropertyChanged("Ingredients");

            }
        }
        #endregion

        AddingNewProductInteractor productInteractor = new AddingNewProductInteractor();
        public ICommand AddNewProductCommand { get; }
        public AddingProductViewModel()
        {
            AddNewProductCommand = new DelegateCommand(TryAddNewProduct);
        }

        private void TryAddNewProduct()
        {
            try
            {
                AddNewProduct();
                MessageBox.Show("Продукт добавлен");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddNewProduct()
        {
            productInteractor.AddNewProduct(NewDish, NewOtherProduct, Title, Price, Ingredients, Weight );
        }
    }
}
