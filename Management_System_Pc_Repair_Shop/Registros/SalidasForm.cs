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
    public partial class SalidasForm : Form
    {
        public SalidasForm()
        {
            InitializeComponent();
        }

        Salidas salida = new Salidas();
        Entradas entrada = new Entradas();
        Portada portada = new Portada();
        Validaciones validar = new Validaciones();

        private void SalidasForm_Load(object sender, EventArgs e)
        {
            this.salidaDateTimePicker.Enabled = false;
            LlenarComboBox();
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Salidas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Salidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Registro de Salidas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void idTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Numeros_KeyPress(e);
        }

        private void observacionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.LetrasNumeros_KeyPress(e);
        }

        private void LlenarComboBox()
        {
            DataTable dtentradas = new DataTable();

            dtentradas = entrada.Listado("*", "Salio=0", ""); // verificar

            EntradaComboBox.DataSource = dtentradas;
            EntradaComboBox.ValueMember = "EntradaId";
            EntradaComboBox.DisplayMember = "Notas";
        }

        private void Limpiar()
        {
            idTextBox.Clear();
            EntradaComboBox.SelectedIndex = -1;
            observacionTextBox.Clear();
            LlenarComboBox();
        }

        private void ObtenerValores()
        {
            int id = 0;
            int.TryParse(idTextBox.Text, out id);
            salida.SalidaId = id;
            salida.Fecha = DateTime.Now.ToString("yyyy-MM-dd");
            salida.EntradaId = (int)EntradaComboBox.SelectedValue;
            salida.Observacion = observacionTextBox.Text;
            salida.RetiradoPor = portada.toolStripStatusLabel.Text;
        }

        private void DevolverValores()
        {
            idTextBox.Text = salida.SalidaId.ToString();
            salidaDateTimePicker.Text = salida.Fecha.ToString();
            EntradaComboBox.Text = salida.EntradaId.ToString();
            observacionTextBox.Text = salida.Observacion.ToString();
        }

        private void botonBuscarSalida_Click(object sender, EventArgs e)
        {
            ObtenerValores();
            if (idTextBox.Text.Length == 0)
            {
                MessageBox.Show("Debe insertar un Id", "Error al Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (idTextBox.Text.Length == 0)
                {
                    MessageBox.Show("Debe insertar un Id", "Error al Buscar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (salida.Buscar(salida.EntradaId))
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
                if (EntradaComboBox.Text != "" && observacionTextBox.Text != "")
                {
                    if (salida.Insertar())
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
                if (EntradaComboBox.Text != "" && observacionTextBox.Text != "")
                {
                    if (salida.Editar())
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
                if (salida.Buscar(salida.EntradaId))
                {
                    if (salida.Eliminar())
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
