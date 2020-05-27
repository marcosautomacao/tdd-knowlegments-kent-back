using BankProject.Capitulo_6;
using System;
using Xunit;

namespace BankTestProject
{
    public class Capitulo6Test
    {
        [Fact(DisplayName = "Teste de Igualdade")]
        [Trait("Categoria", "Equuality for all - Redux")]
        public void testEquality()
        {
            // Arrange

            // Act

            // Assert 
            Assert.True(new Dollar(5).equals(new Dollar(5)));
            Assert.False(new Dollar(6).equals(new Dollar(5)));
            Assert.True(new Franc(5).equals(new Franc(5)));
            Assert.False(new Franc(5).equals(new Franc(6)));
        }
    }
}
