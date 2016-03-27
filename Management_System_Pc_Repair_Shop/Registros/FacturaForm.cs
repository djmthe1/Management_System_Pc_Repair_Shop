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
    public partial class FacturaForm : Form
    {
        public FacturaForm()
        {
            InitializeComponent();
        }

        Facturas factura = new Facturas();
        Salidas salida = new Salidas();

        private void FacturaForm_Load(object sender, EventArgs e)
        {

        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Facturas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Facturas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Limpiar()
        {
            idTextBox.Clear();
            facturaDateTimePicker.ResetText();
            salidaIdTextBox.Clear();
            cargoDeReparacionTextBox.Clear();
            articulosComboBox.SelectedIndex = -1;
            marcaComboBox.SelectedIndex = -1;
            precioTextBox.Clear();
            articulosDataGridView.Rows.Clear();
        }

        private void ObtenerValores()
        {
            int id = 0;
            int.TryParse(idTextBox.Text, out id);
            factura.FacturaId = id;
            factura.Fecha = facturaDateTimePicker.Text;
            int salidaid = 0;
            int.TryParse(salidaIdTextBox.Text, out salidaid);
            factura.SalidaId = salidaid;
            float montoapagar = 0;
            float.TryParse(montoAPagarTextBox.Text, out montoapagar);
            factura.MontoAPagar = montoapagar;
            foreach (var articulo in factura.articulos)
            {
                articulosDataGridView.Rows.Add(articulo.Pieza, articulo.Marca, articulo.Precio);
            }
        }

        private void DevolverValores()
        {
            idTextBox.Text = factura.FacturaId.ToString();
            facturaDateTimePicker.Text = factura.Fecha.ToString();
            salidaIdTextBox.Text = factura.SalidaId.ToString();
            cargoDeReparacionTextBox.Text = factura.CargoReparacion.ToString();
            totalFacturaTextBox.Text = factura.Total.ToString();
            montoAPagarTextBox.Text = factura.MontoAPagar.ToString();
            foreach (var articulo in factura.articulos)
            {
                articulosDataGridView.Rows.Add(articulo.Pieza, articulo.Marca, articulo.Precio);
            }
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            ObtenerValores();
            if (idTextBox.Text.Length == 0)
            {
                MessageBox.Show("Debe insertar un Id", "Error al Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (factura.Buscar(factura.FacturaId))
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
            float precio = 0;
            float.TryParse(precioTextBox.Text, out precio);
            try
            {
                if (!articulosComboBox.Text.Equals("") && !marcaComboBox.Text.Equals("") && !precioTextBox.Text.Equals(""))
                {
                    articulosDataGridView.Rows.Add(articulosComboBox.Text, marcaComboBox.Text, precioTextBox.Text);
                    factura.InsertarArticulo( articulosComboBox.Text, marcaComboBox.Text, precio);
                    articulosComboBox.SelectedIndex = -1;
                    marcaComboBox.SelectedIndex = -1;
                    precioTextBox.Clear();
                }
            }
            catch (Exception)
            {
                MensajeError("Error al insertar");
            }
        }

        private void buscarSalidaButton_Click(object sender, EventArgs e)
        {
            ObtenerValores();
            if (salidaIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Debe insertar un Id", "Error al Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (salida.Buscar(factura.SalidaId))
                {
                    DevolverValores();
                }
                else
                {
                    MensajeAdvertencia("Id no encontrado");
                    salidaIdTextBox.Clear();
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
            if (idTextBox.Text == "")
            {
                if (salidaIdTextBox.Text != "" && cargoDeReparacionTextBox.Text != "" && totalFacturaTextBox.Text != "" && montoAPagarTextBox.Text != "")
                {
                    if (factura.Insertar())
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
                if (salidaIdTextBox.Text != "" && cargoDeReparacionTextBox.Text != "" && totalFacturaTextBox.Text != "" && montoAPagarTextBox.Text != "")
                {
                    if (factura.Editar())
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
            if (factura.Buscar(factura.FacturaId))
            {
                if (factura.Eliminar())
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
