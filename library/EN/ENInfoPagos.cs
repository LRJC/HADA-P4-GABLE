using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.EN
{
    class ENInfoPagos
    {
        private ENUsuario _usuario;
        private string _cuentaBancaria;
        private string _tarjeta;
        private string _dirEnvio;
        private string _dirFact;

        public ENUsuario usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public string cuentaBancaria
        {
            get { return _cuentaBancaria; }
            set { _cuentaBancaria = value; }
        }
        public string tarjeta
        {
            get { return _tarjeta; }
            set { _tarjeta = value; }
        }
        public string dirEnvio
        {
            get { return _dirEnvio; }
            set { _dirEnvio = value; }
        }
        public string dirFact
        {
            get { return _dirFact; }
            set { _dirFact = value; }
        }

        public ENInfoPagos()
        {
            usuario = new ENUsuario();
            cuentaBancaria = "";
            tarjeta = "";
            dirEnvio = "";
            dirFact = "";
        }

        public ENInfoPagos(ENUsuario usuario)
        {
            this.usuario = usuario;
        }

    }
}
