using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject.Capitulo_9
{
    public abstract class Money
    {
        protected string currency;
        protected int amount { get; set; }
        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public bool equals(object obj)
        {
            Money money = (Money)obj;
            return this.amount == money.amount;
        }

        public static Money dollar(int v)
        {
            return new Dollar(v, "USD");
        }


        public static Money franc(int v)
        {
            return new Franc(v, "CHF");
        }

        public string getCurrency()
        {
            return currency;
        }

        public abstract Money times(int multiplier);
    }
}
