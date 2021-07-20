using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Capa_Conexion.Clase_Conexion;

namespace Capa_GUI
{
    public partial class PantallaRegistroPaciente : Form
    {
        private int posicion;
        private int ultimo;

        public int Posicion { get => posicion; set => posicion = value; }
        public int Ultimo { get => ultimo; set => ultimo = value; }

        //mostrar
        public void mostrar()
        {
            ServicePaciente.WebServicePacienteSoapClient auxService = new ServicePaciente.WebServicePacienteSoapClient();
            ServicePaciente.Paciente auxPaciente = new ServicePaciente.Paciente();


            this.Ultimo = auxService.consultarPacienteService().Tables[0].Rows.Count - 1;



            if (this.Posicion <= 0)
                this.Posicion = 0;

            if (this.Posicion >= this.Ultimo)
                this.Posicion = this.Ultimo;

            auxPaciente = auxService.posicionPacienteService(this.Posicion);

            this.txtRut.Text = auxPaciente.Rut;
            this.txtNombre.Text = auxPaciente.Nombre;
            this.txtApellido.Text = auxPaciente.Apellido;
            this.txtAntecedentes.Text = auxPaciente.Antecedentes;
            this.txtStock.Text = auxPaciente.Stock_productos;
            this.txtDisponibilidad.Text = auxPaciente.Disponibilidad;
            this.txtEpicrisis.Text = auxPaciente.Epicrisis;
            this.txtTelefono.Text = auxPaciente.Telefono;
            this.txtTutor.Text = auxPaciente.Tutor_nombre;

            this.txtPosicion.Text = (this.Posicion + 1) + "-" + (this.Ultimo + 1);
        }//fin mostrar

        public void limpiar()
        {
            this.txtRut.Text = "";
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtAntecedentes.Text = "";
            this.txtStock.Text = "";
            this.txtDisponibilidad.Text = "";
            this.txtEpicrisis.Text = "";
            this.txtTelefono.Text = "";
            this.txtTutor.Text = "";
            this.txtUbicacion.Text = "";
        }

        public void habilitar()
        {
            this.txtRut.Enabled = true;
            this.txtNombre.Enabled = true;
            this.txtApellido.Enabled = true;
            this.txtAntecedentes.Enabled = true;
            this.txtStock.Enabled = true;
            this.txtDisponibilidad.Enabled = true;
            this.txtEpicrisis.Enabled = true;
            this.txtTelefono.Enabled = true;
            this.txtTutor.Enabled = true;
            this.txtUbicacion.Enabled = true;
        }

        public void deshabilitar()
        {
            this.txtRut.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtApellido.Enabled = false;
            this.txtAntecedentes.Enabled = false;
            this.txtStock.Enabled = false;
            this.txtDisponibilidad.Enabled = false;
            this.txtEpicrisis.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.txtTutor.Enabled = false;
            this.txtUbicacion.Enabled = false;
        }

