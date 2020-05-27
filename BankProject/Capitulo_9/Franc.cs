using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject.Capitulo_9
{
    public class Franc : Money
    {
        public Franc(int amount, string currency) : base(amount, currency) {}

        public override Money times(int multiplier)
        {
            return Money.franc(multiplier);
        }
    }
}
