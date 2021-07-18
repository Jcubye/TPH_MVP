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
    /// Summary description for WebServiceUbicacion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceUbicacion : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarUbicacionService(Ubicacion ubicacion)
        {
            NegocioUbicacion auxNegocio = new NegocioUbicacion();
            auxNegocio.insertarUbicacion(ubicacion);

        }

        [WebMethod]
        public void actualizarUbicacionService(Ubicacion ubicacion)
        {
            NegocioUbicacion auxNegocio = new NegocioUbicacion();
            auxNegocio.actualizarUbicacion(ubicacion);
        }

        [WebMethod]
        public void eliminarUbicacionService(String area)
        {
            NegocioUbicacion auxNegocio = new NegocioUbicacion();
            auxNegocio.eliminarUbicacion(area);
        }

        [WebMethod]
        public DataSet ConsultarUbicacionService()
        {
            NegocioUbicacion auxNegocio = new NegocioUbicacion();
            return auxNegocio.consultarUbicacion();
        }

        [WebMethod]
        public Ubicacion buscaUbicacionService(String area)
        {
            NegocioUbicacion auxNegocio = new NegocioUbicacion ();
            return auxNegocio.buscaUbicacion(area);
        }

        [WebMethod]
        public Ubicacion posicionUbicacionService(int fila)
        {
            NegocioUbicacion auxNegocio = new NegocioUbicacion();
            return auxNegocio.posicionUbicacion(fila);
        }
    }
}
