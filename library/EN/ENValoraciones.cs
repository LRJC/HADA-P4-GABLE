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
        public string usuaro_id
        {
            get
            {
                return new string(usuario.ToCharArray());
            }

            set
            {
                usuario = value;
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

        public int producto_id
        {
            get
            {
                return producto;
            }

            set
            {
                producto = value;
            }
        }

        private string usuario;
        private int producto;
        private string texto;
        private int puntos;

        public ENValoraciones() { }

        public ENValoraciones(string usuario, string texto, int puntos, int producto)
        {
            producto_id = producto;
            usuaro_id = usuario;
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
            return cval.readValoraciones(this);
        }

        public bool deleteValoraciones()
        {
            CADValoraciones cval = new CADValoraciones();
            return cval.deleteValoraciones(this);
        }

        public bool updateValoraciones()
        {
            CADValoraciones cval = new CADValoraciones();
            return cval.updateValoraciones(this);
        }

    }
}
