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
    public partial class PantallaListarTutor : Form
    {
        public PantallaListarTutor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceTutor.WebServiceTutorSoapClient auxTutorService = new ServiceTutor.WebServiceTutorSoapClient();
            this.DataGridViewTutor.DataSource = auxTutorService.consultarTutorService();
            this.DataGridViewTutor.DataMember = "tutor";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }
    }
}
