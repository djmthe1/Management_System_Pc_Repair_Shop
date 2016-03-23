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
    public class PiezasTests
    {
        [TestMethod()]
        public void PiezasTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PiezasTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertarTest()
        {
            Piezas pieza = new Piezas();
            pieza.Descripcion = "Motherboard";
            Assert.IsTrue(pieza.Insertar());
        }

        [TestMethod()]
        public void EditarTest()
        {
            Piezas pieza = new Piezas();
            pieza.PiezaId = 1;
            pieza.Descripcion = "Procesador";
            Assert.IsTrue(pieza.Editar());
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Piezas pieza = new Piezas();
            pieza.PiezaId = 1;
            Assert.IsTrue(pieza.Eliminar());
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Piezas pieza = new Piezas();
            Assert.IsTrue(pieza.Buscar(1));
        }

        [TestMethod()]
        public void ListadoTest()
        {
            Piezas pieza = new Piezas();
            Assert.IsTrue(pieza.Listado(" * ", " 1=1 ", "").Rows.Count > 0);
        }
    }
}