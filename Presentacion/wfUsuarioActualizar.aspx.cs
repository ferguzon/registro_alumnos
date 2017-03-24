using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class wfUsuarioActualizar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["s_inicioSesion"] != null)
            {

                mvAgruparVistas.SetActiveView(vwBuscarUsuario);

            }
            else
            {

                Response.Redirect("wfSesionIniciar.aspx");

            } // if que comprueba validez de la sesión
                       

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {                       
            
                llenarCampos(txtLoginUsuario.Text);                                                             
            
        } // fin del botón buscar

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

            limpiarCampos();
                       
        } // fin del btnCancelar

        private void limpiarCampos()
        {

            // este método limpia los campos del formulario

            txtNombrePersona.Text = string.Empty;
            txtCorreoElectronico.Text = string.Empty;
            txtLoginUsuario.Text = string.Empty;
            txtClave.Text = string.Empty;
            txtLoginUsuarioActualizar.Text = string.Empty;
            Session.Remove("s_idUsuario");

            mvAgruparVistas.SetActiveView(vwBuscarUsuario);

        } // fin del método limpiarCampos

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            Negocio.usuarioNegocio dc = null;
            Entidad.Usuarios usuarioActualizar = null;

            try
            {

                dc = new Negocio.usuarioNegocio();
                usuarioActualizar = new Entidad.Usuarios();

                usuarioActualizar.nombre = txtNombrePersona.Text;
                usuarioActualizar.correo_electronico = txtCorreoElectronico.Text;
                usuarioActualizar.login = txtLoginUsuarioActualizar.Text;
                usuarioActualizar.clave = txtClave.Text;
                usuarioActualizar.Id = (int)Session["s_idUsuario"];

                dc.actualizarUsuarioNegocio(usuarioActualizar);

                limpiarCampos();
                lblResultado.Text = "La información se actualizó correctamente.";

            }
            catch (Exception)
            {

                cvErrorActualizar.IsValid = false;
                cvErrorActualizar.ErrorMessage = "Por favor verifique la información ingresada.";

            } // fin del try

        } // fin del botón actualizar

        protected void btnEliminarUsuario_Click(object sender, EventArgs e)
        {

            mvAgruparVistas.SetActiveView(vwConfirmarEliminarUsuario);
            
        }

        protected void llenarCampos(string nombreUsuario)
        {

            // este método consulta el usuario y llena los campos dl formulario

            Negocio.usuarioNegocio dc = null;
            Entidad.Usuarios usuario = null;

            try
            {

                // busca el usuario con base en el "user login" y rellena su información en los campos correspondientes
                // no se muestra la contraseña por privacidad

                dc = new Negocio.usuarioNegocio();
                usuario = dc.obtenerUsuarioNegocio(nombreUsuario);
                                
                txtNombrePersona.Text = usuario.nombre;
                txtCorreoElectronico.Text = usuario.correo_electronico;
                txtLoginUsuarioActualizar.Text = usuario.login;
                lblFechaIngreso.Text = usuario.fecha_proceso.ToShortDateString();
             
                Session.Add("s_idUsuario", usuario.Id);
                
                mvAgruparVistas.SetActiveView(vwActualizarUsuario);

            }
            catch (Exception)
            {

                cvError.IsValid = false;
                cvError.ErrorMessage = "Por favor revise el usuario ingresado.";

            } // fin del try

        } // fin del método llenarCampos

        protected void btnConfirmarEliminarUsuario_Click(object sender, EventArgs e)
        {

            Negocio.usuarioNegocio dc = null;
            Entidad.Usuarios usuarioEliminar = null;

            try
            {

                dc = new Negocio.usuarioNegocio();
                usuarioEliminar = new Entidad.Usuarios();


                dc.eliminarUsuarioNegocio(Session["s_idUsuario"].ToString());

                limpiarCampos();
                lblResultado.Text = "El usuario se eliminó correctamente.";


            }
            catch (Exception)
            {

                cvErrorActualizar.IsValid = false;
                cvErrorActualizar.ErrorMessage = "Por favor verifique la información ingresada.";

            } // fin del try

        }

        protected void btnCancelarEliminacionUsuario_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            lblResultado.Text = "Se ha cancelado la eliminación del usuario.";
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {

            limpiarCampos();
            Response.Redirect("Default.aspx");

        }
    } // fin de la clase wfUsuarioActualizar
}