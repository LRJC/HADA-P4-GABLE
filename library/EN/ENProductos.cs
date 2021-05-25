﻿using System;
using library.CAD;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace library.EN

{
    public class ENProductos
    {
        public int id_producto
        {
            get
            {
                return idProducto;
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

        public float pre_producto
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

        public string tipo_producto
        {
            get
            {
                return new string(tipoProducto.ToCharArray());
            }

            set
            {
                tipoProducto = value;
            }
        }

        public string marca_producto
        {
            get
            {
                return new string(marcaProducto.ToCharArray());
            }

            set
            {
                marcaProducto = value;
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


        private int idProducto;
        private string nomProducto;
        private string descProducto;
        private float preProducto;
        private string tipoProducto;
        private string marcaProducto;
        private string imaProducto;

        public ENProductos() { }

        public ENProductos(int idProducto, string nomProducto, string descProducto, float preProducto, string tipoProducto, string imaProducto,string marcaProducto)//Pablo
        {
            id_producto = idProducto;
            nom_producto = nomProducto;
            desc_producto = descProducto;
            pre_producto = preProducto;
            tipo_producto = tipoProducto;
            marca_producto = marcaProducto;
            ImageLocation = imaProducto;
        }
        public bool readProducto()//Pablo
        {
            CADProductos cpro = new CADProductos();
            return cpro.readProductos(this);
        }

        public bool createProducto()
        {
            CADProductos cpro = new CADProductos();
            return cpro.createProductos(this);
        }

        public bool deleteProductos()
        {
            CADProductos cpro = new CADProductos();
            return cpro.deleteProductos(this);
        }

        public bool updateProductos()
        {
            CADProductos cpro = new CADProductos();
            return cpro.updateProductos(this);
        }

        public DataTable getRecommended()
        {
            CADProductos p = new CADProductos();
            return p.getRecommended();
        }

        public DataTable getMostSold()
        {
            CADProductos p = new CADProductos();
            return p.getMostSold();
        }

        public DataTable getBetterReviewed()
        {
            CADProductos p = new CADProductos();
            return p.getBetterReviewed();
        }

    }
}
