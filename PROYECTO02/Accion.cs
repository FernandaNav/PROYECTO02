using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO02
{
    public class Accion
    {
        public string Tipo { get; set; }
        public Libro Libro { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }

        public Accion(string tipo, Libro libro, Usuario usuario)
        {
            Tipo = tipo;
            Libro = libro;
            Usuario = usuario;
            Fecha = DateTime.Now;
        }

        public string Descripcion()
        {
            return $"{Tipo} de '{Libro.Titulo}' para '{Usuario.Nombre}' el {Fecha}";
        }
    }

}
