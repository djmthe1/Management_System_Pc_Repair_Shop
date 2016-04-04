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
    public class UsuariosTests
    {
        [TestMethod()]
        public void UsuariosTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UsuariosTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertarTest()
        {
            Usuarios usuario = new Usuarios();
            
            usuario.Nombre = "Jeff";
            usuario.Password = "1234";
            usuario.Prioridad = "Administrador";
            Assert.IsTrue(usuario.Insertar());
        }

        [TestMethod()]
        public void EditarTest()
        {
            Usuarios usuario = new Usuarios();

            usuario.UsuarioId = 1;
            usuario.Nombre = "Jeff";
            usuario.Password = "1234";
            usuario.Prioridad = "Administrador";
            Assert.IsTrue(usuario.Editar());
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Usuarios usuario = new Usuarios();

            usuario.UsuarioId = 1;
            Assert.IsTrue(usuario.Eliminar());
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Usuarios usuario = new Usuarios();

            Assert.IsTrue(usuario.Buscar(0));
        }

        [TestMethod()]
        public void ListadoTest()
        {
            Usuarios usuario = new Usuarios();

            Assert.IsTrue(usuario.Listado(" * ", " 1=1 ", "").Rows.Count > 0);
        }

        [TestMethod()]
        public void VerificarTest()
        {
            Assert.Fail();
        }
    }
}