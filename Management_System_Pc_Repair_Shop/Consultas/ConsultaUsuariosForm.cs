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

namespace Management_System_Pc_Repair_Shop.Consultas
{
    public partial class ConsultaUsuariosForm : Form
    {
        public ConsultaUsuariosForm()
        {
            InitializeComponent();
        }

        private void ConsultaUsuariosForm_Load(object sender, EventArgs e)
        {

        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            string filtro = "1=1";

            if (textBoxFiltro.Text.Length > 0)
            {
                filtro = comboBoxCampos.Text + " like '%" + textBoxFiltro.Text + "%'";
            }

            dataGridViewConsulta.DataSource = usuario.Listado("UsuarioId, Nombre, Prioridad", filtro, "");
            textBoxConteo.Text = dataGridViewConsulta.RowCount.ToString();
        }

        private void imprimirButton_Click(object sender, EventArgs e)
        {
            Reportes.VisorReportesForm Visor = new Reportes.VisorReportesForm();
            DataTable dt = new DataTable();

            dt = (DataTable)dataGridViewConsulta.DataSource;
            dt.TableName = "Usuarios";
            Visor.reporte = "ReportUsuarios.rdlc";
            Visor.data = dt;
            Visor.ShowDialog();
        }
    }
}
