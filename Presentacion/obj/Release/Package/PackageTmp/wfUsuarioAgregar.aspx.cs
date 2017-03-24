using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class wfUsuarioAgregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // definimos la fecha en la que se realiza el proceso

            lblFechaProceso.Text = DateTime.Now.ToShortDateString();

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            Negocio.usuarioNegocio dc = null;
            Entidad.Usuarios usuario = new Entidad.Usuarios();

            try
            {

                // pasamos el usuario a la capa de negocio

                dc = new Negocio.usuarioNegocio();

                usuario.nombre = txtNombrePersona.Text.ToString().Trim();
                usuario.correo_electronico = txtCorreoElectronico.Text.ToString().Trim();
                usuario.login = txtNombreUsuario.Text.Trim();
                usuario.clave = txtClave.Text.ToString().Trim();
                usuario.fecha_proceso = DateTime.Parse(lblFechaProceso.Text);

                int resultado = dc.ingresarUsuarioNegocio(usuario);

                if (resultado == 1)
                {

                    limpiarCampos();
                    lblResultadoProceso.Text = " La información se almacenó correctamente.";

                }
                else
                {

                    cvErrores.IsValid = false;
                    cvErrores.ErrorMessage = "El nombre de usuario que está tratando de almacenar ya está registrado en la base de datos.";

                }


            }
            catch (Exception)
            {

                cvErrores.IsValid = false;
                cvErrores.ErrorMessage = "Verifique la información ingresada.";                              

            } // fin del try

        } // fin del botón guardar

        private void limpiarCampos()
        {

            // este método limpia los campos del formulario

            txtNombrePersona.Text = string.Empty;
            txtCorreoElectronico.Text = string.Empty;
            txtNombreUsuario.Text = string.Empty;
            txtClave.Text = string.Empty;
            lblFechaProceso.Text = "";


        } // fin del método limpiarCampos

    } // fin de la clase wfUsuarioAgregar
}