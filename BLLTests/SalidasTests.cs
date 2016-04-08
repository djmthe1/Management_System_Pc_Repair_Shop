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
    public class SalidasTests
    {
        [TestMethod()]
        public void SalidasTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SalidasTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertarTest()
        {
            Salidas salida = new Salidas();
            salida.Fecha = "2016-2-2";
            salida.EntradaId = 1;
            salida.Observacion = "nada";
            salida.RetiradoPor = "Jeff";
            Assert.IsTrue(salida.Insertar());
        }

        [TestMethod()]
        public void EditarTest()
        {
            Salidas salida = new Salidas();
            salida.SalidaId = 1;
            salida.Fecha = "2016-2-2";
            salida.EntradaId = 1;
            salida.Observacion = "nada";
            salida.RetiradoPor = "Jeff";
            Assert.IsTrue(salida.Editar());
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Salidas salida = new Salidas();
            salida.SalidaId = 1;
            Assert.IsTrue(salida.Eliminar());
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Salidas salida = new Salidas();
            salida.SalidaId = 1;
            Assert.IsTrue(salida.Buscar(2));
        }

        [TestMethod()]
        public void ListadoTest()
        {
            Salidas salida = new Salidas();
            Assert.IsTrue(salida.Listado("*", " 1=1 ", "").Rows.Count > 0);
        }

        [TestMethod()]
        public void VerificarVencidosTest()
        {
            Assert.Fail();
        }
    }
}