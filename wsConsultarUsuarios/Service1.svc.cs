using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wsConsultarUsuarios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public string obtenerUsuario(int idUsuario)
        {

            Negocio.usuarioNegocio dc = null;
            string login = "";

            try
            {

                // Desde acá realizamos el enlace a la capa de negocio para recuperar
                // el nombre de usuario con base en su ID

                dc = new Negocio.usuarioNegocio();
                login = dc.obtenerUsuarioNegocio(idUsuario);

                return login;

            }
            catch (Exception)
            {

                return "No se encontró el usuario";
            } // try
            
        } // fin del método obtenerUsuario

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
