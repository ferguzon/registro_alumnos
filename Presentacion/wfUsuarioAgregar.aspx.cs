using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class wfUsuarioAgregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["s_inicioSesion"] != null)
            {                

            // definimos la fecha en la que se realiza el proceso
            if (!IsPostBack)
            {                              
                                  
                lblFechaProceso.Text = DateTime.Now.ToShortDateString();
            }
            
            }
            else
            {

                Response.Redirect("wfSesionIniciar.aspx");

            } // if que comprueba validez de la sesión

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {            

            if (txtClave.Text == txtClaveConfirmar.Text)
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
                    usuario.clave = CreateMD5(txtClave.Text.Trim());
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
                
            }
            else
            {

                cvErrores.IsValid = false;
                cvErrores.ErrorMessage = "Las claves ingresadas no coinciden. Por favor verifique.";

            } // fin del if que compara ambas claves

            

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

        protected static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
            }
            return sb.ToString();

        } // CreateMD5

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

            Response.Redirect("wfDefault.aspx");

        }
    } // fin de la clase wfUsuarioAgregar
}