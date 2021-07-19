using Capa_DTO;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Capa_Service
{
    /// <summary>
    /// Summary description for WebServicePaciente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServicePaciente : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarPacienteService(Paciente paciente)
        {
            NegocioPaciente auxNegocio = new NegocioPaciente();
            auxNegocio.insertarPaciente(paciente);

        }

        [WebMethod]
        public void actualizarPacienteService(Paciente paciente)
        {
            NegocioPaciente auxNegocio = new NegocioPaciente();
            auxNegocio.actualizarPaciente(paciente);
        }

        [WebMethod]
        public void eliminarPacienteService(String rut)
        {
            NegocioPaciente auxNegocio = new NegocioPaciente();
            auxNegocio.eliminarPaciente(rut);
        }

        [WebMethod]
        public DataSet consultarPacienteService()
        {
            NegocioPaciente auxNegocio = new NegocioPaciente();
            return auxNegocio.consultarPaciente();
        }

        [WebMethod]
        public Paciente buscarPacienteService(String rut)
        {
            NegocioPaciente auxNegocio = new NegocioPaciente();
            return auxNegocio.buscarPaciente(rut);
        }

        [WebMethod]
        public Paciente posicionPacienteService(int fila)
        {
            NegocioPaciente auxNegocio = new NegocioPaciente();
            return auxNegocio.posicionPaciente(fila);
        }
    }
}
