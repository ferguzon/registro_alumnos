using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class asignaturaNegocio
    {
        
        public List<Entidad.Asignatura> obtenerAsignaturaNegocio()
        {

            Datos.asignaturaDatos dc = null;
            List<Entidad.Asignatura> asignatura = null;

            try
            {

                dc = new Datos.asignaturaDatos();
                asignatura = dc.obtenerListadoAsignaturasDatos();

                return asignatura;

            }
            catch (Exception err)
            {

                throw err;
            }

        } // fin del método obtenerCarreras

        public List<Entidad.Asignatura> recuperarAsignaturasCarreraNegocio(int idCarrera)
        {

            Datos.asignaturaDatos dc = null;
            List<Entidad.Asignatura> listadoAsignaturas = null;

            try
            {

                dc = new Datos.asignaturaDatos();
                listadoAsignaturas = dc.obtenerNombreAsignaturaDatos(idCarrera);

                return listadoAsignaturas;

            }
            catch (Exception)
            {

                throw;
            }

        } // recuperarAsignaturaCarreraNaegocio

    }
}
