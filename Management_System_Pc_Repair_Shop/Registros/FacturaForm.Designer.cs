namespace Management_System_Pc_Repair_Shop.Registros
{
    partial class FacturaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturaForm));
            this.entradaIdLabel = new System.Windows.Forms.Label();
            this.facturaLabel = new System.Windows.Forms.Label();
            this.totalVentaLabel = new System.Windows.Forms.Label();
            this.totalFacturaLabel = new System.Windows.Forms.Label();
            this.montoAPagarLabel = new System.Windows.Forms.Label();
            this.precioLabel = new System.Windows.Forms.Label();
            this.totalReparaciónLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.articulosVendidosPanel = new System.Windows.Forms.Panel();
            this.articulosVendidosLabel = new System.Windows.Forms.Label();
            this.totalVentaTextBox = new System.Windows.Forms.TextBox();
            this.marcaComboBox = new System.Windows.Forms.ComboBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.botonInsertar = new System.Windows.Forms.Button();
            this.articulosVendidosDataGridView = new System.Windows.Forms.DataGridView();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulosComboBox = new System.Windows.Forms.ComboBox();
            this.articuloLabel = new System.Windows.Forms.Label();
            this.marcaLabel = new System.Windows.Forms.Label();
            this.facturaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.totalReparacionTextBox = new System.Windows.Forms.TextBox();
            this.montoAPagarTextBox = new System.Windows.Forms.TextBox();
            this.totalFacturaTextBox = new System.Windows.Forms.TextBox();
            this.entradaComboBox = new System.Windows.Forms.ComboBox();
            this.articulosReparadosPanel = new System.Windows.Forms.Panel();
            this.articulosReparadosLabel = new System.Windows.Forms.Label();
            this.articulosReparadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.articulosVendidosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulosVendidosDataGridView)).BeginInit();
            this.articulosReparadosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulosReparadosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // entradaIdLabel
            // 
            this.entradaIdLabel.AutoSize = true;
            this.entradaIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradaIdLabel.Location = new System.Drawing.Point(197, 50);
            this.entradaIdLabel.Name = "entradaIdLabel";
            this.entradaIdLabel.Size = new System.Drawing.Size(66, 13);
            this.entradaIdLabel.TabIndex = 0;
            this.entradaIdLabel.Text = "EntradaId:";
            // 
            // facturaLabel
            // 
            this.facturaLabel.AutoSize = true;
            this.facturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturaLabel.Location = new System.Drawing.Point(12, 9);
            this.facturaLabel.Name = "facturaLabel";
            this.facturaLabel.Size = new System.Drawing.Size(118, 25);
            this.facturaLabel.TabIndex = 1;
            this.facturaLabel.Text = "FACTURA";
            // 
            // totalVentaLabel
            // 
            this.totalVentaLabel.AutoSize = true;
            this.totalVentaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVentaLabel.Location = new System.Drawing.Point(216, 166);
            this.totalVentaLabel.Name = "totalVentaLabel";
            this.totalVentaLabel.Size = new System.Drawing.Size(93, 13);
            this.totalVentaLabel.TabIndex = 2;
            this.totalVentaLabel.Text = "Total Articulos:";
            // 
            // totalFacturaLabel
            // 
            this.totalFacturaLabel.AutoSize = true;
            this.totalFacturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFacturaLabel.Location = new System.Drawing.Point(513, 283);
            this.totalFacturaLabel.Name = "totalFacturaLabel";
            this.totalFacturaLabel.Size = new System.Drawing.Size(40, 13);
            this.totalFacturaLabel.TabIndex = 3;
            this.totalFacturaLabel.Text = "Total:";
            // 
            // montoAPagarLabel
            // 
            this.montoAPagarLabel.AutoSize = true;
            this.montoAPagarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoAPagarLabel.Location = new System.Drawing.Point(628, 283);
            this.montoAPagarLabel.Name = "montoAPagarLabel";
            this.montoAPagarLabel.Size = new System.Drawing.Size(94, 13);
            this.montoAPagarLabel.TabIndex = 4;
            this.montoAPagarLabel.Text = "Monto a Pagar:";
            // 
            // precioLabel
            // 
            this.precioLabel.AutoSize = true;
            this.precioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioLabel.Location = new System.Drawing.Point(257, 29);
            this.precioLabel.Name = "precioLabel";
            this.precioLabel.Size = new System.Drawing.Size(47, 13);
            this.precioLabel.TabIndex = 5;
            this.precioLabel.Text = "Precio:";
            // 
            // totalReparaciónLabel
            // 
            this.totalReparaciónLabel.AutoSize = true;
            this.totalReparaciónLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalReparaciónLabel.Location = new System.Drawing.Point(173, 167);
            this.totalReparaciónLabel.Name = "totalReparaciónLabel";
            this.totalReparaciónLabel.Size = new System.Drawing.Size(109, 13);
            this.totalReparaciónLabel.TabIndex = 6;
            this.totalReparaciónLabel.Text = "Total Reparación:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(262, 14);
            this.idTextBox.MaxLength = 5;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(98, 20);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTextBox_KeyPress);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(238, 14);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(22, 13);
            this.idLabel.TabIndex = 55;
            this.idLabel.Text = "Id:";
            // 
            // articulosVendidosPanel
            // 
            this.articulosVendidosPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.articulosVendidosPanel.Controls.Add(this.articulosVendidosLabel);
            this.articulosVendidosPanel.Controls.Add(this.totalVentaTextBox);
            this.articulosVendidosPanel.Controls.Add(this.marcaComboBox);
            this.articulosVendidosPanel.Controls.Add(this.precioTextBox);
            this.articulosVendidosPanel.Controls.Add(this.botonInsertar);
            this.articulosVendidosPanel.Controls.Add(this.articulosVendidosDataGridView);
            this.articulosVendidosPanel.Controls.Add(this.articulosComboBox);
            this.articulosVendidosPanel.Controls.Add(this.articuloLabel);
            this.articulosVendidosPanel.Controls.Add(this.marcaLabel);
            this.articulosVendidosPanel.Controls.Add(this.precioLabel);
            this.articulosVendidosPanel.Controls.Add(this.totalVentaLabel);
            this.articulosVendidosPanel.Location = new System.Drawing.Point(409, 79);
            this.articulosVendidosPanel.Name = "articulosVendidosPanel";
            this.articulosVendidosPanel.Size = new System.Drawing.Size(385, 186);
            this.articulosVendidosPanel.TabIndex = 61;
            // 
            // articulosVendidosLabel
            // 
            this.articulosVendidosLabel.AutoSize = true;
            this.articulosVendidosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articulosVendidosLabel.Location = new System.Drawing.Point(3, 4);
            this.articulosVendidosLabel.Name = "articulosVendidosLabel";
            this.articulosVendidosLabel.Size = new System.Drawing.Size(142, 16);
            this.articulosVendidosLabel.TabIndex = 81;
            this.articulosVendidosLabel.Text = "Articulos Vendidos:";
            // 
            // totalVentaTextBox
            // 
            this.totalVentaTextBox.Location = new System.Drawing.Point(315, 163);
            this.totalVentaTextBox.Name = "totalVentaTextBox";
            this.totalVentaTextBox.ReadOnly = true;
            this.totalVentaTextBox.Size = new System.Drawing.Size(67, 20);
            this.totalVentaTextBox.TabIndex = 84;
            // 
            // marcaComboBox
            // 
            this.marcaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marcaComboBox.FormattingEnabled = true;
            this.marcaComboBox.Items.AddRange(new object[] {
            "Dell"});
            this.marcaComboBox.Location = new System.Drawing.Point(165, 43);
            this.marcaComboBox.Name = "marcaComboBox";
            this.marcaComboBox.Size = new System.Drawing.Size(89, 21);
            this.marcaComboBox.TabIndex = 4;
            // 
            // precioTextBox
            // 
            this.precioTextBox.Location = new System.Drawing.Point(260, 45);
            this.precioTextBox.MaxLength = 5;
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(69, 20);
            this.precioTextBox.TabIndex = 5;
            this.precioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioTextBox_KeyPress);
            // 
            // botonInsertar
            // 
            this.botonInsertar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonInsertar.BackgroundImage")));
            this.botonInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonInsertar.Location = new System.Drawing.Point(335, 36);
            this.botonInsertar.Name = "botonInsertar";
            this.botonInsertar.Size = new System.Drawing.Size(32, 29);
            this.botonInsertar.TabIndex = 81;
            this.botonInsertar.UseVisualStyleBackColor = true;
            this.botonInsertar.Click += new System.EventHandler(this.botonInsertar_Click);
            // 
            // articulosVendidosDataGridView
            // 
            this.articulosVendidosDataGridView.AllowUserToAddRows = false;
            this.articulosVendidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articulosVendidosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Articulo,
            this.Marca,
            this.Precio});
            this.articulosVendidosDataGridView.Location = new System.Drawing.Point(14, 70);
            this.articulosVendidosDataGridView.Name = "articulosVendidosDataGridView";
            this.articulosVendidosDataGridView.Size = new System.Drawing.Size(353, 76);
            this.articulosVendidosDataGridView.TabIndex = 79;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // articulosComboBox
            // 
            this.articulosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.articulosComboBox.FormattingEnabled = true;
            this.articulosComboBox.Items.AddRange(new object[] {
            "Motherboard"});
            this.articulosComboBox.Location = new System.Drawing.Point(55, 43);
            this.articulosComboBox.Name = "articulosComboBox";
            this.articulosComboBox.Size = new System.Drawing.Size(104, 21);
            this.articulosComboBox.TabIndex = 3;
            // 
            // articuloLabel
            // 
            this.articuloLabel.AutoSize = true;
            this.articuloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articuloLabel.Location = new System.Drawing.Point(52, 27);
            this.articuloLabel.Name = "articuloLabel";
            this.articuloLabel.Size = new System.Drawing.Size(54, 13);
            this.articuloLabel.TabIndex = 77;
            this.articuloLabel.Text = "Articulo:";
            // 
            // marcaLabel
            // 
            this.marcaLabel.AutoSize = true;
            this.marcaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaLabel.Location = new System.Drawing.Point(162, 28);
            this.marcaLabel.Name = "marcaLabel";
            this.marcaLabel.Size = new System.Drawing.Size(46, 13);
            this.marcaLabel.TabIndex = 76;
            this.marcaLabel.Text = "Marca:";
            // 
            // facturaDateTimePicker
            // 
            this.facturaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.facturaDateTimePicker.Location = new System.Drawing.Point(470, 14);
            this.facturaDateTimePicker.MinDate = new System.DateTime(2016, 3, 27, 0, 0, 0, 0);
            this.facturaDateTimePicker.Name = "facturaDateTimePicker";
            this.facturaDateTimePicker.Size = new System.Drawing.Size(98, 20);
            this.facturaDateTimePicker.TabIndex = 5;
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaLabel.Location = new System.Drawing.Point(425, 14);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(46, 13);
            this.fechaLabel.TabIndex = 67;
            this.fechaLabel.Text = "Fecha:";
            // 
            // totalReparacionTextBox
            // 
            this.totalReparacionTextBox.Location = new System.Drawing.Point(284, 163);
            this.totalReparacionTextBox.MaxLength = 6;
            this.totalReparacionTextBox.Name = "totalReparacionTextBox";
            this.totalReparacionTextBox.ReadOnly = true;
            this.totalReparacionTextBox.Size = new System.Drawing.Size(98, 20);
            this.totalReparacionTextBox.TabIndex = 6;
            this.totalReparacionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cargoDeReparacionTextBox_KeyPress);
            // 
            // montoAPagarTextBox
            // 
            this.montoAPagarTextBox.Location = new System.Drawing.Point(724, 280);
            this.montoAPagarTextBox.MaxLength = 6;
            this.montoAPagarTextBox.Name = "montoAPagarTextBox";
            this.montoAPagarTextBox.Size = new System.Drawing.Size(67, 20);
            this.montoAPagarTextBox.TabIndex = 6;
            this.montoAPagarTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.montoAPagarTextBox_KeyPress);
            // 
            // totalFacturaTextBox
            // 
            this.totalFacturaTextBox.Location = new System.Drawing.Point(555, 280);
            this.totalFacturaTextBox.Name = "totalFacturaTextBox";
            this.totalFacturaTextBox.ReadOnly = true;
            this.totalFacturaTextBox.Size = new System.Drawing.Size(67, 20);
            this.totalFacturaTextBox.TabIndex = 87;
            // 
            // entradaComboBox
            // 
            this.entradaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entradaComboBox.FormattingEnabled = true;
            this.entradaComboBox.Location = new System.Drawing.Point(262, 47);
            this.entradaComboBox.Name = "entradaComboBox";
            this.entradaComboBox.Size = new System.Drawing.Size(98, 21);
            this.entradaComboBox.TabIndex = 3;
            this.entradaComboBox.SelectedIndexChanged += new System.EventHandler(this.entradaComboBox_SelectedIndexChanged);
            // 
            // articulosReparadosPanel
            // 
            this.articulosReparadosPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.articulosReparadosPanel.Controls.Add(this.articulosReparadosLabel);
            this.articulosReparadosPanel.Controls.Add(this.articulosReparadosDataGridView);
            this.articulosReparadosPanel.Controls.Add(this.totalReparacionTextBox);
            this.articulosReparadosPanel.Controls.Add(this.totalReparaciónLabel);
            this.articulosReparadosPanel.Location = new System.Drawing.Point(9, 79);
            this.articulosReparadosPanel.Name = "articulosReparadosPanel";
            this.articulosReparadosPanel.Size = new System.Drawing.Size(385, 186);
            this.articulosReparadosPanel.TabIndex = 88;
            // 
            // articulosReparadosLabel
            // 
            this.articulosReparadosLabel.AutoSize = true;
            this.articulosReparadosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articulosReparadosLabel.Location = new System.Drawing.Point(4, 4);
            this.articulosReparadosLabel.Name = "articulosReparadosLabel";
            this.articulosReparadosLabel.Size = new System.Drawing.Size(154, 16);
            this.articulosReparadosLabel.TabIndex = 80;
            this.articulosReparadosLabel.Text = "Articulos Reparados:";
            // 
            // articulosReparadosDataGridView
            // 
            this.articulosReparadosDataGridView.AllowUserToAddRows = false;
            this.articulosReparadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articulosReparadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.articulosReparadosDataGridView.Location = new System.Drawing.Point(16, 29);
            this.articulosReparadosDataGridView.Name = "articulosReparadosDataGridView";
            this.articulosReparadosDataGridView.Size = new System.Drawing.Size(353, 118);
            this.articulosReparadosDataGridView.TabIndex = 79;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Articulo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Problema";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cargo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EliminarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(478, 316);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(87, 41);
            this.EliminarButton.TabIndex = 9;
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
            this.NuevoButton.Location = new System.Drawing.Point(236, 316);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(88, 41);
            this.NuevoButton.TabIndex = 7;
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
            this.GuardarButton.Location = new System.Drawing.Point(357, 316);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(88, 41);
            this.GuardarButton.TabIndex = 8;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonBuscar.BackgroundImage")));
            this.botonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBuscar.Location = new System.Drawing.Point(366, 7);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(31, 29);
            this.botonBuscar.TabIndex = 2;
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // FacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(802, 369);
            this.Controls.Add(this.articulosReparadosPanel);
            this.Controls.Add(this.entradaComboBox);
            this.Controls.Add(this.totalFacturaTextBox);
            this.Controls.Add(this.montoAPagarTextBox);
            this.Controls.Add(this.facturaDateTimePicker);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.articulosVendidosPanel);
            this.Controls.Add(this.facturaLabel);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.montoAPagarLabel);
            this.Controls.Add(this.totalFacturaLabel);
            this.Controls.Add(this.entradaIdLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FacturaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro De Factura";
            this.Load += new System.EventHandler(this.FacturaForm_Load);
            this.articulosVendidosPanel.ResumeLayout(false);
            this.articulosVendidosPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulosVendidosDataGridView)).EndInit();
            this.articulosReparadosPanel.ResumeLayout(false);
            this.articulosReparadosPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulosReparadosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label entradaIdLabel;
        private System.Windows.Forms.Label facturaLabel;
        private System.Windows.Forms.Label totalVentaLabel;
        private System.Windows.Forms.Label totalFacturaLabel;
        private System.Windows.Forms.Label montoAPagarLabel;
        private System.Windows.Forms.Label precioLabel;
        private System.Windows.Forms.Label totalReparaciónLabel;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Panel articulosVendidosPanel;
        private System.Windows.Forms.Button botonInsertar;
        private System.Windows.Forms.DataGridView articulosVendidosDataGridView;
        private System.Windows.Forms.ComboBox articulosComboBox;
        private System.Windows.Forms.Label articuloLabel;
        private System.Windows.Forms.Label marcaLabel;
        private System.Windows.Forms.ComboBox marcaComboBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.DateTimePicker facturaDateTimePicker;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.TextBox totalVentaTextBox;
        private System.Windows.Forms.TextBox totalReparacionTextBox;
        private System.Windows.Forms.TextBox montoAPagarTextBox;
        private System.Windows.Forms.TextBox totalFacturaTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.ComboBox entradaComboBox;
        private System.Windows.Forms.Panel articulosReparadosPanel;
        private System.Windows.Forms.DataGridView articulosReparadosDataGridView;
        private System.Windows.Forms.Label articulosVendidosLabel;
        private System.Windows.Forms.Label articulosReparadosLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}