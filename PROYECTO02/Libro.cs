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

        public Libro(string titulo, string autor, string iSBN, string genero, bool disponible)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = iSBN;
            Genero = genero;
            Disponible = disponible;
        }
        public void EditarLibro(string nuevoTitulo, string nuevoAutor, string nuevoISBN, string nuevoGenero)
        {
            Titulo = nuevoTitulo;
            Autor = nuevoAutor;
            ISBN = nuevoISBN;
            Genero = nuevoGenero;
        }

    }
}
