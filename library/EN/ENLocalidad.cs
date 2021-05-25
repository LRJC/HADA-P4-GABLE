using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENLocalidad
    {
        private string _codm;
        public string codm
        {
            get { return _codm; }
            set { _codm = value; }
        }

        private string _pueblo;
        public string pueblo
        {
            get { return _pueblo; }
            set { _pueblo = value; }
        }

        private string _provincia;
        public string provincia
        {
            get { return _provincia; }
            set { _provincia = value; }
        }

        public bool createLocalidad()
        {
            CADLocalidad loc = new CADLocalidad();
            if (loc.createLocalidad(this)) return true;
            else return false;
        }

        public bool readLocalidad()
        {
            CADLocalidad loc = new CADLocalidad();
            if (loc.readLocalidad(this)) return true;
            else return false;
        }

        public bool readFirstLocalidad()
        {
            CADLocalidad loc = new CADLocalidad();
            if (loc.readFirstLocalidad(this)) return true;
            else return false;
        }

        public bool readNextLocalidad()
        {
            CADLocalidad loc = new CADLocalidad();
            if (loc.readNextLocalidad(this)) return true;
            else return false;
        }

        public bool updateLocalidad()
        {
            CADLocalidad loc = new CADLocalidad();
            if (loc.updateLocalidad(this)) return true;
            else return false;
        }

        public bool deleteLocalidad()
        {
            CADLocalidad loc = new CADLocalidad();
            if (loc.deleteLocalidad(this)) return true;
            else return false;
        }
    }
}
