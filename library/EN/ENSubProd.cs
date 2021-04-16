using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library.CAD;

namespace library.EN
{
    class ENSubProd
    {
        public bool createProducto()//ENSubProd Lucas
        {
            CADSubProd aux = new CADSubProd();
            return aux.createProducto(this);
        }

        public bool deleteProducto()//ENSubProd Lucas
        {
            CADSubProd aux = new CADSubProd();
            return aux.deleteProducto(this);
        }

        public bool updateProducto()
        {
            CADSubProd aux = new CADSubProd();
            return aux.deleteProducto(this);
        }
    }
}
