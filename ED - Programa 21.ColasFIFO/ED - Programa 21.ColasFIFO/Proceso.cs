using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED___Programa_21.ColasFIFO
{
    class Proceso
    {
        static Random aleatorio = new Random();
        private int _ciclos;
        public int ciclos
        {
            get { return _ciclos; }
            set { _ciclos = value; }
        }
        private Proceso _siguiente;
        public Proceso siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public Proceso()
        {
            _ciclos = aleatorio.Next(4, 15);
        }
    }
}
