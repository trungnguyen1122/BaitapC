﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM 
{
    class MobilePhone : Product
    {
       
 public MobilePhone(int id, string name, double price, string producer) : base (id, name, price, producer)
        {
        }

        public override double computeTax() => this.price * 10 /100;
    }
}
