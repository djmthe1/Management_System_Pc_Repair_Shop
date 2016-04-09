using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ArticulosEntregados
    {
        public int Id { set; get; }
        public int FacturaId { set; get; }
        public string Articulo { set; get; }
        public string Problema { set; get; }
        public float Cargo { set; get; }
        ConexionDb conexion = new ConexionDb();

        public ArticulosEntregados(int id, int facturaId, string Articulo, string problema, float cargo)
        {
            this.Id = id;
            this.FacturaId = facturaId;
            this.Articulo = Articulo;
            this.Problema = problema;
            this.Cargo = cargo;
        }

        public ArticulosEntregados(int facturaId, string Articulo, string problema, float cargo)
        {
            this.FacturaId = facturaId;
            this.Articulo = Articulo;
            this.Problema = problema;
            this.Cargo = cargo;
        }

        public ArticulosEntregados(string Articulo, string problema, float cargo)
        {
            this.Articulo = Articulo;
            this.Problema = problema;
            this.Cargo = cargo;
        }

        public ArticulosEntregados()
        {
        }
    }
}
