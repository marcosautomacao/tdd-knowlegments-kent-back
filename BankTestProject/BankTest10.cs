using BankProject.Capitulo_10;
using System;
using Xunit;

namespace BankTestProject
{
    public class Capitulo10Test
    {
        [Fact(DisplayName = "Teste de Igualdade")]
        [Trait("Titulo", "Interesting Times")]
        public void testDifferentClassEquality()
        {
            // Arrange

            // Act

            // Assert 
            Assert.True(new Money(5, "USD").equals(new Money(5, "USD")));
        }
    }
}