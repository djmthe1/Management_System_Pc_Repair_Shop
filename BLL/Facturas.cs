using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Facturas : ClaseMaestra
    {

        public int FacturaId { set; get; }
        public string Fecha { set; get; }
        public int SalidaId { set; get; }
        public int ClienteId { set; get; }
        public float Total { set; get; }
        public float MontoAPagar { set; get; }
        public string DespachadoPor { set; get; }
    ArticulosVendidos Articulo = new ArticulosVendidos();
        public List<ArticulosVendidos> articulos { get; set; }
        ConexionDb conexion = new ConexionDb();

        public Facturas(int facturaId, string fecha, int salidaId, int clienteId, float total, float montoAPagar, string despachadoPor)
        {
            this.FacturaId = facturaId;
            this.Fecha = fecha;
            this.SalidaId = salidaId;
            this.ClienteId = clienteId;
            this.Total = total;
            this.MontoAPagar = montoAPagar;
            this.DespachadoPor = despachadoPor;
        }

        public Facturas()
        {

        }

        public override bool Insertar()
        {
            int retorno = 0;
            object identity;
            try
            {
                //obtengo el identity insertado en la tabla
                identity = conexion.ObtenerValor(string.Format("INSERT INTO Facturas (Fecha, SalidaId, ClienteId, Total, MontoAPagar, DespachadoPor) VALUES ('{0}'.{1},{2},{3},{4},'{5}') Select @@Identity", this.SalidaId, this.ClienteId, this.Total, this.MontoAPagar, this.DespachadoPor));

                //intento convertirlo a entero
                int.TryParse(identity.ToString(), out retorno);

                this.FacturaId = retorno;
                if (retorno > 0)
                 {
                     foreach (ArticulosVendidos datos in this.articulos)
                     {
                         conexion.Ejecutar(string.Format("INSERT INTO ArticulosVendidos (FacturaId, Pieza, Marca, Precio) VALUES ({0},'{1}','{2}',{3})", datos.FacturaId, datos.Pieza, datos.Marca, datos.Precio));
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
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("SELECT " + Campos + " FROM Facturas WHERE " + Condicion + ordenar));
        }
    }
}
