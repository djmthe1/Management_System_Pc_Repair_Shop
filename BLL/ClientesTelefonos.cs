using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ClientesTelefonos
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Telefono { get; set; }
        ConexionDb conexion = new ConexionDb();

        public ClientesTelefonos(int id, int clienteId, string telefono)
        {
            this.Id = id;
            this.ClienteId = clienteId;
            this.Telefono = telefono;
        }

        public ClientesTelefonos()
        {
        }
    }
}
