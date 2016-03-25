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
    public partial class EntradasForm : Form
    {
        public EntradasForm()
        {
            InitializeComponent();
        }

        Entradas entrada = new Entradas();

        private void EntradasForm_Load(object sender, EventArgs e)
        {

        }
        
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Entradas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Entradas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Entradas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Limpiar()
        {
            idTextBox.Clear();
            entregaDateTimePicker.ResetText();
            clienteIdTextBox.Clear();
            notasTextBox.Clear();
            articulosComboBox.SelectedIndex = -1;
            problemaTextBox.Clear();
        }
        
        private void ObtenerValores()
        {
            int id = 0;
            int.TryParse(idTextBox.Text, out id);
            entrada.EntradaId = id;
            entrada.Fecha = entradaDateTimePicker.Text;
            entrada.FechaEntrega = entregaDateTimePicker.Text;
            int clienteid = 0;
            int.TryParse(clienteIdTextBox.Text, out clienteid);
            entrada.ClienteId = clienteid;
            entrada.Notas = notasTextBox.Text;
            foreach (var articulo in entrada.articulos)
            {
                articulosDataGridView.Rows.Add(articulo.Articulo, articulo.Problema);
            }
        }

        private void DevolverValores()
        {
            idTextBox.Text = entrada.EntradaId.ToString();
            entradaDateTimePicker.Text = entrada.Fecha.ToString();
            entregaDateTimePicker.Text = entrada.FechaEntrega.ToString();
            clienteIdTextBox.Text = entrada.ClienteId.ToString();
            notasTextBox.Text = entrada.Notas.ToString();
            foreach (var articulo in entrada.articulos)
            {
                articulosDataGridView.Rows.Add(articulo.Articulo, articulo.Problema);
            }
        }
        
        private void buscarButton_Click(object sender, EventArgs e)
        {
            ObtenerValores();
            if (idTextBox.Text.Length == 0)
            {
                MessageBox.Show("Debe insertar un Id", "Error al Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (entrada.Buscar(entrada.EntradaId))
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

        private void buscarClienteButton_Click(object sender, EventArgs e)
        {

        }

        private void botonInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!articulosComboBox.Text.Equals("") || !problemaTextBox.Text.Equals(""))
                {
                    articulosDataGridView.Rows.Add(articulosComboBox.Text, problemaTextBox.Text);
                    entrada.InsertarArticulo(articulosComboBox.Text, problemaTextBox.Text);
                    articulosComboBox.SelectedIndex = -1;
                    problemaTextBox.Clear();
                }
            }
            catch (Exception)
            {
                MensajeError("Error al insertar");
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            ObtenerValores();
            if (idTextBox.Text == "")
            {
                if (clienteIdTextBox.Text != "" && notasTextBox.Text != "")
                {
                    if (entrada.Insertar())
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
                if (clienteIdTextBox.Text != "" && notasTextBox.Text != "")
                {
                    if (entrada.Editar())
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
            if (entrada.Buscar(entrada.EntradaId))
            {
                if (entrada.Eliminar())
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
