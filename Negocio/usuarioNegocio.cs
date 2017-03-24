using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class usuarioNegocio
    {

        public int obtenerUsuarioNegocio(string nombreUsuario, string clave)
        {

            Datos.usuarioDatos dc = null;
            Entidad.Usuarios usuario = null;

            try
            {

                // recuperamos el usuario desde la capa de datos

                dc = new Datos.usuarioDatos();
                usuario = dc.obtenerUsuarioDatos(nombreUsuario);

                int resultado = 0;

                if (usuario.clave == "123" && clave == "123")
                {

                    // se definió que se cambie la contraseña del usuario

                    resultado = 1;

                }
                else if (usuario.login == nombreUsuario && usuario.clave == CreateMD5(clave))
                {

                    
                    // en este caso usuario y contraseña son correctos

                    resultado = 2;

                }
                else if (usuario.login != nombreUsuario || usuario.clave != clave)
                {

                    // el nombre de usuario o clave no son correctos

                    resultado = 3;

                } // fin del if que comprueba si el usuario y clave son correctos

                return resultado;

            }
            catch (Exception err)
            {

                throw err;

            } // fin del try

            

        } // fin del método obtenerUsuarioNegocio

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

        public int ingresarUsuarioNegocio(Entidad.Usuarios usuario)
        {

            Datos.usuarioDatos dc = null;
            Entidad.Usuarios usuarioExistente = null;
            int resultado = 0;

            try
            {

                // pasamos el usuario a la capa de datos

                dc = new Datos.usuarioDatos();

                usuarioExistente = dc.obtenerUsuarioDatos(usuario.login);

                if (usuarioExistente == null)
                {

                    usuario.clave = CreateMD5(usuario.clave);

                    dc.ingresarUsuarioDatos(usuario);
                    resultado = 1;

                } // fin del if usuarioExistente != null

                return resultado;

            }
            catch (Exception err)
            {

                throw err;

            } // fin del try

        } // fin del método ingresarUsuarioNegocio

        public Entidad.Usuarios obtenerUsuarioNegocio(string nombreUsuario)
        {

            Datos.usuarioDatos dc = null;
            Entidad.Usuarios usuario = null;

            try
            {

                // este método busca un usuario con base en su nombre

                dc = new Datos.usuarioDatos();
                usuario = dc.obtenerUsuarioDatos(nombreUsuario);

                return usuario;

            }
            catch (Exception err)
            {

                throw(err);

            } // fin del try

        } // fin del método actualizarUsuarioNegocio

        public void actualizarUsuarioNegocio(Entidad.Usuarios usuarioActualizar)
        {

            Datos.usuarioDatos dc = null;
            
            try
            {

                // actualizamos la información del usuario

                usuarioActualizar.clave = CreateMD5(usuarioActualizar.clave);

                dc = new Datos.usuarioDatos();
                dc.actualizarUsuarioDatos(usuarioActualizar);
                                
            }
            catch (Exception err)
            {

                throw(err);
            }
            

        } // fin del método actualizarUsuarioNegocio

        public void eliminarUsuarioNegocio(string usuarioEliminar)
        {

            Datos.usuarioDatos dc = null;

            try
            {

                dc = new Datos.usuarioDatos();

                dc.eliminarUsuarioDatos(usuarioEliminar);

            }
            catch (Exception err)
            {

                throw (err);

            } // fin del try

        } // fin del método eliminarUsuarioNegocio

    } // fin de la clase usuarioNegocio

}
