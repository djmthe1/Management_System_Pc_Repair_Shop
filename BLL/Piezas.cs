using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Piezas : ClaseMaestra
    {
        public int PiezaId { set; get; }
        public string Descripcion { set; get; }
        ConexionDb conexion = new ConexionDb();

        public Piezas(int piezaId, string descripcion)
        {
            this.PiezaId = piezaId;
            this.Descripcion = descripcion;
        }

        public Piezas()
        {
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("INSERT INTO Piezas (Descripcion) VALUES ('{0}')", this.Descripcion));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("UPDATE Piezas SET Descripcion='{0}' WHERE PiezaId={1}", this.Descripcion, this.PiezaId));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("DELETE FROM Piezas WHERE PiezaId={0}", this.PiezaId));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("SELECT * FROM Piezas WHERE PiezaId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.PiezaId = (int)dt.Rows[0]["PiezaId"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenFinal = "";
            if (!Orden.Equals(""))
                ordenFinal = " orden by  " + Orden;
            return conexion.ObtenerDatos(string.Format("SELECT " + Campos + " FROM Piezas WHERE " + Condicion + Orden));

        }
    }
}
