using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElHueco.Models;

namespace ElHueco.Tests
{
    [TestClass]
    public class ClienteTest
    {
        [TestMethod]
        public void ConstructorCliente()
        {
            var cliente = new Cliente("Johan Perez", "1045081064","3113685322", "Medellin Barrio Fino");

            Assert.AreEqual("Johan Perez", cliente.nombreCliente);
            Assert.AreEqual("3113685322", cliente.telefono);
            Assert.AreEqual("1045081064", cliente.documentoId);
            Assert.AreEqual("Medellin Barrio Fino", cliente.direccion);
         }
        

    }
}
