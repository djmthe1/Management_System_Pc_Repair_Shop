using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;


namespace BLL
{
    public class Usuarios : ClaseMaestra
    {
        public int UsuarioId { set; get; }
        public string Nombre { set; get; }
        public string Password { set; get; }
        public string Prioridad { set; get; }
        ConexionDb conexion = new ConexionDb();

        public Usuarios(int usuarioId, string nombre, string password, string prioridad)
        {
            this.UsuarioId = usuarioId;
            this.Nombre = nombre;
            this.Password = password;
            this.Prioridad = prioridad;
        }

        public Usuarios()
        {
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                this.UsuarioId = (int)conexion.ObtenerValor(String.Format("Insert Into Usuarios (Nombre, Password, Prioridad) Values ('{0}','{1}','{2}') Select @@Identity", this.Nombre, this.Password, this.Prioridad));
                retorno = this.UsuarioId > 0;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("Update Usuarios set Nombre='{0}', Password='{1}', Prioridad='{2}' where UsuarioId={3}", this.Nombre, this.Password, this.Prioridad, this.UsuarioId));
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
                conexion.Ejecutar(String.Format("Delete From Usuarios where UsuarioId={0}", this.UsuarioId));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();

            dt = conexion.ObtenerDatos("Select * from Usuarios Where UsuarioId=" + IdBuscado);
            if (dt.Rows.Count > 0)
            {
                this.UsuarioId = (int)dt.Rows[0]["UsuarioId"];
                this.Nombre = dt.Rows[0]["Nombre"].ToString();
                this.Password = dt.Rows[0]["Password"].ToString();
                this.Prioridad = dt.Rows[0]["Prioridad"].ToString();
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("Select " + Campos + " from Usuarios where " + Condicion + ordenar));
        }

        public bool Verificar(string Nombre, string Password, string Prioridad)
        {
            bool retorno = false;
            try
            {
                DataTable dt = new DataTable();
                dt = conexion.ObtenerDatos(String.Format("Select * From Usuarios where Nombre='{0}' and Password='{1}' and Prioridad='{2}'", Nombre, Password, Prioridad));
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
