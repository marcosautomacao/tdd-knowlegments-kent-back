using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject.Capitulo_8
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public override Money times(int multiplier)
        {
            return new Dollar(this.amount * multiplier);
        }
    }
}
