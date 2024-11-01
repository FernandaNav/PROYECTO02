using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO02
{
    public class Bibliotecario : Usuario
    {
        public Bibliotecario(string nombre, string contraseña)
            : base(nombre, contraseña, "Bibliotecario") { }
    }

}
