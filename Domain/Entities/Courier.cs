using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Domain.Entities
{
    public class Courier
    {
        public string CourierName { get; }
        public bool HasCar { get; }
        public Courier(string CourierName, bool HasCar)
        {
            if (CourierName == "")
                throw new ArgumentException("CourierName is an empty string");
            this.CourierName = CourierName;
            this.HasCar = HasCar;
        }
    }
}
