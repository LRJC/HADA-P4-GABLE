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
        private int numCesta;

        public int NumCesta
        {
            get { return numCesta; }
            set { numCesta = value; }
        }

        public ENCesta()
        {
            numCesta = -1;
        }

        public ENCesta(int numCesta)
        {
            NumCesta = numCesta;
        }

        public string getUserID()
        {
            CADCesta c = new CADCesta();
            return c.getUserID(this);
        }

        public bool proceedToBuy()
        {
            CADCesta c = new CADCesta();
            return c.proceedToBuy(this);
        }
    }
}
