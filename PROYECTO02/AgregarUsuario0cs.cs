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
    public partial class AgregarUsuario0cs : Form
    {
        private Biblioteca biblioteca;
        public AgregarUsuario0cs(Biblioteca biblioteca)
        {
            this.biblioteca = biblioteca;
            InitializeComponent();
        }
        private void btnLimpiar1_Click(object sender, EventArgs e)
        {
            txtNombreNew.Text = string.Empty;
            txtPasswordNew.Text = string.Empty;
            cmbUsuarioNew.SelectedIndex = -1;
        }

        private void AgregarUsuario0cs_Paint(object sender, PaintEventArgs e)
        {
            Color colorInicio = Color.FromArgb(138, 195, 185);
            Color colorFinal = Color.FromArgb(12, 115, 109);
            using (LinearGradientBrush brocha = new LinearGradientBrush(this.ClientRectangle, colorInicio, colorFinal, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brocha, this.ClientRectangle);
            }
        }

        private void btnAgregarUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreNew.Text) ||
                string.IsNullOrWhiteSpace(txtPasswordNew.Text) ||
                string.IsNullOrWhiteSpace(cmbUsuarioNew.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos antes de agregar el usuario.");
                return;
            }
            string nombre = txtNombreNew.Text;
            string contraseña = txtPasswordNew.Text;
            string rol = cmbUsuarioNew.SelectedItem.ToString();
            Usuario nuevoUsuario;

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
                MessageBox.Show("Por favor, seleccione un rol.");
                return;
            }
            if (biblioteca == null)
            {
                MessageBox.Show("La biblioteca no está inicializada.");
                return;
            }
            biblioteca.AgregarUsuario(nuevoUsuario);
            biblioteca.AgregarUsuario(nuevoUsuario);
            MessageBox.Show("Usuario registrado exitosamente.");
        }
        public void ActualizarDataGridView(List<Usuario> usuarios)
        {
            dataGridViewUsuarios.DataSource = null; // Restablece el origen de datos para refrescar
            dataGridViewUsuarios.DataSource = usuarios; // Asigna la lista de usuarios como origen de datos
        }
    }
}
