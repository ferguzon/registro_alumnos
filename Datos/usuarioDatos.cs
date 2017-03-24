using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class usuarioDatos
    {

        public Entidad.Usuarios obtenerUsuarioDatos(string nombreUsuario)
        {

            Entidad.CursoNetEntities dc = null;
            Entidad.Usuarios usuario = null;

            try
            {

                // obtenemos la información del usuario con base en el parámetro nombreUsuario

                dc = new Entidad.CursoNetEntities();
                usuario = dc.Usuarios.Where(u => u.login == nombreUsuario).FirstOrDefault();

                return usuario;

            }
            catch (Exception err)
            {

                throw (err);

            } // fin del try

        } // fin del método obtenerUsuario
        
        public void ingresarUsuarioDatos(Entidad.Usuarios usuario)
        {

            Entidad.CursoNetEntities dc = null;
            Entidad.Usuarios nuevoUsuario = null;

            try
            {

                // guardamos el usuario que recibimos de la clase de negocio

                dc = new Entidad.CursoNetEntities();
                nuevoUsuario = dc.Usuarios.Add(usuario);

                dc.SaveChanges();

            }
            catch (Exception err)
            {

                throw err;

            } // fin del try


        } // fin del método ingresarUsuarioDatos
              
        public void actualizarUsuarioDatos(Entidad.Usuarios usuarioActualizar)
        {

            Entidad.CursoNetEntities dc = null;
            Entidad.Usuarios usuario = null;

            try
            {

                // actualizamos el usuario en la base de datos

                dc = new Entidad.CursoNetEntities();           
                usuario = dc.Usuarios.Where(u => u.Id == usuarioActualizar.Id).FirstOrDefault();

                usuario.login = usuarioActualizar.login;
                usuario.nombre = usuarioActualizar.nombre;
                usuario.clave = usuarioActualizar.clave;
                usuario.correo_electronico = usuarioActualizar.correo_electronico;

                dc.SaveChanges();

            }
            catch (Exception err)
            {

                throw(err);
            }

        } // fin del método actualizarUsuarioDatos

        public void eliminarUsuarioDatos(string idUsuario)
        {

            // este método elimina un usuario de la base de datos

            Entidad.CursoNetEntities dc = null;
            Entidad.Usuarios usuario = null;

            try
            {

                int idUsuarioEliminar = int.Parse(idUsuario);
                dc = new Entidad.CursoNetEntities();
                usuario = dc.Usuarios.Where(u => u.Id == idUsuarioEliminar).FirstOrDefault();

                dc.Usuarios.Remove(usuario);
                dc.SaveChanges();

            }
            catch (Exception err)
            {

                throw (err);

            } // fin del try

        } // fin del método eliminarUsuarioDatos

    } // fin de la clase usuarioDatos
}
