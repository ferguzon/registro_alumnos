using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class carreraAsignaturaDatos
    {

        public void guardarCarreraAsignaturaDatos(Entidad.Carrera_Asignatura carreraAsignatura)
        {

            Entidad.CursoNetEntities dc = null;

            try
            {

                dc = new Entidad.CursoNetEntities();

                dc.Carrera_Asignatura.Add(carreraAsignatura);
                dc.SaveChanges();

            }
            catch (Exception err)
            {

                throw err;
            }
        } // guardarCarreraAsignaturaDatos

        public List<Entidad.Carrera_Asignatura> recuperarAsignaturasCarreraDatos(int idCarrera)
        {

            Entidad.CursoNetEntities dc = null;
            List<Entidad.Carrera_Asignatura> carreraAsignatura = null;

            try
            {

                dc = new Entidad.CursoNetEntities();
                carreraAsignatura = dc.Carrera_Asignatura.Where(u => u.id_carrera == idCarrera).ToList();

                return carreraAsignatura;

            }
            catch (Exception err)
            {

                throw err;

            } // try


        } // recuperarAsignaturasCarreraDatos

        
    }
}
