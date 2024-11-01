using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTO02
{
    public partial class AgregarUsuario : UserControl
    {
        private Biblioteca biblioteca;

        public AgregarUsuario(Biblioteca biblioteca)
        {
            this.biblioteca = biblioteca;
            InitializeComponent();
        }


        private void AgregarUsuario_Paint(object sender, PaintEventArgs e)
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
            txtNombreNew.Text = string.Empty;
            txtPasswordNew.Text = string.Empty;
            cmbUsuarioNew.SelectedIndex = -1;
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

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
