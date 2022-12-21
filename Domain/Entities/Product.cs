using System;

namespace ARMDel.Domain.Entities
{
    public abstract class Product
    {
        public string Title { get; }
        public float Price { get; }
        private bool IsNormalParameters(string Title, float Price)
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
        public Product(string Title, float Price)
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
        public string[] Ingredients { get; }
        public Dish(string Title, float Price, float Weight, string[] Ingredients) : base(Title, Price)
        {
            if (Weight <= 0)
                throw new ArgumentException("Weight must be greater than 0");
            else if (Ingredients == null)
                throw new ArgumentNullException("Null Ingredients");
            this.Weight = Weight;
            this.Ingredients = Ingredients;
        }
    }
    public class OtherProducts : Product
    {
        public OtherProducts(string Title, float Price) : base(Title, Price)
        {
        }
    }
}

