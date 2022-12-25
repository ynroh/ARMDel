using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Domain.Entities
{
    public class Administrator: User
    {
        public Administrator(string name, string login, string password):base(name, login, password)
        { }
    }
}
