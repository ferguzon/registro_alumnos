using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class wfCarreraReporteListado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["s_inicioSesion"] != null)
            {

                if (!IsPostBack)
                {

                    Negocio.carreraNegocio dc = new Negocio.carreraNegocio();

                    rptListadoCarreras.LocalReport.ReportEmbeddedResource = "Presentacion.rptCarrerasListado.rdlc";
                    rptListadoCarreras.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("dsTablaCarreras", dc.obtenerListaCarreras()));

                    rptListadoCarreras.LocalReport.SetParameters(new Microsoft.Reporting.WebForms.ReportParameter("descripcion", "descripcion"));
                    rptListadoCarreras.LocalReport.SetParameters(new Microsoft.Reporting.WebForms.ReportParameter("fecha_inicio", "fecha_inicio"));
                    rptListadoCarreras.LocalReport.SetParameters(new Microsoft.Reporting.WebForms.ReportParameter("fecha_cierre", "fecha_cierre"));

                    rptListadoCarreras.LocalReport.Refresh();

                } // if !IsPosback

            }
            else
            {

                Response.Redirect("wfSesionIniciar.aspx");

            } // if que comprueba validez de la sesión 
        }
    }
}