using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Domain.Entities
{
    public class Address
    { 
        public string District { get; }
        public string Street { get; }
        public string Building { get; }
        public int Apartment { get; }
        public int Entrance { get; }
        public bool HasIntercom { get; }
        private bool IsNormalParameters(string District, string Street, string Building, int Apartment, int Entrance)
        {
            bool isNormal = true;
            bool NullDistrict = District == "";
            bool NullStreet = Street == "";
            bool NullBuilding = Building == "";
            bool InvalidApartment = Apartment <= 0;
            bool InvalidEntrance = Entrance <= 0;
            if (NullDistrict)
            {
                isNormal = false;
                throw new ArgumentException("District is an empty string");
            }
            else if (NullStreet)
            {
                isNormal = false;
                throw new ArgumentException("Street is an empty string");
            }
            else if (NullBuilding)
            {
                isNormal = false;
                throw new ArgumentException("Building is an empty string");
            }
            else if (InvalidApartment)
            {
                isNormal = false;
                throw new ArgumentException("InvalidApartment must be greater than 0");
            }
            else if (InvalidEntrance)
            {
                isNormal = false;
                throw new ArgumentException("InvalidEntrance must be greater than 0");
            }
            return isNormal;
        }
        public Address(string District, string Street, string Building, int Apartment, int Entrance, bool HasIntercom)
        {
            if (IsNormalParameters(District, Street, Building, Apartment, Entrance) == true)
            {
                this.District = District;
                this.Street = Street;
                this.Building = Building;
                this.Apartment = Apartment;
                this.Entrance = Entrance;
                this.HasIntercom = HasIntercom;
            }
        }
    }
}
