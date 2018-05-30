using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoPruebasUnitarias.Tests
{
    [TestClass]
    public class DivisionTests
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void divisionDivideEntreCero()
        {
            //Arrange o Planteamiento
            const int dividendo = 8;
            const int divisor = 0;
            const int esperado = 8;
            //Act o Prueba
            var actual = Matematicas.division(dividendo, divisor);

            //Assert o Excepción
            Assert.AreEqual(esperado, actual);
        }
    }
}
