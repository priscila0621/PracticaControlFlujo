using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios.Models
{
    public class Usuario
    {
        public string Nick { get; set; } // Nombre de usuario
        public string Contrasena { get; set; } // Contraseña del usuario

        private static List<Usuario> usuariosRegistrados = new List<Usuario>(); // Lista de usuarios registrados

        // Constructor para inicializar un nuevo usuario
        public Usuario(string nick, string contrasena)
        {
            Nick = nick;
            Contrasena = contrasena;
        }

        // Agrega un nuevo usuario a la lista, lanza excepción si ya está registrado
        public static void AgregarUsuario(string nick, string contrasena)
        {
            foreach (var usuario in usuariosRegistrados)
            {
                if (usuario.Nick == nick)
                {
                    throw new Exception("El usuario ya está registrado.");
                }
            }
            usuariosRegistrados.Add(new Usuario(nick, contrasena));
        }

        // Verifica si un usuario con el nombre y contraseña proporcionados está registrado
        public static bool EstaRegistrado(string nick, string contrasena)
        {
            foreach (var usuario in usuariosRegistrados)
            {
                if (usuario.Nick == nick && usuario.Contrasena == contrasena)
                {
                    return true;
                }
            }
            return false;
        }

        // Obtiene la lista de todos los usuarios registrados
        public static List<Usuario> ObtenerUsuariosRegistrados()
        {
            return usuariosRegistrados;
        }
    }
}
