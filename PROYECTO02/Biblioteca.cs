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

        public Biblioteca()
        {
            usuarios = new List<Usuario>(); // Inicializa la lista de usuarios
                                            // Crear usuario fijo
            usuarios.Add(new Bibliotecario("Fernanda", "Chuchu"));
        }

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
            var usuario = BuscarUsuario(nombre);
            if (usuario != null)
            {
                usuarios.Remove(usuario);
            }
            else
            {
                throw new Exception("El usuario no existe.");
            }
        }

        public void EditarUsuario(string nombre, string nuevaContraseña, string nuevoRol)
        {
            var usuario = BuscarUsuario(nombre);
            if (usuario != null)
            {
                usuario.Contrasena = nuevaContraseña;
                usuario.Rol = nuevoRol;
            }
            else
            {
                throw new Exception("El usuario no existe.");
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
                return usuario; // Retorna el usuario si las credenciales son válidas
            }
            else
            {
                throw new Exception("Credenciales incorrectas.");
            }
        }
    }
}
