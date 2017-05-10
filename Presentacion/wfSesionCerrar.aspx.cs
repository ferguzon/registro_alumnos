using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class wfCerrarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                if (Session["s_inicioSesion"] != null)
                {
                    Session.Remove("s_inicioSesion");
                    Session.Remove("s_usuarioCambioClave");
                    Session.Remove("s_idUsuario");
                    Session.Remove("s_carreraAsignatura");

                    Session.Add("s_Redirigir", 1);

                } // fin del if

            } // fin del if isPostBack

        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {

            Response.Redirect("wfSesionIniciar.aspx");

        }

        //protected void Timer1_Tick(object sender, EventArgs e)
        //{

        //}

        protected void Timer1_Tick1(object sender, EventArgs e)
        {

            //lblTiempo.Text = Session["s_Redirigir"].ToString();

            //int value = (int)Session["s_Redirigir"];

            //value++;

            //Session["s_Redirigir"] = value;

            //if (value > 3)
            //{

            //    Response.Redirect("wfSesionIniciar.aspx");

            //} // if

            Response.Redirect("wfSesionIniciar.aspx");

        } // fin del timer1

        }
}