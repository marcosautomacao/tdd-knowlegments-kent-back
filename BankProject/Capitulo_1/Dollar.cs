using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject.Capitulo_1
{
    public class Dollar
    {
        public int amount { get; set; }
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public void times(int multiplier)
        {
            this.amount *= multiplier;
        }
    }
}
