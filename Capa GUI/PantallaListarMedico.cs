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
    public partial class PantallaListarMedico : Form
    {
        public PantallaListarMedico()
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
            ServiceMedico.WebServiceMedicoCargoSoapClient auxServicio = new ServiceMedico.WebServiceMedicoCargoSoapClient();
            this.DataGridViewTutor.DataSource = auxServicio.consultarMedicoService();
            this.DataGridViewTutor.DataMember = "medico_cargo";
        }
    }
}
