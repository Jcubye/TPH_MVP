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
                this.deshabilitar();
                this.txtRut.Text = "Nuevo";
                this.txtClave.Enabled = true;
                this.txtNombre.Enabled = true;
                this.txtApellido.Enabled = true;
                this.txtTelefono.Enabled = true;
                this.txtCorreo.Enabled = true;
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
                        //no valida si existe, pero en este caso no lo hara ya que Id no es ingresable y se autoincrementa
                        //if (String.IsNullOrEmpty(auxServiceDepartamento.buscaDepartamento(auxDepartamento.Id).Nombre))
                        //{
                        //    MessageBox.Show("El Departamento ya existe", "System");
                        //}
                        //else
                        //{
                        //aca iria el grabar, si el dpto no existiera
                        //}
                        //auxServiceDepartamento.insertarDepartamentoService(auxDepartamento);
                        auxServiceTutor.insertarTutorService(auxTutor);

                        MessageBox.Show("¡Datos Guardados!", "System");
                        this.deshabilitar();
                        this.btnRegistrar.Text = "Registrar";
                        this.btnModificar.Enabled = true;
                        this.btnEliminar.Enabled = true;
                        this.btnListar.Enabled = true;
                        this.btnPrimero.Enabled = true;
                        this.btnAnterior.Enabled = true;
                        this.btnSiguiente.Enabled = true;
                        this.btnUltimo.Enabled = true;
                        this.btnSalir.Text = "Salir";
                        //this.mostrar();


                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Datos no Guardados" + ex.Message, "System");
                this.limpiar();
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            PantallaListarTutor pListarTutor = new PantallaListarTutor();
            pListarTutor.ShowDialog();
        }
    }
}
    
