using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO02
{
    public class Lector : Usuario
    {
        public Lector(string nombre, string contraseña)
            : base(nombre, contraseña, "Lector") { }
    }
}
