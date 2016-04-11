namespace Management_System_Pc_Repair_Shop.Registros
{
    partial class InicioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioForm));
            this.loginButton = new System.Windows.Forms.Button();
            this.salirButton = new System.Windows.Forms.Button();
            this.inicioLabel1 = new System.Windows.Forms.Label();
            this.inicioLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Image = ((System.Drawing.Image)(resources.GetObject("loginButton.Image")));
            this.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.Location = new System.Drawing.Point(12, 169);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(101, 41);
            this.loginButton.TabIndex = 13;
            this.loginButton.Text = "Login";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // salirButton
            // 
            this.salirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.salirButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirButton.Image = ((System.Drawing.Image)(resources.GetObject("salirButton.Image")));
            this.salirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salirButton.Location = new System.Drawing.Point(12, 231);
            this.salirButton.Name = "salirButton";
            this.salirButton.Size = new System.Drawing.Size(101, 41);
            this.salirButton.TabIndex = 14;
            this.salirButton.Text = "Salir";
            this.salirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salirButton.UseVisualStyleBackColor = true;
            this.salirButton.Click += new System.EventHandler(this.salirButton_Click);
            // 
            // inicioLabel1
            // 
            this.inicioLabel1.AutoSize = true;
            this.inicioLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inicioLabel1.Font = new System.Drawing.Font("Rockwell Extra Bold", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioLabel1.ForeColor = System.Drawing.Color.Blue;
            this.inicioLabel1.Location = new System.Drawing.Point(7, 5);
            this.inicioLabel1.Name = "inicioLabel1";
            this.inicioLabel1.Size = new System.Drawing.Size(360, 30);
            this.inicioLabel1.TabIndex = 15;
            this.inicioLabel1.Text = "Management System Pc";
            // 
            // inicioLabel2
            // 
            this.inicioLabel2.AutoSize = true;
            this.inicioLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inicioLabel2.Font = new System.Drawing.Font("Rockwell Extra Bold", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioLabel2.ForeColor = System.Drawing.Color.Blue;
            this.inicioLabel2.Location = new System.Drawing.Point(84, 33);
            this.inicioLabel2.Name = "inicioLabel2";
            this.inicioLabel2.Size = new System.Drawing.Size(195, 30);
            this.inicioLabel2.TabIndex = 16;
            this.inicioLabel2.Text = " Repair Shop";
            // 
            // InicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 284);
            this.Controls.Add(this.inicioLabel2);
            this.Controls.Add(this.inicioLabel1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.salirButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management System Pc Repair Shop";
            this.Load += new System.EventHandler(this.InicioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button salirButton;
        private System.Windows.Forms.Label inicioLabel1;
        private System.Windows.Forms.Label inicioLabel2;
        private System.Windows.Forms.Button loginButton;
    }
}