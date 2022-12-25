using ARMDel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Domain.UseCases
{
    internal class AddingOrderInteractor
    {
        public decimal CalcOrdrCost(List<Tuple<Dish, int, string>> tuples, decimal DelCost) 
        {
            decimal res = 0;
            Calculator calculator = new Calculator();
            res = calculator.CalculateOrderCost(tuples);

            if (res < 1200)
                res += DelCost;
            return res; 
        }
        public void AddOrder(DateTime DateOfAdded, string OperatorName)
        {
            
        }
    }
}
