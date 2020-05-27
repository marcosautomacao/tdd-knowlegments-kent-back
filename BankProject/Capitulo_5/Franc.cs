using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject.Capitulo_5
{
    public class Franc
    {
        private int amount { get; set; }
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc times(int multiplier)
        {
            return new Franc(this.amount * multiplier);
        }

        public bool equals(object obj)
        {
            Franc dollar = (Franc)obj;
            return this.amount == dollar.amount;
        }
    }
}
