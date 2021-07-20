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
    public partial class PantallaListarIngresos : Form
    {
        public PantallaListarIngresos()
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
            ServiceIngreso.WebServiceIngresoSoapClient auxIngresoService = new ServiceIngreso.WebServiceIngresoSoapClient();
            this.DataGridViewTutor.DataSource = auxIngresoService.consultarIngresoService();
            this.DataGridViewTutor.DataMember = "ingreso";
        }
    }
}
