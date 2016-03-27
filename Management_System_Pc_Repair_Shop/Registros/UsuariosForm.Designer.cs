namespace Management_System_Pc_Repair_Shop.Registros
{
    partial class UsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosForm));
            this.prioridadComboBox = new System.Windows.Forms.ComboBox();
            this.confirmarContraseñaLabel = new System.Windows.Forms.Label();
            this.confirmarPassTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.usuarioIdTextBox = new System.Windows.Forms.TextBox();
            this.prioridadLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prioridadComboBox
            // 
            this.prioridadComboBox.AllowDrop = true;
            this.prioridadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prioridadComboBox.FormattingEnabled = true;
            this.prioridadComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.prioridadComboBox.Location = new System.Drawing.Point(134, 166);
            this.prioridadComboBox.Name = "prioridadComboBox";
            this.prioridadComboBox.Size = new System.Drawing.Size(100, 21);
            this.prioridadComboBox.TabIndex = 6;
            // 
            // confirmarContraseñaLabel
            // 
            this.confirmarContraseñaLabel.AllowDrop = true;
            this.confirmarContraseñaLabel.AutoSize = true;
            this.confirmarContraseñaLabel.Location = new System.Drawing.Point(24, 136);
            this.confirmarContraseñaLabel.Name = "confirmarContraseñaLabel";
            this.confirmarContraseñaLabel.Size = new System.Drawing.Size(108, 13);
            this.confirmarContraseñaLabel.TabIndex = 44;
            this.confirmarContraseñaLabel.Text = "Confirmar Contraseña";
            // 
            // confirmarPassTextBox
            // 
            this.confirmarPassTextBox.AllowDrop = true;
            this.confirmarPassTextBox.Location = new System.Drawing.Point(134, 136);
            this.confirmarPassTextBox.MaxLength = 50;
            this.confirmarPassTextBox.Name = "confirmarPassTextBox";
            this.confirmarPassTextBox.Size = new System.Drawing.Size(100, 20);
            this.confirmarPassTextBox.TabIndex = 5;
            this.confirmarPassTextBox.UseSystemPasswordChar = true;
            // 
            // passTextBox
            // 
            this.passTextBox.AllowDrop = true;
            this.passTextBox.Location = new System.Drawing.Point(134, 106);
            this.passTextBox.MaxLength = 50;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(100, 20);
            this.passTextBox.TabIndex = 4;
            this.passTextBox.UseSystemPasswordChar = true;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.AllowDrop = true;
            this.nombreTextBox.Location = new System.Drawing.Point(134, 76);
            this.nombreTextBox.MaxLength = 50;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 3;
            // 
            // usuarioIdTextBox
            // 
            this.usuarioIdTextBox.AllowDrop = true;
            this.usuarioIdTextBox.Location = new System.Drawing.Point(134, 46);
            this.usuarioIdTextBox.MaxLength = 5;
            this.usuarioIdTextBox.Name = "usuarioIdTextBox";
            this.usuarioIdTextBox.Size = new System.Drawing.Size(35, 20);
            this.usuarioIdTextBox.TabIndex = 1;
            // 
            // prioridadLabel
            // 
            this.prioridadLabel.AllowDrop = true;
            this.prioridadLabel.AutoSize = true;
            this.prioridadLabel.Location = new System.Drawing.Point(84, 165);
            this.prioridadLabel.Name = "prioridadLabel";
            this.prioridadLabel.Size = new System.Drawing.Size(48, 13);
            this.prioridadLabel.TabIndex = 43;
            this.prioridadLabel.Text = "Prioridad";
            // 
            // passLabel
            // 
            this.passLabel.AllowDrop = true;
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(71, 107);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(61, 13);
            this.passLabel.TabIndex = 42;
            this.passLabel.Text = "Contraseña";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AllowDrop = true;
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(88, 78);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(44, 13);
            this.nombreLabel.TabIndex = 41;
            this.nombreLabel.Text = "Nombre";
            // 
            // IDlabel
            // 
            this.IDlabel.AllowDrop = true;
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(116, 49);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(16, 13);
            this.IDlabel.TabIndex = 40;
            this.IDlabel.Text = "Id";
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EliminarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(253, 225);
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
            this.NuevoButton.Location = new System.Drawing.Point(11, 225);
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
            this.GuardarButton.Location = new System.Drawing.Point(132, 225);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(88, 41);
            this.GuardarButton.TabIndex = 8;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buscarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buscarButton.BackgroundImage")));
            this.buscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarButton.Location = new System.Drawing.Point(175, 40);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(32, 30);
            this.buscarButton.TabIndex = 2;
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 278);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.prioridadComboBox);
            this.Controls.Add(this.confirmarContraseñaLabel);
            this.Controls.Add(this.confirmarPassTextBox);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.usuarioIdTextBox);
            this.Controls.Add(this.prioridadLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.IDlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UsuariosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro De Usuario";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox prioridadComboBox;
        private System.Windows.Forms.Label confirmarContraseñaLabel;
        private System.Windows.Forms.TextBox confirmarPassTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox usuarioIdTextBox;
        private System.Windows.Forms.Label prioridadLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button buscarButton;
    }
}