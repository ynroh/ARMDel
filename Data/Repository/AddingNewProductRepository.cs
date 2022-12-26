using ARMDel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Data.Repository
{
    public class AddingNewProductRepository
    {
        public void AddNewDish(string Title, decimal Price, string Ingredients, float Weight)
        {
            Dish dish = new Dish(Title, Price, Weight, Ingredients);
            DataManager.AddDish(dish);
        }

        public void AddOtherProduct(string Title, decimal Price)
        {
            OtherProduct otherProduct = new OtherProduct(Title, Price);
            DataManager.AddOtherProduct(otherProduct);
        }
    }
}
