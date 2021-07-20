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
    public partial class PantallaListarPaciente : Form
    {
        public PantallaListarPaciente()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ServicePaciente.WebServicePacienteSoapClient auxPacienteService = new ServicePaciente.WebServicePacienteSoapClient();
            this.DataGridViewTutor.DataSource = auxPacienteService.consultarPacienteService();
            this.DataGridViewTutor.DataMember = "paciente";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }
    }
}
