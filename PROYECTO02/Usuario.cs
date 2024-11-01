using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO02
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string ID { get; private set; }
        public string Contrasena { get; set; }
        public string Rol { get; set; }

        private static int contador = 1;

        public Usuario(string nombre, string contrasena, string rol)
        {
            Nombre = nombre;
            Contrasena = contrasena;
            Rol = rol;
            ID = "USR" + contador++;
        }
    }
}
