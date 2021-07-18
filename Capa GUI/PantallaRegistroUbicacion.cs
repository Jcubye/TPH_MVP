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
        public PantallaRegistroUbicacion()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtListar_Click(object sender, EventArgs e)
        {
            PantallaListarUbicacion pListarUbicacion = new PantallaListarUbicacion();
            pListarUbicacion.ShowDialog();
        }
    }
}
