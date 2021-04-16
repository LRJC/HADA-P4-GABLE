using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{

    public class ENBuscador
    {

        private string _textoBusqueda;
        public string textoBusqueda //el texto introducido en la búsqueda
        {   
            get { return _textoBusqueda; } 
            set 
            {
                _textoBusqueda = value;
            } 
        } 
        private List<string> _generos;
        public List<string> generos //filtros por género activos
        {   
            get { return _generos; }
            set { _generos = value; } 
        } 
        private int _precioMin;
        public int precioMin //precio min del producto a buscar
        {
            get { return _precioMin; }
            set { _precioMin = value; }
        } 
        private int _precioMax;
        public int precioMax //precio max del producto a buscar
        { 
            get { return _precioMax; }
            set { _precioMax = value; }
        } 

        
        public ENBuscador() 
        {
            generos = new List<string>();
        }

        public ENBuscador(string textoBusqueda, List<string> generos, int precioMin, int precioMax) 
        {
            this.textoBusqueda = textoBusqueda;
            this.generos = generos;
            this.precioMin = precioMin;
            this.precioMax = precioMax;
        }

        public bool createBuscador() 
        {
            CADBuscador bus = new CADBuscador();
            if (bus.createBuscador()) return true;
            return false; 
        }
        public bool readBuscador() 
        {
            CADBuscador bus = new CADBuscador();
            if (bus.readBuscador()) return true;
            return false;
        }
        public bool updateBuscador() 
        {
            CADBuscador bus = new CADBuscador();
            if (bus.updateBuscador()) return true;
            return false;
        }
        public bool deleteBuscador() 
        {
            CADBuscador bus = new CADBuscador();
            if (bus.deleteBuscador()) return true;
            return false;
        }
    }
}
