using System;

namespace ARMDel.Domain.Entities
{
    public abstract class Product
    {
        public string Title { get; }
        public decimal Price { get; }
        private bool IsNormalParameters(string Title, decimal Price)
        {
            bool isNormal = true;
            bool NullTitle = Title == "";
            bool InvalidPrice = Price <= 0;
            if (NullTitle)
            {
                isNormal = false;
                throw new ArgumentException("Title is an empty string");
            }
            else if (InvalidPrice)
            {
                isNormal = false;
                throw new ArgumentException("Price must be greater than 0");
            }
            return isNormal;
        }
        public Product(string Title, decimal Price)
        {
            if (IsNormalParameters(Title, Price) == true)
            {
                this.Title = Title;
                this.Price = Price;
            }
        }
    }
    public class Dish : Product
    {
        public float Weight { get; }
        public string Ingredients { get; }
        public Dish(string Title, decimal Price, float Weight, string Ingredients) : base(Title, Price)
        {
            this.Weight = Weight;
            this.Ingredients = Ingredients;
        }
    }
    public class OtherProduct : Product
    {
        public OtherProduct(string Title, decimal Price) : base(Title, Price)
        {
        }
    }
}

