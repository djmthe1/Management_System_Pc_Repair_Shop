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
    public partial class ConsultaAtrasadosForm : Form
    {
        public ConsultaAtrasadosForm()
        {
            InitializeComponent();
        }

        private void ConsultaAtrasadosForm_Load(object sender, EventArgs e)
        {
            Entradas entradas = new Entradas();
            dataGridViewConsulta.DataSource = entradas.VerificarAtrasos();
            textBoxConteo.Text = dataGridViewConsulta.RowCount.ToString();
        }
    }
}
