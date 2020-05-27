using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject.Capitulo_6
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc times(int multiplier)
        {
            return new Franc(this.amount * multiplier);
        }
    }
}
