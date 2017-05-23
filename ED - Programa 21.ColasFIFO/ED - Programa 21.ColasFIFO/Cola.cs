using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED___Programa_21.ColasFIFO
{
    class Cola
    {
        private Proceso _enTurno;
        private Proceso _fin;
        
        public void Enqueue(Proceso proceso)
        {
            if (_enTurno == null)
            {
                _enTurno = proceso;
                _fin = _enTurno;
            }
            else
            {
                _fin.siguiente = proceso;
                _fin = _fin.siguiente;
            }
        }

        public void Dequeue()
        {
            if (_fin == _enTurno)
                _fin = null;
            _enTurno = _enTurno.siguiente;
            //Proceso auxiliar = _enTurno;
            //while (auxiliar != _fin)
            //{
            //    auxiliar = auxiliar.siguiente;
            //}
        }

        public Proceso Pop()
        {
            return _enTurno;
        }

        public override string ToString()
        {
            int pendientes = 0;
            int sumaCiclos = 0;
            Proceso auxiliar = _enTurno;
            while (auxiliar != null)
            {
                pendientes++;
                sumaCiclos += auxiliar.ciclos;
                auxiliar = auxiliar.siguiente;
            }
            return "Procesos pendientes: " + pendientes.ToString() + Environment.NewLine + "Suma de sus ciclos: " + sumaCiclos.ToString();
        }
    }
}
