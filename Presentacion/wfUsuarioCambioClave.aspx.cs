using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class wfCambioClave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                if (Session["s_inicioSesion"] != null)
                {
                    
                    try
                    {                                                 

                            Entidad.Usuarios usuario = new Entidad.Usuarios();

                            usuario = (Entidad.Usuarios)Session["s_usuarioCambioClave"];

                            lblUsuario.Text = usuario.login;
                          
                    }
                    catch (Exception)
                    {

                        cvErrores.IsValid = false;
                        cvErrores.ErrorMessage = "Ocurrió un error al procesar la información.";
                                           
                    } // try                                           
                    
                }
                else
                {

                    Response.Redirect("wfSesionIniciar.aspx");

                }

            } // if isPostBack

        } // page load

        protected void btnActualizarClave_Click(object sender, EventArgs e)
        {

            Negocio.usuarioNegocio dc = null;

            try
            {

                if (txtNuevaClave.Text == txtRepetirNuevaClave.Text)
                {

                    dc = new Negocio.usuarioNegocio();

                    Entidad.Usuarios usuario = new Entidad.Usuarios();

                    usuario = (Entidad.Usuarios)Session["s_usuarioCambioClave"];
                                       
                    usuario.clave = txtNuevaClave.Text;

                    dc.actualizarUsuarioNegocio(usuario);

                    lblResultado.Text = "La contraseña se guardó exitosamente.";
                    txtNuevaClave.Text = string.Empty;
                    txtRepetirNuevaClave.Text = string.Empty;

                }
                else
                {

                    cvErrores.IsValid = false;
                    cvErrores.ErrorMessage = "Las contraseñas ingresadas no coinciden";

                }



            }
            catch (Exception)
            {

                cvErrores.IsValid = false;
                cvErrores.ErrorMessage = "Ocurrió un error al actualizar la contraseña";

            } // try   

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            Response.Redirect("wfSesionIniciar.aspx");

        }
    }
}