namespace Management_System_Pc_Repair_Shop.Registros
{
    partial class EntradasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradasForm));
            this.fechaEntregaLabel = new System.Windows.Forms.Label();
            this.problemaLabel = new System.Windows.Forms.Label();
            this.notasLabel = new System.Windows.Forms.Label();
            this.articuloLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.entradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.articulosComboBox = new System.Windows.Forms.ComboBox();
            this.articulosDataGridView = new System.Windows.Forms.DataGridView();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Problema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemaTextBox = new System.Windows.Forms.TextBox();
            this.entregaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombreClienteLabel = new System.Windows.Forms.Label();
            this.entradasPanel = new System.Windows.Forms.Panel();
            this.botonInsertar = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.articulosDataGridView)).BeginInit();
            this.entradasPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fechaEntregaLabel
            // 
            this.fechaEntregaLabel.AutoSize = true;
            this.fechaEntregaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaEntregaLabel.Location = new System.Drawing.Point(12, 127);
            this.fechaEntregaLabel.Name = "fechaEntregaLabel";
            this.fechaEntregaLabel.Size = new System.Drawing.Size(112, 13);
            this.fechaEntregaLabel.TabIndex = 60;
            this.fechaEntregaLabel.Text = "Fecha de Entrega:";
            // 
            // problemaLabel
            // 
            this.problemaLabel.AutoSize = true;
            this.problemaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemaLabel.Location = new System.Drawing.Point(176, 14);
            this.problemaLabel.Name = "problemaLabel";
            this.problemaLabel.Size = new System.Drawing.Size(63, 13);
            this.problemaLabel.TabIndex = 61;
            this.problemaLabel.Text = "Problema:";
            // 
            // notasLabel
            // 
            this.notasLabel.AutoSize = true;
            this.notasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notasLabel.Location = new System.Drawing.Point(238, 26);
            this.notasLabel.Name = "notasLabel";
            this.notasLabel.Size = new System.Drawing.Size(44, 13);
            this.notasLabel.TabIndex = 62;
            this.notasLabel.Text = "Notas:";
            // 
            // articuloLabel
            // 
            this.articuloLabel.AutoSize = true;
            this.articuloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articuloLabel.Location = new System.Drawing.Point(11, 12);
            this.articuloLabel.Name = "articuloLabel";
            this.articuloLabel.Size = new System.Drawing.Size(54, 13);
            this.articuloLabel.TabIndex = 63;
            this.articuloLabel.Text = "Articulo:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(130, 20);
            this.idTextBox.MaxLength = 6;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(78, 20);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTextBox_KeyPress);
            // 
            // entradaDateTimePicker
            // 
            this.entradaDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.entradaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.entradaDateTimePicker.Location = new System.Drawing.Point(130, 91);
            this.entradaDateTimePicker.Name = "entradaDateTimePicker";
            this.entradaDateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.entradaDateTimePicker.TabIndex = 3;
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaLabel.Location = new System.Drawing.Point(78, 94);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(46, 13);
            this.fechaLabel.TabIndex = 65;
            this.fechaLabel.Text = "Fecha:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(102, 23);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(22, 13);
            this.idLabel.TabIndex = 64;
            this.idLabel.Text = "Id:";
            // 
            // notasTextBox
            // 
            this.notasTextBox.Location = new System.Drawing.Point(282, 26);
            this.notasTextBox.MaxLength = 100;
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.Size = new System.Drawing.Size(151, 122);
            this.notasTextBox.TabIndex = 7;
            this.notasTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.notasTextBox_KeyPress);
            // 
            // articulosComboBox
            // 
            this.articulosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.articulosComboBox.FormattingEnabled = true;
            this.articulosComboBox.Location = new System.Drawing.Point(66, 9);
            this.articulosComboBox.Name = "articulosComboBox";
            this.articulosComboBox.Size = new System.Drawing.Size(104, 21);
            this.articulosComboBox.TabIndex = 8;
            // 
            // articulosDataGridView
            // 
            this.articulosDataGridView.AllowUserToAddRows = false;
            this.articulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articulosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Articulo,
            this.Problema});
            this.articulosDataGridView.Location = new System.Drawing.Point(14, 39);
            this.articulosDataGridView.Name = "articulosDataGridView";
            this.articulosDataGridView.ReadOnly = true;
            this.articulosDataGridView.Size = new System.Drawing.Size(374, 150);
            this.articulosDataGridView.TabIndex = 72;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            // 
            // Problema
            // 
            this.Problema.HeaderText = "Problema";
            this.Problema.Name = "Problema";
            this.Problema.ReadOnly = true;
            this.Problema.Width = 200;
            // 
            // problemaTextBox
            // 
            this.problemaTextBox.Location = new System.Drawing.Point(241, 11);
            this.problemaTextBox.MaxLength = 200;
            this.problemaTextBox.Name = "problemaTextBox";
            this.problemaTextBox.Size = new System.Drawing.Size(117, 20);
            this.problemaTextBox.TabIndex = 9;
            this.problemaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.problemaTextBox_KeyPress);
            // 
            // entregaDateTimePicker
            // 
            this.entregaDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.entregaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.entregaDateTimePicker.Location = new System.Drawing.Point(130, 125);
            this.entregaDateTimePicker.Name = "entregaDateTimePicker";
            this.entregaDateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.entregaDateTimePicker.TabIndex = 4;
            // 
            // nombreClienteLabel
            // 
            this.nombreClienteLabel.AutoSize = true;
            this.nombreClienteLabel.BackColor = System.Drawing.Color.Transparent;
            this.nombreClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreClienteLabel.ForeColor = System.Drawing.Color.Black;
            this.nombreClienteLabel.Location = new System.Drawing.Point(70, 57);
            this.nombreClienteLabel.Name = "nombreClienteLabel";
            this.nombreClienteLabel.Size = new System.Drawing.Size(50, 13);
            this.nombreClienteLabel.TabIndex = 78;
            this.nombreClienteLabel.Text = "Cliente:";
            // 
            // entradasPanel
            // 
            this.entradasPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.entradasPanel.Controls.Add(this.articulosComboBox);
            this.entradasPanel.Controls.Add(this.problemaLabel);
            this.entradasPanel.Controls.Add(this.articuloLabel);
            this.entradasPanel.Controls.Add(this.articulosDataGridView);
            this.entradasPanel.Controls.Add(this.problemaTextBox);
            this.entradasPanel.Controls.Add(this.botonInsertar);
            this.entradasPanel.Location = new System.Drawing.Point(33, 163);
            this.entradasPanel.Name = "entradasPanel";
            this.entradasPanel.Size = new System.Drawing.Size(400, 203);
            this.entradasPanel.TabIndex = 79;
            // 
            // botonInsertar
            // 
            this.botonInsertar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonInsertar.BackgroundImage")));
            this.botonInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonInsertar.Location = new System.Drawing.Point(363, 9);
            this.botonInsertar.Name = "botonInsertar";
            this.botonInsertar.Size = new System.Drawing.Size(25, 24);
            this.botonInsertar.TabIndex = 10;
            this.botonInsertar.UseVisualStyleBackColor = true;
            this.botonInsertar.Click += new System.EventHandler(this.botonInsertar_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buscarButton.BackgroundImage")));
            this.buscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarButton.Location = new System.Drawing.Point(212, 20);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(25, 22);
            this.buscarButton.TabIndex = 2;
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EliminarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(318, 387);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(101, 41);
            this.EliminarButton.TabIndex = 13;
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
            this.NuevoButton.Location = new System.Drawing.Point(45, 387);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(101, 41);
            this.NuevoButton.TabIndex = 11;
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
            this.GuardarButton.Location = new System.Drawing.Point(181, 387);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(101, 41);
            this.GuardarButton.TabIndex = 12;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(130, 57);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(142, 21);
            this.clienteComboBox.TabIndex = 80;
            // 
            // EntradasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(462, 440);
            this.Controls.Add(this.clienteComboBox);
            this.Controls.Add(this.entradasPanel);
            this.Controls.Add(this.nombreClienteLabel);
            this.Controls.Add(this.entregaDateTimePicker);
            this.Controls.Add(this.notasTextBox);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.entradaDateTimePicker);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.notasLabel);
            this.Controls.Add(this.fechaEntregaLabel);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntradasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro De Entradas";
            this.Load += new System.EventHandler(this.EntradasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articulosDataGridView)).EndInit();
            this.entradasPanel.ResumeLayout(false);
            this.entradasPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Label fechaEntregaLabel;
        private System.Windows.Forms.Label problemaLabel;
        private System.Windows.Forms.Label notasLabel;
        private System.Windows.Forms.Label articuloLabel;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker entradaDateTimePicker;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.ComboBox articulosComboBox;
        private System.Windows.Forms.DataGridView articulosDataGridView;
        private System.Windows.Forms.TextBox problemaTextBox;
        private System.Windows.Forms.Button botonInsertar;
        private System.Windows.Forms.DateTimePicker entregaDateTimePicker;
        private System.Windows.Forms.Label nombreClienteLabel;
        private System.Windows.Forms.Panel entradasPanel;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Problema;
    }
}