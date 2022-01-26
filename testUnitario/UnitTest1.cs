using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDatos;

namespace testUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ClienteIgualar()
        {

            //agrega un cliente a la lista en caso de no existir en la misma.
            Cliente auxCliente = new Cliente("wilson", "Huallpa", 221);

            Assert.IsTrue(Comercio.GetListaClientes() + auxCliente);
        }

        [TestMethod]
        public void Comparar()
        {

        }
    }
}
