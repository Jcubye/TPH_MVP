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
    /// Summary description for WebServiceAtencion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceAtencion : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarAtencionService(Atencion atencion)
        {
            NegocioAtencion auxNegocio = new NegocioAtencion();
            auxNegocio.insertarAtencion(atencion);

        }

        [WebMethod]
        public void actualizarAtencionService(Atencion atencion)
        {
            NegocioAtencion auxNegocio = new NegocioAtencion();
            auxNegocio.actualizarAtencion(atencion);
        }

        [WebMethod]
        public void eliminarAtencionService(int id)
        {
            NegocioAtencion auxNegocio = new NegocioAtencion();
            auxNegocio.eliminarAtencion(id);
        }

        [WebMethod]
        public DataSet consultarAtencionService()
        {
            NegocioAtencion auxNegocio = new NegocioAtencion();
            return auxNegocio.consultarAtencion();
        }

        [WebMethod]
        public Atencion buscaAtencionService(int id)
        {
            NegocioAtencion auxNegocio = new NegocioAtencion();
            return auxNegocio.buscarAtencion(id);
        }

        [WebMethod]
        public Atencion posicionAtencionService(int fila)
        {
            NegocioAtencion auxNegocio = new NegocioAtencion();
            return auxNegocio.posicionAtencion(fila);
        }

    }
}
