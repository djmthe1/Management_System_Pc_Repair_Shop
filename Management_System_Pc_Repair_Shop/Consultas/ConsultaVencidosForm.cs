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
    public partial class ConsultaVencidosForm : Form
    {
        public ConsultaVencidosForm()
        {
            InitializeComponent();
        }

        private void ConsultaVencidosForm_Load(object sender, EventArgs e)
        {
            Salidas salidas = new Salidas();
            dataGridViewConsulta.DataSource = salidas.VerificarVencidos("SalidaId, Fecha, EntradaId, Entregado, RetiradoPor");
            textBoxConteo.Text = dataGridViewConsulta.RowCount.ToString();
        }

        private void imprimirButton_Click(object sender, EventArgs e)
        {

        }
    }
}
