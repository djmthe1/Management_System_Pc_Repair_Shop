using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Tests
{
    [TestClass()]
    public class ClientesTests
    {
        [TestMethod()]
        public void ClientesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ClientesTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertarTelefonoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertarTest()
        {
            Clientes clientes = new Clientes();
            clientes.Nombre = "";
            clientes.Apellido = "";
            clientes.Direccion = "";

            Assert.IsTrue(clientes.Insertar());
        }

        [TestMethod()]
        public void EditarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ListadoTest()
        {
            Assert.Fail();
        }
    }
}