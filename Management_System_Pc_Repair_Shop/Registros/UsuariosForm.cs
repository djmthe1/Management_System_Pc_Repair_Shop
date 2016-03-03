using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Management_System_Pc_Repair_Shop.Registros
{
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        Usuarios usuarios = new Usuarios();

        private void UsuariosForm_Load(object sender, EventArgs e)
        {

        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Limpiar()
        {
            usuarioIdTextBox.Clear();
            nombreTextBox.Clear();
            passTextBox.Clear();
            confirmarPassTextBox.Clear();
        }

        private void ObtenerValores()
        {
            int usuId = 0;
            int.TryParse(usuarioIdTextBox.Text, out usuId);
            usuarios.UsuarioId = usuId;
            usuarios.Nombre = nombreTextBox.Text;
            usuarios.Password = passTextBox.Text;
            usuarios.Prioridad = prioridadComboBox.Text;
        }

        private void DevolverValores()
        {
            usuarioIdTextBox.Text = usuarios.UsuarioId.ToString();
            nombreTextBox.Text = usuarios.Nombre.ToString();
            passTextBox.Text = usuarios.Password.ToString();
            prioridadComboBox.Text = usuarios.Prioridad.ToString();
        }


        private void buscarButton_Click(object sender, EventArgs e)
        {
            ObtenerValores();
            if (usuarioIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Debe insertar un Id", "Error al Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (usuarios.Buscar(usuarios.UsuarioId))
                {
                    DevolverValores();
                }
                else
                {
                    MensajeAdvertencia("Id no encontrado");
                    Limpiar();
                }
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            ObtenerValores();

            if (usuarioIdTextBox.Text == "")
            {
                if (nombreTextBox.Text != "" && passTextBox.Text != "" && confirmarPassTextBox.Text != "" && prioridadComboBox.Text != "")
                {
                    if (passTextBox.Text == confirmarPassTextBox.Text)
                    {
                        if (usuarios.Insertar())
                        {
                            Limpiar();
                            MensajeOk("Insertado correctamente");
                        }
                        else
                        {
                            MensajeError("Error al insertar");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (nombreTextBox.Text != "" && passTextBox.Text != "" && passTextBox.Text == confirmarPassTextBox.Text && prioridadComboBox.Text != "")
                {
                    if (passTextBox.Text == confirmarPassTextBox.Text)
                    {
                        if (usuarios.Editar())
                        {
                            Limpiar();
                            MensajeOk("Modificado correctamente");
                        }

                        else
                        {
                            MensajeError("Error al modificar");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                      
                    }
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
                ObtenerValores();
                if (usuarios.Buscar(usuarios.UsuarioId))
                {
                    if (usuarios.Eliminar())
                    {
                        MensajeOk("Eliminado correctamente");
                        Limpiar();
                    }
                    else
                    {
                        MensajeError("Error al eliminar");
                    }
                }
                else
                {
                    MensajeAdvertencia("Este Id no existe");
                    Limpiar();
                }
        }
    }
}
