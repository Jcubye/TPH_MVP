using Capa_DTO;
using Capa_Negocio;
using System;
using System.Collections.Generic;
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
    }
}
