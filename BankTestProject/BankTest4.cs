using BankProject.Capitulo_4;
using System;
using Xunit;

namespace BankTestProject
{
    public class Capitulo4Test
    {
        [Fact(DisplayName = "Teste de Multiplicacao")]
        [Trait("Categoria", "Privacy")]
        public void testMultiplication()
        {
            // Arrange
            Dollar five = new Dollar(5);
            // Assert 
            Assert.True(new Dollar(10).equals(five.times(2)));
            // Assert 
            Assert.True(new Dollar(15).equals(five.times(3)));
        }
    }
}
