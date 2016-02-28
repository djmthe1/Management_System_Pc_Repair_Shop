using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System_Pc_Repair_Shop
{
    public partial class Portada : Form
    {
        public Portada()
        {
            InitializeComponent();
        }

        private void Portada_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea Salir?", "Management System Pc Repair Shop", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea Cerrar Sesion?", "Management System Pc Repair Shop", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                Registros.LoginForm LoginF = new Registros.LoginForm();
                LoginF.Show();
                this.Close();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.UsuariosForm usuarios = new Registros.UsuariosForm();
            usuarios.Show();
        }

        private void piezasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.PiezasForm Rpiezas = new Registros.PiezasForm();
            Rpiezas.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.MarcasForm Rmarcas = new Registros.MarcasForm();
            Rmarcas.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registros.ClientesForm Rclientes = new Registros.ClientesForm();
            Rclientes.Show();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.EntradasForm REntradas = new Registros.EntradasForm();
            REntradas.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaClientesForm Cclientes = new Consultas.ConsultaClientesForm();
            Cclientes.Show();
        }

        private void marcasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaMarcasForm Cmarcas = new Consultas.ConsultaMarcasForm();
            Cmarcas.Show();
        }

        private void piezasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaPiezasForm Cpiezas = new Consultas.ConsultaPiezasForm();
            Cpiezas.Show();
        }

        private void entradasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Consultas.ConsultaEntradasForm Centradas = new Consultas.ConsultaEntradasForm();
            //Centradas.Show();
        }

    }
}
