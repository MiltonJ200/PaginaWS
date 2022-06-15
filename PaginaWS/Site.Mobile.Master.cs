using System;
using System.Web.UI;

namespace PaginaWS
{
    public partial class Site_Mobile : MasterPage
    {
        public Site_Mobile()
        {
            Load += Page_Load;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}