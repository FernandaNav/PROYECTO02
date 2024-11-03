using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO02
{
    public class ColaEspera
    {
        private LinkedList<Usuario> listaEspera;

        public ColaEspera()
        {
            listaEspera = new LinkedList<Usuario>();
        }

        public void Encolar(Usuario usuario)
        {
            listaEspera.AddLast(usuario);
        }

        public Usuario Desencolar()
        {
            if (listaEspera.Count > 0)
            {
                var usuario = listaEspera.First.Value;
                listaEspera.RemoveFirst();
                return usuario;
            }
            return null;
        }

        public int Count => listaEspera.Count;
    }

}
