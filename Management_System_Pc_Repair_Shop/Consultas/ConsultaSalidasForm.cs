﻿using BLL;
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
    public partial class ConsultaSalidasForm : Form
    {
        public ConsultaSalidasForm()
        {
            InitializeComponent();
        }

        Validaciones validar = new Validaciones();

        private void ConsultaSalidasForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.LetrasNumeros_KeyPress(e);
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            Salidas salidas = new Salidas();
            string filtro = "1=1";

            if (textBoxFiltro.Text.Length > 0)
            {
                filtro = comboBoxCampos.Text + " like '%" + textBoxFiltro.Text + "%'";
            }

            dataGridViewConsulta.DataSource = salidas.Listado("SalidaId, Fecha, EntradaId, Observacion, RetiradoPor", filtro, "");
            textBoxConteo.Text = dataGridViewConsulta.RowCount.ToString();
        }

        private void imprimirButton_Click(object sender, EventArgs e)
        {
            Reportes.VisorReportesForm Visor = new Reportes.VisorReportesForm();
            DataTable dt = new DataTable();

            dt = (DataTable)dataGridViewConsulta.DataSource;
            dt.TableName = "Salidas";
            Visor.reporte = "ReportSalidas.rdlc";
            Visor.data = dt;
            Visor.ShowDialog();
        }
    }
}
