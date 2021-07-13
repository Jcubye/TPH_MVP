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
    public partial class PantallaResumenMedico : Form
    {
        public PantallaResumenMedico()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaRegistroDepartamento pRegistroDepartamento = new PantallaRegistroDepartamento();
            pRegistroDepartamento.ShowDialog();
        }
    }
}
