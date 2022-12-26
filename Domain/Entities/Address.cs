using ARMDel.Domain.Entities.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Domain.Entities
{
    public class Address: IAddress
    { 
        public string District { get; }
        public string Street { get; set; }
        public string Building { get; set; }
        public int Apartment { get; set; }
        public int Entrance { get; }
        public int Floor { get; }
        public bool HasIntercom { get; }
        private bool IsNormalParameters(string District, string Street, string Building, int Apartment, int Entrance, int Floor)
        {
            bool isNormal = true;
            bool NullDistrict = District == "";
            bool NullStreet = Street == "";
            bool NullBuilding = Building == "";
            bool InvalidApartment = Apartment <= 0;
            bool InvalidEntrance = Entrance <= 0;
            bool InvalidFloor = Floor <= 0;
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
                throw new ArgumentException("Apartment must be greater than 0");
            }
            else if (InvalidEntrance)
            {
                isNormal = false;
                throw new ArgumentException("dEntrance must be greater than 0");
            }
            else if (InvalidFloor)
            {
                isNormal = false;
                throw new ArgumentException("Floor must be greater than 0");
            }
            return isNormal;
        }
        public Address(string District, string Street, string Building, int Apartment, int Entrance, int Floor, bool HasIntercom)
        {
            if (IsNormalParameters(District, Street, Building, Apartment, Entrance, Floor) == true)
            {
                this.District = District;
                this.Street = Street;
                this.Building = Building;
                this.Apartment = Apartment;
                this.Entrance = Entrance;
                this.Floor = Floor;
                this.HasIntercom = HasIntercom;
            }
        }
    }
}
