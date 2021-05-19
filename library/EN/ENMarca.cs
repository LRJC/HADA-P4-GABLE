using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library.CAD;

namespace library.EN
{
    public class ENMarca
    {
        private string _nombre;
        private string _origen;
        private string _url;

        public ENMarca(string nombre, string origen, string imagen)
        {
            this.nombre = nombre;
            this.origen = origen;
            this.imagen = imagen;
        }

        public ENMarca()
        {
            this.nombre = "";
            this.origen = "";
            this.imagen = "";
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

        public string imagen
        {
            get { return _url; }

            set { _url = value; }
        }

        public bool readMarca()
        {
            bool retornar;
            CADMarca m = new CADMarca();
            return m.readMarca(this);
        }

        public bool deleteMarca()
        {
            bool retornar = false;
            CADMarca m = new CADMarca();
            if (m.readMarca(this))
            {
                retornar = m.createMarca(this);
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

        public bool modifyMarca()
        {
            bool retornar = false;
            CADMarca m = new CADMarca();
            if (m.readMarca(this))
            {
                retornar = m.createMarca(this);
            }
            return retornar;
        }

    }
}
