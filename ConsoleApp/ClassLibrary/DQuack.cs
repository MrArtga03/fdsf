﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class DQuack : IQuackBehavior
    {
        public string Quack()
        {
            return "Кря кря кря";
        }
    }
}
