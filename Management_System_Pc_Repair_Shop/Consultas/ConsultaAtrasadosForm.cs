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
    public partial class ConsultaAtrasadosForm : Form
    {
        public ConsultaAtrasadosForm()
        {
            InitializeComponent();
        }

        Validaciones validar = new Validaciones();

        private void ConsultaAtrasadosForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.LetrasNumeros_KeyPress(e);
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            Entradas entradas = new Entradas();
            string filtro = "1=1";

            if (textBoxFiltro.Text.Length > 0)
            {
                filtro = comboBoxCampos.Text + " like '%" + textBoxFiltro.Text + "%'";
            }

            dataGridViewConsulta.DataSource = entradas.Listado("EntradaId, Fecha, FechaEntrega, ClienteId, Notas, RecibidoPor, Salio, Entregado", filtro, "");
            textBoxConteo.Text = dataGridViewConsulta.RowCount.ToString();
        }

        private void imprimirButton_Click(object sender, EventArgs e)
        {
            Reportes.VisorReportesForm Visor = new Reportes.VisorReportesForm();
            DataTable dt = new DataTable();

            dt = (DataTable)dataGridViewConsulta.DataSource;
            dt.TableName = "Entradas";
            Visor.reporte = "ReportAtrasados.rdlc";
            Visor.data = dt;
            Visor.ShowDialog();
        }
    }
}
