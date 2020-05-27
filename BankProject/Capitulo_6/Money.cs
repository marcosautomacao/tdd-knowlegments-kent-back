using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject.Capitulo_6
{
    public class Money
    {
        protected int amount { get; set; }

        public bool equals(object obj)
        {
            Money money = (Money)obj;
            return this.amount == money.amount;
        }
    }
}
