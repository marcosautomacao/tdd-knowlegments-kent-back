using BankProject.Capitulo_5;
using System;
using Xunit;

namespace BankTestProject
{
    public class Capitulo5Test
    {
        [Fact(DisplayName = "Teste de Multiplicacao em Francos")]
        [Trait("Titulo", "Fanc-ly speaking")]
        public void testFrancMultiplication()
        {
            // Arrange
            Franc five = new Franc(5);
            // Assert 
            Assert.True(new Franc(10).equals(five.times(2)));
            // Assert 
            Assert.True(new Franc(15).equals(five.times(3)));
        }
    }
}
