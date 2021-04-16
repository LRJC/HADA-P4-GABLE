using System;
using library.CAD;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.EN
{
    class ENValoraciones
    {
        public string id_val
        {
            get
            {
                return new string(idVal.ToCharArray());
            }

            set
            {
                idVal = value;
            }
        }

        public string tex_val
        {
            get
            {
                return new string(texto.ToCharArray());
            }

            set
            {
                texto = value;
            }
        }

        public int pun_val
        {
            get
            {
                return puntos;
            }

            set
            {
                puntos = value;
            }
        }


        private string idVal;
        private string texto;
        private int puntos;

        public ENValoraciones() { }

        public ENValoraciones(string idVal, string texto, int puntos)
        {
            id_val = idVal;
            tex_val = texto;
            pun_val = puntos;
        }
        public bool createValoracion()
        {
            CADValoraciones cval = new CADValoraciones();
            return cval.createValoraciones(this);
        }

        public bool readValoraciones()
        {
            CADValoraciones cval = new CADValoraciones();
            return cval.readValoracioneses(this);
        }
    }
}
