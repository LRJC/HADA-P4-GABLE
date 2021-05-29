using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENProvincia
    {
        private string _codp;
        public string codp
        {
            get { return _codp; }
            set { _codp = value; }
        }
        private string _nombre;
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public bool createProvincia()
        {
            CADProvincia pro = new CADProvincia();
            if (pro.createProvincia(this))
            {
                return true;
            }
            return false;
        }

        public bool readProvincia()
        {
            CADProvincia pro = new CADProvincia();
            if (pro.readProvincia(this))
            {
                return true;
            }
            return false;
        }

        public bool updateProvincia()
        {
            CADProvincia pro = new CADProvincia();
            if (pro.updateProvincia(this))
            {
                return true;
            }
            return false;
        }

        public bool deleteProvincia()
        {
            CADProvincia pro = new CADProvincia();
            if (pro.deleteProvincia(this))
            {
                return true;
            }
            return false;
        }
    }
}
