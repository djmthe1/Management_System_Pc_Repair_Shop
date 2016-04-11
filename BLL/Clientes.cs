using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Clientes : ClaseMaestra
    {
        public int ClienteId { set; get; }
        public string NombreCompleto { set; get; }
        public string Direccion { set; get; }
        ClientesTelefonos Telefono = new ClientesTelefonos();
        public List<ClientesTelefonos> telefonos { get; set; }
        ConexionDb conexion = new ConexionDb();

        public Clientes(int clienteId, string nombreCompleto, string apellido, string direccion)
        {
            this.ClienteId = clienteId;
            this.NombreCompleto = nombreCompleto;
            this.Direccion = direccion;
        }

        public Clientes()
        {
            telefonos = new List<ClientesTelefonos>();
        }

        public void InsertarTelefono(int ClienteId, string Tipo, string Telefono)
        {
            this.telefonos.Add(new ClientesTelefonos(ClienteId, Tipo, Telefono));
        }

        public override bool Insertar()
        {
            int retorno = 0;
            object identity;
            try
            {
                //obtengo el identity insertado en la tabla
                identity = conexion.ObtenerValor(String.Format("INSERT INTO Clientes (NombreCompleto, Direccion) VALUES ('{0}','{1}') SELECT @@Identity", this.NombreCompleto, this.Direccion));

                //intento convertirlo a entero
                int.TryParse(identity.ToString(), out retorno);

                this.ClienteId = retorno;
                if (retorno > 0)
                {
                    foreach (ClientesTelefonos numeros in this.telefonos)
                    {
                        conexion.Ejecutar(String.Format("INSERT INTO ClientesTelefonos (ClienteId, Tipo, Telefono) VALUES ({0},'{1}','{2}')", retorno, numeros.Tipo, numeros.Telefono));
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
                retorno = conexion.Ejecutar(String.Format("UPDATE Clientes SET NombreCompleto='{0}', Direccion='{1}' WHERE ClienteId={2}", this.NombreCompleto, this.Direccion, this.ClienteId));
                if (retorno)
                {
                    conexion.Ejecutar(String.Format("DELETE FROM ClientesTelefonos WHERE ClienteId={0}", this.ClienteId));
                    foreach (ClientesTelefonos numeros in this.telefonos)
                    {
                        conexion.Ejecutar(string.Format("INSERT INTO ClientesTelefonos (ClienteId, Tipo, Telefono) VALUES ({0},'{1}','{2}')", this.ClienteId, numeros.Tipo, numeros.Telefono));
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
                retorno = conexion.Ejecutar(String.Format("DELETE FROM Clientes WHERE ClienteId={0}", this.ClienteId));
                if (retorno)
                    conexion.Ejecutar(String.Format("DELETE FROM ClientesTelefonos WHERE ClienteId={0}", this.ClienteId));
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();
            DataTable dtTelefonos = new DataTable();

            dt = conexion.ObtenerDatos("SELECT * FROM Clientes WHERE ClienteId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.ClienteId = (int)dt.Rows[0]["ClienteId"];
                this.NombreCompleto = dt.Rows[0]["NombreCompleto"].ToString();
                this.Direccion = dt.Rows[0]["Direccion"].ToString();

                dtTelefonos = conexion.ObtenerDatos(String.Format("SELECT * FROM ClientesTelefonos WHERE ClienteId=" + IdBuscado));
                
                foreach (DataRow row in dtTelefonos.Rows)
                {
                    this.InsertarTelefono((int)dtTelefonos.Rows[0]["ClienteId"], row["Tipo"].ToString(), row["Telefono"].ToString());
                }
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("SELECT " + Campos + " FROM Clientes WHERE " + Condicion + ordenar));
        }
    }
}
