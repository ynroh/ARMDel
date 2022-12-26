using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Domain.Repository
{
    public interface IUser
    {
        string Name { get;}
        string Login { get;}
        string Password { get;}
    }
}
