﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMDel.Domain.Entities
{
    public class Operator : User
    {
        public Operator(string Name, string Login, string Password) : base(Name, Login, Password)
        { }

    }
}
