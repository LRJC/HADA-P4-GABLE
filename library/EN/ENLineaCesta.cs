using System;
using library.CAD;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.EN
{
    public class ENLineaCesta
    {
        private ENProductos producto;
        private int unidades;

        public ENProductos Producto
        {
            get { return this.producto; }
            set { this.producto = value; }
        }
        public int Unidades
        {
            get { return this.unidades; }
            set { this.unidades = value; }
        }

        public ENLineaCesta()
        {
            this.producto = null;
            this.unidades = 0;
        }
        public ENLineaCesta(ENProductos producto, int unidades)
        {
            this.producto = producto;
            this.unidades = unidades;
        }

        public bool addUnit()
        {
            this.unidades += 1;

            CADLineaCesta lc = new CADLineaCesta();
            return lc.addUnit(this);
        }

        public bool removeUnit()
        {
            if (this.unidades > 0)
            {
                this.unidades += 1;

                CADLineaCesta lc = new CADLineaCesta();
                return lc.removeUnit(this);
            }

            return false;
        }
    }
}
