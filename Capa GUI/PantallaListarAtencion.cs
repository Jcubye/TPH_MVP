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
    public partial class PantallaListarAtencion : Form
    {
        public PantallaListarAtencion()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ServiceAtencion.WebServiceAtencionSoapClient auxAtencionService = new ServiceAtencion.WebServiceAtencionSoapClient();
            this.DataGridViewTutor.DataSource = auxAtencionService.consultarAtencionService();
            this.DataGridViewTutor.DataMember = "atencion";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }


    }
}