        public PantallaRegistroPaciente()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.btnSalir.Text == "Salir")
            {
                this.Dispose();
                System.GC.Collect();
            }
            else
            {
                if (this.btnRegistrar.Text.Equals("Nuevo"))
                {
                    this.btnRegistrar.Text = "Registrar";
                }
                if (this.btnModificar.Text.Equals("Actualizar"))
                {
                    this.btnModificar.Text = "Modificar";
                }
                if (this.btnEliminar.Text.Equals("Confirmar"))
                {
                    this.btnEliminar.Text = "Eliminar";
                }
                this.deshabilitar();
                this.mostrar();
                this.btnRegistrar.Enabled = true;
                this.btnModificar.Enabled = true;
                this.btnEliminar.Enabled = true;
                this.btnListar.Enabled = true;
                this.btnSalir.Text = "Salir";
                //this.mostrar();
            }
        }

        private void PantallaRegistroPaciente_Load(object sender, EventArgs e)
        {
            //ConexionSQLSERVER conexion = new ConexionSQLSERVER();

            //SqlCommand comando = new SqlCommand("SELECT id from tutor");
            //conexion.abrir();
            //SqlDataReader registro = comando.ExecuteReader();
            //while(registro.Read())
            //{
            //    this.txtTutor.Items.Add(registro["id"].ToString());
            //}
            //conexion.cerrar();
            
            this.Posicion = 0;
            this.mostrar();
            this.deshabilitar();
            this.txtPosicion.Enabled = false;
        }

        private void txtTutor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.btnRegistrar.Text == "Registrar")
                {
                    this.limpiar();
                    this.habilitar();
                    this.btnRegistrar.Text = "Nuevo";
                    this.btnModificar.Enabled = false;
                    this.btnEliminar.Enabled = false;
                    this.btnListar.Enabled = false;
                    this.btnPrimero.Enabled = false;
                    this.btnAnterior.Enabled = false;
                    this.btnSiguiente.Enabled = false;
                    this.btnUltimo.Enabled = false;
                    this.btnSalir.Text = "Cancelar";
                }
                else
                {
                    ServicePaciente.WebServicePacienteSoapClient auxServicio = new ServicePaciente.WebServicePacienteSoapClient();
                    ServicePaciente.Paciente auxPaciente = new ServicePaciente.Paciente();
                    this.deshabilitar();
                    auxPaciente.Id = 0;
                    auxPaciente.Rut = this.txtRut.Text;
                    auxPaciente.Nombre = this.txtNombre.Text;
                    auxPaciente.Apellido = this.txtApellido.Text;
                    auxPaciente.Antecedentes = this.txtAntecedentes.Text;
                    auxPaciente.Stock_productos = this.txtStock.Text;
                    auxPaciente.Disponibilidad = this.txtDisponibilidad.Text;
                    auxPaciente.Epicrisis = this.txtEpicrisis.Text;
                    auxPaciente.Telefono = this.txtTelefono.Text;
                    auxPaciente.Tutor_id = Convert.ToInt32(this.txtTutor.Text);
                    auxPaciente.Tutor_nombre = this.txtTutor.Text;
                    auxPaciente.Ubicacion_id = Convert.ToInt32(this.txtUbicacion.Text);

                    if (String.IsNullOrEmpty(this.txtRut.Text)
                        )
                    {
                        MessageBox.Show("Debe ingresar Datos", "System");
                    }
                    else
                    {
                        auxServicio.insertarPacienteService(auxPaciente);

                        MessageBox.Show("¡Datos Guardados!", "System");


                        this.btnModificar.Enabled = true;
                        this.btnEliminar.Enabled = true;
                        this.btnListar.Enabled = true;
                        this.btnPrimero.Enabled = true;
                        this.btnAnterior.Enabled = true;
                        this.btnSiguiente.Enabled = true;
                        this.btnUltimo.Enabled = true;
                        this.btnRegistrar.Text = "Registrar";
                        this.btnSalir.Text = "Salir";
                        this.Posicion = this.Posicion + 1;
                        this.mostrar();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Datos no Guardados" + ex.Message, "System");
                this.btnModificar.Enabled = true;
                this.btnEliminar.Enabled = true;
                this.btnListar.Enabled = true;
                this.btnPrimero.Enabled = true;
                this.btnAnterior.Enabled = true;
                this.btnSiguiente.Enabled = true;
                this.btnUltimo.Enabled = true;
                this.btnRegistrar.Text = "Registrar";
                this.btnSalir.Text = "Salir";
                this.limpiar();
            }
        }//Fin registrar

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.btnModificar.Text == "Modificar")
                {
                    this.habilitar();
                    this.txtRut.Enabled = false;
                    this.btnModificar.Text = "Actualizar";
                    this.btnRegistrar.Enabled = false;
                    this.btnEliminar.Enabled = false;
                    this.btnListar.Enabled = false;
                    this.btnPrimero.Enabled = false;
                    this.btnAnterior.Enabled = false;
                    this.btnSiguiente.Enabled = false;
                    this.btnUltimo.Enabled = false;
                    this.btnSalir.Text = "Cancelar";
                }
                else
                {
                    ServicePaciente.WebServicePacienteSoapClient auxService = new ServicePaciente.WebServicePacienteSoapClient();
                    ServicePaciente.Paciente auxPaciente = new ServicePaciente.Paciente();
                    deshabilitar();
                    auxPaciente.Rut = this.txtRut.Text;
                    auxPaciente.Nombre = this.txtNombre.Text;
                    auxPaciente.Apellido = this.txtApellido.Text;
                    auxPaciente.Antecedentes = this.txtAntecedentes.Text;
                    auxPaciente.Stock_productos = this.txtStock.Text;
                    auxPaciente.Disponibilidad = this.txtDisponibilidad.Text;
                    auxPaciente.Epicrisis = this.txtEpicrisis.Text;
                    auxPaciente.Telefono = this.txtTelefono.Text;
                    auxPaciente.Tutor_id = 0;
                    auxPaciente.Tutor_nombre = this.txtNombre.Text;
                    auxPaciente.Ubicacion_id = 0;

                    if (String.IsNullOrEmpty(this.txtRut.Text)
                        )
                    {
                        MessageBox.Show("Debe ingresar Clave", "System");
                    }
                    else
                    {
                        auxService.actualizarPacienteService(auxPaciente);

                        MessageBox.Show("¡Datos Actualizados!", "System");
                        this.btnModificar.Text = "Modificar";
                        this.btnRegistrar.Enabled = true;
                        this.btnEliminar.Enabled = true;
                        this.btnListar.Enabled = true;
                        this.btnPrimero.Enabled = true;
                        this.btnAnterior.Enabled = true;
                        this.btnSiguiente.Enabled = true;
                        this.btnUltimo.Enabled = true;
                        this.btnSalir.Text = "Salir";
                        this.Posicion = this.Posicion + 1;
                        this.mostrar();
                        //this.deshabilitar();

                    }

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Datos no Guardados" + ex.Message, "System");
                this.limpiar();
            }
        }//Modificar

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.btnEliminar.Text.Equals("Confirmar"))
                {
                    //Validar rut nulo o vacio
                    if (String.IsNullOrEmpty(this.txtRut.Text.Trim()))
                    {
                        MessageBox.Show("Falta Rut ", "Sistema");
                        return;
                    }

                    ServicePaciente.WebServicePacienteSoapClient auxServicio = new ServicePaciente.WebServicePacienteSoapClient();

                    //Se valida si el cliente existe

                    if (String.IsNullOrEmpty(auxServicio.buscarPacienteService(this.txtRut.Text).Rut))
                    {
                        MessageBox.Show("Paciente no Existe ", "System");
                        this.txtRut.Focus();
                        return;
                    }

                    //Confirmar eliminar
                    if ((MessageBox.Show("Esta seguro de Eliminar?", "Sistema",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes))
                    {
                        auxServicio.eliminarPacienteService(this.txtRut.Text);
                        MessageBox.Show("Paciente Eliminado ", "System");

                        //Volver la pantalla
                        this.btnRegistrar.Enabled = true;
                        this.btnModificar.Enabled = true;
                        this.btnListar.Enabled = true;
                        this.btnEliminar.Text = "Eliminar";
                        this.btnSalir.Text = "Salir";
                        this.mostrar();
                    }
                }

                else
                {
                    this.deshabilitar();
                    this.btnEliminar.Enabled = true;
                    this.btnRegistrar.Enabled = false;
                    this.btnModificar.Enabled = false;
                    this.btnListar.Enabled = false;
                    this.btnSalir.Text = "Cancelar";
                    this.btnEliminar.Text = "Confirmar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos no Eliminados " + ex.Message, "Sistema");
            }
        }//fin eliminar

        private void btnListar_Click(object sender, EventArgs e)
        {
            PantallaListarPaciente pListarPaciente = new PantallaListarPaciente();
            pListarPaciente.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
