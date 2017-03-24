using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["s_inicioSesion"] == null)
            {
                Response.Redirect("wfSesionIniciar.aspx");

            } // if que comprueba validez de la sesión 

        }
    }
}