using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Salidas : ClaseMaestra
    {
        public int SalidaId { set; get; }
        public string Fecha { set; get; }
        public int EntradaId { set; get; }
        public string Observacion { set; get; }
        public bool Entregado { set; get; }
        public string RetiradoPor { set; get; }
        ConexionDb conexion = new ConexionDb();
        DataTable dt = new DataTable();

        public Salidas(int salidaId, string fecha, int entradaId, string obsevacion, bool entregado, string retiradoPor)
        {
            this.SalidaId = salidaId;
            this.Fecha = fecha;
            this.EntradaId = entradaId;
            this.Observacion = obsevacion;
            this.Entregado = entregado;
            this.RetiradoPor = retiradoPor;
        }

        public Salidas()
        {

        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("INSERT INTO Salidas (Fecha, EntradaId, Observacion, RetiradoPor) VALUES('{0}',{1},'{2}','{3}','{4}')", this.Fecha, this.EntradaId, this.Observacion, this.RetiradoPor));
                if (retorno)
                {
                    conexion.Ejecutar(String.Format("UPDATE Entradas SET Salio='True', WHERE EntradaId={0}", this.EntradaId));
                }
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("UPDATE Salidas SET Fecha='{0}', EntradaId={1}, Observacion='{2}', RetiradoPor='{3}' WHERE SalidaId={4}", this.Fecha, this.EntradaId, this.Observacion, this.RetiradoPor, this.SalidaId));
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
                conexion.Ejecutar(String.Format("DELETE FROM Salidas WHERE SalidaId={0}", this.SalidaId));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            dt = conexion.ObtenerDatos("SELECT * FROM Salidas WHERE SalidaId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.SalidaId = (int)dt.Rows[0]["SalidaId"];
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.EntradaId = (int)dt.Rows[0]["EntradaId"];
                this.Observacion = dt.Rows[0]["Observacion"].ToString();
                this.RetiradoPor = dt.Rows[0]["RetiradoPor"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("SELECT " + Campos + " FROM Salidas WHERE " + Condicion + ordenar));
        }

        public bool VerificarVencidos(string Campos)
        {
            bool retorno = false;
            string hoy = DateTime.Now.ToShortDateString();
            try
            {
                dt = conexion.ObtenerDatos("SELECT * FROM Salidas WHERE Fecha >= " + hoy + Campos);
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
