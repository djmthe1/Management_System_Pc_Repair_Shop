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
        public string FechaEntrega { set; get; }
        public int ClienteId { set; get; }
        public string Problemas { set; get; }
        public string Notas { set; get; }
        public string RecibidoPor { set; get; }
        EntradasArticulos Articulo = new EntradasArticulos();
        public List<EntradasArticulos> articulos { get; set; }
        ConexionDb conexion = new ConexionDb();
        DataTable dt = new DataTable();

        public Entradas(int entradaId, string fecha, string fechaEntrega, int clienteId, string problemas, string nota, string recibidoPor)
        {
            this.EntradaId = entradaId;
            this.Fecha = fecha;
            this.FechaEntrega = fechaEntrega;
            this.ClienteId = clienteId;
            this.Problemas = problemas;
            this.Notas = nota;
            this.RecibidoPor = recibidoPor;
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
                identity = conexion.ObtenerValor(string.Format("Insert Into Entradas (Fecha, FechaEntrega, ClienteId, Problemas, Notas, RecibidoPor) Values ('{0}','{2}',{1},'{3}','{4}','{5}') Select @@Identity", this.Fecha, this.FechaEntrega, this.ClienteId, this.Problemas, this.Notas, this.RecibidoPor));

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
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Update Entradas Set Fecha='{0}', FechaEntrega='{1}', ClienteId={2}, Problemas='{3}', Notas='{4}', RecibidoPor='{5}' where EntradaId={6}", this.Fecha, this.FechaEntrega, this.ClienteId, this.Problemas, this.Notas, this.RecibidoPor, this.EntradaId));
                if (retorno)
                {
                    conexion.Ejecutar(string.Format("Delete From EntradasArticulos Where EntradaId= {0}", this.EntradaId));
                    foreach (EntradasArticulos descripcion in this.articulos)
                    {
                        conexion.Ejecutar(string.Format("Insert Into EntradasArticulos (EntradaId,Articulo) Values ({0},'{1}')", descripcion.EntradaId, descripcion.Articulo));
                    }
                }
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Delete From Entradas where EntradaId={0}", this.EntradaId));
                if (retorno)
                    conexion.Ejecutar(string.Format("Delete From EntradasArticulos Where EntradaId={0}", this.EntradaId));
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }
        
        public override bool Buscar(int IdBuscado)
        {
            DataTable dtArticulos = new DataTable();

            dt = conexion.ObtenerDatos("Select * From Entradas Where EntradaId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.EntradaId = (int)dt.Rows[0]["EntradaId"];
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.FechaEntrega = dt.Rows[0]["FechaEntrega"].ToString();
                this.ClienteId = (int)dt.Rows[0]["ClienteId"];
                this.Problemas = dt.Rows[0]["Problemas"].ToString();
                this.Notas = dt.Rows[0]["Notas"].ToString();
                this.RecibidoPor = dt.Rows[0]["RecibidoPor"].ToString();

                dtArticulos = conexion.ObtenerDatos(String.Format("Select E.Fecha, A.Articulo as Articulo from Entradas E inner join EntradasArticulos A on E.EntradaId = A.EntradaId where E.EntradaId = {0}", IdBuscado));

                foreach (DataRow row in dtArticulos.Rows)
                {
                    InsertarArticulo(1, EntradaId, row["Articulo"].ToString());
                }
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("Select " + Campos + " from Entradas where " + Condicion + ordenar));
        }

        public bool VerificarAtrasos(string Campos)
        {
            bool retorno = false;
            string hoy = DateTime.Now.ToShortDateString();
            try
            {
                dt = conexion.ObtenerDatos("Select * From Entradas Where Fecha >= " + hoy + Campos);
                if (dt.Rows.Count > 0)
                {
                    retorno = true;
                }
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }
    }
}
