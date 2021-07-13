
namespace Capa_GUI
{
    partial class PantallaResumenTutor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosNecesariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.epicrisisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resumenToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resumenToolStripMenuItem
            // 
            this.resumenToolStripMenuItem.Name = "resumenToolStripMenuItem";
            this.resumenToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.resumenToolStripMenuItem.Text = "Resumen";
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosNecesariosToolStripMenuItem,
            this.ubicaciónToolStripMenuItem,
            this.contactarToolStripMenuItem,
            this.epicrisisToolStripMenuItem});
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // productosNecesariosToolStripMenuItem
            // 
            this.productosNecesariosToolStripMenuItem.Name = "productosNecesariosToolStripMenuItem";
            this.productosNecesariosToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.productosNecesariosToolStripMenuItem.Text = "Productos Necesarios";
            // 
            // ubicaciónToolStripMenuItem
            // 
            this.ubicaciónToolStripMenuItem.Name = "ubicaciónToolStripMenuItem";
            this.ubicaciónToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.ubicaciónToolStripMenuItem.Text = "Ubicación";
            // 
            // contactarToolStripMenuItem
            // 
            this.contactarToolStripMenuItem.Name = "contactarToolStripMenuItem";
            this.contactarToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.contactarToolStripMenuItem.Text = "Contactar";
            // 
            // epicrisisToolStripMenuItem
            // 
            this.epicrisisToolStripMenuItem.Name = "epicrisisToolStripMenuItem";
            this.epicrisisToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.epicrisisToolStripMenuItem.Text = "Epicrisis";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // PantallaResumenTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaResumenTutor";
            this.Text = "PantallaResumenTutor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resumenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosNecesariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem epicrisisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}