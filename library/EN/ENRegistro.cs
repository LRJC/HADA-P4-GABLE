using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.EN;
{
    class ENRegistro
    {
        private ENUsuario usuario;
        public ENUsuario usu_
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public ENRegistro()
        {
            usu_ = null;
        }

        public ENRegistro(ENUsuario new_us)
        {
            usu_ = new_us;
        }

        public bool createUsuario()
        {
            CADRegistro c = new CADRegistro();
            return c.createUsuario(*this);
        }
    }
}
