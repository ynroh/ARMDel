using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Domain.Entities.interfaces
{
    public interface IProduct
    {
         string Title { get; }
         decimal Price { get; }
    }
}
