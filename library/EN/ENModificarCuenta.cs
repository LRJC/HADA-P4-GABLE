using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.EN
{
    public class ENModificarCuenta
    {
        private string _nombre;
        public string nombre 
        { 
            get { return _nombre; }
            set { _nombre = value; }
        }
        
        public ENModificarCuenta() { }


        public bool createModificarCuenta() 
        {
            CADModificarCuenta mod = new CADModificarCuenta();
            if (mod.createModificarCuenta()) return true;
            return false;
        }
        public bool readModificarCuenta() 
        {
            CADModificarCuenta mod = new CADModificarCuenta();
            if (mod.createModificarCuenta()) return true;
            return false;

        }
        public bool updateModificarCuenta() 
        {
            CADModificarCuenta mod = new CADModificarCuenta();
            if (mod.createModificarCuenta()) return true;
            return false;
        }
        public bool deleteModificarCuenta() 
        {
            CADModificarCuenta mod = new CADModificarCuenta();
            if (mod.createModificarCuenta()) return true;
            return false;
        }
    }
}
