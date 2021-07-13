
namespace Capa_GUI
{
    partial class PantallaResumenMedico
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
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroTutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroIngresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resumenToolStripMenuItem,
            this.registroToolStripMenuItem,
            this.documentosToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resumenToolStripMenuItem
            // 
            this.resumenToolStripMenuItem.Name = "resumenToolStripMenuItem";
            this.resumenToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.resumenToolStripMenuItem.Text = "Resumen";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroTutorToolStripMenuItem,
            this.registroPacienteToolStripMenuItem,
            this.registroIngresoToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.registroToolStripMenuItem.Text = "Registro Usuarios";
            // 
            // registroTutorToolStripMenuItem
            // 
            this.registroTutorToolStripMenuItem.Name = "registroTutorToolStripMenuItem";
            this.registroTutorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registroTutorToolStripMenuItem.Text = "Registro Tutor";
            // 
            // registroPacienteToolStripMenuItem
            // 
            this.registroPacienteToolStripMenuItem.Name = "registroPacienteToolStripMenuItem";
            this.registroPacienteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registroPacienteToolStripMenuItem.Text = "Registro Paciente";
            // 
            // documentosToolStripMenuItem
            // 
            this.documentosToolStripMenuItem.Name = "documentosToolStripMenuItem";
            this.documentosToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.documentosToolStripMenuItem.Text = "Registro Atención";
            // 
            // registroIngresoToolStripMenuItem
            // 
            this.registroIngresoToolStripMenuItem.Name = "registroIngresoToolStripMenuItem";
            this.registroIngresoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registroIngresoToolStripMenuItem.Text = "Registro Ingreso";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.salirToolStripMenuItem.Text = "Registro Departamentos";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // PantallaResumenMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 449);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaResumenMedico";
            this.Text = "PantallaResumenMedico";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resumenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroTutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroIngresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
    }
}