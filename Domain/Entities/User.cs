using ARMDel.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Domain.Entities
{
    public abstract class User: IUser
    {
        public string Name { get;}
        public string Login { get; }
        public string Password { get;}  

        public User(string Name, string Login, string Password)
        {
            if (Name == null)
                throw new ArgumentNullException("Null name");
            else if (Login == null)
                throw new ArgumentNullException("Null login");
            else if (Password == null)
                throw new ArgumentNullException("Null Password");
            else 
                this.Name = Name;
                this.Login = Login;
                this.Password = Password;
        }
    }
}
