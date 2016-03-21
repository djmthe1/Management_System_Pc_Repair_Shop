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
    public partial class ConsultaEntradasForm : Form
    {
        public ConsultaEntradasForm()
        {
            InitializeComponent();
        }

        private void ConsultaEntradasForm_Load(object sender, EventArgs e)
        {

        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            Entradas entradas = new Entradas();
            string filtro = "1=1";

            if (textBoxFiltro.Text.Length > 0)
            {
                filtro = comboBoxCampos.Text + " like '%" + textBoxFiltro.Text + "%'";
            }

            dataGridViewConsulta.DataSource = entradas.Listado("EntradaId, Fecha, FechaEntrega, ClienteId, Notas, RecibidoPor", filtro, "");
            textBoxConteo.Text = dataGridViewConsulta.RowCount.ToString();
        }
    }
}
