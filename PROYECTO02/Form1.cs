﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO02
{
    public partial class Form1 : Form
    {
        private Biblioteca biblioteca;

        public Form1(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.biblioteca = biblioteca; // Asigna la instancia pasada
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" ¡Gracias por usar Estante Gatuno, adiós!");
            Application.Exit();
        }

        private void linea1_Click(object sender, EventArgs e)
        {

        }

        private void Acceder_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim(); // Obtener el nombre del usuario
            string contrasena = txtPassword.Text.Trim(); // Obtener la contraseña del usuario
            string rol = cmbUsuario.Text; // Obtener el rol seleccionado

            try
            {
                // Verificar las credenciales del usuario
                Usuario usuarioAutenticado = biblioteca.VerificarCredenciales(nombre, contrasena);

                // Validar que el usuario autenticado no sea null
                if (usuarioAutenticado != null)
                {
                    // Verificar que el rol del usuario autenticado coincida con el rol seleccionado
                    if (usuarioAutenticado.Rol == rol)
                    {
                        MessageBox.Show("Inicio de sesión exitoso como " + rol + ".", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Si el rol es bibliotecario, abrir el menú de bibliotecario
                        if (rol == "Bibliotecario")
                        {
                            Menu menuForm = new Menu(biblioteca);
                            menuForm.Show();
                            this.Hide(); // Oculta el formulario de inicio de sesión
                        }
                        else
                        {
                            MessageBox.Show("Hola Lector");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El rol del usuario no coincide con el rol seleccionado.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // Mostrar mensaje de error si ocurre una excepción
            }
            finally
            {
                // Limpiar los campos de texto
                txtNombre.Text = "";
                txtPassword.Text = "";
            }
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
