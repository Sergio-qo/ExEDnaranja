using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExEDNaranja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEDNaranja.Tests
{
    [TestClass()]
    public class ClienteTests
    {
        /// <summary>
        /// Comprueba que el metodo suma saldo es correcto
        /// </summary>
        [TestMethod()]
        public void SumaSaldoTest()
        {
            Cliente cliente = new Cliente();
            cliente.SumaSaldo(50);
            Assert.IsTrue(cliente.Saldo == 150);
        }
        /// <summary>
        /// Comprueba que el metodo restaSaldo es correcto
        /// </summary>
        [TestMethod()]
        public void RestaSaldoTest()
        {
            Cliente cliente = new Cliente();
            cliente.RestaSaldo(50);
            Assert.IsTrue(cliente.Saldo == 50);
        }
    }
}