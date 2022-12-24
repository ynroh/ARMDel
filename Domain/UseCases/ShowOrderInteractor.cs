using ARMDel.Domain.Entities;
using ARMDel.Domain.Repository;
using System;
using System.Collections.Generic;

namespace ARMDel.Domain.UseCases
{
    public class ShowingOrderInteractor
    {
        public List<Order> FindOrderByDate(DateTime date)
        {
         List<Order> foundOrders = new List<Order>();
            foreach(var ord in DataManager.AllOrders)
                if(ord.DateOfAdded == date)
                    foundOrders.Add(ord);
            return foundOrders;
        }
    }
}
