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

        public void InsertarTelefono(int Id, int ClienteId, string Telefono)
        {
            this.telefonos.Add(new ClientesTelefonos(Id, ClienteId, Telefono));

        }

        public void LimpiarTelefono()
        {
            this.telefonos.Clear();
        }

        public override bool Insertar()
        {
            int retorno = 0;
            object identity;
            try
            {
                //obtengo el identity insertado en la tabla personas
                identity = conexion.ObtenerValor(string.Format("Insert Into Clientes (Nombre, Apellido, Direccion) Values ('{0}','{1}','{2}') Select @@Identity", this.Nombre, this.Apellido, this.Direccion));

                //intento convertirlo a entero
                int.TryParse(identity.ToString(), out retorno);

                this.ClienteId = retorno;
                if (retorno > 0)
                {
                    foreach (ClientesTelefonos numeros in this.telefonos)
                    {
                        conexion.Ejecutar(string.Format("Insert Into ClientesTelefonos (Telefono) Values ({0})",  numeros.Telefono));
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
                retorno = conexion.Ejecutar(String.Format("Update Clientes set Nombre='{0}', Apellido='{1}', Direccion='{2}', where ClienteId={3}", this.Nombre, this.Apellido, this.Direccion, this.ClienteId));
                if (retorno)
                {
                    conexion.Ejecutar(string.Format("Delete From ClientesTelefonos Where ClienteId= {0}", this.ClienteId));
                    foreach (ClientesTelefonos numeros in this.telefonos)
                    {
                        conexion.Ejecutar(string.Format("Insert Into ClientesTelefonos (Telefono) Values ({0})", numeros.Telefono));
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
                retorno = conexion.Ejecutar(String.Format("Delete From Clientes where ClienteId={0}", this.ClienteId));
                if (retorno)
                    conexion.Ejecutar(string.Format("Delete From ClientesTelefonos Where ClienteId={0}", this.ClienteId));
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }


        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();
            DataTable dtTelefonos = new DataTable();

            dt = conexion.ObtenerDatos("Select * From Clientes Where ClienteId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.ClienteId = (int)dt.Rows[0]["ClienteId"];
                this.Nombre = dt.Rows[0]["Nombre"].ToString();
                this.Apellido = dt.Rows[0]["Apellido"].ToString();
                this.Direccion = dt.Rows[0]["Direccion"].ToString();

                dtTelefonos = conexion.ObtenerDatos(String.Format("Select C.Nombre, T.Telefono as Telefono from Clientes C inner join ClientesTelefonos T on C.ClienteId = T.ClienteId where C.ClienteId = {0}", IdBuscado));
                
                foreach (DataRow row in dtTelefonos.Rows)
                {
                    InsertarTelefono(1, ClienteId, row["Telefono"].ToString());
                }
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("Select " + Campos + " from Clientes where " + Condicion + ordenar));
        }
    }
}
