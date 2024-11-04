using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO02
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public string Genero { get; set; }
        public bool Disponible { get; set; }
        public int Solicitudes { get; set; } = 0;

        public Libro(string titulo, string autor, string isbn, string genero)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            Genero = genero;
            Disponible = true;
            Solicitudes = 0;
        }
    }
}
