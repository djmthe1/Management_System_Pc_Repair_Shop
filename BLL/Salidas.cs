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
        public string RetiradoPor { set; get; }
        ConexionDb conexion = new ConexionDb();

        public Salidas(int salidaId, string fecha, int entradaId, string retiradoPor)
        {
            this.SalidaId = salidaId;
            this.Fecha = fecha;
            this.EntradaId = entradaId;
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
                this.SalidaId = (int)conexion.ObtenerValor(String.Format("Insert Into Salidas (Fecha, EntradaId, RetiradoPor) Values('{0}',{1},'{2}') Select @@Identity", this.Fecha, this.EntradaId, this.RetiradoPor));
                retorno = this.SalidaId > 0;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Update Salidas set Fecha='{0}', EntradaId={1}, RetiradoPor='{2}' where SalidaId={3}", this.Fecha, this.EntradaId, this.RetiradoPor, this.SalidaId));
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
                conexion.Ejecutar(String.Format("Delete From Salidas where SalidaId={0}", this.SalidaId));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from Salidas Where SalidaId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.SalidaId = (int)dt.Rows[0]["SalidaId"];
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.EntradaId = (int)dt.Rows[0]["EntradaId"];
                this.RetiradoPor = dt.Rows[0]["RetiradoPor"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("Select " + Campos + " from Salidas where " + Condicion + ordenar));
        }
    }
}
