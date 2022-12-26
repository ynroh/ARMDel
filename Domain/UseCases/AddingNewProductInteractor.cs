using ARMDel.Data.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace ARMDel.Domain.UseCases
{
    public class AddingNewProductInteractor
    {
        AddingNewProductRepository productRepository = new AddingNewProductRepository();
        public void AddNewProduct(bool NewDish, bool NewOtherProduct, string Title, decimal Price, string Ingredients, float Weight)
        {
            if (Title == null)
                throw new ArgumentNullException("Введите название!");
            else if (Price == 0)
                throw new ArgumentNullException("Введите цену!");

            else if (NewDish == true)
            {
                if (Ingredients == "")
                    throw new ArgumentNullException("Введите соств!");
                else if (Weight == 0)
                    throw new ArgumentNullException("Укажите вес!");
                else productRepository.AddNewDish(Title, Price, Ingredients, Weight);
            }

            else if(NewOtherProduct == true)
            {
                productRepository.AddOtherProduct(Title, Price);
            }
        }
    }
}
