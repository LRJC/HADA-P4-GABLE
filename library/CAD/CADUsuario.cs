using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using library.EN;

namespace library.CAD
{
    class CADUsuario
    {
        private string dbd;

        public CADUsuario()
        {
            //revisar->dbd = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }

        public bool createUsuario(ENUsuario us)//register
        {
            //implementación
            return true;
        }

        public bool updateUsuario(ENUsuario us)
        {
            //implementación
            return true;
        }

        public bool deleteUsuario(ENUsuario us)
        {
            //implememtación
            return true;
        }

        public bool readUsuario(ENUsuario us)
        {
            //implementación
            return true;
        }

        public bool loginUsuario(ENUsuario en)
        {
            //implementación(validación de contraseña y usuario, ...)
            return true;
        }

        public bool logoutUsuario(ENUsuario en)//revisar
        {
            //implementación
            return true;
        }

        public bool subirProducto(ENUsuario en)//revisar
        {
            //implementación
            return true;
        }

        public bool deleteProducto(ENUsuario en)//revisar
        {
            //implementación
            return true;
        }
    }
}
