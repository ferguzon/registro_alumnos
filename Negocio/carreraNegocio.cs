using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class carreraNegocio
    {

        public int existeCarreraNegocio(string nombreCarrera)
        {

            Datos.carreraDatos dc = null;
            Entidad.Carrera carrera = null;

            try
            {

                dc = new Datos.carreraDatos();
                int respuesta = 1;

                carrera = dc.buscarCarreraDatos(nombreCarrera);

                if (carrera != null)
                {

                    respuesta = 0;

                }
                else
                {

                    respuesta = 1;

                }

                return respuesta;

            }
            catch (Exception)
            {

                throw;
            }

        } // fin del método obtenerCarreraNegocio

        public void guardarCarreraNegocio(Entidad.Carrera carrera)
        {

            Datos.carreraDatos dc = null;

            try
            {

                dc = new Datos.carreraDatos();

                dc.guardarCarreraDatos(carrera);

            }
            catch (Exception err)
            {

                throw err;
            }

        } // guardarCarreraNegocio

        public int obtenerUltimoIDCarrera(string nombreCarrera)
        {

            Datos.carreraDatos dc = null;
            Entidad.Carrera carrera = null;

            try
            {

                int ultimoID = 0;

                dc = new Datos.carreraDatos();

                carrera = dc.obtenerUltimoIDCarrera(nombreCarrera);
                ultimoID = carrera.Id;
                ultimoID++;

                return ultimoID;

            }
            catch (Exception err)
            {

                throw err;
            }

            

        } // obtenerUltimoIDCarrera

        public Entidad.Carrera obtenerCarreraNegocio(string nombreCarrera)
        {

            Datos.carreraDatos dc = null;
            Entidad.Carrera carrera = null;

            try
            {

                dc = new Datos.carreraDatos();
                
                carrera = dc.buscarCarreraDatos(nombreCarrera);
                
                return carrera;

            }
            catch (Exception err)
            {

                throw err;
            }

        } // fin del método obtenerCarreraNegocio

        public List<Entidad.Carrera> obtenerListaCarreras()
        {

            Datos.carreraDatos dc = null;
            List<Entidad.Carrera> carrera = null;

            try
            {

                dc = new Datos.carreraDatos();
                carrera = dc.obtenerCarreraDatos();

                return carrera;

            }
            catch (Exception err)
            {

                throw err;
            }


        } // fin del método obtenerListaCarreras

    }
}
