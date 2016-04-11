using System;
using System.Windows.Forms;

namespace Management_System_Pc_Repair_Shop.Registros
{
    partial class ClientesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesForm));
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nombreClienteLabel = new System.Windows.Forms.Label();
            this.clienteIdLabel = new System.Windows.Forms.Label();
            this.clienteIdTextBox = new System.Windows.Forms.TextBox();
            this.botonBuscarCliente = new System.Windows.Forms.Button();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.botonInsertarTelefono = new System.Windows.Forms.Button();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.telefonosDataGridView = new System.Windows.Forms.DataGridView();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTelefonoComboBox = new System.Windows.Forms.ComboBox();
            this.tipoTelefonoLabel = new System.Windows.Forms.Label();
            this.telefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(98, 50);
            this.nombreTextBox.MaxLength = 40;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(193, 20);
            this.nombreTextBox.TabIndex = 3;
            this.nombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTextBox_KeyPress);
            // 
            // nombreClienteLabel
            // 
            this.nombreClienteLabel.AutoSize = true;
            this.nombreClienteLabel.BackColor = System.Drawing.Color.Transparent;
            this.nombreClienteLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreClienteLabel.ForeColor = System.Drawing.Color.Black;
            this.nombreClienteLabel.Location = new System.Drawing.Point(41, 55);
            this.nombreClienteLabel.Name = "nombreClienteLabel";
            this.nombreClienteLabel.Size = new System.Drawing.Size(54, 15);
            this.nombreClienteLabel.TabIndex = 28;
            this.nombreClienteLabel.Text = "Nombre:";
            // 
            // clienteIdLabel
            // 
            this.clienteIdLabel.AutoSize = true;
            this.clienteIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.clienteIdLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteIdLabel.ForeColor = System.Drawing.Color.Black;
            this.clienteIdLabel.Location = new System.Drawing.Point(39, 29);
            this.clienteIdLabel.Name = "clienteIdLabel";
            this.clienteIdLabel.Size = new System.Drawing.Size(56, 15);
            this.clienteIdLabel.TabIndex = 30;
            this.clienteIdLabel.Text = "ClienteId:";
            // 
            // clienteIdTextBox
            // 
            this.clienteIdTextBox.Location = new System.Drawing.Point(98, 24);
            this.clienteIdTextBox.MaxLength = 5;
            this.clienteIdTextBox.Name = "clienteIdTextBox";
            this.clienteIdTextBox.Size = new System.Drawing.Size(64, 20);
            this.clienteIdTextBox.TabIndex = 1;
            this.clienteIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clienteIdTextBox_KeyPress);
            // 
            // botonBuscarCliente
            // 
            this.botonBuscarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonBuscarCliente.BackgroundImage")));
            this.botonBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBuscarCliente.Location = new System.Drawing.Point(167, 19);
            this.botonBuscarCliente.Name = "botonBuscarCliente";
            this.botonBuscarCliente.Size = new System.Drawing.Size(31, 29);
            this.botonBuscarCliente.TabIndex = 2;
            this.botonBuscarCliente.UseVisualStyleBackColor = true;
            this.botonBuscarCliente.Click += new System.EventHandler(this.botonBuscarCliente_Click);
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.BackColor = System.Drawing.Color.Transparent;
            this.direccionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionLabel.ForeColor = System.Drawing.Color.Black;
            this.direccionLabel.Location = new System.Drawing.Point(34, 81);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(61, 15);
            this.direccionLabel.TabIndex = 35;
            this.direccionLabel.Text = "Direccion:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(98, 76);
            this.direccionTextBox.MaxLength = 30;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(193, 20);
            this.direccionTextBox.TabIndex = 5;
            this.direccionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.direccionTextBox_KeyPress);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EliminarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(246, 261);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(87, 41);
            this.EliminarButton.TabIndex = 11;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NuevoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(12, 261);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(88, 41);
            this.NuevoButton.TabIndex = 9;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GuardarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(129, 261);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(88, 41);
            this.GuardarButton.TabIndex = 10;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // botonInsertarTelefono
            // 
            this.botonInsertarTelefono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonInsertarTelefono.BackgroundImage")));
            this.botonInsertarTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonInsertarTelefono.Location = new System.Drawing.Point(299, 94);
            this.botonInsertarTelefono.Name = "botonInsertarTelefono";
            this.botonInsertarTelefono.Size = new System.Drawing.Size(30, 28);
            this.botonInsertarTelefono.TabIndex = 8;
            this.botonInsertarTelefono.UseVisualStyleBackColor = true;
            this.botonInsertarTelefono.Click += new System.EventHandler(this.botonInsertarTelefono_Click);
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.BackColor = System.Drawing.Color.Transparent;
            this.telefonoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoLabel.ForeColor = System.Drawing.Color.Black;
            this.telefonoLabel.Location = new System.Drawing.Point(38, 107);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(57, 15);
            this.telefonoLabel.TabIndex = 54;
            this.telefonoLabel.Text = "Telefono:";
            // 
            // telefonosDataGridView
            // 
            this.telefonosDataGridView.AllowUserToAddRows = false;
            this.telefonosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.telefonosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Telefono,
            this.Tipo});
            this.telefonosDataGridView.Location = new System.Drawing.Point(42, 125);
            this.telefonosDataGridView.MultiSelect = false;
            this.telefonosDataGridView.Name = "telefonosDataGridView";
            this.telefonosDataGridView.ReadOnly = true;
            this.telefonosDataGridView.Size = new System.Drawing.Size(249, 100);
            this.telefonosDataGridView.TabIndex = 59;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // tipoTelefonoComboBox
            // 
            this.tipoTelefonoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoTelefonoComboBox.FormattingEnabled = true;
            this.tipoTelefonoComboBox.Items.AddRange(new object[] {
            "Residencia",
            "Celular",
            "Oficina",
            "Trabajo",
            "Fax",
            "Otro"});
            this.tipoTelefonoComboBox.Location = new System.Drawing.Point(214, 101);
            this.tipoTelefonoComboBox.Name = "tipoTelefonoComboBox";
            this.tipoTelefonoComboBox.Size = new System.Drawing.Size(79, 21);
            this.tipoTelefonoComboBox.TabIndex = 7;
            // 
            // tipoTelefonoLabel
            // 
            this.tipoTelefonoLabel.AutoSize = true;
            this.tipoTelefonoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoTelefonoLabel.Location = new System.Drawing.Point(179, 108);
            this.tipoTelefonoLabel.Name = "tipoTelefonoLabel";
            this.tipoTelefonoLabel.Size = new System.Drawing.Size(33, 13);
            this.tipoTelefonoLabel.TabIndex = 61;
            this.tipoTelefonoLabel.Text = "Tipo:";
            // 
            // telefonoMaskedTextBox
            // 
            this.telefonoMaskedTextBox.Location = new System.Drawing.Point(98, 102);
            this.telefonoMaskedTextBox.Mask = "000-000-0000";
            this.telefonoMaskedTextBox.Name = "telefonoMaskedTextBox";
            this.telefonoMaskedTextBox.Size = new System.Drawing.Size(79, 20);
            this.telefonoMaskedTextBox.TabIndex = 6;
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(345, 314);
            this.Controls.Add(this.telefonoMaskedTextBox);
            this.Controls.Add(this.tipoTelefonoLabel);
            this.Controls.Add(this.tipoTelefonoComboBox);
            this.Controls.Add(this.telefonosDataGridView);
            this.Controls.Add(this.botonInsertarTelefono);
            this.Controls.Add(this.telefonoLabel);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.nombreClienteLabel);
            this.Controls.Add(this.clienteIdLabel);
            this.Controls.Add(this.clienteIdTextBox);
            this.Controls.Add(this.botonBuscarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro De Clientes";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.telefonosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label nombreClienteLabel;
        private System.Windows.Forms.Label clienteIdLabel;
        private System.Windows.Forms.TextBox clienteIdTextBox;
        private System.Windows.Forms.Button botonBuscarCliente;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button botonInsertarTelefono;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.DataGridView telefonosDataGridView;
        private System.Windows.Forms.ComboBox tipoTelefonoComboBox;
        private System.Windows.Forms.Label tipoTelefonoLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.MaskedTextBox telefonoMaskedTextBox;
    }
}