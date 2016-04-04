using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System_Pc_Repair_Shop.Consultas
{
    public partial class ConsultaClientesForm : Form
    {
        public ConsultaClientesForm()
        {
            InitializeComponent();
        }
        
        Validaciones validar = new Validaciones();

        private void ConsultaClientesForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.LetrasNumeros_KeyPress(e);
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            string filtro = "1=1";

            if (textBoxFiltro.Text.Length > 0)
            {
                filtro = comboBoxCampos.Text + " like '%" + textBoxFiltro.Text + "%'";
            }

            dataGridViewConsulta.DataSource = clientes.Listado("ClienteId, Nombre, Apellido, Direccion", filtro, "");
            textBoxConteo.Text = dataGridViewConsulta.RowCount.ToString();
        }

        private void imprimirButton_Click(object sender, EventArgs e)
        {
            Reportes.VisorReportesForm Visor = new Reportes.VisorReportesForm();
            DataTable dt = new DataTable();

            dt = (DataTable)dataGridViewConsulta.DataSource;
            dt.TableName = "Clientes";
            Visor.reporte = "ReportClientes.rdlc";
            Visor.data = dt;
            Visor.ShowDialog();
        }
    }
}
