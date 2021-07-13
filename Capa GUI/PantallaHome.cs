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
    public partial class PantallaHome : Form
    {
        public PantallaHome()
        {
            InitializeComponent();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            PantallaLoginMedico pLoginMedico = new PantallaLoginMedico();
            pLoginMedico.ShowDialog();
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            PantallaLoginTutor pLoginTutor = new PantallaLoginTutor();
            pLoginTutor.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
