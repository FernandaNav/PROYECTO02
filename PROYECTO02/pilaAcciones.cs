using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO02
{
    public class PilaAcciones
    {
        private LinkedList<string> acciones;

        public PilaAcciones()
        {
            acciones = new LinkedList<string>();
        }

        public void Apilar(string accion)
        {
            acciones.AddLast(accion);
        }

        public string Desapilar()
        {
            if (acciones.Count > 0)
            {
                var accion = acciones.Last.Value;
                acciones.RemoveLast();
                return accion;
            }
            return null;
        }

        public int Count => acciones.Count;
    }
}
