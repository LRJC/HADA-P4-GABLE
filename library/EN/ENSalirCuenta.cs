using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library.CAD;

namespace library.EN
{
    class ENSalirCuenta
    {
        public bool loggout()
        {
            CADSalirCuenta aux = new CADSalirCuenta();
            return aux.loggout(this);
        }
    }
}
