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
    /// Summary description for WebServiceIngreso
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceIngreso : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarIngresoService(Ingreso ingreso)
        {
            NegocioIngreso auxNegocio = new NegocioIngreso();
            auxNegocio.insertarIngreso(ingreso);

        }

        [WebMethod]
        public void actualizarIngresoService(Ingreso ingreso)
        {
            NegocioIngreso auxNegocio = new NegocioIngreso();
            auxNegocio.actualizarIngreso(ingreso);
        }

        [WebMethod]
        public void eliminarIngresoService(int id)
        {
            NegocioIngreso auxNegocio = new NegocioIngreso();
            auxNegocio.eliminarIngreso(id);
        }

        [WebMethod]
        public DataSet consultarIngresoService()
        {
            NegocioIngreso auxNegocio = new NegocioIngreso();
            return auxNegocio.consultarIngreso();
        }

        [WebMethod]
        public Ingreso buscaIngresoService(int id)
        {
            NegocioIngreso auxNegocio = new NegocioIngreso();
            return auxNegocio.buscarIngreso(id);
        }

        [WebMethod]
        public Ingreso posicionIngresoService(int fila)
        {
            NegocioIngreso auxNegocio = new NegocioIngreso();
            return auxNegocio.posicionIngreso(fila);
        }
    }
}
