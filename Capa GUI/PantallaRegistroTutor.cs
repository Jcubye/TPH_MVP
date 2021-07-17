using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_GUI
{
    public partial class PantallaRegistroTutor : Form
    {
        private int posicion;
        private int ultimo;

        public int Posicion { get => posicion; set => posicion = value; }
        public int Ultimo { get => ultimo; set => ultimo = value; }


        //mostrar
        public void mostrar()
        {
            ServiceTutor.WebServiceTutorSoapClient auxService = new ServiceTutor.WebServiceTutorSoapClient();
            ServiceTutor.Tutor auxTutor = new ServiceTutor.Tutor();
            this.Ultimo = auxService.consultarTutorService().Tables[0].Rows.Count -1;




            if (this.Posicion < 0)
                this.Posicion = 0;

            if (this.Posicion >= this.Ultimo)
                this.Posicion = this.Ultimo;

            auxTutor = auxService.posicionTutorService(this.Posicion);

            this.txtRut.Text = auxTutor.Rut;
            this.txtClave.Text = auxTutor.Clave;
            this.txtNombre.Text = auxTutor.Nombre;
            this.txtApellido.Text = auxTutor.Apellido;
            this.txtTelefono.Text = auxTutor.Telefono;
            this.txtCorreo.Text = auxTutor.Correo;

            this.txtPosicion.Text = (this.Posicion + 1) + "-" + (this.Ultimo + 1);
        }

        public void limpiar()
        {
            this.txtRut.Text = "";
            this.txtClave.Text = "";
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtTelefono.Text = "";
            this.txtCorreo.Text = "";
            this.txtRut.Focus();
        }

        public void habilitar()
        {
            this.txtRut.Enabled = true;
            this.txtClave.Enabled = true;
            this.txtNombre.Enabled = true;
            this.txtApellido.Enabled = true;
            this.txtTelefono.Enabled = true;
            this.txtCorreo.Enabled = true;
            this.txtRut.Enabled = true;
        }

        public void deshabilitar()
        {
            this.txtRut.Enabled = false;
            this.txtClave.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtApellido.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.txtCorreo.Enabled = false;
            this.txtRut.Enabled = false;
        }

        public PantallaRegistroTutor()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.btnSalir.Text == "Salir")
            {
                this.Dispose();
                System.GC.Collect();
            }
            else
            {
                if(this.btnRegistrar.Text.Equals("Nuevo"))
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

        private void txtRegistrar_Click(object sender, EventArgs e)
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
                    ServiceTutor.WebServiceTutorSoapClient auxServiceTutor = new ServiceTutor.WebServiceTutorSoapClient();
                    ServiceTutor.Tutor auxTutor = new ServiceTutor.Tutor();
                    this.deshabilitar();
                    auxTutor.Id = 0;
                    auxTutor.Rut = this.txtRut.Text;
                    auxTutor.Clave = this.txtClave.Text;
                    auxTutor.Nombre = this.txtNombre.Text;
                    auxTutor.Apellido = this.txtApellido.Text;
                    auxTutor.Telefono = this.txtTelefono.Text;
                    auxTutor.Correo = this.txtCorreo.Text;

                    if (String.IsNullOrEmpty(this.txtRut.Text)
                        )
                    {
                        MessageBox.Show("Debe ingresar Datos", "System");
                    }
                    else
                    {
                        auxServiceTutor.insertarTutorService(auxTutor);

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
            
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtEliminar_Click(object sender, EventArgs e)
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

                    ServiceTutor.WebServiceTutorSoapClient auxServicio = new ServiceTutor.WebServiceTutorSoapClient();

                    //Se valida si el cliente existe

                    if (String.IsNullOrEmpty(auxServicio.buscaTutorService(this.txtRut.Text).Rut))
                    {
                        MessageBox.Show("Tutor no Existe ", "System");
                        this.txtRut.Focus();
                        return;
                    }

                    //Confirmar eliminar
                    if ((MessageBox.Show("Esta seguro de Eliminar?", "Sistema",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes))
                    {
                        auxServicio.eliminarTutorServce(this.txtRut.Text);
                        MessageBox.Show("Tutor Eliminado ", "System");

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
        } //Fin eliminar
    

        private void btnListar_Click(object sender, EventArgs e)
        {
            PantallaListarTutor pListarTutor = new PantallaListarTutor();
            pListarTutor.ShowDialog();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            Posicion = 0;
            mostrar();
        }

        private void PantallaRegistroTutor_Load(object sender, EventArgs e)
        {
            this.Posicion = 0;
            this.mostrar();
            this.deshabilitar();
            this.txtPosicion.Enabled = false;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.Posicion = this.Posicion - 1;
            mostrar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.Posicion = this.Posicion + 1;
            mostrar();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            this.Posicion = this.Ultimo;
            mostrar();
        }

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
                    ServiceTutor.WebServiceTutorSoapClient auxServiceTutor = new ServiceTutor.WebServiceTutorSoapClient();
                    ServiceTutor.Tutor auxTutor = new ServiceTutor.Tutor();
                    deshabilitar();
                    auxTutor.Rut = this.txtRut.Text;
                    auxTutor.Clave = this.txtClave.Text;
                    auxTutor.Nombre = this.txtNombre.Text;
                    auxTutor.Apellido = this.txtApellido.Text;
                    auxTutor.Telefono = this.txtTelefono.Text;
                    auxTutor.Correo = this.txtCorreo.Text;

                    if (String.IsNullOrEmpty(this.txtClave.Text)
                        )
                    {
                        MessageBox.Show("Debe ingresar Clave", "System");
                    }
                    else
                    {
                        auxServiceTutor.actualizarTutorService(auxTutor);

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
            
                   
                
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
