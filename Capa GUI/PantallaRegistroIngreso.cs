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
    public partial class PantallaRegistroIngreso : Form
    {
        private int posicion;
        private int ultimo;

        public int Posicion { get => posicion; set => posicion = value; }
        public int Ultimo { get => ultimo; set => ultimo = value; }

        //mostrar
        public void mostrar()
        {
            ServiceIngreso.WebServiceIngresoSoapClient auxService = new ServiceIngreso.WebServiceIngresoSoapClient();
            ServiceIngreso.Ingreso auxIngreso = new ServiceIngreso.Ingreso();
            this.Ultimo = auxService.consultarIngresoService().Tables[0].Rows.Count - 1;

            if (this.Posicion < 0)
                this.Posicion = 0;

            if (this.Posicion >= this.Ultimo)
                this.Posicion = this.Ultimo;

            auxIngreso = auxService.posicionIngresoService(this.Posicion);

            //this.txtFecha.Text = Convert.ToDateTime(auxAtencion.Fecha).ToString("yyyy/MM/DD");
            this.txtPrioridad.Text = auxIngreso.Prioridad;
            this.txtPaciente.Text = Convert.ToString(auxIngreso.Paciente_id);
            this.txtMedico.Text = Convert.ToString(auxIngreso.Medico_cargo_id);


            this.txtPosicion.Text = (this.Posicion + 1) + "-" + (this.Ultimo + 1);
        }

        public void limpiar()
        {
            this.txtFecha.Text = txtFecha.Text;
            this.txtPrioridad.Text = "";
            this.txtPaciente.Text = "";
            this.txtMedico.Text = "";
        }

        public void habilitar()
        {
            this.txtFecha.Enabled = true;
            this.txtPrioridad.Enabled = true;
            this.txtPaciente.Enabled = true;
            this.txtMedico.Enabled = true;
        }

        public void deshabilitar()
        {
            this.txtFecha.Enabled = false;
            this.txtPrioridad.Enabled = false;
            this.txtPaciente.Enabled = false;
            this.txtMedico.Enabled = false;
        }

        public PantallaRegistroIngreso()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            PantallaListarIngresos pListaIngreso = new PantallaListarIngresos();
            pListaIngreso.ShowDialog();
        }

        private void PantallaRegistroIngreso_Load(object sender, EventArgs e)
        {
            this.Posicion = 0;
            this.mostrar();
            this.deshabilitar();
            this.txtPosicion.Enabled = false;
        }
    }
}
