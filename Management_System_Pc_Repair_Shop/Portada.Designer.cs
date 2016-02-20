namespace Management_System_Pc_Repair_Shop
{
    partial class Portada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portada));
            this.portadaMenuStrip = new System.Windows.Forms.MenuStrip();
            this.portadaStatusStrip = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // portadaMenuStrip
            // 
            this.portadaMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.portadaMenuStrip.Name = "portadaMenuStrip";
            this.portadaMenuStrip.Size = new System.Drawing.Size(721, 24);
            this.portadaMenuStrip.TabIndex = 0;
            // 
            // portadaStatusStrip
            // 
            this.portadaStatusStrip.Location = new System.Drawing.Point(0, 443);
            this.portadaStatusStrip.Name = "portadaStatusStrip";
            this.portadaStatusStrip.Size = new System.Drawing.Size(721, 22);
            this.portadaStatusStrip.TabIndex = 1;
            // 
            // Portada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 465);
            this.Controls.Add(this.portadaStatusStrip);
            this.Controls.Add(this.portadaMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Portada";
            this.Text = "Management System Pc Repair Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip portadaMenuStrip;
        private System.Windows.Forms.StatusStrip portadaStatusStrip;
    }
}

