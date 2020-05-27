using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject.Capitulo_8
{
    public abstract class Money
    {
        protected int amount { get; set; }

        public bool equals(object obj)
        {
            Money money = (Money)obj;
            return this.amount == money.amount;
        }

        public static Money dollar(int v)
        {
            return new Dollar(v);
        }        
        public static Money franc(int v)
        {
            return new Franc(v);
        }

        public abstract Money times(int multiplier);
    }
}
