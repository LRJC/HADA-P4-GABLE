using System;
using library.CAD;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.EN

{
    class ENProductos
    {
        public string id_producto
        {
            get
            {
                return new string(idProducto.ToCharArray());
            }
            set
            {
                idProducto = value;
            }
        }

        public string nom_producto
        {
            get
            {
                return new string(nomProducto.ToCharArray());
            }

            set
            {
                nomProducto = value;
            }

        }

        public string desc_producto
        {
            get
            {
                return new string(descProducto.ToCharArray());
            }
            set
            {
                descProducto = value;
            }
        }

        public int pre_producto
        {
            get
            {
                return preProducto;
            }
            set
            {
                preProducto = value;
            }
        }

        public string gen_producto
        {
            get
            {
                return new string(genProducto.ToCharArray());
            }

            set
            {
                genProducto = value;
            }
        }

        public string ImageLocation
        {
            get
            {
                return new string(imaProducto.ToCharArray());
            }
            set
            {
                imaProducto = value;
            }
        }


        private string idProducto;
        private string nomProducto;
        private string descProducto;
        private int preProducto;
        private string genProducto;
        private string imaProducto;

        public ENProductos() { }

        public ENProductos(string idProducto, string nomProducto, string descProducto, int preProducto, string genProducto, string imaProducto)//Pablo
        {
            id_producto = idProducto;
            nom_producto = nomProducto;
            desc_producto = descProducto;
            pre_producto = preProducto;
            gen_producto = genProducto;
            ImageLocation = imaProducto;
        }
        public bool readProducto()//Pablo
        {
            CADProductos cpro = new CADProductos();
            return cpro.readProductos(this);
        }


    }
}
