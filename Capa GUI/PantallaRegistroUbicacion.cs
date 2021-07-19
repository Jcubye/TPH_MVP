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
    public partial class PantallaRegistroUbicacion : Form
    {
        private int posicion;
        private int ultimo;

        public int Posicion { get => posicion; set => posicion = value; }
        public int Ultimo { get => ultimo; set => ultimo = value; }

        //mostrar
        public void mostrar()
        {
            ServiceUbicacion.WebServiceUbicacionSoapClient auxService = new ServiceUbicacion.WebServiceUbicacionSoapClient();
            ServiceUbicacion.Ubicacion auxUbicacion = new ServiceUbicacion.Ubicacion();


            this.Ultimo = auxService.ConsultarUbicacionService().Tables[0].Rows.Count - 1;



            if (this.Posicion <= 0)
                this.Posicion = 0;

            if (this.Posicion >= this.Ultimo)
                this.Posicion = this.Ultimo;

            auxUbicacion = auxService.posicionUbicacionService(this.Posicion);

            this.txtArea.Text = auxUbicacion.Area;
            this.txtCamas.Text = auxUbicacion.Camas.ToString();
            

            this.txtPosicion.Text = (this.Posicion + 1) + "-" + (this.Ultimo + 1);
        }//fin mostrar

        public void limpiar()
        {
            this.txtArea.Text = "";
            this.txtCamas.Text = "";
        }

        public void habilitar()
        {
            this.txtArea.Enabled = true;
            this.txtCamas.Enabled = true;
        }

        public void deshabilitar()
        {
            this.txtArea.Enabled = false;
            this.txtCamas.Enabled = false;
        }

        public PantallaRegistroUbicacion()
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
                //this.mostrar();
            }
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtListar_Click(object sender, EventArgs e)
        {
            PantallaListarUbicacion pListarUbicacion = new PantallaListarUbicacion();
            pListarUbicacion.ShowDialog();
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
                    ServiceUbicacion.WebServiceUbicacionSoapClient auxServicio = new ServiceUbicacion.WebServiceUbicacionSoapClient();
                    ServiceUbicacion.Ubicacion auxUbicacion = new ServiceUbicacion.Ubicacion();
                    this.deshabilitar();
                    auxUbicacion.Id = 0;
                    auxUbicacion.Area = this.txtArea.Text;
                    auxUbicacion.Camas = Int32.Parse(this.txtCamas.Text);

                    if (String.IsNullOrEmpty(this.txtArea.Text)
                        )
                    {
                        MessageBox.Show("Debe ingresar Datos", "System");
                    }
                    else
                    {
                        auxServicio.insertarUbicacionService(auxUbicacion);

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
        }//fin registrar

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.btnModificar.Text == "Modificar")
                {
                    this.habilitar();
                    this.txtArea.Enabled = false;
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
                    ServiceUbicacion.WebServiceUbicacionSoapClient auxService = new ServiceUbicacion.WebServiceUbicacionSoapClient();
                    ServiceUbicacion.Ubicacion auxUbicacion = new ServiceUbicacion.Ubicacion();
                    deshabilitar();
                    auxUbicacion.Area= this.txtArea.Text;
                    auxUbicacion.Camas =  Int32.Parse(this.txtCamas.Text);

                    if (String.IsNullOrEmpty(this.txtArea.Text)
                        )
                    {
                        MessageBox.Show("Debe ingresar Clave", "System");
                    }
                    else
                    {
                        auxService.actualizarUbicacionService(auxUbicacion);

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
        }//fin modificar

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.btnEliminar.Text.Equals("Confirmar"))
                {
                    //Validar rut nulo o vacio
                    if (String.IsNullOrEmpty(this.txtArea.Text.Trim()))
                    {
                        MessageBox.Show("Falta Area ", "Sistema");
                        return;
                    }

                    ServiceUbicacion.WebServiceUbicacionSoapClient auxService = new ServiceUbicacion.WebServiceUbicacionSoapClient();

                    //Se valida si el cliente existe

                    if (String.IsNullOrEmpty(auxService.buscaUbicacionService(this.txtArea.Text).Area))
                    {
                        MessageBox.Show("Area no Existe ", "System");
                        this.txtArea.Focus();
                        return;
                    }

                    //Confirmar eliminar
                    if ((MessageBox.Show("Esta seguro de Eliminar?", "Sistema",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes))
                    {
                        auxService.eliminarUbicacionService(this.txtArea.Text);
                        MessageBox.Show("Departamento Eliminado ", "System");

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

        private void PantallaRegistroUbicacion_Load(object sender, EventArgs e)
        {
            this.Posicion = 0;
            this.mostrar();
            this.deshabilitar();
            this.txtPosicion.Enabled = false;
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            Posicion = 0;
            mostrar();
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
    }
}
