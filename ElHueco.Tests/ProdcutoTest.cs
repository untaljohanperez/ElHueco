using ElHueco.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElHueco.Tests
{
    [TestClass]
    public class ProductoTest
    {
        [TestMethod] 
        public void ConstructorProducto()
        {
            Producto producto = new Producto("Alcancia tarro mediana", 700, 400);

            Assert.AreEqual("Alcancia tarro mediana", producto.nombreProducto);
            Assert.AreEqual(700, producto.precioVenta);
            Assert.AreEqual(400, producto.costoProducto); 
        }
    }
}
