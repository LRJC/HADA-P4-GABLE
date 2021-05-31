using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENUsuario
    {
        private string _dni;
        private string _nombre;
        private string _apellidos;
        private string _email;
        private string _contraseña;
        private int _telefono;
        private int _numTarjeta;
        private int _cvv;
        private string _expTarjeta;
        private string _fechanac;//comprobar
        private bool _admin;

        public ENUsuario(string dni, string nombre, string apellidos, string email, int tlf, int NT, int cvv, string expT, string fechanac)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.email = email;
            this.contraseña = contraseña;
            this.tlf = tlf;
            this.cvv = cvv;
            this.numTarjeta = NT;
            this.expTarjeta = expT;
            this.fechanac = fechanac;
        }

        public ENUsuario()
        {
            this.dni = "";
            this.nombre = "";
            this.apellidos = "";
            this.email = "";
            this.contraseña = "";
            this.tlf = 0;
            this.cvv = 0;
            this.numTarjeta = 0;
            this.expTarjeta = "";
            this.fechanac = "";
        }

        public string dni
        {
            get { return _dni; }

            set { _dni = value; }
        }

        public string nombre
        {
            get { return _nombre; }

            set { _nombre = value; }
        }

        public string apellidos
        {
            get { return _apellidos; }

            set { _apellidos = value; }
        }

        public string email
        {
            get { return _email; }

            set { _email = value; }
        }

        public string contraseña
        {
            get { return _contraseña; }

            set { _contraseña = value; }
        }

        public int tlf
        {
            get { return _telefono; }

            set { _telefono = value; }
        }

        public int numTarjeta
        {
            get { return _numTarjeta; }

            set { _numTarjeta = value; }
        }

        public int cvv
        {
            get { return _cvv; }

            set { _cvv = value; }
        }

        public string expTarjeta
        {
            get { return _expTarjeta; }

            set { _expTarjeta = value; }
        }

        public string fechanac//comprobar
        {
            get { return _fechanac; }

            set { _fechanac = value; }
        }

        public bool admin
        {
            get { return _admin; }

            set { _admin = value; }
        }


        public bool readUsuario()
        {
            bool devolver;
            CADUsuario usu = new CADUsuario();
            devolver = usu.readUsuario(this);
            return devolver;
        }

        public bool createUsuario()//register
        {
            bool devolver = false;
            CADUsuario usu = new CADUsuario();
            if (!usu.readUsuario(this))
            {
                devolver = usu.createUsuario(this);
            }
            return devolver;
        }

        public bool deleteUsuario()
        {
            bool devolver = false;
            CADUsuario c = new CADUsuario();
            if (c.readUsuario(this))
            {
                devolver = c.deleteUsuario(this);
            }
            return devolver;
        }

        public bool updateUsuario()
        {
            bool devolver = false;
            CADUsuario us = new CADUsuario();
            ENUsuario en = new ENUsuario();

            en.dni = dni;
            en.nombre = nombre;
            en.apellidos = apellidos;
            if (us.readUsuario(this) == true)
            {
                this.dni = en.dni;
                this.nombre = en.nombre;
                this.apellidos = en.apellidos;
                devolver = us.updateUsuario(this);
            }

            return devolver;
        }

    }
}
