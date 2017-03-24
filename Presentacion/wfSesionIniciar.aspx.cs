using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class wfIniciarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {

            Negocio.usuarioNegocio dc = null;
            int resultado = 0;

            try
            {

                dc = new Negocio.usuarioNegocio();

                resultado = dc.obtenerUsuarioNegocio(txtNombreUsuario.Text, txtClave.Text);
                
                if (resultado == 1)
                {

                    // se requiere cambio de contraseña

                    Session.Add("s_inicioSesion", txtNombreUsuario.Text);

                    Session.Add("s_usuarioCambioClave", dc.obtenerUsuarioNegocio(txtNombreUsuario.Text));
                    Response.Redirect("wfUsuarioCambioClave.aspx");
                    

                }
                else if (resultado == 2)
                {

                    // la información es correcta, se redirige al usuario

                    Session.Add("s_inicioSesion", txtNombreUsuario.Text);
                    Response.Redirect("Default.aspx");
                    
                    
                }
                else if (resultado == 3)
                {
                    
                    // nombre de usuario o clave no son correctos

                    cvErrores.IsValid = false;
                    cvErrores.ErrorMessage = "El nombre de usuario o clave no son válidos";

                }
            }
            catch (Exception)
            {

                

                cvErrores.IsValid = false;
                cvErrores.ErrorMessage = "Por favor verifique los datos ingresados.";

            } // fin del try

        }
    }
}