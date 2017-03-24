using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class carreraAsignaturaNegocio
    {

        public void guardarCarreraAsignaturaNegocio(Entidad.Carrera_Asignatura carreraAsignatura)
        {

            Datos.carreraAsignaturaDatos dc = null;

            try
            {

                dc = new Datos.carreraAsignaturaDatos();

                dc.guardarCarreraAsignaturaDatos(carreraAsignatura);
                
            }
            catch (Exception err)
            {

                throw err;
            }

        } // guardarCarreraAsignaturaNegocio

       
    }
}
