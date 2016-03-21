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
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.fechaEntregaLabel = new System.Windows.Forms.Label();
            this.problemaLabel = new System.Windows.Forms.Label();
            this.notasLabel = new System.Windows.Forms.Label();
            this.articuloLabel = new System.Windows.Forms.Label();
            this.buscarButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.entradaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.entregaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.articulosComboBox = new System.Windows.Forms.ComboBox();
            this.articulosDataGridView = new System.Windows.Forms.DataGridView();
            this.problemaTextBox = new System.Windows.Forms.TextBox();
            this.botonInsertar = new System.Windows.Forms.Button();
            this.clienteIdTextBox = new System.Windows.Forms.TextBox();
            this.clienteIdLabel = new System.Windows.Forms.Label();
            this.buscarClienteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.articulosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EliminarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(307, 415);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(101, 41);
            this.EliminarButton.TabIndex = 57;
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
            this.NuevoButton.Location = new System.Drawing.Point(34, 415);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(101, 41);
            this.NuevoButton.TabIndex = 55;
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
            this.GuardarButton.Location = new System.Drawing.Point(170, 415);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(101, 41);
            this.GuardarButton.TabIndex = 56;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // fechaEntregaLabel
            // 
            this.fechaEntregaLabel.AutoSize = true;
            this.fechaEntregaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaEntregaLabel.Location = new System.Drawing.Point(-1, 79);
            this.fechaEntregaLabel.Name = "fechaEntregaLabel";
            this.fechaEntregaLabel.Size = new System.Drawing.Size(108, 13);
            this.fechaEntregaLabel.TabIndex = 60;
            this.fechaEntregaLabel.Text = "Fecha de Entrega";
            // 
            // problemaLabel
            // 
            this.problemaLabel.AutoSize = true;
            this.problemaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemaLabel.Location = new System.Drawing.Point(196, 225);
            this.problemaLabel.Name = "problemaLabel";
            this.problemaLabel.Size = new System.Drawing.Size(59, 13);
            this.problemaLabel.TabIndex = 61;
            this.problemaLabel.Text = "Problema";
            // 
            // notasLabel
            // 
            this.notasLabel.AutoSize = true;
            this.notasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notasLabel.Location = new System.Drawing.Point(67, 128);
            this.notasLabel.Name = "notasLabel";
            this.notasLabel.Size = new System.Drawing.Size(40, 13);
            this.notasLabel.TabIndex = 62;
            this.notasLabel.Text = "Notas";
            // 
            // articuloLabel
            // 
            this.articuloLabel.AutoSize = true;
            this.articuloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articuloLabel.Location = new System.Drawing.Point(31, 223);
            this.articuloLabel.Name = "articuloLabel";
            this.articuloLabel.Size = new System.Drawing.Size(50, 13);
            this.articuloLabel.TabIndex = 63;
            this.articuloLabel.Text = "Articulo";
            // 
            // buscarButton
            // 
            this.buscarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buscarButton.BackgroundImage")));
            this.buscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarButton.Location = new System.Drawing.Point(175, 25);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(25, 22);
            this.buscarButton.TabIndex = 68;
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(116, 27);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(56, 20);
            this.idTextBox.TabIndex = 67;
            // 
            // entradaDateTimePicker
            // 
            this.entradaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.entradaDateTimePicker.Location = new System.Drawing.Point(113, 53);
            this.entradaDateTimePicker.Name = "entradaDateTimePicker";
            this.entradaDateTimePicker.Size = new System.Drawing.Size(112, 20);
            this.entradaDateTimePicker.TabIndex = 66;
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaLabel.Location = new System.Drawing.Point(64, 53);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(42, 13);
            this.fechaLabel.TabIndex = 65;
            this.fechaLabel.Text = "Fecha";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(88, 27);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 64;
            this.idLabel.Text = "Id";
            // 
            // notasTextBox
            // 
            this.notasTextBox.Location = new System.Drawing.Point(113, 128);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.Size = new System.Drawing.Size(297, 82);
            this.notasTextBox.TabIndex = 69;
            // 
            // entregaDateTimePicker
            // 
            this.entregaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.entregaDateTimePicker.Location = new System.Drawing.Point(113, 79);
            this.entregaDateTimePicker.Name = "entregaDateTimePicker";
            this.entregaDateTimePicker.Size = new System.Drawing.Size(112, 20);
            this.entregaDateTimePicker.TabIndex = 70;
            // 
            // articulosComboBox
            // 
            this.articulosComboBox.FormattingEnabled = true;
            this.articulosComboBox.Location = new System.Drawing.Point(86, 220);
            this.articulosComboBox.Name = "articulosComboBox";
            this.articulosComboBox.Size = new System.Drawing.Size(104, 21);
            this.articulosComboBox.TabIndex = 71;
            // 
            // articulosDataGridView
            // 
            this.articulosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articulosDataGridView.Location = new System.Drawing.Point(34, 250);
            this.articulosDataGridView.Name = "articulosDataGridView";
            this.articulosDataGridView.Size = new System.Drawing.Size(374, 150);
            this.articulosDataGridView.TabIndex = 72;
            // 
            // problemaTextBox
            // 
            this.problemaTextBox.Location = new System.Drawing.Point(261, 222);
            this.problemaTextBox.Name = "problemaTextBox";
            this.problemaTextBox.Size = new System.Drawing.Size(117, 20);
            this.problemaTextBox.TabIndex = 73;
            // 
            // botonInsertar
            // 
            this.botonInsertar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonInsertar.BackgroundImage")));
            this.botonInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonInsertar.Location = new System.Drawing.Point(383, 222);
            this.botonInsertar.Name = "botonInsertar";
            this.botonInsertar.Size = new System.Drawing.Size(25, 24);
            this.botonInsertar.TabIndex = 75;
            this.botonInsertar.UseVisualStyleBackColor = true;
            this.botonInsertar.Click += new System.EventHandler(this.botonInsertar_Click);
            // 
            // clienteIdTextBox
            // 
            this.clienteIdTextBox.Location = new System.Drawing.Point(113, 102);
            this.clienteIdTextBox.Name = "clienteIdTextBox";
            this.clienteIdTextBox.Size = new System.Drawing.Size(56, 20);
            this.clienteIdTextBox.TabIndex = 77;
            // 
            // clienteIdLabel
            // 
            this.clienteIdLabel.AutoSize = true;
            this.clienteIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteIdLabel.Location = new System.Drawing.Point(50, 105);
            this.clienteIdLabel.Name = "clienteIdLabel";
            this.clienteIdLabel.Size = new System.Drawing.Size(57, 13);
            this.clienteIdLabel.TabIndex = 76;
            this.clienteIdLabel.Text = "ClienteId";
            // 
            // buscarClienteButton
            // 
            this.buscarClienteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buscarClienteButton.BackgroundImage")));
            this.buscarClienteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarClienteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarClienteButton.Location = new System.Drawing.Point(175, 98);
            this.buscarClienteButton.Name = "buscarClienteButton";
            this.buscarClienteButton.Size = new System.Drawing.Size(25, 24);
            this.buscarClienteButton.TabIndex = 78;
            this.buscarClienteButton.UseVisualStyleBackColor = true;
            this.buscarClienteButton.Click += new System.EventHandler(this.buscarClienteButton_Click);
            // 
            // EntradasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 468);
            this.Controls.Add(this.buscarClienteButton);
            this.Controls.Add(this.clienteIdTextBox);
            this.Controls.Add(this.clienteIdLabel);
            this.Controls.Add(this.botonInsertar);
            this.Controls.Add(this.problemaTextBox);
            this.Controls.Add(this.articulosDataGridView);
            this.Controls.Add(this.articulosComboBox);
            this.Controls.Add(this.entregaDateTimePicker);
            this.Controls.Add(this.notasTextBox);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.entradaDateTimePicker);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.articuloLabel);
            this.Controls.Add(this.notasLabel);
            this.Controls.Add(this.problemaLabel);
            this.Controls.Add(this.fechaEntregaLabel);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntradasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro De Entradas";
            this.Load += new System.EventHandler(this.EntradasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articulosDataGridView)).EndInit();
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
        private System.Windows.Forms.DateTimePicker entregaDateTimePicker;
        private System.Windows.Forms.ComboBox articulosComboBox;
        private System.Windows.Forms.DataGridView articulosDataGridView;
        private System.Windows.Forms.TextBox problemaTextBox;
        private System.Windows.Forms.Button botonInsertar;
        private System.Windows.Forms.TextBox clienteIdTextBox;
        private System.Windows.Forms.Label clienteIdLabel;
        private System.Windows.Forms.Button buscarClienteButton;
    }
}