using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class EntradasArticulos
    {
        public int Id { set; get; }
        public int EntradaId { set; get; }
        public string Articulo { set; get; }
        public string Problema { set; get; }
        ConexionDb conexion = new ConexionDb();

        public EntradasArticulos(int id, int entradaId, string Articulo, string problema)
        {
            this.Id = id;
            this.EntradaId = entradaId;
            this.Articulo = Articulo;
            this.Problema = problema;
        }

        public EntradasArticulos( string Articulo, string problema)
        {
            this.Articulo = Articulo;
            this.Problema = problema;
        }

        public EntradasArticulos()
        {
        }
    }
}
