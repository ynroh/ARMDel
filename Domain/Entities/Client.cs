using ARMDel.Domain.Entities.interfaces;
using System;

namespace ARMDel.Domain.Entities
{
    public class Client: IClient
    {
        public string ClientName { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; }
        private bool IsNormalParameters(string ClientName, string PhoneNumber, Address Address)
        {
            bool isNormal = true;
            
            bool NullClientName = ClientName == "";
            bool NullPhoneNumber = PhoneNumber == null;
            bool NullAddress = Address == null;
            bool InvalidPhoneNumber = PhoneNumber.Length != 11;
            if (NullClientName)
            {
                isNormal = false;
                throw new ArgumentException("ClientName is an empty string");
            }
            else if (NullPhoneNumber)
            {
                isNormal = false;
                throw new ArgumentException("PhoneNumber is an empty string");
            }
            else if(NullAddress)
            {
                isNormal = false;
                throw new ArgumentNullException("Null Address");
            }
            else if(InvalidPhoneNumber)
            {
                isNormal = false;
                throw new ArgumentException("PhoneNumber must contain 11 digits");
            }
            else 
            foreach(var num in PhoneNumber)
                if (num <'0' || num >'9')
                {
                    isNormal = false;
                    throw new ArgumentException("PhoneNumber must contain digits only");
                }
            return isNormal;
        }
        public Client(string ClientName, string PhoneNumber, Address Address)
        {
            if (IsNormalParameters(ClientName, PhoneNumber, Address) == true)
            {
                this.ClientName = ClientName;
                this.PhoneNumber = PhoneNumber;
                this.Address = Address;
            }
        }
    }
}
