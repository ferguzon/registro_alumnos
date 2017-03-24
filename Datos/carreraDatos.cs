using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class carreraDatos
    {

        public Entidad.Carrera buscarCarreraDatos(string nombreCarrera)
        {

            Entidad.CursoNetEntities dc = null;
            Entidad.Carrera carrera = null;

            try
            {

                dc = new Entidad.CursoNetEntities();
                carrera = dc.Carrera.Where(u => u.descripcion == nombreCarrera).FirstOrDefault();

                return carrera;

            }
            catch (Exception err)
            {

                throw err;
            }

        }

        public void guardarCarreraDatos(Entidad.Carrera carrera)
        {

            Entidad.CursoNetEntities dc = null;

            try
            {

                dc = new Entidad.CursoNetEntities();

                dc.Carrera.Add(carrera);
                dc.SaveChanges();

            }
            catch (Exception err)
            {

                throw err;
            }
            
        } // guardarCarreraDatos

        public Entidad.Carrera obtenerUltimoIDCarrera(string nombreCarrera)
        {

            Entidad.CursoNetEntities dc = null;
            Entidad.Carrera carrera = null;
                      
            try
            {

                dc = new Entidad.CursoNetEntities();

                carrera = dc.Carrera.OrderByDescending(u => u.Id).First();

                return carrera;
            }
            catch (Exception err)
            {

                throw err;
            }


        } // obtenerUltimoIDCarrera

    }
}
