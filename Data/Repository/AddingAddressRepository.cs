using ARMDel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ARMDel.Data.Repository
{
    public class AddingAddressRepository
    {
        public Address AddAddress(string District, string Street, string Building, int Apartment, int Entrance, int Floor, bool HasIntercom)
        {
            Address Address = new Address( District,  Street,  Building,  Apartment,  Entrance,  Floor,  HasIntercom);
            return Address;
        }
    }
}
