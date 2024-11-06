using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            usuarios.Add(new Bibliotecario("Fernanda", "123"));
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
            if (nombre.Equals("Fernanda", StringComparison.OrdinalIgnoreCase))
            {//para que nunca se elimine a Fernanda
                MessageBox.Show("No se permite eliminar al usuario Fernanda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var usuario = BuscarUsuario(nombre);
            if (usuario == null)
            {
                MessageBox.Show("El usuario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var prestamoActivo = prestamosActivos.Any(p => p.Usuario == usuario);//para verificar si el usuario tiene algun prestamo activo
            if (prestamoActivo)
            {
                MessageBox.Show("No se puede eliminar el usuario porque tiene préstamos activos. Debe devolver los libros primero.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var passwordPrompt = new PedirContrasena(this))
            {
                if (passwordPrompt.ShowDialog() == DialogResult.OK)
                {
                    if (usuario.Contrasena == passwordPrompt.Password)
                    {
                        if (UsuarioAutenticado != null && UsuarioAutenticado.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                        {
                            usuarios.Remove(usuario);
                            UsuarioAutenticado = null; 

                            MessageBox.Show("Usuario eliminado exitosamente. Al cerrar tu sesión, no podrás volver a ingresar.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            usuarios.Remove(usuario);
                            MessageBox.Show("Usuario eliminado exitosamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public void EditarUsuario(string nombreOriginal, string nuevoNombre, string nuevaContraseña, string nuevoRol)
        {
            if (nombreOriginal.Equals("Fernanda", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("No se permite editar al usuario Fernanda.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var usuario = BuscarUsuario(nombreOriginal);
            if (usuario != null)
            {
                usuario.Nombre = nuevoNombre; 
                usuario.Contrasena = nuevaContraseña; 
                usuario.Rol = nuevoRol;
                MessageBox.Show("Usuario actualizado exitosamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El usuario no existe.","", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var libroAEliminar = libros.FirstOrDefault(libro => libro.ISBN == isbn);

            if (libroAEliminar == null)
            {
                MessageBox.Show("El libro no existe en el inventario.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var libroPrestado = prestamosActivos.FirstOrDefault(prestamo => prestamo.Libro.ISBN == isbn);

            if (libroPrestado != null) //si el libro está prestado, no es puede eliminar
            {
                MessageBox.Show("No se puede eliminar el libro porque está prestado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            libros.Remove(libroAEliminar);
            MessageBox.Show("El libro ha sido eliminado correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            var resultado = MessageBox.Show($"¿Estás seguro de pedir el libro '{libro.Titulo}' del autor '{libro.Autor}'?", "Confirmar Solicitud", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (libro.Disponible)
                {
                    var prestamo = new Prestamos(libro, UsuarioAutenticado);
                    prestamosActivos.AddLast(prestamo);
                    libro.Disponible = false;
                    var accion = new Accion("Préstamo", libro, UsuarioAutenticado);
                    pilaAcciones.AddLast(accion);

                    MessageBox.Show($"Préstamo realizado: '{libro.Titulo}' el {prestamo.Prestamo}.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    libro.Solicitudes++;
                }
                else
                {
                    colaEspera.AddLast(UsuarioAutenticado);
                    MessageBox.Show($"El libro '{libro.Titulo}' no está disponible. Se le ha agregado a la lista de espera.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    libro.Solicitudes++;
                }
            }
            else
            {
                MessageBox.Show("La solicitud de préstamo ha sido cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void DevolverLibro(string isbn)
        {
            var prestamo = prestamosActivos.FirstOrDefault(p => p.Libro.ISBN == isbn && p.Usuario.Equals(UsuarioAutenticado));
            if (prestamo != null)
            {
                var libro = prestamo.Libro;
                var resultado = MessageBox.Show($"¿Estás seguro de devolver el libro '{libro.Titulo}' del autor '{libro.Autor}'?","Confirmar Devolución",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    prestamosActivos.Remove(prestamo);
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
                    MessageBox.Show("La devolución ha sido cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                });
            }
            return listaPrestamos;
        }
        public List<Libro> ObtenerLibrosMasSolicitados()
        {
            return libros.OrderByDescending(l => l.Solicitudes).ToList();
        }
        public LinkedList<Libro> QuickSortLibrosPorTitulo(LinkedList<Libro> listaLibros)
        {
            if (listaLibros.Count <= 1)
                return listaLibros;
            Libro pivote = listaLibros.First.Value;
            LinkedList<Libro> izquierda = new LinkedList<Libro>();
            LinkedList<Libro> derecha = new LinkedList<Libro>();

            foreach (var libro in listaLibros)
            {
                if (libro != pivote)
                {
                    if (string.Compare(libro.Titulo, pivote.Titulo, StringComparison.OrdinalIgnoreCase) < 0)
                        izquierda.AddLast(libro);
                    else
                        derecha.AddLast(libro);
                }
            }
            var resultado = new LinkedList<Libro>(QuickSortLibrosPorTitulo(izquierda));
            resultado.AddLast(pivote);//agregar el pivote
            foreach (var libro in QuickSortLibrosPorTitulo(derecha))
                resultado.AddLast(libro);

            return resultado;
        }
        public List<Libro> ObtenerLibrosOrdenados()
        {
            var librosOrdenados = QuickSortLibrosPorTitulo(libros);
            return librosOrdenados.ToList();
        }
        public List<Libro> BuscarLibrosPorCriterioRecursivo(LinkedListNode<Libro> nodoActual, string criterio)
        {
            List<Libro> resultados = new List<Libro>();

            if (nodoActual == null)
            {
                return resultados;
            }
            if (string.IsNullOrEmpty(criterio))
            {
                MessageBox.Show("El criterio de búsqueda no puede estar vacío.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return resultados;
            }

            if (nodoActual.Value.Titulo != null && nodoActual.Value.Titulo.Contains(criterio) || nodoActual.Value.Autor != null && nodoActual.Value.Autor.Contains(criterio) || nodoActual.Value.ISBN != null && nodoActual.Value.ISBN.Contains(criterio))
            {
                resultados.Add(nodoActual.Value);
            }


            resultados.AddRange(BuscarLibrosPorCriterioRecursivo(nodoActual.Next, criterio));
            return resultados;
        }

        public void MostrarLibrosEncontrados(string criterio, DataGridView dgv)
        {
            dgv.Rows.Clear();
            var resultados = BuscarLibrosPorCriterioRecursivo(libros.First, criterio);

            foreach (var libro in resultados)
            {
                string disponibilidad = ConvertirDisponibilidad(libro.Disponible);
                dgv.Rows.Add(libro.Titulo, libro.Autor, libro.ISBN, libro.Genero, disponibilidad);
            }
            if (resultados.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ConvertirDisponibilidad(bool disponible)
        {
            return disponible ? "SI" : "NO";
        }
    }
}
