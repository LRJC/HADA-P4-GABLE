using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENLogin
    {
        private ENUsuario usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public ENLogin()
        {
            Usuario = null;
        }

        public ENLogin(ENUsuario usuario)
        {
            Usuario = usuario;
        }

        public bool tryLogin()
        {
            CADLogin l = new CADLogin();
            return l.tryLogin(this);
        }
    }
}
