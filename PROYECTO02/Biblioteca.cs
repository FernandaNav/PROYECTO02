using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO02
{
    public class Biblioteca
    {
        private List<Usuario> usuarios;
        private LinkedList<Libro> libros;
        private LinkedList<Prestamos> prestamosActivos;
        private LinkedList<Accion> pilaAcciones;
        private LinkedList<Usuario> colaEspera;

        public Usuario UsuarioAutenticado { get; private set; }
        public Biblioteca()
        {
            usuarios = new List<Usuario>();                          
            usuarios.Add(new Bibliotecario("Fernanda", "chuchu"));
            libros = new LinkedList<Libro>();
            prestamosActivos = new LinkedList<Prestamos>();
            colaEspera = new LinkedList<Usuario>();
            pilaAcciones = new LinkedList<Accion>();
        }
        //MÉTODOS PARA USUARIOS
        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public Usuario BuscarUsuario(string nombre)
        {
            return usuarios.FirstOrDefault(u => u.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }

        public void EliminarUsuario(string nombre)
        {
            if (UsuarioAutenticado != null && UsuarioAutenticado.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("No se puede eliminar el usuario que está actualmente autenticado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nombre.Equals("Fernanda", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("No se permite eliminar al usuario Fernanda.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var usuario = BuscarUsuario(nombre);
            if (usuario != null)
            {
                usuarios.Remove(usuario);
            }
            else
            {
                MessageBox.Show("El usuario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditarUsuario(string nombreOriginal, string nuevoNombre, string nuevaContraseña, string nuevoRol)
        {
            if (nombreOriginal.Equals("Fernanda", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("No se permite editar al usuario Fernanda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var usuario = BuscarUsuario(nombreOriginal);
            if (usuario != null)
            {
                usuario.Nombre = nuevoNombre; 
                usuario.Contrasena = nuevaContraseña; 
                usuario.Rol = nuevoRol; 
            }
            else
            {
                MessageBox.Show("El usuario no existe.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return usuarios;
        }
        public Usuario VerificarCredenciales(string nombre, string contraseña)
        {
            var usuario = usuarios.Find(u => u.Nombre == nombre);
            if (usuario != null && usuario.Contrasena == contraseña)
            {
                UsuarioAutenticado = usuario;
                return usuario;
            }
            else
            {
                throw new Exception("Credenciales incorrectas.");
            }
        }
        //TERMINA MÉTODOS USUARIO
        //INICIAMOS CON MÉTODOS PARA LIBROS
        public void AgregarLibro(Libro libro)
        {
            if (BuscarLibroPorISBN(libro.ISBN) != null)
            {
                throw new Exception("El ISBN ya existe.");
            }
            libros.AddLast(libro);
        }
        public void EditarLibro(string isbn, string nuevoTitulo, string nuevoAutor, string nuevoGenero)
        {
            var libro = BuscarLibroPorISBN(isbn);
            if (libro != null)
            {
                libro.Titulo = nuevoTitulo;
                libro.Autor = nuevoAutor;
                libro.Genero = nuevoGenero;
            }
            else
            {
                throw new Exception("El libro no existe.");
            }
        }
        public void EliminarLibro(string isbn)
        {
            var libro = BuscarLibroPorISBN(isbn);
            if (libro != null)
            {
                libros.Remove(libro);
            }
            else
            {
                throw new Exception("El libro no existe.");
            }
        }
        public Libro BuscarLibroPorISBN(string isbn)
        {
            foreach (var libro in libros)
            {
                if (libro.ISBN.Equals(isbn, StringComparison.OrdinalIgnoreCase))
                {
                    return libro;
                }
            }
            return null; 
        }
        public Libro BuscarLibroPorTitulo(string titulo)
        {
            return BuscarLibroPorTituloRecursivo(libros.First, titulo);
        }

        private Libro BuscarLibroPorTituloRecursivo(LinkedListNode<Libro> nodo, string titulo)
        {
            if (nodo == null) //el caso base es que no hayan más nodos
            {
                return null; 
            }
            if (nodo.Value.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
            {//si encuentra el título dentro de la lista enlazada
                return nodo.Value;
            }
            return BuscarLibroPorTituloRecursivo(nodo.Next, titulo); //Llamada Recursiva, se coloca el nodo "siguiente" en el parámetro
        }
        public List<Libro> ObtenerLibros()
        {
            List<Libro> listaLibros = new List<Libro>();
            foreach (var libro in libros)
            {
                listaLibros.Add(libro);
            }
            return listaLibros;
        }
        //TERMINA MÉTODOS PARA LIBROS
        //EMPIEZAN MÉTODOS PARA PRÉSTAMOS
        public void SolicitarPrestamo(string isbn)
        {
            var libro = BuscarLibroPorISBN(isbn);
            if (libro == null)
            {
                MessageBox.Show("El libro no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var prestamoExistente = prestamosActivos.FirstOrDefault(p => p.Libro.ISBN == isbn && p.Usuario.Equals(UsuarioAutenticado));
            if (prestamoExistente != null)
            {
                MessageBox.Show($"Ya tienes el libro '{libro.Titulo}' prestado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (libro.Disponible)
            {
                var prestamo = new Prestamos(libro, UsuarioAutenticado);
                prestamosActivos.AddLast(prestamo);
                libro.Disponible = false;
                var accion = new Accion("Préstamo", libro, UsuarioAutenticado);
                pilaAcciones.AddLast(accion);

                MessageBox.Show($"Préstamo realizado: '{libro.Titulo}' el {prestamo.Prestamo}.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                colaEspera.AddLast(UsuarioAutenticado);
                MessageBox.Show($"El libro '{libro.Titulo}' no está disponible. Se le ha agregado a la lista de espera.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void DevolverLibro(string isbn)
        {
            var prestamo = prestamosActivos.FirstOrDefault(p => p.Libro.ISBN == isbn && p.Usuario.Equals(UsuarioAutenticado));
            if (prestamo != null)
            {
                prestamosActivos.Remove(prestamo);
                var libro = prestamo.Libro;
                libro.Disponible = true;
                var accion = new Accion("Devolución", libro, UsuarioAutenticado);
                pilaAcciones.AddLast(accion);
                if (colaEspera.Count > 0)
                {
                    var siguienteUsuario = colaEspera.First.Value;
                    colaEspera.RemoveFirst();
                    var nuevoPrestamo = new Prestamos(libro, siguienteUsuario);
                    prestamosActivos.AddLast(nuevoPrestamo); 
                    libro.Disponible = false; 
                    var accionPrestamo = new Accion("Préstamo", libro, siguienteUsuario); 
                    pilaAcciones.AddLast(accionPrestamo); 

                    MessageBox.Show($"El libro '{libro.Titulo}' ha sido asignado a '{siguienteUsuario.Nombre}'.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                MessageBox.Show($"Libro devuelto: '{libro.Titulo}' el {prestamo.Devolucion}.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No has prestado este libro.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void DeshacerAccion()
        {
            if (pilaAcciones.Count == 0)
            {
                MessageBox.Show("No hay acciones para deshacer.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var ultimaAccion = pilaAcciones.Last.Value;
            if (!ultimaAccion.Usuario.Equals(UsuarioAutenticado))
            {
                MessageBox.Show("No hay acciones para deshacer", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            pilaAcciones.RemoveLast();

            if (ultimaAccion.Tipo == "Préstamo")
            {
                ultimaAccion.Libro.Disponible = true;
                var prestamo = prestamosActivos.FirstOrDefault(p => p.Libro.ISBN == ultimaAccion.Libro.ISBN && p.Usuario.Equals(ultimaAccion.Usuario));
                if (prestamo != null)
                {
                    prestamosActivos.Remove(prestamo);
                    MessageBox.Show($"Se ha deshecho el préstamo de '{ultimaAccion.Libro.Titulo}' para '{ultimaAccion.Usuario.Nombre}'.", "Acción Deshecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (ultimaAccion.Tipo == "Devolución")
            {
                ultimaAccion.Libro.Disponible = false;
                var nuevoPrestamo = new Prestamos(ultimaAccion.Libro, ultimaAccion.Usuario);
                prestamosActivos.AddLast(nuevoPrestamo);
                MessageBox.Show($"Se ha deshecho la devolución de '{ultimaAccion.Libro.Titulo}' para '{ultimaAccion.Usuario.Nombre}'.", "Acción Deshecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Acción desconocida para deshacer.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool PilaVacia()
        {
            return pilaAcciones.Count == 0;
        }
        public List<PrestamoView> ObtenerPrestamosActivos()
        {
            List<PrestamoView> listaPrestamos = new List<PrestamoView>();
            foreach (var prestamo in prestamosActivos)
            {
                listaPrestamos.Add(new PrestamoView
                {
                    TituloLibro = prestamo.Libro.Titulo,
                    NombreUsuario = prestamo.Usuario.Nombre,
                    FechaPrestamo = prestamo.Prestamo,
                    FechaDevolucion = prestamo.Devolucion
                });
            }
            return listaPrestamos;
        }
    }
}
