using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO02
{
    public partial class Crear : Form
    {
        private Biblioteca biblioteca;
        public Crear(Biblioteca biblioteca)
        {
            this.biblioteca = biblioteca;
            InitializeComponent();
        }

        private void Crear_Paint(object sender, PaintEventArgs e)
        {
            Color colorInicio = Color.FromArgb(138, 195, 185);
            Color colorFinal = Color.FromArgb(12, 115, 109);
            using (LinearGradientBrush brocha = new LinearGradientBrush(this.ClientRectangle, colorInicio, colorFinal, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brocha, this.ClientRectangle);
            }
        }

        private void btnLimpiar1_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnAgregarUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(cmbRol.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos antes de agregar el usuario.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nombre = txtNombre.Text;
            string contraseña = txtPassword.Text;
            string rol = cmbRol.SelectedItem.ToString();
            Usuario nuevoUsuario;

            if (biblioteca.ObtenerUsuarios().Any(u => u.Nombre == nombre)) 
            {
                MessageBox.Show($"El nombre de usuario '{nombre}' ya existe. Intenta con otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rol == "Bibliotecario")
            {
                nuevoUsuario = new Bibliotecario(nombre, contraseña);
            }
            else if (rol == "Lector")
            {
                nuevoUsuario = new Lector(nombre, contraseña);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un rol.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (biblioteca == null)
            {
                MessageBox.Show("La biblioteca no está inicializada.");
                return;
            }
            biblioteca.AgregarUsuario(nuevoUsuario);
            MessageBox.Show("Usuario registrado exitosamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNombre.Text = string.Empty;
            txtPassword.Text = string.Empty;
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
