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
    public partial class PantallaAdministrador : Form
    {
        public PantallaAdministrador()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void registroPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaRegistroPaciente pRegistroPaciente = new PantallaRegistroPaciente();
            pRegistroPaciente.ShowDialog();
        }

        private void registroTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaRegistroTutor pRegistroTutor = new PantallaRegistroTutor();
            pRegistroTutor.ShowDialog();
        }

        private void registroMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaRegistroMedico pRegistroMedico = new PantallaRegistroMedico();
            pRegistroMedico.ShowDialog();
        }

        private void registroAtenciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaRegistroAtencion pRegistroAtencion = new PantallaRegistroAtencion();
            pRegistroAtencion.ShowDialog();
        }

        private void registroDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaRegistroUbicacion pRegistroDepartamento = new PantallaRegistroUbicacion();
            pRegistroDepartamento.ShowDialog();
        }
    }
}
