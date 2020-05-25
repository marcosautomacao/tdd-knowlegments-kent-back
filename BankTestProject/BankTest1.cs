using BankProject.Capitulo_1;
using System;
using Xunit;

namespace BankTestProject
{
    public class Capitulo1Test1
    {
        [Fact(DisplayName = "Teste de Multiplicacao")]
        [Trait("Categoria", "Multicurrency Money")]
        public void testMultiplication()
        {
            // Arrange
            Dollar five = new Dollar(5);

            // Act
            five.times(2);

            // Assert 
            Assert.Equal(10, five.amount);
        }
    }
}
