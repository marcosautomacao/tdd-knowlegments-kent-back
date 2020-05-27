using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject.Capitulo_7
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Money times(int multiplier)
        {
            return new Dollar(this.amount * multiplier);
        }
    }
}
