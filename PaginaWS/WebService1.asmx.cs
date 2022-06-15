using System.ComponentModel;
using System.Web.Services;

namespace PaginaWS
{

    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
    // <System.Web.Script.Services.ScriptService()> _
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class WebService1 : WebService
    {
        [WebMethod()]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
    }
}