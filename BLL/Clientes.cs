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
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Direccion { set; get; }
        ClientesTelefonos Telefono = new ClientesTelefonos();
        public List<ClientesTelefonos> telefonos { get; set; }
        ConexionDb conexion = new ConexionDb();

        public Clientes(int clienteId, string nombre, string apellido, string direccion)
        {
            this.ClienteId = clienteId;
            this.Nombre = nombre;
            this.Apellido = apellido;
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
                identity = conexion.ObtenerValor(String.Format("INSERT INTO Clientes (Nombre, Apellido, Direccion) VALUES ('{0}','{1}','{2}') SELECT @@Identity", this.Nombre, this.Apellido, this.Direccion));

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
                retorno = conexion.Ejecutar(String.Format("UPDATE Clientes SET Nombre='{0}', Apellido='{1}', Direccion='{2}' WHERE ClienteId={3}", this.Nombre, this.Apellido, this.Direccion, this.ClienteId));
                if (retorno)
                {
                    conexion.Ejecutar(string.Format("DELETE FROM ClientesTelefonos WHERE ClienteId={0}", this.ClienteId));
                    foreach (ClientesTelefonos numeros in this.telefonos)
                    {
                        conexion.Ejecutar(string.Format("INSERT INTO ClientesTelefonos (ClienteId, Tipo, Telefono) VALUES ({0},'{1}','{2}')", numeros.ClienteId, numeros.Tipo, numeros.Telefono));
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
                    conexion.Ejecutar(string.Format("DELETE FROM ClientesTelefonos WHERE ClienteId={0}", this.ClienteId));
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
                this.Nombre = dt.Rows[0]["Nombre"].ToString();
                this.Apellido = dt.Rows[0]["Apellido"].ToString();
                this.Direccion = dt.Rows[0]["Direccion"].ToString();

                dtTelefonos = conexion.ObtenerDatos(String.Format("SELECT * FROM ClientesTelefonos WHERE ClienteId=" + IdBuscado));
                
                foreach (DataRow row in dtTelefonos.Rows)
                {
                    this.InsertarTelefono((int)dtTelefonos.Rows[0]["ClienteId"], row["Telefono"].ToString(), row["Tipo"].ToString());
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
