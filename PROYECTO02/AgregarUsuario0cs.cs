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
            dataGridViewUsuarios.DataSource = biblioteca.ObtenerUsuarios();
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

            if (biblioteca.ObtenerUsuarios().Any(u => u.Nombre == nombre)) // Asegúrate de que la propiedad Nombre exista en tu clase Usuario
            {
                MessageBox.Show($"El nombre de usuario '{nombre}' ya existe. Intenta con otro.");
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
                MessageBox.Show("Por favor, seleccione un rol.");
                return;
            }
            if (biblioteca == null)
            {
                MessageBox.Show("La biblioteca no está inicializada.");
                return;
            }
            biblioteca.AgregarUsuario(nuevoUsuario);
            dataGridViewUsuarios.DataSource = null;
            dataGridViewUsuarios.DataSource = biblioteca.ObtenerUsuarios();
            MessageBox.Show("Usuario registrado exitosamente.");
            txtNombreNew.Text = "";
            txtPasswordNew.Text = "";
            cmbUsuarioNew.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AgregarUsuario0cs_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(532, 120);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreNew_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPasswordNew_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbUsuarioNew_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
