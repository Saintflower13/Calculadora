using Services.Calculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTestTestes
{
    [TestClass]
    public class TestesCalculos
    {
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(-5, -100, -105)]
        [DataRow(999, -99, 900)]
        [DataRow(5.64, 48.75, 54.39)]
        [DataRow(1557, 2405, 3962)]
        [DataRow(-517.4, 157, -360.4)]
        [DataRow(-55, 100, 45)]
        public void AdicaoTeste(double a, double b, double valor_esperado)
        {
            // Arrange
            Calculadora calculadora = new Calculadora();

            // ACt
            double valor_calculado = calculadora.Somar(a, b);

            // Assert
            Assert.AreEqual(valor_esperado, valor_calculado);
        }

        [DataTestMethod]
        [DataRow(10, 0, 10)]
        [DataRow(10, 10, 0)]
        [DataRow(-5, -75, 70)]
        [DataRow(14.71, 2.14, 12.57)]
        [DataRow(856, 900, -44)]
        [DataRow(5.37, -0.63, 6)]
        public void SubtracaoTeste(double a, double b, double valor_esperado)
        {
            // Arrange
            Calculadora calculadora = new Calculadora();

            // Act
            double valor_calculado = calculadora.Subtrair(a, b);

            // Assert
            Assert.AreEqual(valor_esperado, valor_calculado);
        }

        [DataTestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(10, 10, 100)]
        [DataRow(45, 5.3, 238.5)]
        [DataRow(0.3, 0.5, 0.15)]
        [DataRow(7, -1.5, -10.5)]
        public void MultiplicacaoTeste(double a, double b, double valor_esperado)
        {
            // Arrange
            Calculadora calculadora = new Calculadora();

            // Act
            double valor_calculado = calculadora.Multiplicar(a, b);

            // Assert
            Assert.AreEqual(valor_esperado, valor_calculado);
        }

        [DataTestMethod]
        [DataRow(10, 2, 5)]
        [DataRow(70, 10, 7)]
        [DataRow(5, 10, 0.5)]
        [DataRow(5, -10, -0.5)]
        public void DivisaoTeste(double a, double b, double valor_esperado)
        {
            // Arrange
            Calculadora calculadora = new Calculadora();

            // Act
            double valor_calculado = calculadora.Dividir(a, b);

            // Assert
            Assert.AreEqual(valor_esperado, valor_calculado);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DisparaExcecaoSeDivisorForZero()
        {
            // Arrange
            Calculadora calculadora = new Calculadora();
            double a = 10;
            double b = 0;

            // Act
            double valor_calculado = calculadora.Dividir(a, b);
        }
    }
}

