using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class asignaturaDatos
    {
        public List<Entidad.Asignatura> obtenerListadoAsignaturasDatos()
        {

            Entidad.CursoNetEntities dc = null;
            List<Entidad.Asignatura> asignatura = null;

            try
            {

                dc = new Entidad.CursoNetEntities();
                asignatura = dc.Asignatura.ToList();

                return asignatura;

            }
            catch (Exception err)
            {

                throw err;
            }

        } // fin de obtenerListadoAsignaturaDatos

        public List<Entidad.Asignatura> obtenerNombreAsignaturaDatos(int idCarrera)
        {

            Entidad.CursoNetEntities dc = null;
            List<Entidad.Asignatura> asignatura = new List<Entidad.Asignatura>();

            try
            {

                dc = new Entidad.CursoNetEntities();
                asignatura = (from x in dc.Carrera_Asignatura join y in dc.Asignatura on x.id_asignatura equals y.Id where x.id_carrera == idCarrera select y).ToList();
                return asignatura;

            }
            catch (Exception err)
            {

                throw err;
            }

        } // obtenerNombreAsignaturaDatos
    }
}
