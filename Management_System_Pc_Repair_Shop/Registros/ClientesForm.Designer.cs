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
            this.apellidoLabel = new System.Windows.Forms.Label();
            this.clienteIdLabel = new System.Windows.Forms.Label();
            this.clienteIdTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.botonBuscarCliente = new System.Windows.Forms.Button();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.botonInsertarTelefono = new System.Windows.Forms.Button();
            this.botonEliminarTelefono = new System.Windows.Forms.Button();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.TelefonoTextBox = new System.Windows.Forms.TextBox();
            this.telefonosDataGridView = new System.Windows.Forms.DataGridView();
            this.tipoTelefonoComboBox = new System.Windows.Forms.ComboBox();
            this.tipoTelefonoLabel = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(84, 48);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 32;
            // 
            // nombreClienteLabel
            // 
            this.nombreClienteLabel.AutoSize = true;
            this.nombreClienteLabel.BackColor = System.Drawing.Color.Transparent;
            this.nombreClienteLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreClienteLabel.ForeColor = System.Drawing.Color.Black;
            this.nombreClienteLabel.Location = new System.Drawing.Point(27, 49);
            this.nombreClienteLabel.Name = "nombreClienteLabel";
            this.nombreClienteLabel.Size = new System.Drawing.Size(51, 15);
            this.nombreClienteLabel.TabIndex = 28;
            this.nombreClienteLabel.Text = "Nombre";
            // 
            // apellidoLabel
            // 
            this.apellidoLabel.AutoSize = true;
            this.apellidoLabel.BackColor = System.Drawing.Color.Transparent;
            this.apellidoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoLabel.ForeColor = System.Drawing.Color.Black;
            this.apellidoLabel.Location = new System.Drawing.Point(27, 74);
            this.apellidoLabel.Name = "apellidoLabel";
            this.apellidoLabel.Size = new System.Drawing.Size(51, 15);
            this.apellidoLabel.TabIndex = 29;
            this.apellidoLabel.Text = "Apellido";
            // 
            // clienteIdLabel
            // 
            this.clienteIdLabel.AutoSize = true;
            this.clienteIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.clienteIdLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteIdLabel.ForeColor = System.Drawing.Color.Black;
            this.clienteIdLabel.Location = new System.Drawing.Point(25, 24);
            this.clienteIdLabel.Name = "clienteIdLabel";
            this.clienteIdLabel.Size = new System.Drawing.Size(53, 15);
            this.clienteIdLabel.TabIndex = 30;
            this.clienteIdLabel.Text = "ClienteId";
            // 
            // clienteIdTextBox
            // 
            this.clienteIdTextBox.Location = new System.Drawing.Point(84, 19);
            this.clienteIdTextBox.Name = "clienteIdTextBox";
            this.clienteIdTextBox.Size = new System.Drawing.Size(64, 20);
            this.clienteIdTextBox.TabIndex = 31;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(84, 74);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoTextBox.TabIndex = 33;
            // 
            // botonBuscarCliente
            // 
            this.botonBuscarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonBuscarCliente.BackgroundImage")));
            this.botonBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBuscarCliente.Location = new System.Drawing.Point(153, 14);
            this.botonBuscarCliente.Name = "botonBuscarCliente";
            this.botonBuscarCliente.Size = new System.Drawing.Size(31, 29);
            this.botonBuscarCliente.TabIndex = 34;
            this.botonBuscarCliente.UseVisualStyleBackColor = true;
            this.botonBuscarCliente.Click += new System.EventHandler(this.botonBuscarCliente_Click);
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.BackColor = System.Drawing.Color.Transparent;
            this.direccionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionLabel.ForeColor = System.Drawing.Color.Black;
            this.direccionLabel.Location = new System.Drawing.Point(20, 102);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(58, 15);
            this.direccionLabel.TabIndex = 35;
            this.direccionLabel.Text = "Direccion";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(84, 100);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 36;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EliminarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(246, 272);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(87, 41);
            this.EliminarButton.TabIndex = 53;
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
            this.NuevoButton.Location = new System.Drawing.Point(12, 272);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(88, 41);
            this.NuevoButton.TabIndex = 51;
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
            this.GuardarButton.Location = new System.Drawing.Point(129, 272);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(88, 41);
            this.GuardarButton.TabIndex = 52;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // botonInsertarTelefono
            // 
            this.botonInsertarTelefono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonInsertarTelefono.BackgroundImage")));
            this.botonInsertarTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonInsertarTelefono.Location = new System.Drawing.Point(277, 126);
            this.botonInsertarTelefono.Name = "botonInsertarTelefono";
            this.botonInsertarTelefono.Size = new System.Drawing.Size(30, 28);
            this.botonInsertarTelefono.TabIndex = 58;
            this.botonInsertarTelefono.UseVisualStyleBackColor = true;
            this.botonInsertarTelefono.Click += new System.EventHandler(this.botonInsertarTelefono_Click);
            // 
            // botonEliminarTelefono
            // 
            this.botonEliminarTelefono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonEliminarTelefono.BackgroundImage")));
            this.botonEliminarTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonEliminarTelefono.Location = new System.Drawing.Point(277, 224);
            this.botonEliminarTelefono.Name = "botonEliminarTelefono";
            this.botonEliminarTelefono.Size = new System.Drawing.Size(30, 28);
            this.botonEliminarTelefono.TabIndex = 57;
            this.botonEliminarTelefono.UseVisualStyleBackColor = true;
            this.botonEliminarTelefono.Click += new System.EventHandler(this.botonEliminarTelefono_Click);
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.BackColor = System.Drawing.Color.Transparent;
            this.telefonoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoLabel.ForeColor = System.Drawing.Color.Black;
            this.telefonoLabel.Location = new System.Drawing.Point(24, 128);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(57, 15);
            this.telefonoLabel.TabIndex = 54;
            this.telefonoLabel.Text = "Telefono:";
            // 
            // TelefonoTextBox
            // 
            this.TelefonoTextBox.Location = new System.Drawing.Point(84, 126);
            this.TelefonoTextBox.Name = "TelefonoTextBox";
            this.TelefonoTextBox.Size = new System.Drawing.Size(75, 20);
            this.TelefonoTextBox.TabIndex = 55;
            // 
            // telefonosDataGridView
            // 
            this.telefonosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.telefonosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Telefono,
            this.Tipo});
            this.telefonosDataGridView.Location = new System.Drawing.Point(84, 152);
            this.telefonosDataGridView.MultiSelect = false;
            this.telefonosDataGridView.Name = "telefonosDataGridView";
            this.telefonosDataGridView.Size = new System.Drawing.Size(187, 100);
            this.telefonosDataGridView.TabIndex = 59;
            // 
            // tipoTelefonoComboBox
            // 
            this.tipoTelefonoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoTelefonoComboBox.FormattingEnabled = true;
            this.tipoTelefonoComboBox.Items.AddRange(new object[] {
            "Casa"});
            this.tipoTelefonoComboBox.Location = new System.Drawing.Point(196, 126);
            this.tipoTelefonoComboBox.Name = "tipoTelefonoComboBox";
            this.tipoTelefonoComboBox.Size = new System.Drawing.Size(75, 21);
            this.tipoTelefonoComboBox.TabIndex = 60;
            // 
            // tipoTelefonoLabel
            // 
            this.tipoTelefonoLabel.AutoSize = true;
            this.tipoTelefonoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoTelefonoLabel.Location = new System.Drawing.Point(157, 129);
            this.tipoTelefonoLabel.Name = "tipoTelefonoLabel";
            this.tipoTelefonoLabel.Size = new System.Drawing.Size(33, 13);
            this.tipoTelefonoLabel.TabIndex = 61;
            this.tipoTelefonoLabel.Text = "Tipo:";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 325);
            this.Controls.Add(this.tipoTelefonoLabel);
            this.Controls.Add(this.tipoTelefonoComboBox);
            this.Controls.Add(this.telefonosDataGridView);
            this.Controls.Add(this.botonInsertarTelefono);
            this.Controls.Add(this.botonEliminarTelefono);
            this.Controls.Add(this.telefonoLabel);
            this.Controls.Add(this.TelefonoTextBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.nombreClienteLabel);
            this.Controls.Add(this.apellidoLabel);
            this.Controls.Add(this.clienteIdLabel);
            this.Controls.Add(this.clienteIdTextBox);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.botonBuscarCliente);
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
        private System.Windows.Forms.Label apellidoLabel;
        private System.Windows.Forms.Label clienteIdLabel;
        private System.Windows.Forms.TextBox clienteIdTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.Button botonBuscarCliente;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button botonInsertarTelefono;
        private System.Windows.Forms.Button botonEliminarTelefono;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.TextBox TelefonoTextBox;
        private System.Windows.Forms.DataGridView telefonosDataGridView;
        private System.Windows.Forms.ComboBox tipoTelefonoComboBox;
        private System.Windows.Forms.Label tipoTelefonoLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}