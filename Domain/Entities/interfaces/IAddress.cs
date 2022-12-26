using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Domain.Entities.interfaces
{
    public interface IAddress
    {
         string District { get; }
         string Street { get; }
         string Building { get; }
         int Apartment { get;  }
         int Entrance { get; }
         int Floor { get; }
         bool HasIntercom { get; }
    }
}
