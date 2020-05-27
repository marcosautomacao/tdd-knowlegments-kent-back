﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject.Capitulo_3
{
    public class Dollar
    {
        public int amount { get; set; }
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar times(int multiplier)
        {
            return new Dollar(this.amount * multiplier);
        }

        public bool equals(object obj)
        {
            Dollar dollar = (Dollar)obj;
            return this.amount == dollar.amount;
        }
    }
}
