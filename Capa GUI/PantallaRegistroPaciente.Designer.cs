
namespace Capa_GUI
{
    partial class PantallaRegistroPaciente
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
            this.components = new System.ComponentModel.Container();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEpicrisis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAntecedentes = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTutor = new System.Windows.Forms.ComboBox();
            this.tutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tutorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtDisponibilidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tutorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(514, 674);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(75, 22);
            this.txtPosicion.TabIndex = 86;
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(697, 673);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(75, 23);
            this.btnUltimo.TabIndex = 85;
            this.btnUltimo.Text = ">>";
            this.btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(606, 673);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 84;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(420, 673);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 83;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(323, 673);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(75, 23);
            this.btnPrimero.TabIndex = 82;
            this.btnPrimero.Text = "<<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(697, 644);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 81;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(606, 644);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 80;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(514, 644);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 79;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(420, 644);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 78;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(323, 644);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 77;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 578);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 76;
            this.label10.Text = "Nombre Tutor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 540);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 74;
            this.label9.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(418, 537);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 72;
            this.label8.Text = "Epicrisis:";
            // 
            // txtEpicrisis
            // 
            this.txtEpicrisis.Location = new System.Drawing.Point(418, 446);
            this.txtEpicrisis.Multiline = true;
            this.txtEpicrisis.Name = "txtEpicrisis";
            this.txtEpicrisis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEpicrisis.Size = new System.Drawing.Size(420, 75);
            this.txtEpicrisis.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "Disponibilidad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(283, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 17);
            this.label11.TabIndex = 68;
            this.label11.Text = "Stock Productos:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(418, 314);
            this.txtStock.Multiline = true;
            this.txtStock.Name = "txtStock";
            this.txtStock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStock.Size = new System.Drawing.Size(420, 76);
            this.txtStock.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(283, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 17);
            this.label12.TabIndex = 66;
            this.label12.Text = "Antecedentes";
            // 
            // txtAntecedentes
            // 
            this.txtAntecedentes.Location = new System.Drawing.Point(418, 218);
            this.txtAntecedentes.Multiline = true;
            this.txtAntecedentes.Name = "txtAntecedentes";
            this.txtAntecedentes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAntecedentes.Size = new System.Drawing.Size(420, 84);
            this.txtAntecedentes.TabIndex = 65;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(283, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 17);
            this.label13.TabIndex = 64;
            this.label13.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(418, 175);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 63;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(283, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 62;
            this.label14.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(418, 136);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 61;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(283, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 17);
            this.label15.TabIndex = 60;
            this.label15.Text = "Rut:";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(418, 93);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(100, 22);
            this.txtRut.TabIndex = 59;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(415, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(181, 25);
            this.label16.TabIndex = 58;
            this.label16.Text = "Registro Paciente";
            // 
            // txtTutor
            // 
            this.txtTutor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tutorBindingSource, "Nombre", true));
            this.txtTutor.DataSource = this.tutorBindingSource1;
            this.txtTutor.DisplayMember = "Nombre";
            this.txtTutor.FormattingEnabled = true;
            this.txtTutor.Location = new System.Drawing.Point(418, 575);
            this.txtTutor.Name = "txtTutor";
            this.txtTutor.Size = new System.Drawing.Size(121, 24);
            this.txtTutor.TabIndex = 87;
            this.txtTutor.ValueMember = "Nombre";
            this.txtTutor.SelectedIndexChanged += new System.EventHandler(this.txtTutor_SelectedIndexChanged);
            // 
            // tutorBindingSource
            // 
            this.tutorBindingSource.DataSource = typeof(Capa_GUI.ServiceTutor.Tutor);
            // 
            // tutorBindingSource1
            // 
            this.tutorBindingSource1.DataSource = typeof(Capa_GUI.ServiceTutor.Tutor);
            // 
            // txtDisponibilidad
            // 
            this.txtDisponibilidad.FormattingEnabled = true;
            this.txtDisponibilidad.Items.AddRange(new object[] {
            "Disponible",
            "No Disponible"});
            this.txtDisponibilidad.Location = new System.Drawing.Point(420, 405);
            this.txtDisponibilidad.Name = "txtDisponibilidad";
            this.txtDisponibilidad.Size = new System.Drawing.Size(176, 24);
            this.txtDisponibilidad.TabIndex = 88;
            // 
            // PantallaRegistroPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 783);
            this.Controls.Add(this.txtDisponibilidad);
            this.Controls.Add(this.txtTutor);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEpicrisis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAntecedentes);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.label16);
            this.Name = "PantallaRegistroPaciente";
            this.Text = "PantallaRegistroPaciente";
            this.Load += new System.EventHandler(this.PantallaRegistroPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEpicrisis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAntecedentes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox txtTutor;
        private System.Windows.Forms.BindingSource tutorBindingSource;
        private System.Windows.Forms.BindingSource tutorBindingSource1;
        private System.Windows.Forms.ComboBox txtDisponibilidad;
    }
}