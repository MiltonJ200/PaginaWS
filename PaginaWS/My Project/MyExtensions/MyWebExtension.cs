/* TODO ERROR: Skipped IfDirectiveTrivia
#If _MyType <> "Empty" Then
*/
using System.Diagnostics;
using System.Web;
using Microsoft.VisualBasic;

namespace PaginaWS.My
{
    /// <summary>
    /// Módulo usado para definir las propiedades que están disponibles en el espacio de nombres My para proyectos web.
    /// </summary>
    /// <remarks></remarks>
    [HideModuleName()]
    static class MyWebExtension
    {
        private readonly static MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.Devices.ServerComputer> s_Computer = new MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.Devices.ServerComputer>();
        private readonly static MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.WebUser> s_User = new MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.WebUser>();
        private readonly static MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.Logging.AspLog> s_Log = new MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.Logging.AspLog>();
        /// <summary>
        /// Devuelve información sobre el equipo host.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal static Microsoft.VisualBasic.Devices.ServerComputer Computer
        {
            get
            {
                return s_Computer.GetInstance;
            }
        }
        /// <summary>
        /// Devuelve información del usuario web actual.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal static Microsoft.VisualBasic.ApplicationServices.WebUser User
        {
            get
            {
                return s_User.GetInstance;
            }
        }
        /// <summary>
        /// Devuelve un objeto Request.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        [System.ComponentModel.Design.HelpKeyword("My.Request")]
        internal static HttpRequest Request
        {
            [DebuggerHidden()]
            get
            {
                var CurrentContext = HttpContext.Current;
                if (CurrentContext is object)
                {
                    return CurrentContext.Request;
                }

                return null;
            }
        }
        /// <summary>
        /// Devuelve un objeto Response.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        [System.ComponentModel.Design.HelpKeyword("My.Response")]
        internal static HttpResponse Response
        {
            [DebuggerHidden()]
            get
            {
                var CurrentContext = HttpContext.Current;
                if (CurrentContext is object)
                {
                    return CurrentContext.Response;
                }

                return null;
            }
        }
        /// <summary>
        /// Devuelve el objeto de registro Asp.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal static Microsoft.VisualBasic.Logging.AspLog Log
        {
            get
            {
                return s_Log.GetInstance;
            }
        }
    }
}

/* TODO ERROR: Skipped EndIfDirectiveTrivia
#End If*/