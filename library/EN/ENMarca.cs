using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENMarca
    {
        private string _nombre;
        private string _origen;
        

        public ENMarca(string nombre, string origen)
        {
            this.nombre = nombre;
            this.origen = origen;
        }

        public ENMarca()
        {
            this.nombre = "";
            this.origen = "";
        }

        public string nombre
        {
            get { return _nombre; }

            set { _nombre = value; }
        }

        public string origen
        {
            get { return _origen; }

            set { _origen = value; }
        }

        public bool readMarca()
        {
            CADMarca m = new CADMarca();
            return m.readMarca(this);
        }

        public bool deleteMarca()
        {
            bool retornar = false;
            CADMarca m = new CADMarca();
            if (m.readMarca(this))
            {
                retornar = m.deleteMarca(this);
            }
            return retornar;
        }

        public bool createMarca()
        {
            bool retornar=false;
            CADMarca m = new CADMarca();
            if (!m.readMarca(this))
            {
                retornar = m.createMarca(this);
            }
            return retornar;
        }

        public bool modifyMarca(string nombrenuevo)
        {
            CADMarca m = new CADMarca();
            return m.modifyMarca(this, nombrenuevo);
        }

    }
}
