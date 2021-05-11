using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library.CAD;

namespace library.EN
{   
    public class ENCesta
    {
        private ENUsuario usuario;
        private List<ENLineaCesta> productos;

        public ENUsuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public List<ENLineaCesta> Productos
        {
            get { return productos; }
            set { productos = value; }
        }

        public ENCesta()
        {
            Usuario = null;
            Productos = new List<ENLineaCesta>();
        }

        public ENCesta(ENUsuario usuario, List<ENLineaCesta> productos)
        {
            Usuario = usuario;
            Productos = productos;
        }

        public bool removeProduct(ENLineaCesta producto)
        {
            CADCesta c = new CADCesta();
            return c.removeProduct(this, producto);
        }

        public bool proceedToBuy()
        {
            CADCesta c = new CADCesta();
            return c.proceedToBuy(this);
        }
    }
}
