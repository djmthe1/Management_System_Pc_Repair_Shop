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

namespace Management_System_Pc_Repair_Shop.Consultas
{
    public partial class ConsultaPiezasForm : Form
    {
        public ConsultaPiezasForm()
        {
            InitializeComponent();
        }

        Validaciones validar = new Validaciones();

        private void ConsultaPiezasForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.LetrasNumeros_KeyPress(e);
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            Piezas piezas = new Piezas();
            string filtro = "1=1";

            if (textBoxFiltro.Text.Length > 0)
            {
                filtro = comboBoxCampos.Text + " like '%" + textBoxFiltro.Text + "%'";
            }

            dataGridViewConsulta.DataSource = piezas.Listado("PiezaId, Descripcion", filtro, "");
            textBoxConteo.Text = dataGridViewConsulta.RowCount.ToString();
        }

        private void imprimirButton_Click(object sender, EventArgs e)
        {
            Reportes.VisorReportesForm Visor = new Reportes.VisorReportesForm();
            DataTable dt = new DataTable();
       
            dt = (DataTable)dataGridViewConsulta.DataSource;
            dt.TableName = "Piezas";
            Visor.reporte = "ReportPiezas.rdlc";
            Visor.data = dt;
            Visor.ShowDialog();
        }
    }
}
