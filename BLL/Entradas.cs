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
        public string Notas { set; get; }
        public string RecibidoPor { set; get; }
        public bool Salio { set; get; }
        public bool Entregado { set; get; }
        EntradasArticulos Articulo = new EntradasArticulos();
        public List<EntradasArticulos> articulos { get; set; }
        ConexionDb conexion = new ConexionDb();
        DataTable dt = new DataTable();

        public Entradas(int entradaId, string fecha, string fechaEntrega, int clienteId, string nota, string recibidoPor, bool salio, bool entregado)
        {
            this.EntradaId = entradaId;
            this.Fecha = fecha;
            this.FechaEntrega = fechaEntrega;
            this.ClienteId = clienteId;
            this.Notas = nota;
            this.RecibidoPor = recibidoPor;
            this.Salio = salio;
            this.Entregado = entregado;
        }

        public Entradas()
        {
            articulos = new List<EntradasArticulos>();
        }

        public void InsertarArticulo(int EntradaId, string Articulo, string Problema)
        {
            this.articulos.Add(new EntradasArticulos(EntradaId, Articulo, Problema));
        }

        public void LimpiarArticulo()
        {
            this.articulos.Clear();
        }

        public override bool Insertar()
        {
            int retorno = 0;
            object identity;
            try
            {
                //obtengo el identity insertado en la tabla
                identity = conexion.ObtenerValor(String.Format("Insert Into Entradas (Fecha, FechaEntrega, ClienteId, Notas, RecibidoPor) Values ('{0}','{1}',{2},'{3}','{4}') Select @@Identity", this.Fecha, this.FechaEntrega, this.ClienteId, this.Notas, this.RecibidoPor));

                //intento convertirlo a entero
                int.TryParse(identity.ToString(), out retorno);

                this.EntradaId = retorno;
                if (retorno > 0)
                {
                    foreach (EntradasArticulos descripcion in this.articulos)
                    {
                        conexion.Ejecutar(String.Format("Insert Into EntradasArticulos (EntradaId, Articulo, Problema) Values ({0},'{1}','{2}')", retorno, descripcion.Articulo, descripcion.Problema));
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
                retorno = conexion.Ejecutar(String.Format("Update Entradas Set Fecha='{0}', FechaEntrega='{1}', ClienteId={2}, Notas='{3}', RecibidoPor='{4}' WHERE EntradaId={5}", this.Fecha, this.FechaEntrega, this.ClienteId, this.Notas, this.RecibidoPor, this.EntradaId));
                if (retorno)
                {
                    conexion.Ejecutar(String.Format("Delete FROM EntradasArticulos WHERE EntradaId= {0}", this.EntradaId));
                    foreach (EntradasArticulos descripcion in this.articulos)
                    {
                        conexion.Ejecutar(String.Format("Insert Into EntradasArticulos (EntradaId, Articulo, Problema) Values ({0},'{1}','{2}')", descripcion.EntradaId, descripcion.Articulo, descripcion.Problema));
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
                retorno = conexion.Ejecutar(String.Format("Delete FROM Entradas WHERE EntradaId={0}", this.EntradaId));
                if (retorno)
                    conexion.Ejecutar(String.Format("Delete FROM EntradasArticulos WHERE EntradaId={0}", this.EntradaId));
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }
        
        public override bool Buscar(int IdBuscado)
        {
            DataTable dtArticulos = new DataTable();

            dt = conexion.ObtenerDatos("SELECT * FROM Entradas WHERE EntradaId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.EntradaId = (int)dt.Rows[0]["EntradaId"];
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.FechaEntrega = dt.Rows[0]["FechaEntrega"].ToString();
                this.ClienteId = (int)dt.Rows[0]["ClienteId"];
                this.Notas = dt.Rows[0]["Notas"].ToString();
                this.RecibidoPor = dt.Rows[0]["RecibidoPor"].ToString();
                //this.Salio = (bool)dt.Rows[0]["Salio"];
                //this.Entregado = (bool)dt.Rows[0]["Entregado"];

                dtArticulos = conexion.ObtenerDatos(String.Format("SELECT * FROM EntradasArticulos WHERE EntradaId=" + IdBuscado));

                foreach (DataRow row in dtArticulos.Rows)
                {
                    this.InsertarArticulo((int)dtArticulos.Rows[0]["EntradaId"], row["Articulo"].ToString(), row["Problema"].ToString());
                }
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("SELECT " + Campos + " FROM Entradas WHERE " + Condicion + ordenar));
        }

        public bool VerificarAtrasos(string Campos)
        {
            bool retorno = false;
            string hoy = DateTime.Now.ToShortDateString();
            try
            {
                dt = conexion.ObtenerDatos("SELECT * FROM Entradas WHERE Salio='False' AND FechaEntrega <= getDate()");
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
