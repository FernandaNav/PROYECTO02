using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO02
{
    public class Prestamos
    {
        public Libro Libro { get; }
        public Usuario Usuario { get; }
        public DateTime FechaPrestamo { get; }
        public DateTime FechaDevolucion { get; set; }

        public Prestamos(Libro libro, Usuario usuario)
        {
            Libro = libro;
            Usuario = usuario;
            FechaPrestamo = DateTime.Now.Date;
            FechaDevolucion = FechaPrestamo.AddDays(3);
        }
        public string FechaPrestamoFormateada => FechaPrestamo.ToString("d");
        public string FechaDevolucionFormateada => FechaDevolucion.ToString("d");
    }
}
