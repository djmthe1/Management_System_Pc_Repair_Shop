namespace Management_System_Pc_Repair_Shop.Registros
{
    partial class SalidasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalidasForm));
            this.idLabel = new System.Windows.Forms.Label();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.observacionLabel = new System.Windows.Forms.Label();
            this.salidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.EntradaComboBox = new System.Windows.Forms.ComboBox();
            this.observacionTextBox = new System.Windows.Forms.TextBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.botonBuscarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(72, 19);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(22, 13);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "Id:";
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaLabel.Location = new System.Drawing.Point(48, 50);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(46, 13);
            this.fechaLabel.TabIndex = 7;
            this.fechaLabel.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "EntradaId:";
            // 
            // observacionLabel
            // 
            this.observacionLabel.AutoSize = true;
            this.observacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacionLabel.Location = new System.Drawing.Point(12, 112);
            this.observacionLabel.Name = "observacionLabel";
            this.observacionLabel.Size = new System.Drawing.Size(82, 13);
            this.observacionLabel.TabIndex = 9;
            this.observacionLabel.Text = "Observación:";
            // 
            // salidaDateTimePicker
            // 
            this.salidaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.salidaDateTimePicker.Location = new System.Drawing.Point(96, 50);
            this.salidaDateTimePicker.Name = "salidaDateTimePicker";
            this.salidaDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.salidaDateTimePicker.TabIndex = 3;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(96, 19);
            this.idTextBox.MaxLength = 5;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(60, 20);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idTextBox_KeyPress);
            // 
            // EntradaComboBox
            // 
            this.EntradaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EntradaComboBox.FormattingEnabled = true;
            this.EntradaComboBox.Location = new System.Drawing.Point(96, 78);
            this.EntradaComboBox.Name = "EntradaComboBox";
            this.EntradaComboBox.Size = new System.Drawing.Size(97, 21);
            this.EntradaComboBox.TabIndex = 4;
            // 
            // observacionTextBox
            // 
            this.observacionTextBox.Location = new System.Drawing.Point(96, 112);
            this.observacionTextBox.MaxLength = 200;
            this.observacionTextBox.Multiline = true;
            this.observacionTextBox.Name = "observacionTextBox";
            this.observacionTextBox.Size = new System.Drawing.Size(246, 82);
            this.observacionTextBox.TabIndex = 5;
            this.observacionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.observacionTextBox_KeyPress);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EliminarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(254, 226);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(88, 41);
            this.EliminarButton.TabIndex = 8;
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
            this.NuevoButton.Location = new System.Drawing.Point(20, 226);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(88, 41);
            this.NuevoButton.TabIndex = 6;
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
            this.GuardarButton.Location = new System.Drawing.Point(137, 226);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(88, 41);
            this.GuardarButton.TabIndex = 7;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // botonBuscarCliente
            // 
            this.botonBuscarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonBuscarCliente.BackgroundImage")));
            this.botonBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBuscarCliente.Location = new System.Drawing.Point(162, 11);
            this.botonBuscarCliente.Name = "botonBuscarCliente";
            this.botonBuscarCliente.Size = new System.Drawing.Size(31, 29);
            this.botonBuscarCliente.TabIndex = 2;
            this.botonBuscarCliente.UseVisualStyleBackColor = true;
            this.botonBuscarCliente.Click += new System.EventHandler(this.botonBuscarCliente_Click);
            // 
            // SalidasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(368, 279);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.botonBuscarCliente);
            this.Controls.Add(this.observacionTextBox);
            this.Controls.Add(this.EntradaComboBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.salidaDateTimePicker);
            this.Controls.Add(this.observacionLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.idLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalidasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro De Salidas";
            this.Load += new System.EventHandler(this.SalidasForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label observacionLabel;
        private System.Windows.Forms.DateTimePicker salidaDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox EntradaComboBox;
        private System.Windows.Forms.TextBox observacionTextBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button botonBuscarCliente;
    }
}