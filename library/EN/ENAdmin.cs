using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENAdmin
    {
        private string _dni;
        public string dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        private string _email;
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _contrasenya;
        public string contrasenya
        {
            get { return _contrasenya; }
            set { _contrasenya = value; }
        }

        private string _nombre;
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellidos;
        public string apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }

        public bool createAdmin()
        {
            return false;
        }

        public bool readAdmin()
        {
            return false;
        }

        public bool updateAdmin()
        {
            return false;
        }

        public bool deleteAdmin()
        {
            return false;
        }
    }
}
