using BankProject.Capitulo_7;
using System;
using Xunit;

namespace BankTestProject
{
    public class Capitulo7Test
    {
        [Fact(DisplayName = "Teste de Igualdade")]
        [Trait("Categoria", "Equality for All")]
        public void testEquality()
        {
            // Arrange

            // Act

            // Assert 
            Assert.True(new Dollar(5).equals(new Dollar(5)));
            Assert.False(new Dollar(6).equals(new Dollar(5)));
        }
    }
}
