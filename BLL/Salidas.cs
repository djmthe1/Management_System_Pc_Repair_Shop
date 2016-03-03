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
        public bool Entregado { set; get; }
        public string RetiradoPor { set; get; }
        ConexionDb conexion = new ConexionDb();
        DataTable dt = new DataTable();

        public Salidas(int salidaId, string fecha, int entradaId, bool entregado, string retiradoPor)
        {
            this.SalidaId = salidaId;
            this.Fecha = fecha;
            this.EntradaId = entradaId;
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
                this.SalidaId = (int)conexion.ObtenerValor(String.Format("Insert Into Salidas (Fecha, EntradaId, Entregado, RetiradoPor) Values('{0}',{1},'{2}','{3}') Select @@Identity", this.Fecha, this.EntradaId, this.RetiradoPor));
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
                conexion.Ejecutar(String.Format("Update Salidas set Fecha='{0}', EntradaId={1}, Entregado='{2}', RetiradoPor='{3}' where SalidaId={4}", this.Fecha, this.EntradaId, this.Entregado, this.RetiradoPor, this.SalidaId));
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
            dt = conexion.ObtenerDatos("Select * From Salidas Where SalidaId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.SalidaId = (int)dt.Rows[0]["SalidaId"];
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.EntradaId = (int)dt.Rows[0]["EntradaId"];
                this.Entregado = (bool)dt.Rows[0]["Entregado"];
                this.RetiradoPor = dt.Rows[0]["RetiradoPor"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("Select " + Campos + " From Salidas where " + Condicion + ordenar));
        }

        public bool VerificarVencidos()
        {
            bool retorno = false;
            string hoy = DateTime.Now.ToShortDateString();
            try
            {
                dt = conexion.ObtenerDatos("Select * From Salidas Where Fecha >= " + hoy);
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
