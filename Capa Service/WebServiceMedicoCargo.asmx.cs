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
    /// Summary description for WebServiceMedicoCargo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceMedicoCargo : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarMedicoService(Medico_cargo medico)
        {
            NegocioMedico auxNegocio = new NegocioMedico();
            auxNegocio.insertarMedico(medico);

        }

        [WebMethod]
        public void actualizarMedicoService(Medico_cargo medico)
        {
            NegocioMedico auxNegocio = new NegocioMedico();
            auxNegocio.actualizarMedico(medico);

        }

        [WebMethod]
        public void eliminarMedicoService(String medico)
        {
            NegocioMedico auxNegocio = new NegocioMedico();
            auxNegocio.eliminarMedico(medico);
        }

        [WebMethod]
        public DataSet consultarMedicoService()
        {
            NegocioMedico auxNegocio = new NegocioMedico();
            return auxNegocio.consultarMedico();
        }

        [WebMethod]
        public Medico_cargo buscaMedicoService(String rut)
        {
            NegocioMedico auxNegocio = new NegocioMedico();
            return auxNegocio.buscaMedico(rut);
        }

        [WebMethod]
        public Medico_cargo posicionMedicoService(int fila)
        {
            NegocioMedico auxNegocio = new NegocioMedico();
            return auxNegocio.posicionMedico(fila);
        }
    }
}
