﻿using System;
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
        float TotalPiezas = 0;
        float TotalReparacion = 0;

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
            DataTable dtentradas = new DataTable();

            dtentradas = entrada.Listado("*", "Salio=1 AND Entregado is null", "");

            entradaComboBox.DataSource = dtentradas;
            entradaComboBox.ValueMember = "EntradaId";
            entradaComboBox.DisplayMember = "Notas";
            
            DataTable dtmarcas = new DataTable();;
            dtmarcas = marca.Listado("*", "0=0", "ORDER BY Descripcion");

            for (int i = 0; i <= dtmarcas.Rows.Count - 1; i++)
                marcaComboBox.Items.Add(marca.Listado("*", "0=0", "ORDER BY Descripcion").Rows[i]["Descripcion"]);

            DataTable dtpiezas = new DataTable();
            dtpiezas = pieza.Listado("*", "0=0", "ORDER BY Descripcion");

            for (int i = 0; i <= dtpiezas.Rows.Count - 1; i++)
                articulosComboBox.Items.Add(pieza.Listado("*", "0=0", "ORDER BY Descripcion").Rows[i]["Descripcion"]);
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
            EliminarButton.Enabled = false;
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
            foreach (var articuloVendido in factura.articulosVendidos)
            {
                articulosVendidosDataGridView.Rows.Add(articuloVendido.Pieza, articuloVendido.Marca, articuloVendido.Precio);
            }
            foreach (var articuloEntregado in factura.articulosEntregados)
            {
                articulosReparadosDataGridView.Rows.Add(articuloEntregado.Articulo, articuloEntregado.Problema, articuloEntregado.Cargo);
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
            foreach (var articuloVendido in factura.articulosVendidos)
            {
                articulosVendidosDataGridView.Rows.Add(articuloVendido.Pieza, articuloVendido.Marca, articuloVendido.Precio);
            }
            foreach (var articuloEntregado in factura.articulosEntregados)
            {
                articulosReparadosDataGridView.Rows.Add(articuloEntregado.Articulo, articuloEntregado.Problema, articuloEntregado.Cargo);
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
                    EliminarButton.Enabled = true;
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
                    factura.InsertarArticuloVendido( articulosComboBox.Text, marcaComboBox.Text, precio);
                    foreach (DataGridViewRow artic in articulosVendidosDataGridView.Rows)
                    {
                        TotalPiezas += (float)Convert.ToDecimal(artic.Cells["Precio"].Value);
                    }
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
            entrada.EntradaId = (int)entradaComboBox.SelectedValue;
            articulosReparadosDataGridView.Rows.Clear();
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

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            ObtenerValores();
            if (idTextBox.Text == "")
            {
                if (entradaComboBox.Text.Equals("") && totalReparacionTextBox.Text != "" && totalFacturaTextBox.Text != "" && montoAPagarTextBox.Text != "")
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
                if (entradaComboBox.Text.Equals("") && totalReparacionTextBox.Text != "" && totalFacturaTextBox.Text != "" && montoAPagarTextBox.Text != "")
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
