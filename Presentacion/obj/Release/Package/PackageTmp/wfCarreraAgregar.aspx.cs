using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class wfCarreraAgregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                lblFechaProceso.Text = DateTime.Now.ToString();

                Negocio.asignaturaNegocio dc = null;
                List<Entidad.Asignatura> asignaturas = null;

                try
                {

                    dc = new Negocio.asignaturaNegocio();
                    asignaturas = dc.obtenerAsignaturaNegocio();

                    ListItem sel = new ListItem();
                    sel.Value = "0";
                    sel.Text = "Seleccione...";
                    
                    ddlListadoAsignaturas.Items.Add(sel);

                    ddlListadoAsignaturas.DataSource = asignaturas;
                    ddlListadoAsignaturas.DataTextField = "descripcion";
                    ddlListadoAsignaturas.DataValueField = "Id";
                    ddlListadoAsignaturas.DataBind();

                    List<Entidad.Carrera_Asignatura> listaAsignaturas = new List<Entidad.Carrera_Asignatura>();

                    Session.Add("carreraAsignatura", listaAsignaturas);

                }
                catch (Exception)
                {

                    cvErrores.IsValid = false;
                    cvErrores.ErrorMessage = "Ocurrió un error al recuperar la información de las carreras";
                }

            } // if

            mvAgruparVistas.SetActiveView(vwIngresarCarrera);

        } // page load

        protected void ddlListadoAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {

            Negocio.carreraNegocio dc = new Negocio.carreraNegocio();
            Entidad.Carrera carrera = new Entidad.Carrera();

            lstAsignaturasSeleccionadas.Items.Add(ddlListadoAsignaturas.SelectedItem.Text);

            List<Entidad.Carrera_Asignatura> listaTemp = new List<Entidad.Carrera_Asignatura>();
            Entidad.Carrera_Asignatura carreraAsignatura = new Entidad.Carrera_Asignatura();

            listaTemp = (List<Entidad.Carrera_Asignatura>)Session["carreraAsignatura"];

            carreraAsignatura.id_asignatura = int.Parse(ddlListadoAsignaturas.SelectedValue);
            carreraAsignatura.id_carrera = dc.obtenerUltimoIDCarrera(txtNombreCarrera.Text);

            listaTemp.Add(carreraAsignatura);

            Session["carreraAsignatura"] = listaTemp;
            
        } // ddlListadoAsignaturas

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            Negocio.carreraNegocio dc = null;
            Negocio.carreraAsignaturaNegocio dc1 = null;
            int respuesta = 0;
            
            try
            {
                dc = new Negocio.carreraNegocio();
                respuesta = dc.existeCarreraNegocio(txtNombreCarrera.Text);
                dc1 = new Negocio.carreraAsignaturaNegocio();
                

                if (respuesta == 1)
                {

                    Entidad.Carrera carrera = new Entidad.Carrera();

                    carrera.descripcion = txtNombreCarrera.Text.Trim().ToUpper();
                    carrera.fecha_inicio = DateTime.Parse(txtFechaInicio.Text);
                    carrera.fecha_cierre = DateTime.Parse(txtFechaCierre.Text);
                    carrera.fecha_proceso = DateTime.Parse(lblFechaProceso.Text);
                    carrera.estado = 1;

                    dc.guardarCarreraNegocio(carrera);

                    List<Entidad.Carrera_Asignatura> listaTemp = new List<Entidad.Carrera_Asignatura>();
                    listaTemp = (List<Entidad.Carrera_Asignatura>)Session["carreraAsignatura"];

                    foreach (var item in listaTemp)
                    {

                        dc1.guardarCarreraAsignaturaNegocio(item);

                    }

                    mvAgruparVistas.SetActiveView(vwMostrarResultado);
                    lblResultado.Text = "La carrera se agregó correctamente.";
                    Session.Remove("carreraAsignatura");
                    
                }
                else
                {
                    cvErrores.IsValid = false;
                    cvErrores.ErrorMessage = "Esa carrera ya está registrada en la base de datos.";
                }

            }
            catch (Exception)
            {

                cvErrores.IsValid = false;
                cvErrores.ErrorMessage = "Ocurrió un error al guardar la información.";
               
            } // try

        } // btnGuardar

        protected void btnRegresar_Click(object sender, EventArgs e)
        {

            Response.Redirect("Default.aspx");

        }
    }
}