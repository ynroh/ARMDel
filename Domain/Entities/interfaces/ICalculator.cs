using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Domain.Entities.interfaces
{
    public interface ICalculator
    {
        decimal CalculateOrderCost(List<Tuple<Dish, int, string>> tuples);

        decimal CalculateDelCost(string District);
    }
}
