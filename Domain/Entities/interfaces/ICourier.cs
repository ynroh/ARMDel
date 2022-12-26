using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Domain.Entities.interfaces
{
    public interface ICourier
    {
         string CourierName { get; }
         bool HasCar { get; }
    }
}
