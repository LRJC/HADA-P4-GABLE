using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library.CAD;

namespace library.EN
{
	public class ENCompra
	{
		private ENProductos producto;

		public ENProductos prod_
        {
            get { return producto; }
			set { producto = value; }
        }

		public ENCompra()
		{
			prod_ = null;
		}

		public ENCompra(ENProductos new_prod)
        {
			prod_ = new_prod;
        }

		public bool doCompra()
        {
			CADCompra c = new CADCompra();
			return c.doCompra(*this);
        }
	}
}
