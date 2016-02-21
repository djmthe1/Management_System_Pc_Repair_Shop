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

namespace Management_System_Pc_Repair_Shop.Registros
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        Usuarios usuarios = new Usuarios();

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Limpiar()
        {
            prioridadComboBox.SelectedIndex = -1;
            usuarioTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void ObtenerValores()
        {
            usuarios.Nombre = usuarioTextBox.Text;
            usuarios.Password = passwordTextBox.Text;
            usuarios.Prioridad = prioridadComboBox.Text;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usuarioTextBox.Text == "" || passwordTextBox.Text == "" || prioridadComboBox.Text == "")
            {
                MessageBox.Show("Debe llenar todos los Campos", "Error Al Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpiar();
            }
            else
            {
                if (usuarios.Verificar(usuarioTextBox.Text, passwordTextBox.Text, prioridadComboBox.Text))
                {
                    Portada portada = new Portada();
                    portada.Show();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                    Limpiar();
                }
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
