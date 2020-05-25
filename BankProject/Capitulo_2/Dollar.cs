using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject.Capitulo_2
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
    }
}
