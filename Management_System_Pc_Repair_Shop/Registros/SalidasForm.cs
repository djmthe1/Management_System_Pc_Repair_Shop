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

        private void SalidasForm_Load(object sender, EventArgs e)
        {

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

        private void Limpiar()
        {
            idTextBox.Clear();
            EntradaComboBox.SelectedIndex = -1;
            observacionTextBox.Clear();
        }

        private void ObtenerValores()
        {
            int id = 0;
            int.TryParse(idTextBox.Text, out id);
            salida.SalidaId = id;
            salida.Fecha = salidaDateTimePicker.Text;
            int salidaid = 0;
            int.TryParse(idTextBox.Text, out salidaid);
            salida.SalidaId = salidaid;
            salida.Observacion = observacionTextBox.Text;
        }

        private void DevolverValores()
        {
            idTextBox.Text = salida.SalidaId.ToString();
            salidaDateTimePicker.Text = salida.Fecha.ToString();
            EntradaComboBox.Text = salida.EntradaId.ToString();
            observacionTextBox.Text = salida.Observacion.ToString();
        }

        private void botonBuscarCliente_Click(object sender, EventArgs e)
        {
            ObtenerValores();
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
