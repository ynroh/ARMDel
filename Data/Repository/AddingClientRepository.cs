using ARMDel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Data.Repository
{
    public class AddingClientRepository
    {
        public Client AddClient(string ClientName, string PhoneNumber, Address Address)
        {
            Client Client = new Client(ClientName, PhoneNumber, Address);
            return Client;
        }
    }
}
