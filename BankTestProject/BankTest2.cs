using BankProject.Capitulo_2;
using System;
using Xunit;

namespace BankTestProject
{
    public class Capitulo2Test
    {
        [Fact(DisplayName = "Teste de Multiplicacao")]
        [Trait("Categoria", "Degenerate Objects")]
        public void testMultiplication()
        {
            // Arrange
            Dollar five = new Dollar(5);

            // Act
            var product = five.times(2);

            // Assert 
            Assert.Equal(10, product.amount);

            // Act
            product = five.times(3);

            // Assert 
            Assert.Equal(15, product.amount);
        }
    }
}
