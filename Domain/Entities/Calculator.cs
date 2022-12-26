using ARMDel.Domain.Entities.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Domain.Entities
{
    public class Calculator : ICalculator
    {
        public decimal CalculateOrderCost(List<Tuple<Dish, int, string>> tuples)
        {
            decimal res = 0;
            foreach (var tuple in tuples)
            {
                res += tuple.Item1.Price* tuple.Item2;
            }
            return res;
        }

        public decimal CalculateDelCost(string District)
        {
            decimal res = 0;
            foreach (var d in DataManager.Alldistricts)
            {
                if (d.Title == District)
                    res = d.DelPrice;
            }
            return res;
        }
    }
}
