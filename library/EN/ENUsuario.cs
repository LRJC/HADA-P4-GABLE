using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library.CAD;

namespace library.EN
{
    public class ENUsuario
    {
        private string _nif;
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

        public string nif
        {
            get { return _nif; }

            set { _nif = value; }
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

            en.nif = nif;
            en.nombre = nombre;
            en.apellidos = apellidos;
            if (us.readUsuario(this) == true)
            {
                this.nif = en.nif;
                this.nombre = en.nombre;
                this.apellidos = en.apellidos;
                devolver = us.updateUsuario(this);
            }

            return devolver;
        }


        public bool loginUsuario()
        {
            CADUsuario nuevo = new CADUsuario();
            return nuevo.loginUsuario(this);
        }

        public bool logout()//revisar
        {
            CADUsuario nuevo = new CADUsuario();
            return nuevo.logoutUsuario(this);
        }

        public bool subirProducto()
        {
            ENProductos en = new ENProductos();
            return en.createProducto();
        }

        public bool deleteProducto()
        {
            ENProductos en = new ENProductos();
            return en.deleteProductos();
        }

        public bool createLocalidad()
        {
            ENLocalidad en = new ENLocalidad();
            return en.createLocalidad();
        }

        public bool deleteLocalidad()
        {
            ENLocalidad en = new ENLocalidad();
            return en.deleteLocalidad();
        }

        public bool createProvincia()
        {
            ENProvincia en = new ENProvincia();
            return en.createProvincia();
        }

        public bool deleteProvincia()
        {
            ENProvincia en = new ENProvincia();
            return en.deleteProvincia();
        }

    }
}
