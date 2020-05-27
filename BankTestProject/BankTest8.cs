using BankProject.Capitulo_8;
using System;
using Xunit;

namespace BankTestProject
{
    public class Capitulo8Test
    {
        [Fact(DisplayName = "Teste de Igualdade")]
        [Trait("Titulo", "Makin' Objects")]
        public void testEquality()
        {
            // Arrange

            // Act

            // Assert 
            Assert.True(new Dollar(5).equals(new Dollar(5)));
            Assert.False(new Dollar(6).equals(new Dollar(5)));
        }

        [Fact(DisplayName = "Teste de Multiplicacao")]
        [Trait("Titulo", "Makin' Objects")]
        public void testFrancMultiplication()
        {
            // Arrange
            Money five = Money.dollar(5);
            // Assert 
            Assert.True(new Franc(10).equals(five.times(2)));
            // Assert 
            Assert.True(new Franc(15).equals(five.times(3)));
        }
    }
}