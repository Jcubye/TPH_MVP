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
    /// Summary description for WebServiceTutor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceTutor : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarTutorService(Tutor tutor)
        {
            NegocioTutor auxNegocio = new NegocioTutor();
            auxNegocio.insertarTutor(tutor);

        }

        [WebMethod]
        public void actualizarTutorService(Tutor tutor)
        {
            NegocioTutor auxNegocio = new NegocioTutor();
            auxNegocio.actualizarTutor(tutor);

        }

        [WebMethod]
        public void eliminarTutorServce(String tutor)
        {
            NegocioTutor auxNegocio = new NegocioTutor();
            auxNegocio.eliminarTutor(tutor);
        }

        [WebMethod]
        public DataSet consultarTutorService()
        {
            NegocioTutor auxNegocio = new NegocioTutor();
            return auxNegocio.consultarTutor();
        }

        [WebMethod]
        public void buscaTutorService(String rut)
        {
            NegocioTutor auxNegocio = new NegocioTutor();
            auxNegocio.buscaTutor(rut);
        }

        [WebMethod]
        public Tutor posicionTutorService(int fila)
        {
            NegocioTutor auxNegocio = new NegocioTutor();
            return auxNegocio.posicionTutor(fila);
        }


    }
}
