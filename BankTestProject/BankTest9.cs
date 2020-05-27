using BankProject.Capitulo_9;
using System;
using Xunit;

namespace BankTestProject
{
    public class Capitulo9Test
    {
        [Fact(DisplayName = "Teste de moeda")]
        [Trait("Titulo", "Times we are Living In")]
        public void testCurrency()
        {
            // Arrange

            // Act

            // Assert 
            Assert.Equal("USD", Money.dollar(1).getCurrency());
            Assert.Equal("CHF", Money.franc(1).getCurrency());
        }
    }
}