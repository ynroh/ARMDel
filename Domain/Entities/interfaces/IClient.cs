using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Domain.Entities.interfaces
{
    public interface IClient
    {
         string ClientName { get; set; }
         string PhoneNumber { get; set; }
         Address Address { get; }
    }
}
