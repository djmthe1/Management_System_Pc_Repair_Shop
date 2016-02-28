using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Entradas : ClaseMaestra
    {
        public int EntradaId { set; get; }
        public string Fecha { set; get; }
        public int ClienteId { set; get; }
        public string Problemas { set; get; }
        public string Notas { set; get; }
        EntradasArticulos Articulo = new EntradasArticulos();
        public List<EntradasArticulos> articulos { get; set; }
        public ConexionDb conexion = new ConexionDb();

        public Entradas(int entradaId, string fecha, int clienteId, string problemas, string nota)
        {
            this.EntradaId = entradaId;
            this.Fecha = fecha;
            this.ClienteId = clienteId;
            this.Problemas = problemas;
            this.Notas = nota;
        }

        public Entradas()
        {
            articulos = new List<EntradasArticulos>();
        }

        public void InsertarArticulo(int Id, int EntradaId, string Articulo)
        {
            this.articulos.Add(new EntradasArticulos(Id, EntradaId, Articulo));

        }

        public override bool Insertar()
        {
            int retorno = 0;
            object identity;
            try
            {
                //obtengo el identity insertado en la tabla personas
                identity = conexion.ObtenerValor(string.Format("Insert Into Entradas (Fecha, ClienteId, Problemas, Notas) Values ('{0}',{1},'{2}','{3}') Select @@Identity", this.Fecha, this.ClienteId, this.Problemas, this.Notas));

                //intento convertirlo a entero
                int.TryParse(identity.ToString(), out retorno);

                this.ClienteId = retorno;
                if (retorno > 0)
                {
                    foreach (EntradasArticulos descripcion in this.articulos)
                    {
                        conexion.Ejecutar(string.Format("Insert Into EntradasArticulos (EntradaId,Articulo) Values ({0},'{1}')", descripcion.EntradaId, descripcion.Articulo));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno > 0;
        }

        public override bool Editar()
        {
            throw new NotImplementedException();
        }

        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }
        
        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }
    }
}
