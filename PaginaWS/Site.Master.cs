using System;
using System.Web.UI;

namespace PaginaWS
{
    public partial class SiteMaster : MasterPage
    {
        public SiteMaster()
        {
            Load += Page_Load;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}