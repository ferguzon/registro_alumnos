using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class wfCarreraMostrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            mvAgruparVistas.SetActiveView(vwBuscarCarrera);

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {

            Negocio.carreraNegocio dc = null;
            Negocio.asignaturaNegocio dc1 = null;

            Entidad.Carrera carrera = null;
            List<Entidad.Asignatura> listadoAsignaturas = null;

            try
            {

                dc = new Negocio.carreraNegocio();
                carrera = dc.obtenerCarreraNegocio(txtNombreCarrera.Text);

                txtFechaFin.Text = carrera.fecha_cierre.Value.ToShortDateString();
                txtFechaInicio.Text = carrera.fecha_inicio.ToShortDateString();
                txtFechaProceso.Text = carrera.fecha_proceso.ToString();

                if (carrera.estado == 1)
                {

                    lblEStado.Text = "Activo";

                }
                else
                {

                    lblEStado.Text = "Inactivo";

                }
                         

                dc1 = new Negocio.asignaturaNegocio();
                listadoAsignaturas = dc1.recuperarAsignaturasCarreraNegocio(carrera.Id);

                gvAsignaturas.DataSource = listadoAsignaturas;
                gvAsignaturas.DataBind();

            }
            catch (Exception)
            {
                cvErrores.IsValid = false;
                cvErrores.ErrorMessage = "Ocurrió un error al recuperar la carrera";
            }


        } // mostrar carrera

        protected void btnRegresar_Click(object sender, EventArgs e)
        {

            Response.Redirect("Default.aspx");
        }
    }
}