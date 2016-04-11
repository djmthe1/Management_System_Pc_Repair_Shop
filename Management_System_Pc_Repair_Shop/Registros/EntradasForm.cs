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
        Piezas pieza = new Piezas();
        Portada portada = new Portada();
        Clientes cliente = new Clientes();
        Validaciones validar = new Validaciones();

        private void EntradasForm_Load(object sender, EventArgs e)
        {
            this.entradaDateTimePicker.Enabled = false;
            LlenarComboBox();
            Limpiar();
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

        private void idTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Numeros_KeyPress(e);
        }

        private void clienteIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Numeros_KeyPress(e);
        }

        private void notasTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.LetrasNumeros_KeyPress(e);
        }

        private void problemaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.LetrasNumeros_KeyPress(e);
        }

        private void LlenarComboBox()
        {
            DataTable dtclientes = new DataTable();
            dtclientes = cliente.Listado("*", "1=1", "");

            clienteComboBox.DataSource = dtclientes;
            clienteComboBox.ValueMember = "ClienteId";
            clienteComboBox.DisplayMember = "NombreCompleto";

            DataTable dtpiezas = new DataTable();
            dtpiezas = pieza.Listado("*", "0=0", "ORDER BY Descripcion");

            for (int i = 0; i <= dtpiezas.Rows.Count - 1; i++)
                articulosComboBox.Items.Add(pieza.Listado("*", "0=0", "ORDER BY Descripcion").Rows[i]["Descripcion"]);

        }

        private void Limpiar()
        {
            idTextBox.Clear();
            entregaDateTimePicker.ResetText();
            clienteComboBox.SelectedIndex = -1;
            notasTextBox.Clear();
            articulosComboBox.SelectedIndex = -1;
            problemaTextBox.Clear();
            articulosDataGridView.Rows.Clear();
        }
        
        private void ObtenerValores()
        {
            int id = 0;
            int.TryParse(idTextBox.Text, out id);
            entrada.EntradaId = id;
            entrada.Fecha = DateTime.Now.ToString("yyyy-MM-dd");
            entrada.FechaEntrega = entregaDateTimePicker.Text;
            entrada.ClienteId = (int)clienteComboBox.SelectedValue;
            entrada.Notas = notasTextBox.Text;
            entrada.RecibidoPor = portada.toolStripStatusLabel.Text;
            foreach (var articulo in entrada.articulos)
            {
                articulosDataGridView.Rows.Add(articulo.Articulo, articulo.Problema);
            }
        }

        private void DevolverValores()
        {
            idTextBox.Text = entrada.EntradaId.ToString();
            entradaDateTimePicker.Text = entrada.Fecha;
            entregaDateTimePicker.Text = entrada.FechaEntrega;
            clienteComboBox.Text = entrada.ClienteId.ToString();
            notasTextBox.Text = entrada.Notas.ToString();
            foreach (var articulo in entrada.articulos)
            {
                articulosDataGridView.Rows.Add(articulo.Articulo, articulo.Problema);
            }
        }
        
        private void buscarButton_Click(object sender, EventArgs e)
        {
            articulosDataGridView.Rows.Clear();
            
            if (idTextBox.Text.Length == 0)
            {
                MessageBox.Show("Debe insertar un Id", "Error al Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                entrada.EntradaId = int.Parse(idTextBox.Text);
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

        private void botonInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!articulosComboBox.Text.Equals("") && !problemaTextBox.Text.Equals(""))
                {
                    articulosDataGridView.Rows.Add(articulosComboBox.Text, problemaTextBox.Text);
                    entrada.InsertarArticulo(1, articulosComboBox.Text, problemaTextBox.Text);
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
            if (idTextBox.Text == "")
            {
                if (!clienteComboBox.Text.Equals("")  && notasTextBox.Text != "")
                {
                    ObtenerValores();
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
                if (!clienteComboBox.Text.Equals("") && notasTextBox.Text != "")
                {
                    ObtenerValores();
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
            if (idTextBox.Text.Length == 0)
            {
                MessageBox.Show("Debe insertar un Id", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                entrada.EntradaId = int.Parse(idTextBox.Text);
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
}
