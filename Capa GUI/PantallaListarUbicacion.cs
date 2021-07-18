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
    public partial class PantallaListarUbicacion : Form
    {
        public PantallaListarUbicacion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ServiceUbicacion.WebServiceUbicacionSoapClient auxServicio = new ServiceUbicacion.WebServiceUbicacionSoapClient();
            this.DataGridViewTutor.DataSource = auxServicio.ConsultarUbicacionService();
            this.DataGridViewTutor.DataMember = "ubicacion";
        }
    }
}
