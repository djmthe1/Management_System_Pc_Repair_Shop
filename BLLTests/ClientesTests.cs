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

            clientes.NombreCompleto = "Jeff Rodriguez";
            clientes.Direccion = "Duarte";
            Assert.IsTrue(clientes.Insertar());
        }

        [TestMethod()]
        public void EditarTest()
        {
            Clientes clientes = new Clientes();

            clientes.ClienteId = 1;
            clientes.NombreCompleto = "Jeff Rodriguez";
            clientes.Direccion = "Duarte";
            Assert.IsTrue(clientes.Editar());
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Clientes clientes = new Clientes();

            clientes.ClienteId = 1;
            Assert.IsTrue(clientes.Eliminar());
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Clientes clientes = new Clientes();

            Assert.IsTrue(clientes.Buscar(0));
        }

        [TestMethod()]
        public void ListadoTest()
        {
            Clientes clientes = new Clientes();

            Assert.IsTrue(clientes.Listado(" * ", " 1=1 ", "").Rows.Count > 0);
        }
    }
}