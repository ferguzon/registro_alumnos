using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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

                // Implementamos transacciones para asegurar que la información
                // se almacene correctamente. Para ello, agregar la referencia
                // "using System.Transactions" y crear un nuevo objeto de tipo
                // TransactionScope. Al terminar la transacción, hacer un 
                // ts.complete.

                using (TransactionScope ts = new TransactionScope())
                {

                    dc = new Entidad.CursoNetEntities();

                    dc.Carrera.Add(carrera);
                    dc.SaveChanges();

                    ts.Complete();

                }


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

        public List<Entidad.Carrera> obtenerCarreraDatos()
        {

            Entidad.CursoNetEntities dc = null;
            List<Entidad.Carrera> carrera = null;

            try
            {

                dc = new Entidad.CursoNetEntities();

                carrera = dc.Carrera.ToList();

                return carrera;

            }
            catch (Exception err)
            {

                throw err;
            }

        } // fin obtenerCarreraDatos

    }
}
