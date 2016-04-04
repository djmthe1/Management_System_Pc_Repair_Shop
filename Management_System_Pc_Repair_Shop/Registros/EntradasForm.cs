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
    public partial class EntradasForm : Form
    {
        public EntradasForm()
        {
            InitializeComponent();
        }

        Entradas entrada = new Entradas();
        Portada portada = new Portada();
        Clientes cliente = new Clientes();
        Validaciones validar = new Validaciones();

        private void EntradasForm_Load(object sender, EventArgs e)
        {
            this.entradaDateTimePicker.Enabled = false;
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

        private void Limpiar()
        {
            idTextBox.Clear();
            entregaDateTimePicker.ResetText();
            clienteIdTextBox.Clear();
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
            int clienteid = 0;
            int.TryParse(clienteIdTextBox.Text, out clienteid);
            entrada.ClienteId = clienteid;
            entrada.Notas = notasTextBox.Text;
            entrada.RecibidoPor = portada.toolStripStatusLabel.Text;
            entrada.LimpiarArticulo();
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
            clienteIdTextBox.Text = entrada.ClienteId.ToString();
            notasTextBox.Text = entrada.Notas.ToString();
            foreach (var articulo in entrada.articulos)
            {
                articulosDataGridView.Rows.Add(articulo.Articulo, articulo.Problema);
            }
        }
        
        private void buscarButton_Click(object sender, EventArgs e)
        {
            articulosDataGridView.Rows.Clear();
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
            ObtenerValores();
            if (clienteIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Debe insertar un Id", "Error al Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (cliente.Buscar(entrada.ClienteId))
                {
                    nombreTextBox.Text = cliente.Nombre.ToString();
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
            if (clienteIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Debe insertar un Id", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
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
