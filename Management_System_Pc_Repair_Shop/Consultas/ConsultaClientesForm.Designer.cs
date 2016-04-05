namespace Management_System_Pc_Repair_Shop.Consultas
{
    partial class ConsultaClientesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaClientesForm));
            this.labelConteo = new System.Windows.Forms.Label();
            this.textBoxConteo = new System.Windows.Forms.TextBox();
            this.dataGridViewConsulta = new System.Windows.Forms.DataGridView();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.comboBoxCampos = new System.Windows.Forms.ComboBox();
            this.buscarButton = new System.Windows.Forms.Button();
            this.imprimirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConteo
            // 
            this.labelConteo.AutoSize = true;
            this.labelConteo.Location = new System.Drawing.Point(9, 290);
            this.labelConteo.Name = "labelConteo";
            this.labelConteo.Size = new System.Drawing.Size(44, 13);
            this.labelConteo.TabIndex = 41;
            this.labelConteo.Text = "Conteo:";
            // 
            // textBoxConteo
            // 
            this.textBoxConteo.Location = new System.Drawing.Point(59, 287);
            this.textBoxConteo.Name = "textBoxConteo";
            this.textBoxConteo.ReadOnly = true;
            this.textBoxConteo.Size = new System.Drawing.Size(39, 20);
            this.textBoxConteo.TabIndex = 40;
            // 
            // dataGridViewConsulta
            // 
            this.dataGridViewConsulta.AllowUserToAddRows = false;
            this.dataGridViewConsulta.AllowUserToDeleteRows = false;
            this.dataGridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsulta.Location = new System.Drawing.Point(16, 53);
            this.dataGridViewConsulta.Name = "dataGridViewConsulta";
            this.dataGridViewConsulta.ReadOnly = true;
            this.dataGridViewConsulta.Size = new System.Drawing.Size(490, 214);
            this.dataGridViewConsulta.TabIndex = 39;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Location = new System.Drawing.Point(16, 10);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(62, 13);
            this.labelBuscar.TabIndex = 38;
            this.labelBuscar.Text = "Buscar Por:";
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(180, 11);
            this.textBoxFiltro.MaxLength = 50;
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(158, 20);
            this.textBoxFiltro.TabIndex = 37;
            this.textBoxFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFiltro_KeyPress);
            // 
            // comboBoxCampos
            // 
            this.comboBoxCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampos.FormattingEnabled = true;
            this.comboBoxCampos.Items.AddRange(new object[] {
            "ClienteId",
            "Nombre",
            "Apellido",
            "Direccion"});
            this.comboBoxCampos.Location = new System.Drawing.Point(84, 10);
            this.comboBoxCampos.Name = "comboBoxCampos";
            this.comboBoxCampos.Size = new System.Drawing.Size(90, 21);
            this.comboBoxCampos.TabIndex = 36;
            // 
            // buscarButton
            // 
            this.buscarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buscarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buscarButton.BackgroundImage")));
            this.buscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarButton.Location = new System.Drawing.Point(344, 5);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(32, 30);
            this.buscarButton.TabIndex = 42;
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // imprimirButton
            // 
            this.imprimirButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imprimirButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imprimirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimirButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimirButton.Image")));
            this.imprimirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imprimirButton.Location = new System.Drawing.Point(418, 276);
            this.imprimirButton.Name = "imprimirButton";
            this.imprimirButton.Size = new System.Drawing.Size(88, 27);
            this.imprimirButton.TabIndex = 60;
            this.imprimirButton.Text = "Imprimir";
            this.imprimirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imprimirButton.UseVisualStyleBackColor = true;
            this.imprimirButton.Click += new System.EventHandler(this.imprimirButton_Click);
            // 
            // ConsultaClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(514, 312);
            this.Controls.Add(this.imprimirButton);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.labelConteo);
            this.Controls.Add(this.textBoxConteo);
            this.Controls.Add(this.dataGridViewConsulta);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.comboBoxCampos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaClientesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Clientes";
            this.Load += new System.EventHandler(this.ConsultaClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Label labelConteo;
        private System.Windows.Forms.TextBox textBoxConteo;
        private System.Windows.Forms.DataGridView dataGridViewConsulta;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.ComboBox comboBoxCampos;
        private System.Windows.Forms.Button imprimirButton;
    }
}