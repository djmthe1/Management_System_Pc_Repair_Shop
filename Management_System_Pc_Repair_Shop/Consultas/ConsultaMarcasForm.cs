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
    public partial class ConsultaMarcasForm : Form
    {
        public ConsultaMarcasForm()
        {
            InitializeComponent();
        }

        Validaciones validar = new Validaciones();

        private void ConsultaMarcasForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.LetrasNumeros_KeyPress(e);
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            Marcas marcas = new Marcas();
            string filtro = "1=1";

            if (textBoxFiltro.Text.Length > 0)
            {
                filtro = comboBoxCampos.Text + " like '%" + textBoxFiltro.Text + "%'";
            }

            dataGridViewConsulta.DataSource = marcas.Listado("MarcaId, Descripcion", filtro, "");
            textBoxConteo.Text = dataGridViewConsulta.RowCount.ToString();
        }

        private void imprimirButton_Click(object sender, EventArgs e)
        {
            Reportes.VisorReportesForm Visor = new Reportes.VisorReportesForm();
            DataTable dt = new DataTable();

            dt = (DataTable)dataGridViewConsulta.DataSource;
            dt.TableName = "Marcas";
            Visor.reporte = "ReportMarcas.rdlc";
            Visor.data = dt;
            Visor.ShowDialog();
        }
    }
}
