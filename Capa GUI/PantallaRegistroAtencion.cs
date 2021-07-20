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
    public partial class PantallaRegistroAtencion : Form
    {
        private int posicion;
        private int ultimo;

        public int Posicion { get => posicion; set => posicion = value; }
        public int Ultimo { get => ultimo; set => ultimo = value; }

        //mostrar
        public void mostrar()
        {
            ServiceAtencion.WebServiceAtencionSoapClient auxService = new ServiceAtencion.WebServiceAtencionSoapClient();
            ServiceAtencion.Atencion auxAtencion = new ServiceAtencion.Atencion();
            this.Ultimo = auxService.consultarAtencionService().Tables[0].Rows.Count - 1;




            if (this.Posicion < 0)
                this.Posicion = 0;

            if (this.Posicion >= this.Ultimo)
                this.Posicion = this.Ultimo;

            auxAtencion = auxService.posicionAtencionService(this.Posicion);

            //this.txtFecha.Text = Convert.ToDateTime(auxAtencion.Fecha).ToString("yyyy/MM/DD");
            this.txtDetalle.Text = auxAtencion.Detalle;
            this.txtPaciente.Text =Convert.ToString(auxAtencion.Ingreso_id);
            

            this.txtPosicion.Text = (this.Posicion + 1) + "-" + (this.Ultimo + 1);
        }

        public void limpiar()
        {
            this.txtFecha.Text = txtFecha.Text;
            this.txtDetalle.Text = "";
            this.txtPaciente.Text = "";
        }

        public void habilitar()
        {
            this.txtFecha.Enabled = true;
            this.txtDetalle.Enabled = true;
            this.txtPaciente.Enabled = true;
        }

        public void deshabilitar()
        {
            this.txtFecha.Enabled = false;
            this.txtDetalle.Enabled = false;
            this.txtPaciente.Enabled = false;
        }

        public PantallaRegistroAtencion()
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
                this.mostrar();
            }
        }

        private void txtListar_Click(object sender, EventArgs e)
        {
            PantallaListarAtencion pListarAtencion = new PantallaListarAtencion();
            pListarAtencion.ShowDialog();
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
                    ServiceAtencion.WebServiceAtencionSoapClient auxAtencionService = new ServiceAtencion.WebServiceAtencionSoapClient();
                    ServiceAtencion.Atencion auxAtencion = new ServiceAtencion.Atencion();
                    this.deshabilitar();
                    auxAtencion.Id = 0;
                    auxAtencion.Fecha = this.txtFecha.Value;
                    auxAtencion.Ingreso_id = Convert.ToInt32(this.txtPaciente.Text);
                    

                    if (String.IsNullOrEmpty(this.txtFecha.Text))
                    {
                        MessageBox.Show("Debe ingresar Datos", "System");
                    }
                    else
                    {
                        auxAtencionService.insertarAtencionService(auxAtencion);

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

        private void txtPrimero_Click(object sender, EventArgs e)
        {
            this.Posicion = 0;
            mostrar();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.Posicion = this.Posicion - 1;
            mostrar();
        }

        private void txtPosicion_TextChanged(object sender, EventArgs e)
        {

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
                    this.txtPaciente.Enabled = false;
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
                    ServiceAtencion.WebServiceAtencionSoapClient auxService = new ServiceAtencion.WebServiceAtencionSoapClient();
                    ServiceAtencion.Atencion auxAtencion = new ServiceAtencion.Atencion();
                    deshabilitar();
                    auxAtencion.Fecha = Convert.ToDateTime(this.txtFecha.Text);
                    auxAtencion.Detalle = this.txtDetalle.Text;
                    auxAtencion.Ingreso_id = Convert.ToInt32(this.txtPaciente.Text);
                    if (String.IsNullOrEmpty(this.txtPaciente.Text))
                    {
                        MessageBox.Show("Debe ingresar datos", "System");
                    }
                    else
                    {
                        auxService.actualizarAtencionService(auxAtencion);

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
                        //this.Posicion = this.Posicion + 1;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.btnEliminar.Text.Equals("Confirmar"))
                {
                    //Validar rut nulo o vacio
                    if (String.IsNullOrEmpty(this.txtPaciente.Text.Trim()))
                    {
                        MessageBox.Show("Falta Paciente ", "Sistema");
                        return;
                    }

                    ServiceAtencion.WebServiceAtencionSoapClient auxService = new ServiceAtencion.WebServiceAtencionSoapClient();

                    ServiceAtencion.Atencion auxAtencion = new ServiceAtencion.Atencion();
                    auxAtencion.Ingreso_id = Convert.ToInt32(this.txtPaciente.Text);
                    ////Se valida si el cliente existe

                    if (auxAtencion.Ingreso_id == 0)
                    {
                        MessageBox.Show("Atencion para ese paciente no Existe ", "System");
                        this.txtDetalle.Focus();
                        return;
                    }

                    //Confirmar eliminar
                    if ((MessageBox.Show("Esta seguro de Eliminar?", "Sistema",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes))
                    {
                        auxService.eliminarAtencionService(auxAtencion.Ingreso_id);
                        MessageBox.Show("Atencion Eliminada ", "System");

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

        private void PantallaRegistroAtencion_Load(object sender, EventArgs e)
        {
            this.Posicion = 0;
            this.mostrar();
            this.deshabilitar();
            this.txtPosicion.Enabled = false;
        }
    }
}
