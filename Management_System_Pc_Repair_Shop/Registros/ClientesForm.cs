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
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        Clientes clientes = new Clientes();

        private void ClientesForm_Load(object sender, EventArgs e)
        {

        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Limpiar()
        {
            clienteIdTextBox.Clear();
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            direccionTextBox.Clear();
        }

        private void ObtenerValores()
        {
            int id = 0;
            int.TryParse(clienteIdTextBox.Text, out id);
            clientes.ClienteId = id;
            clientes.Nombre = nombreTextBox.Text;
            clientes.Apellido = apellidoTextBox.Text;
            clientes.Direccion = direccionTextBox.Text;
        }

        private void DevolverValores()
        {
            clienteIdTextBox.Text = clientes.ClienteId.ToString();
            nombreTextBox.Text = clientes.Nombre.ToString();
            apellidoTextBox.Text = clientes.Apellido.ToString();
            direccionTextBox.Text = clientes.Direccion.ToString();
        }

        private void botonBuscarCliente_Click(object sender, EventArgs e)
        {
            ObtenerValores();
            if (clienteIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Debe insertar un Id", "Error al Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (clientes.Buscar(clientes.ClienteId))
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
            if (clienteIdTextBox.Text == "")
            {
                if (nombreTextBox.Text != "" && apellidoTextBox.Text != "" && direccionTextBox.Text != "")
                {
                    if (clientes.Insertar())
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
                    MessageBox.Show("Debe llenar todos los campos", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (nombreTextBox.Text != "" && apellidoTextBox.Text != "" && direccionTextBox.Text != "")
                {
                    if (clientes.Editar())
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
                    MessageBox.Show("Debe llenar todos los campos", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            ObtenerValores();
            if (clientes.Buscar(clientes.ClienteId))
            {
                if (clientes.Eliminar())
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
