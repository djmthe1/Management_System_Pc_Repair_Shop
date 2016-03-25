using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ArticulosVendidos
    {
        public int Id { set; get; }
        public int FacturaId { set; get; }
        public string Pieza { set; get; }
        public string Marca { set; get; }
        public float Precio { set; get; }

        public ArticulosVendidos(int id, int facturaId, string Pieza, string Marca, float precio)
        {
            this.Id = id;
            this.FacturaId = facturaId;
            this.Pieza = Pieza;
            this.Marca = Marca;
            this.Precio = precio;
        }

        public ArticulosVendidos(string Pieza, string Marca, float precio)
        {
            this.Pieza = Pieza;
            this.Marca = Marca;
            this.Precio = precio;
        }
        public ArticulosVendidos()
        {

        }
    }
}
