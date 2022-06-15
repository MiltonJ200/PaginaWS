using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.FriendlyUrls.Resolvers;

namespace PaginaWS
{
    public partial class ViewSwitcher : UserControl
    {
        protected string CurrentView
        {
            get
            {
                return m_CurrentView;
            }

            private set
            {
                m_CurrentView = value;
            }
        }

        private string m_CurrentView;

        protected string AlternateView
        {
            get
            {
                return m_AlternateView;
            }

            private set
            {
                m_AlternateView = value;
            }
        }

        private string m_AlternateView;

        protected string SwitchUrl
        {
            get
            {
                return m_SwitchUrl;
            }

            private set
            {
                m_SwitchUrl = value;
            }
        }

        private string m_SwitchUrl;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Determinar la vista actual
            bool isMobile = WebFormsFriendlyUrlResolver.IsMobileView(new HttpContextWrapper(Context));
            CurrentView = isMobile ? "Mobile" : "Desktop";

            // Determinar la vista alternativa
            AlternateView = isMobile ? "Desktop" : "Mobile";

            // Create URL de conmutador a partir de la ruta, p. ej. ~/__FriendlyUrls_SwitchView/Mobile?ReturnUrl=/Page
            string url = GetRouteUrl("AspNet.FriendlyUrls.SwitchView", new { view = AlternateView });

            url += "?ReturnUrl=" + HttpUtility.UrlEncode(Request.RawUrl);
            SwitchUrl = url;
        }
    }
}