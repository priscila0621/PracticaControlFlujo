using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuarios.Models;

namespace Usuarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento para el botón de registro
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            string nick = tbNick.Text;
            string contrasena = tbPassword.Text;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(nick) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, ingrese un Nick y una Contraseña.");
                return;
            }

            try
            {
                if (Usuario.EstaRegistrado(nick, contrasena))
                {
                    // Si el usuario ya está registrado, mostrar un mensaje
                    MessageBox.Show("El usuario ya está registrado.");
                }
                else
                {
                    // Si el usuario no está registrado, agregarlo
                    Usuario.AgregarUsuario(nick, contrasena);
                    ActualizarListBoxUsuarios();
                    MessageBox.Show("Se ha registrado correctamente.");
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si ocurre una excepción
                MessageBox.Show(ex.Message);
            }
        }

        // Método para actualizar el ListBox con los usuarios registrados usando for
        private void ActualizarListBoxUsuarios()
        {
            lbRegistrados.Items.Clear();

            List<Usuario> usuarios = Usuario.ObtenerUsuariosRegistrados();
            MessageBox.Show($"Número de usuarios registrados: {usuarios.Count}"); // Verificación

            for (int i = 0; i < usuarios.Count; i++)
            {
                // Mostrar Nick y Contraseña en el ListBox
                lbRegistrados.Items.Add($"Nick: {usuarios[i].Nick}, Contraseña: {usuarios[i].Contrasena}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void lbRegistrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbNick_TextChanged(object sender, EventArgs e)
        {
            // Implementar según sea necesario
        }
    }


}
