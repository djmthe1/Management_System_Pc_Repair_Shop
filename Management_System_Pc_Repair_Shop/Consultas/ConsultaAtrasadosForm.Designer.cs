﻿namespace Management_System_Pc_Repair_Shop.Consultas
{
    partial class ConsultaAtrasadosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaAtrasadosForm));
            this.labelConteo = new System.Windows.Forms.Label();
            this.textBoxConteo = new System.Windows.Forms.TextBox();
            this.dataGridViewConsulta = new System.Windows.Forms.DataGridView();
            this.SalidaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DespachoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConteo
            // 
            this.labelConteo.AutoSize = true;
            this.labelConteo.Location = new System.Drawing.Point(11, 287);
            this.labelConteo.Name = "labelConteo";
            this.labelConteo.Size = new System.Drawing.Size(44, 13);
            this.labelConteo.TabIndex = 37;
            this.labelConteo.Text = "Conteo:";
            // 
            // textBoxConteo
            // 
            this.textBoxConteo.Location = new System.Drawing.Point(61, 284);
            this.textBoxConteo.Name = "textBoxConteo";
            this.textBoxConteo.ReadOnly = true;
            this.textBoxConteo.Size = new System.Drawing.Size(39, 20);
            this.textBoxConteo.TabIndex = 36;
            // 
            // dataGridViewConsulta
            // 
            this.dataGridViewConsulta.AllowUserToOrderColumns = true;
            this.dataGridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalidaId,
            this.Fecha,
            this.EntradaId,
            this.DespachoPor});
            this.dataGridViewConsulta.Location = new System.Drawing.Point(18, 9);
            this.dataGridViewConsulta.Name = "dataGridViewConsulta";
            this.dataGridViewConsulta.Size = new System.Drawing.Size(486, 255);
            this.dataGridViewConsulta.TabIndex = 35;
            // 
            // SalidaId
            // 
            this.SalidaId.HeaderText = "SalidaId";
            this.SalidaId.Name = "SalidaId";
            this.SalidaId.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // EntradaId
            // 
            this.EntradaId.HeaderText = "EntradaId";
            this.EntradaId.Name = "EntradaId";
            // 
            // DespachoPor
            // 
            this.DespachoPor.HeaderText = "DespachoPor";
            this.DespachoPor.Name = "DespachoPor";
            // 
            // ConsultaAtrasadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 312);
            this.Controls.Add(this.labelConteo);
            this.Controls.Add(this.textBoxConteo);
            this.Controls.Add(this.dataGridViewConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaAtrasadosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Atrasados";
            this.Load += new System.EventHandler(this.ConsultaAtrasadosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConteo;
        private System.Windows.Forms.TextBox textBoxConteo;
        private System.Windows.Forms.DataGridView dataGridViewConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalidaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntradaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DespachoPor;
    }
}