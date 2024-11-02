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

        public Biblioteca()
        {
            usuarios = new List<Usuario>(); //Inicializa la lista de usuarios                           
            usuarios.Add(new Bibliotecario("Fernanda", "chuchu"));
            libros = new LinkedList<Libro>();
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

    }
}
