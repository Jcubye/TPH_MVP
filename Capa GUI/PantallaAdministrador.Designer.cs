
namespace Capa_GUI
{
    partial class PantallaAdministrador
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
            this.registroUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroTutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroAtenciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDepartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalMedicos = new System.Windows.Forms.TextBox();
            this.txtTotalPacientes = new System.Windows.Forms.TextBox();
            this.txtTotalCamas = new System.Windows.Forms.TextBox();
            this.txtTotalCamasDisponibles = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resumenToolStripMenuItem,
            this.registroUsuariosToolStripMenuItem,
            this.registroAtenciónToolStripMenuItem,
            this.registroDepartamentosToolStripMenuItem,
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
            // registroUsuariosToolStripMenuItem
            // 
            this.registroUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroPacienteToolStripMenuItem,
            this.registroTutorToolStripMenuItem,
            this.registroMédicoToolStripMenuItem});
            this.registroUsuariosToolStripMenuItem.Name = "registroUsuariosToolStripMenuItem";
            this.registroUsuariosToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.registroUsuariosToolStripMenuItem.Text = "Registro Usuarios";
            // 
            // registroPacienteToolStripMenuItem
            // 
            this.registroPacienteToolStripMenuItem.Name = "registroPacienteToolStripMenuItem";
            this.registroPacienteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registroPacienteToolStripMenuItem.Text = "Registro Paciente";
            // 
            // registroTutorToolStripMenuItem
            // 
            this.registroTutorToolStripMenuItem.Name = "registroTutorToolStripMenuItem";
            this.registroTutorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registroTutorToolStripMenuItem.Text = "Registro Tutor";
            // 
            // registroMédicoToolStripMenuItem
            // 
            this.registroMédicoToolStripMenuItem.Name = "registroMédicoToolStripMenuItem";
            this.registroMédicoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registroMédicoToolStripMenuItem.Text = "Registro Médico";
            // 
            // registroAtenciónToolStripMenuItem
            // 
            this.registroAtenciónToolStripMenuItem.Name = "registroAtenciónToolStripMenuItem";
            this.registroAtenciónToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.registroAtenciónToolStripMenuItem.Text = "Registro Atención";
            // 
            // registroDepartamentosToolStripMenuItem
            // 
            this.registroDepartamentosToolStripMenuItem.Name = "registroDepartamentosToolStripMenuItem";
            this.registroDepartamentosToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.registroDepartamentosToolStripMenuItem.Text = "Registro Departamentos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Medicos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Pacientes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Camas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Camas Disponibles:";
            // 
            // txtTotalMedicos
            // 
            this.txtTotalMedicos.Enabled = false;
            this.txtTotalMedicos.Location = new System.Drawing.Point(351, 113);
            this.txtTotalMedicos.Name = "txtTotalMedicos";
            this.txtTotalMedicos.Size = new System.Drawing.Size(100, 22);
            this.txtTotalMedicos.TabIndex = 5;
            // 
            // txtTotalPacientes
            // 
            this.txtTotalPacientes.Enabled = false;
            this.txtTotalPacientes.Location = new System.Drawing.Point(351, 145);
            this.txtTotalPacientes.Name = "txtTotalPacientes";
            this.txtTotalPacientes.Size = new System.Drawing.Size(100, 22);
            this.txtTotalPacientes.TabIndex = 6;
            // 
            // txtTotalCamas
            // 
            this.txtTotalCamas.Enabled = false;
            this.txtTotalCamas.Location = new System.Drawing.Point(351, 173);
            this.txtTotalCamas.Name = "txtTotalCamas";
            this.txtTotalCamas.Size = new System.Drawing.Size(100, 22);
            this.txtTotalCamas.TabIndex = 7;
            // 
            // txtTotalCamasDisponibles
            // 
            this.txtTotalCamasDisponibles.Enabled = false;
            this.txtTotalCamasDisponibles.Location = new System.Drawing.Point(351, 208);
            this.txtTotalCamasDisponibles.Name = "txtTotalCamasDisponibles";
            this.txtTotalCamasDisponibles.Size = new System.Drawing.Size(100, 22);
            this.txtTotalCamasDisponibles.TabIndex = 8;
            // 
            // PantallaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotalCamasDisponibles);
            this.Controls.Add(this.txtTotalCamas);
            this.Controls.Add(this.txtTotalPacientes);
            this.Controls.Add(this.txtTotalMedicos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaAdministrador";
            this.Text = "PantallaAdministrador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resumenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroTutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroMédicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroAtenciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDepartamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalMedicos;
        private System.Windows.Forms.TextBox txtTotalPacientes;
        private System.Windows.Forms.TextBox txtTotalCamas;
        private System.Windows.Forms.TextBox txtTotalCamasDisponibles;
    }
}