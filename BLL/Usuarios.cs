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
        DataTable dt = new DataTable();

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
                conexion.Ejecutar(String.Format("INSERT INTO Usuarios (Nombre, Password, Prioridad) VALUES ('{0}','{1}','{2}')", this.Nombre, this.Password, this.Prioridad)).ToString();
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                conexion.Ejecutar(String.Format("UPDATE Usuarios SET Nombre='{0}', Password='{1}', Prioridad='{2}' WHERE UsuarioId={3}", this.Nombre, this.Password, this.Prioridad, this.UsuarioId));
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
                conexion.Ejecutar(String.Format("DELETE FROM Usuarios WHERE UsuarioId={0}", this.UsuarioId));
                retorno = true;
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            dt = conexion.ObtenerDatos("SELECT * FROM Usuarios WHERE UsuarioId=" + IdBuscado);
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
            return conexion.ObtenerDatos(("SELECT " + Campos + " FROM Usuarios WHERE " + Condicion + ordenar));
        }

        public bool Verificar(string Nombre, string Password)
        {
            bool retorno = false;
            try
            {
                dt = conexion.ObtenerDatos(String.Format("SELECT * FROM Usuarios WHERE Nombre='{0}' AND Password='{1}'", Nombre, Password));
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
