using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Domain.Entities
{
    public class Client
    {
        public string ClientName { get; }
        public int[] PhoneNumber { get; }
        public Address Address { get; }
        private bool IsNormalParameters(string ClientName, int[] PhoneNumber, Address Address)
        {
            bool isNormal = true;
            
            bool NullClientName = ClientName == "";
            bool NullPhoneNumber = PhoneNumber == null;
            bool NullAddress = Address == null;
            bool InvalidPhoneNumber = PhoneNumber.Length != 10;
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
                throw new ArgumentException("PhoneNumber must contain 10 digits");
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
        public Client(string ClientName, int[] PhoneNumber, Address Address)
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
