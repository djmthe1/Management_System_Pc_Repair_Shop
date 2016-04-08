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
        Entradas entrada = new Entradas();
        Piezas pieza = new Piezas();
        Marcas marca = new Marcas();
        Portada portada = new Portada();
        Validaciones validar = new Validaciones();

        private void FacturaForm_Load(object sender, EventArgs e)
        {
            this.facturaDateTimePicker.Enabled = false;
            LlenarComboBox();
            Limpiar();
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

        private void idTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Numeros_KeyPress(e);
        }

        private void cargoDeReparacionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Numeros_KeyPress(e);
        }

        private void precioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Numeros_KeyPress(e);
        }

        private void montoAPagarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Numeros_KeyPress(e);
        }

        private void LlenarComboBox()
        {
            //----------------------------------------
            DataTable dtentradas = new DataTable();

            dtentradas = entrada.Listado("*", "1=1", ""); //verificar

            entradaComboBox.DataSource = dtentradas;
            entradaComboBox.ValueMember = "EntradaId";
            entradaComboBox.DisplayMember = "Notas";
            //-----------------------------------------
            DataTable dtmarcas = new DataTable();
            dtmarcas = marca.Listado("*", "1=1", "");

            marcaComboBox.DataSource = dtmarcas;
            marcaComboBox.ValueMember = "MarcaId";
            marcaComboBox.DisplayMember = "Descripcion";

            DataTable dtpiezas = new DataTable();
            dtpiezas = pieza.Listado("*", "1=1", "");

            articulosComboBox.DataSource = dtpiezas;
            articulosComboBox.ValueMember = "PiezaId";
            articulosComboBox.DisplayMember = "Descripcion";
        }

        private void Limpiar()
        {
            idTextBox.Clear();
            facturaDateTimePicker.ResetText();
            entradaComboBox.SelectedIndex = -1;
            totalReparacionTextBox.Clear();
            articulosComboBox.SelectedIndex = -1;
            marcaComboBox.SelectedIndex = -1;
            precioTextBox.Clear();
            articulosVendidosDataGridView.Rows.Clear();
            montoAPagarTextBox.Clear();
        }

        private void ObtenerValores()
        {
            int id = 0;
            int.TryParse(idTextBox.Text, out id);
            factura.FacturaId = id;
            factura.Fecha = DateTime.Now.ToString("yyyy-MM-dd");
            int salidaid = 0;
            int.TryParse(entradaComboBox.Text, out salidaid);
            factura.EntradaId = salidaid;
            float montoapagar = 0;
            float.TryParse(montoAPagarTextBox.Text, out montoapagar);
            factura.MontoAPagar = montoapagar;
            factura.DespachadoPor = portada.toolStripStatusLabel.Text;
            foreach (var articulo in factura.articulos)
            {
                articulosVendidosDataGridView.Rows.Add(articulo.Pieza, articulo.Marca, articulo.Precio);
            }
        }

        private void DevolverValores()
        {
            idTextBox.Text = factura.FacturaId.ToString();
            facturaDateTimePicker.Text = factura.Fecha.ToString();
            entradaComboBox.Text = factura.EntradaId.ToString();
            totalReparacionTextBox.Text = factura.CargoReparacion.ToString();
            totalFacturaTextBox.Text = factura.Total.ToString();
            montoAPagarTextBox.Text = factura.MontoAPagar.ToString();
            foreach (var articulo in factura.articulos)
            {
                articulosVendidosDataGridView.Rows.Add(articulo.Pieza, articulo.Marca, articulo.Precio);
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
                    articulosVendidosDataGridView.Rows.Add(articulosComboBox.Text, marcaComboBox.Text, precioTextBox.Text);
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
        
        private void entradaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*private void buscarSalidaButton_Click(object sender, EventArgs e)
        {
            ObtenerValores();
            if (entradaComboBox.Text.Length == 0)
            {
                MessageBox.Show("Debe insertar un Id", "Error al Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (entrada.Buscar(factura.EntradaId))
                {
                    DevolverValores();
                }
                else
                {
                    MensajeAdvertencia("Id no encontrado");
                    entradaComboBox.SelectedIndex = -1;
                }
            }
        }*/

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            ObtenerValores();
            if (idTextBox.Text == "")
            {
                if (entradaComboBox.Text != "" && totalReparacionTextBox.Text != "" && totalFacturaTextBox.Text != "" && montoAPagarTextBox.Text != "")
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
                if (entradaComboBox.Text != "" && totalReparacionTextBox.Text != "" && totalFacturaTextBox.Text != "" && montoAPagarTextBox.Text != "")
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
            if (idTextBox.Text.Length == 0)
            {
                MessageBox.Show("Debe insertar un Id", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
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
}
